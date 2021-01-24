using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;

namespace MyErp.Controllers {
    public class TEngineController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TEngineController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void CreateViewBags(int? prod, int? plant,string Code="",int Coid=0)
        {
            var queryfa = (from fa in _dbContext.TFacilities
                            orderby fa.FaDescr 
                            select fa).ToList();
            ViewBag.ListFA=queryfa;

            var resulp1 = from p in _dbContext.TFacilities 
                        orderby p.FaDescr
                        select new  TFacility{FaId=p.FaId ,FaDescr=p.FaDescr};
            var resulp0 = ( from p in _dbContext.TFacilities  
            select new TFacility{FaId=0,FaDescr="Select a Facility"}).Distinct().ToList();
            var resulp = resulp0.Concat(resulp1);
            ViewBag.ddlPlantVB = new SelectList(resulp.ToList(), "FaId", "FaDescr",plant); 

            var queryca = (from p in _dbContext.TWorkCenters 
                        orderby p.Wccode 
                        where p.WcfaId==plant || plant==0
                        select p).ToList();
            ViewBag.ListProd=queryca;
            var querycas = (from p in _dbContext.TWorkCenters 
                        orderby p.Wccode 
                        where p.WcfaId==plant
                        select p).ToList();
            ViewBag.ListProdAs=querycas;
            var querycan1 = (from p in _dbContext.TWorkCenters 
                        orderby p.Wccode 
                        where p.WcfaId!=plant
                        select new TWorkCenter{WcdId=p.WcdId,Wcdescr=p.Wcdescr} ).ToList();
            var querycan0 = ( from p in _dbContext.TWorkCenters  
            select new TWorkCenter{WcdId=0,Wcdescr="Select a WorkCenter"}).Distinct().ToList();
            var querycans = querycan0.Concat(querycan1);
            ViewBag.ddlProdNAS = new SelectList(querycans.ToList(), "WcdId", "Wcdescr",0); 

            var resuld1 = from p in _dbContext.TWorkCenters 
                        orderby p.Wcdescr
                        //where p.WcfaId==plant
                        select new TWorkCenter{WcdId=p.WcdId ,Wcdescr=p.Wcdescr};
            var resuld0 = ( from p in _dbContext.TWorkCenters  
            select new TWorkCenter{WcdId=0,Wcdescr="Select a Work Center"}).Distinct().ToList();
            var resuld = resuld0.Concat(resuld1);
            ViewBag.ddlReferVD = new SelectList(resuld.ToList(), "WcdId", "Wcdescr",prod); 

            var querypo =(from po in _dbContext.TWccomponents
                        orderby po.WcoDescr
                        where po.WcoWcid ==prod || prod==0
                        select po).ToList();
            ViewBag.ListPO=querypo;

            var querypas = (from p in _dbContext.TWccomponents 
                        orderby p.WcoCode
                        where p.WcoWcid==prod
                        select p).ToList();
            ViewBag.ListPodAs=querypas;
            var querypan1 = (from p in _dbContext.TWccomponents 
                        orderby p.WcoCode
                        where p.WcoWcid!=prod
                        select new TWccomponent{WcoId=p.WcoId,WcoDescr=p.WcoDescr} ).ToList();
            var querypan0 = ( from p in _dbContext.TWccomponents  
            select new TWccomponent{WcoId=0,WcoDescr="Select a Component"}).Distinct().ToList();
            var querypans = querypan0.Concat(querypan1);
            ViewBag.ddlPodNAS = new SelectList(querypans.ToList(), "WcoId", "WcoDescr",0); 


            var queryma =(from po in _dbContext.TMaterials
                        orderby po.MatDescr
                        where po.MatClass==Code || Code ==null ||Code =="" ||Code=="--"
                        //where po.WcoWcid ==prod || prod==0
                        select po).ToList();
            ViewBag.ListMA=queryma;


            var queryman1 = (from p in _dbContext.TMaterials 
                        orderby p.MatRefer
                        //where p.WcoWcid!=prod
                        select new TMaterial{MatId=p.MatId,MatDescr=p.MatDescr} ).ToList();
            var queryman0 = ( from p in _dbContext.TMaterials  
            select new TMaterial{MatId=0,MatDescr="Select a Component"}).Distinct().ToList();
            var querymans = queryman0.Concat(queryman1);
            ViewBag.ddlMatNAS = new SelectList(querymans.ToList(), "MatId", "MatDescr",0); 

            var queryran1 = (from p in _dbContext.TMaterials 
                        orderby p.MatRefer
                        where p.MatClass !="FG"
                        select new TMaterial{MatId=p.MatId,MatDescr=p.MatDescr} ).ToList();
            var queryran0 = ( from p in _dbContext.TMaterials  
            select new TMaterial{MatId=0,MatDescr="Select a Component"}).Distinct().ToList();
            var queryrans = queryran0.Concat(queryran1);
            ViewBag.ddlMatCOM = new SelectList(queryrans.ToList(), "MatId", "MatDescr",0); 

            var queryco =(from pl in _dbContext.TMComponents 
            join p in _dbContext.TMaterials on pl.CoComId equals p.MatId
            join q in _dbContext.TMaterials on pl.CoRefId equals q.MatId
            orderby p.MatDescr 
            where pl.CoRefId ==Coid 
            select new VTMComponent { CoCoId=pl.CoId ,CoRefRe = q.MatRefer ,
            CoRefDes=q.MatDescr ,CoComRe = p.MatRefer ,
            CoComDes=p.MatDescr ,CoRefUM = q.MatUnMed, CoComUM = p.MatUnMed,
            CoRefQt=pl.CoQtyRe,CoComQt=pl.CoQtyCo,
            CoRefId=q.MatId,CoComId=p.MatId}).ToList();
            ViewBag.ListMatComp=queryco;

            Guid g = Guid.NewGuid();
            string Table = g.ToString();
            //var spParams = new object[] { Coid, 0,0,Table };
            //_dbContext.Database.ExecuteSqlRaw("Explosion @p0, @p1, @P3, @p4", spParams);
            var conjunto = new SqlParameter("@p0", Coid);
            var level = new SqlParameter("@p1", int.Parse("0"));
            var order = new SqlParameter("@p2",int.Parse("0"));
            var table = new SqlParameter("@p3", Table);
            //_dbContext.Database.ExecuteSqlRaw("Explosion @p0, @p1, @p2, @p3", conjunto,level,order,table);
            _dbContext.Database.ExecuteSqlRaw("Explosion {0}, {1}, {2}, {3}", conjunto,level,order,table);
            var sql = "SELECT ExpId,ExpOrder,ExpLevel,ExpComp,m.MatRefer as ExpRefer,m.MatDescr as ExpDescr,ExpsLevel FROM ["+Table+"] as t LEFT JOIN T_Material as m ON  t.ExpComp = m.MatId";
            var explosio = _dbContext.TExplosions.FromSqlRaw(sql).ToList();
            _dbContext.Database.ExecuteSqlRaw("Xx_Explosion {0}", table);

            ViewBag.ListMatBom=explosio; //querybo;

            var querywcen1 = (from p in _dbContext.TWorkCenters 
                        orderby p.Wcdescr
                        //where p.MatClass !="FG"
                        select new TWorkCenter{WcdId=p.WcdId,Wcdescr=p.Wcdescr} ).ToList();
            var querywcen0 = ( from p in _dbContext.TMaterials  
            select new TWorkCenter{WcdId=0,Wcdescr="Select a Component"}).Distinct().ToList();
            var querywcen = querywcen0.Concat(querywcen1);
            ViewBag.ddlWCenter = new SelectList(querywcen.ToList(), "WcdId", "Wcdescr",0); 


            var queryro =(from pl in _dbContext.TMRoutings 
            join p in _dbContext.TMaterials on pl.RouRefId equals p.MatId
            join q in _dbContext.TWorkCenters on pl.RouWcid equals q.WcdId
            orderby pl.RouFase 
            where pl.RouRefId ==Coid 
            select new VTMRouting { 
                RoRoId=pl.RouId,
                RoRoMatId=p.MatId ,
                RoRoMatRe = p.MatRefer ,
                RoRoMatDe=p.MatDescr ,
                RoRoFase=pl.RouFase,
                RoRoOper=pl.RouOper,
                RoRoTunit=pl.RouTunit,
                RoRoWCId=pl.RouWcid,
                RoRoWCDe=q.Wcdescr,
                RoRoWtime=pl.RouWtime,
                RoRoWunit=pl.RouWunit
                }).ToList();
            
            ViewBag.ListMatRou=queryro;

       }

        private void  WCeRemove(int id) {
            try{
            var model = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
                model.WcfaId=null;
               _dbContext.TWorkCenters.Update(model);
               _dbContext.SaveChanges();
            }
            catch{}            
        }

        private void  WCeAssign(int id,int wca) {
            try{
            var model = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(wca));
                model.WcfaId=id;
               _dbContext.TWorkCenters.Update(model);
               _dbContext.SaveChanges();
            }
            catch{}            
        }
        private void  WCoRemove(int id) {
            try{
            var model = _dbContext.TWccomponents
                .SingleOrDefault(u => u.WcoId.Equals(id));
                model.WcoWcid=null;
               _dbContext.TWccomponents.Update(model);
               _dbContext.SaveChanges();
            }
            catch{}            
        }

        private void  WCoAssign(int id,int wca) {
            try{
            var model = _dbContext.TWccomponents
                .SingleOrDefault(u => u.WcoId.Equals(wca));
                model.WcoWcid=id;
               _dbContext.TWccomponents.Update(model);
               _dbContext.SaveChanges();
            }
            catch{}            
        }

        public IActionResult Index(int panel, int? FaId, int? WcdId, string Code, string actionType) {
            if(panel ==0 ){panel=1;}
            if(FaId ==null ){FaId=int.Parse("0");}
            if(WcdId ==null ){WcdId=int.Parse("0");}
            ViewData["panel"]=panel;
            ViewData["Title"] = "Engineer Data";
            var dbContext = new MyErpDBContext();
            try{
                CreateViewBags(WcdId,FaId,Code);
             return View();
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }

        [HttpGet]
        public IActionResult FacCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=1;
            return View();      
        }

        [HttpPost]
        public IActionResult FacCreate(TFacility facility,string actionType) {
            ViewData["panel"]=1;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TFacilities.Add(facility); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                return View(facility);
                }
            }
            CreateViewBags(0,facility.FaId);    

            return RedirectToAction("Index",new{panel=1});
        }

        [HttpGet]
        public IActionResult WCeCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=2;
            return View();      
        }

        [HttpPost]
        public IActionResult WCeCreate(TWorkCenter wcenter,string actionType) {
            ViewData["panel"]=2;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TWorkCenters.Add(wcenter); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0,wcenter.WcfaId);    
                return View(wcenter);
                }
            }
            CreateViewBags(0,wcenter.WcfaId);    

            return RedirectToAction("Index",new{panel=2});
        }

        [HttpGet]
        public IActionResult WCoCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=3;
            return View();      
        }

        [HttpPost]
        public IActionResult WCoCreate(TWccomponent wccomp,string actionType) {
            ViewData["panel"]=3;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TWccomponents.Add(wccomp); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(wccomp.WcoWcid,0);    
                return View(wccomp);
                }
            }
            CreateViewBags(wccomp.WcoWcid,0);    
            ViewData["panel"]=3;

            return RedirectToAction("Index",new{panel=3});
        }

        [HttpGet]
        public IActionResult MatCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=4;
            return View();      
        }

        [HttpPost]
        public IActionResult MatCreate(TMaterial material,string actionType) {
            ViewData["panel"]=4;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TMaterials.Add(material); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                return View(material);
                }
            }
            CreateViewBags(0,0);    
            ViewData["panel"]=4;

            return RedirectToAction("Index",new{panel=4});
        }

        [HttpGet]
        public IActionResult CMatCreate(int id,string actionType) {
            CreateViewBags(0,0);
            TMaterial mat=(from  ma in _dbContext.TMaterials
            where ma.MatId==id select ma).SingleOrDefault();
            ViewData["panel"]=4;
            VTMComponent queryco=(from  ma in _dbContext.TMaterials
            join co in _dbContext.TMComponents on ma.MatId equals co.CoRefId
            into RefComp
            from pco in RefComp.DefaultIfEmpty()
            where ma.MatId==id
            select new VTMComponent { 
                CoRefId=id,
                CoRefRe =mat.MatRefer,
                CoRefDes=mat.MatDescr,
                CoRefUM = mat.MatUnMed, 
                CoRefQt=1,
                CoComId=0,
                CoComRe = "" ,
                CoComDes="" ,
                CoComUM = "",
                CoComQt=0}).Distinct().SingleOrDefault();
             //ViewBag.ListMatComp=queryco;
            return View((VTMComponent)queryco);      
        }

        [HttpPost]
        public IActionResult CMatCreate(VTMComponent component,int id,string actionType) {
            ViewData["panel"]=4;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        TMComponent nmod = new TMComponent();
                            nmod.CoComId=component.CoComId; 
                            nmod.CoQtyCo=component.CoComQt;
                            nmod.CoQtyRe=component.CoRefQt;
                            nmod.CoRefId=component.CoRefId;
                        _dbContext.TMComponents.Add(nmod); 
                        _dbContext.SaveChanges();
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                return View(component);
                }
            }
            else{
            if (actionType=="Cancel"){}
            else {
               try{
                //cambia el material componente idicar la unidad de medida
                TMaterial modex = (from p in _dbContext.TMaterials where p.MatId==component.CoComId
                select p).SingleOrDefault();
                component.CoComUM=modex.MatUnMed;
                }catch{}                
                CreateViewBags(0,0);    
                return View(component);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=4;

            return RedirectToAction("MatComp",new{id=id});
        }

        [HttpGet]
        public IActionResult RMatCreate(int id,string actionType) {
            CreateViewBags(0,0);
            TMaterial mat=(from  ma in _dbContext.TMaterials
            where ma.MatId==id select ma).SingleOrDefault();
            ViewData["panel"]=4;
            VTMRouting queryco=(from  ma in _dbContext.TMaterials
            join co in _dbContext.TMRoutings on ma.MatId equals co.RouRefId
            into RefComp
            from pco in RefComp.DefaultIfEmpty()
            where ma.MatId==id
            select new VTMRouting { 
                RoRoId=0,
                RoRoMatId=id,
                RoRoMatRe =mat.MatRefer,
                RoRoMatDe=mat.MatDescr,
                RoRoFase="",
                RoRoOper="",
                RoRoTunit="S",
                RoRoWCId=0,
                RoRoWCDe="",
                RoRoWtime=0,
                RoRoWunit=1}).Distinct().SingleOrDefault();
             //ViewBag.ListMatComp=queryco;
            return View((VTMRouting)queryco);      
        }

        [HttpPost]
        public IActionResult RMatCreate(VTMRouting routing,int id,string actionType) {
            ViewData["panel"]=4;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        TMRouting nmod = new TMRouting();
                            nmod.RouWcid=routing.RoRoWCId; 
                            nmod.RouWunit=routing.RoRoWunit;
                            nmod.RouWtime=routing.RoRoWtime;
                            nmod.RouTunit=routing.RoRoTunit;
                            nmod.RouFase=routing.RoRoFase;
                            nmod.RouOper=routing.RoRoOper;
                            nmod.RouRefId=routing.RoRoMatId;
                        _dbContext.TMRoutings.Add(nmod); 
                        _dbContext.SaveChanges();
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                return View(routing);
                }
            }
            else{
            if (actionType=="Cancel"){}
            else {
               try{
                //cambia el material componente idicar la unidad de medida
                }catch{}                
                CreateViewBags(0,0);    
                return View(routing);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=4;

            return RedirectToAction("MatRoute",new{id=id});
        }

        public IActionResult FacDelete(int id) {
            var mode = _dbContext.TFacilities
                .SingleOrDefault(u => u.FaId.Equals(id));
            try{
            _dbContext.TFacilities.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=1;
            return RedirectToAction("Index",new{panel=1});
        }

        public IActionResult WCeDelete(int id) {
            var mode = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
            try{
            _dbContext.TWorkCenters.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=2;
            return RedirectToAction("Index",new{panel=2});
        }

        public IActionResult WCoDelete(int id) {
            var mode = _dbContext.TWccomponents
                .SingleOrDefault(u => u.WcoId.Equals(id));
            try{
            _dbContext.TWccomponents.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=3;
            return RedirectToAction("Index",new{panel=3});
        }

        public IActionResult MatDelete(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            try{
            _dbContext.TMaterials.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=4;
            return RedirectToAction("Index",new{panel=4});
        }
        public IActionResult CMatDelete(int id) {
            int Mid=0;
            var mode = _dbContext.TMComponents
                .SingleOrDefault(u => u.CoId.Equals(id));
            try{
            Mid=mode.CoRefId;
            _dbContext.TMComponents.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=4;
            return RedirectToAction("MatComp",new{id=Mid});
        }

        public IActionResult RMatDelete(int id) {
            int Mid=0;
            var mode = _dbContext.TMRoutings
                .SingleOrDefault(u => u.RouId.Equals(id));
            try{
            Mid=mode.RouRefId;
            _dbContext.TMRoutings.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=4;
            return RedirectToAction("MatRoute",new{id=Mid});
        }


        [HttpGet]
        public IActionResult FacEdit(int id, int wrem, int wass,int assign, int WcfaId) {
            ViewData["panel"]=1;
            try{
            if (assign==1){ViewData["Assign"]=1;}
            if (wrem!=0){WCeRemove(wrem);}
            if (wass!=0){WCeAssign(id,WcfaId);}
            var model = _dbContext.TFacilities
                .SingleOrDefault(u => u.FaId.Equals(id));
            CreateViewBags(0,model.FaId);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult FacEdit(TFacility facility,int id ,int WcfaId , int wass, string actionType) {
            if (actionType=="Cancel"){}
            else{
            if (wass!=0 && WcfaId!=0){
                WCeAssign(id,WcfaId);
                var model = _dbContext.TFacilities
                    .SingleOrDefault(u => u.FaId.Equals(id));
                CreateViewBags(0,model.FaId);  
                ViewData["panel"]=1;
                return View(model);
            }
            }
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TFacilities.Update(facility);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,facility.FaId);    
                    ViewData["panel"]=1;
                    return View(facility);
                }
            }
            CreateViewBags(0,facility.FaId);    
            ViewData["panel"]=1;

            return RedirectToAction("Index",new{panel=1});
        } 

        [HttpGet]
        public IActionResult WCeEdit(int id, int wrem, int wass,int assign, int WcoId) {
            ViewData["panel"]=2;
            try{
            if (assign==1){ViewData["Assign"]=1;}
            if (wrem!=0){WCoRemove(wrem);}
            if (wass!=0){WCoAssign(id,WcoId);}
            var model = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
            CreateViewBags(id,model.WcfaId);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult WCeEdit(TWorkCenter wcenter,int id ,int WcoId , int wass, string actionType) {
            if (actionType=="Cancel"){}
            else{
            if (wass!=0 && WcoId!=0){
                WCoAssign(id,WcoId);
                var model = _dbContext.TWorkCenters
                    .SingleOrDefault(u => u.WcdId.Equals(id));
                CreateViewBags(id,model.WcfaId);  
                ViewData["panel"]=2;
                return View(model);
            }
            }
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TWorkCenters.Update(wcenter);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,wcenter.WcfaId);    
                    ViewData["panel"]=2;
                 return View(wcenter);
                }
            }
            CreateViewBags(0,wcenter.WcfaId);    
            ViewData["panel"]=2;

            return RedirectToAction("Index",new{panel=2, FaId=wcenter.WcfaId});
        } 

        [HttpGet]
        public IActionResult WCoEdit(int id) {
            ViewData["panel"]=3;
            try{
            var model = _dbContext.TWccomponents
                .SingleOrDefault(u => u.WcoId.Equals(id));
            CreateViewBags(model.WcoWcid,0);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult WCoEdit(TWccomponent wcocomp,int id ,string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TWccomponents.Update(wcocomp);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(wcocomp.WcoWcid,0);    
                    ViewData["panel"]=3;
                 return View(wcocomp);
                }
            }
            CreateViewBags(wcocomp.WcoWcid,0);    
            ViewData["panel"]=3;

            return RedirectToAction("Index",new{panel=3,WcdId=wcocomp.WcoWcid});
        } 

        [HttpGet]
        public IActionResult MatEdit(int id) {
            ViewData["panel"]=4;
            try{
            var model = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,model.MatClass);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult MatEdit(TMaterial material,int id ,string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TMaterials.Update(material);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,0,material.MatClass);    
                    ViewData["panel"]=3;
                 return View(material);
                }
            }
            CreateViewBags(0,0,material.MatClass);    
            ViewData["panel"]=4;

            return RedirectToAction("Index",new{panel=4,Code=material.MatClass});
        } 

        [HttpGet]
        public IActionResult CMatEdit(int id, int MId ,int pamen){
            CreateViewBags(0,0);
            ViewData["pamen"]=pamen;
            ViewData["panel"]=4;
            try{
            VTMComponent model =(from pl in _dbContext.TMComponents 
            join p in _dbContext.TMaterials on pl.CoComId equals p.MatId
            join q in _dbContext.TMaterials on pl.CoRefId equals q.MatId
            orderby p.MatDescr 
            where pl.CoId ==id 
            select new VTMComponent { CoCoId=pl.CoId ,CoRefRe = q.MatRefer ,
            CoRefDes=q.MatDescr ,CoComRe = p.MatRefer ,
            CoComDes=p.MatDescr ,CoRefUM = q.MatUnMed, CoComUM = p.MatUnMed,
            CoRefQt=pl.CoQtyRe,CoComQt=pl.CoQtyCo,
            CoRefId=q.MatId,CoComId=p.MatId}).SingleOrDefault();
            return View(model);
            }
            catch{return View("Error");}  

         }

        [HttpPost]
        public IActionResult CMatEdit(VTMComponent component,int id ,int MId, string actionType) {
            
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    TMComponent nmod = new TMComponent();
                        nmod.CoId=id;
                        nmod.CoComId=component.CoComId; 
                        nmod.CoQtyCo=component.CoComQt;
                        nmod.CoQtyRe=component.CoRefQt;
                        nmod.CoRefId=component.CoRefId;
                        _dbContext.TMComponents.Update(nmod); 
                        _dbContext.SaveChanges();
                }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                ViewData["panel"]=4;
                return View(component);
                }
            }
            else{
                if (actionType=="Cancel"){}
                else{
                try{
                //cambia el material componente idicar la unidad de medida
                TMaterial modex = (from p in _dbContext.TMaterials where p.MatId==component.CoComId
                select p).SingleOrDefault();
                component.CoComUM=modex.MatUnMed;
                }catch{}
                CreateViewBags(0,0);    
                ViewData["panel"]=4;
                return View(component);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=4;

            return RedirectToAction("MatComp",new{id=MId});

        } 


        [HttpGet]
        public IActionResult RMatEdit(int id, int MId ,int pamen){
            CreateViewBags(0,0);
            ViewData["pamen"]=pamen;
            ViewData["panel"]=4;
            try{
            VTMRouting model =(from pl in _dbContext.TMRoutings 
            join p in _dbContext.TMaterials on pl.RouRefId equals p.MatId
            join q in _dbContext.TWorkCenters on pl.RouWcid equals q.WcdId
            orderby p.MatDescr 
            where pl.RouId ==id 
            select new VTMRouting { 
                RoRoId=pl.RouId,
                RoRoMatId=p.MatId ,
                RoRoMatRe = p.MatRefer ,
                RoRoMatDe=p.MatDescr ,
                RoRoFase=pl.RouFase,
                RoRoOper=pl.RouOper,
                RoRoTunit=pl.RouTunit,
                RoRoWCId=pl.RouWcid,
                RoRoWCDe=q.Wcdescr,
                RoRoWtime=pl.RouWtime,
                RoRoWunit=pl.RouWunit
                }).SingleOrDefault();
            return View(model);
            }
            catch{return View("Error");}  

         }

        [HttpPost]
        public IActionResult RMatEdit(VTMRouting routing,int id ,int MId, string actionType) {
            
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    TMRouting nmod = new TMRouting();
                            nmod.RouId=id;
                            nmod.RouWcid=routing.RoRoWCId; 
                            nmod.RouWunit=routing.RoRoWunit;
                            nmod.RouWtime=routing.RoRoWtime;
                            nmod.RouTunit=routing.RoRoTunit;
                            nmod.RouFase=routing.RoRoFase;
                            nmod.RouOper=routing.RoRoOper;
                            nmod.RouRefId=routing.RoRoMatId;
                        _dbContext.TMRoutings.Update(nmod); 
                        _dbContext.SaveChanges();
                }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                ViewData["panel"]=4;
                return View(routing);
                }
            }
            else{
                if (actionType=="Cancel"){}
                else{
                try{
                //cambia el material componente idicar la unidad de medida
                }catch{}
                CreateViewBags(0,0);    
                ViewData["panel"]=4;
                return View(routing);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=4;

            return RedirectToAction("MatRoute",new{id=MId});

        } 


        public IActionResult MatComp(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,"",id);    
            ViewData["panel"]=4;
            ViewBag.Material=mode;   

            return View(mode);

        }

        public IActionResult MatBom(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,"",id);    
            ViewData["panel"]=4;
            ViewBag.Material=mode;   

            return View(mode);

        }

        public IActionResult MatRoute(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,"",id);    
            ViewData["panel"]=4;
            ViewBag.Material=mode;   

            return View(mode);

        }

     }
}
