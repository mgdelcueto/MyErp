using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace MyErp.Controllers {
    [Authorize(Roles="Engineer,Administrator")]
    public class TEngineController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TEngineController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void CreateViewBags(int? prod, int? plant,string Code="",int Coid=0,int? CustId=0,int? TruckId=0)
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

            var querylos = (from p in _dbContext.TLocations 
                        orderby p.LocCode 
                        where p.LocFaId==plant
                        select p).ToList();
            ViewBag.ListStorAs=querylos;


            var querycan1 = (from p in _dbContext.TWorkCenters 
                        orderby p.Wccode 
                        where p.WcfaId!=plant
                        select new TWorkCenter{WcdId=p.WcdId,Wcdescr=p.Wcdescr} ).ToList();
            var querycan0 = ( from p in _dbContext.TWorkCenters  
            select new TWorkCenter{WcdId=0,Wcdescr="Select a WorkCenter"}).Distinct().ToList();
            var querycans = querycan0.Concat(querycan1);
            ViewBag.ddlProdNAS = new SelectList(querycans.ToList(), "WcdId", "Wcdescr",0); 


            var querylan1 = (from p in _dbContext.TLocations 
                        orderby p.LocCode 
                        where p.LocFaId!=plant
                        select new TLocation{LocId=p.LocId,LocDescr=p.LocDescr} ).ToList();
            var querylan0 = ( from p in _dbContext.TWorkCenters  
            select new TLocation{LocId=0,LocDescr="Select a Location"}).Distinct().ToList();
            var querylans = querylan0.Concat(querylan1);
            ViewBag.ddlLocNAS = new SelectList(querylans.ToList(), "LocId", "LocDescr",0); 

            var querylax1 = (from p in _dbContext.TLocations 
                        orderby p.LocCode 
                        select new TLocation{LocId=p.LocId,LocDescr=p.LocDescr} ).ToList();
            var querylax0 = ( from p in _dbContext.TWorkCenters  
            select new TLocation{LocId=0,LocDescr="Select a Location"}).Distinct().ToList();
            var querylaxs = querylan0.Concat(querylax1);
            ViewBag.ddlLocNAX = new SelectList(querylaxs.ToList(), "LocId", "LocDescr",0); 



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

            var queryopas = (from p in _dbContext.TWcoperators
                join w in _dbContext.TWorkCenters on p.WcopWcid equals w.WcdId
                join o in _dbContext.TOperators on p.WcopOpId equals o.OpeId
                where p.WcopWcid==prod
                select new VTWOperator {OpWcId=p.WcopWcid, OpOpId=p.WcopOpId,
                                       OpOpCode=o.OpeCode,OpOpDes=o.OpeDesc,
                                       OpOPAcct=o.OpeAcct,OpOpCost=o.OpeCosth,
                                       OpOPCurcy=o.OpeCurcy, OpWcCode=w.Wccode,OpWcDes=w.Wcdescr}).ToList();

            ViewBag.ListOpdAs=queryopas;

            var querypan1 = (from p in _dbContext.TWccomponents 
                        orderby p.WcoCode
                        where p.WcoWcid!=prod
                        select new TWccomponent{WcoId=p.WcoId,WcoDescr=p.WcoDescr} ).ToList();
            var querypan0 = ( from p in _dbContext.TWccomponents  
            select new TWccomponent{WcoId=0,WcoDescr="Select a Component"}).Distinct().ToList();
            var querypans = querypan0.Concat(querypan1);
            ViewBag.ddlPodNAS = new SelectList(querypans.ToList(), "WcoId", "WcoDescr",0); 

            var queryopan1 = (from p in _dbContext.TOperators 
                        orderby p.OpeDesc
                        //where p.WcoWcid!=prod
                        select new TOperator{OpeId=p.OpeId,OpeDesc=p.OpeDesc} ).ToList();
            var queryopan0 = ( from p in _dbContext.TWccomponents  
            select new TOperator{OpeId=0,OpeDesc="Select a Operator"}).Distinct().ToList();
            var queryopans = queryopan0.Concat(queryopan1);
            ViewBag.ddlPodOPS = new SelectList(queryopans.ToList(), "OpeId", "OpeDesc",0); 


            var queryma =(from po in _dbContext.TMaterials
                        orderby po.MatDescr
                        where po.MatClass==Code || Code ==null ||Code =="" ||Code=="--"
                        //where po.WcoWcid ==prod || prod==0
                        select po).ToList();
            ViewBag.ListMA=queryma;

            var querylo =(from po in _dbContext.TLocations
                        orderby po.LocDescr
                        where po.LocFaId ==plant || plant==0
                        select po).ToList();
            ViewBag.ListLO=querylo;

            var querylop =(from po in _dbContext.TOperators
                        orderby po.OpeDesc
                        //where po.LocFaId ==plant || plant==0
                        select po).ToList();
            ViewBag.ListOP=querylop;

            var querytr =(from po in _dbContext.TCTrucks
                        orderby po.TruckDeno
                        //where po.LocFaId ==plant || plant==0
                        select po).ToList();
            ViewBag.ListTruck=querytr;

            var querystr =(from po in _dbContext.TCTrScheds
                        orderby po.TrScDayOfWeek,po.TrScCrLoadStart
                        where po.TrScTruckId==TruckId 
                        //where po.LocFaId ==plant || plant==0
                        select po).ToList();
            ViewBag.ListSTrucks=querystr;

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


            var querylom =(from pl in _dbContext.TMLocations 
            join p in _dbContext.TMaterials on pl.MLocMatId equals p.MatId
            join q in _dbContext.TLocations on pl.MLocLodId equals q.LocId
            orderby p.MatDescr 
            where pl.MLocMatId ==Coid 
            select new VTMLocation { LoLoId=pl.MLocId ,LoRefRe = p.MatRefer ,
            LoRefDes=p.MatDescr ,LoRefUM = p.MatUnMed,
            LoRefSt=pl.MLocStock ,   LoRefId=p.MatId,
            LoLocCode=q.LocCode,LoLocDescr=q.LocDescr
            }).ToList();
            ViewBag.ListMatLoca=querylom;


            Guid g = Guid.NewGuid();
            string Table = g.ToString();
            //var spParams = new object[] { Coid, 0,0,Table };
            //_dbContext.Database.ExecuteSqlRaw("Explosion @p0, @p1, @P3, @p4", spParams);
            var conjunto = new SqlParameter("@p0", Coid);
            var level = new SqlParameter("@p1", int.Parse("0"));
            var order = new SqlParameter("@p2",int.Parse("0"));
            var coef = new SqlParameter("@p3",int.Parse("1"));
            var table = new SqlParameter("@p4", Table);
            //Ejecutamos la explosion
            var explo = new SqlParameter("@p5",int.Parse("1"));
            _dbContext.Database.ExecuteSqlRaw("bCExplosion {0}, {1}, {2}, {3},{4},{5}", conjunto,level,order,coef,table,explo);
            //var sql = "SELECT ExpId,ExpOrder,ExpLevel,ExpComp,m.MatRefer as ExpRefer,m.MatDescr as ExpDescr,ExpsLevel,ExpCoef,ExpAcCoef,m.MatUnMed as ExpUM FROM ["+Table+"] as t LEFT JOIN T_Material as m ON  t.ExpComp = m.MatId";
            var sqle = "SELECT ExpId,ExpComp,ExpsLevel,ExpRefer,ExpDescr,ExpCoef,ExpUM,WCCode,ExpRouFase,ExpRouOper,ExpRouTime,ExpRouTUnit FROM ["+Table+"] ORDER BY  ExpId";
            var explosio = _dbContext.TExplosionBs.FromSqlRaw(sqle).ToList();
            _dbContext.Database.ExecuteSqlRaw("Xx_Explosion {0}", table);
            ViewBag.ListMatBom=explosio; //querybo;

            //ejecutamos la implosion
            var implo = new SqlParameter("@p5",int.Parse("0"));
            _dbContext.Database.ExecuteSqlRaw("bCExplosion {0}, {1}, {2}, {3},{4},{5}", conjunto,level,order,coef,table,implo);
            //var sql = "SELECT ExpId,ExpOrder,ExpLevel,ExpComp,m.MatRefer as ExpRefer,m.MatDescr as ExpDescr,ExpsLevel,ExpCoef,ExpAcCoef,m.MatUnMed as ExpUM FROM ["+Table+"] as t LEFT JOIN T_Material as m ON  t.ExpComp = m.MatId";
            var sqli = "SELECT ExpId,ExpComp,ExpsLevel,ExpRefer,ExpDescr,ExpCoef,ExpUM,WCCode,ExpRouFase,ExpRouOper,ExpRouTime,ExpRouTUnit FROM ["+Table+"] ORDER BY  ExpId";
            var implosio = _dbContext.TExplosionBs.FromSqlRaw(sqli).ToList();
            _dbContext.Database.ExecuteSqlRaw("Xx_Explosion {0}", table);
            ViewBag.ListMatImp=implosio; //querybo;

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
                RoRoWunit=pl.RouWunit,
                RoRoMinLot=pl.RouMinLot,
                RoRoUEmb=pl.RouUEmb
                }).ToList();
            
            ViewBag.ListMatRou=queryro;
            var queryplan = (from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
                        where p.CplantCustId==CustId || CustId==0
                        select new TCCplant {CplantId=p.CplantId ,CplantDeno=p.CplantDeno}).ToList();
            var querypla0 = ( from p in _dbContext.TCCplants  
            select new TCCplant{CplantId=0,CplantDeno="Select a Plant"}).Distinct().ToList();
            var queryplans = querypla0.Concat(queryplan);
            ViewBag.ddlPlantX = new SelectList(queryplans.ToList(), "CplantId", "CplantDeno",0); 

            var querycust = (from p in _dbContext.TCustomers 
                        orderby p.CustRasoc
                        select new TCustomer {CustId=p.CustId ,CustRasoc=p.CustRasoc}).ToList();
            var querycus0 = ( from p in _dbContext.TCCplants  
            select new TCustomer{CustId=0,CustRasoc="Select a Customer"}).Distinct().ToList();
            var querycusts = querycus0.Concat(querycust);
            ViewBag.ddlCustoX = new SelectList(querycusts.ToList(), "CustId", "CustRasoc",0); 


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

        private void  LoRemove(int id) {
            try{
            var model = _dbContext.TLocations
                .SingleOrDefault(u => u.LocId.Equals(id));
                model.LocFaId=null;
               _dbContext.TLocations.Update(model);
               _dbContext.SaveChanges();
            }
            catch{}            
        }

        private void  LoAssign(int id,int wca) {
            try{
            var model = _dbContext.TLocations
                .SingleOrDefault(u => u.LocId.Equals(wca));
                model.LocFaId=id;
               _dbContext.TLocations.Update(model);
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
        private void  WOpRemove(int wcid,int opid) {
            try{
                var model = _dbContext.TWcoperators
                    .SingleOrDefault(u => u.WcopWcid.Equals(wcid)&& u.WcopOpId.Equals(opid));
                _dbContext.TWcoperators.Remove(model);
                _dbContext.SaveChanges();
                }  
            catch{}                  
        }

        private void  WOpAssign(int wcid,int opid,float opnum) {
                    try{
                        TWcoperator nmod = new TWcoperator();
                            nmod.WcopWcid=wcid; 
                            nmod.WcopOpId=opid;
                            nmod.WcopNum=opnum;
                        _dbContext.TWcoperators.Add(nmod); 
                        _dbContext.SaveChanges();
                    }
                    catch(Exception ex){
                        string mensaje =ex.Message;
                    }
        }

        public IActionResult Index(int panel, int? FaId, int? WcdId, string Code, string actionType) {
            if(panel ==0 ){panel=1;}
            if(FaId ==null ){FaId=int.Parse("0");}
            if(WcdId ==null ){WcdId=int.Parse("0");}
            ViewData["panel"]=panel;
            ViewData["Title"] = "Engineer Data";
            //var dbContext = new MyErpDBContext();
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
        public IActionResult LoCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=5;
            return View();      
        }

        [HttpPost]
        public IActionResult LoCreate(TLocation location,string actionType) {
            ViewData["panel"]=5;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TLocations.Add(location); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0,location.LocFaId);    
                return View(location);
                }
            }
            CreateViewBags(0,location.LocFaId);    

            return RedirectToAction("Index",new{panel=5});
        }


        [HttpGet]
        public IActionResult OphCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=6;
            return View();      
        }

        [HttpPost]
        public IActionResult OphCreate(TOperator myoperator,string actionType) {
            ViewData["panel"]=6;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TOperators.Add(myoperator); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                return View(myoperator);
                }
            }
            CreateViewBags(0,0);    

            return RedirectToAction("Index",new{panel=6});
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
        public IActionResult LMatCreate(int id,string actionType) {
            CreateViewBags(0,0);
            TMaterial mat=(from  ma in _dbContext.TMaterials
            where ma.MatId==id select ma).SingleOrDefault();
            ViewData["panel"]=4;
            VTMLocation queryco=(from  ma in _dbContext.TMaterials
            join co in _dbContext.TMLocations on ma.MatId equals co.MLocMatId
            into RefComp
            from pco in RefComp.DefaultIfEmpty()
            where ma.MatId==id
            select new VTMLocation { 
                LoRefId=id,
                LoRefRe =mat.MatRefer,
                LoRefDes=mat.MatDescr,
                LoRefUM = mat.MatUnMed, 
                LoRefSt=0,}).Distinct().SingleOrDefault();
             //ViewBag.ListMatComp=queryco;
            return View((VTMLocation)queryco);      
        }

        [HttpPost]
        public IActionResult LMatCreate(VTMLocation location,int id,string actionType) {
            ViewData["panel"]=5;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        TMLocation nmod = new TMLocation();
                            nmod.MLocLodId =location.LoLoId; 
                            nmod.MLocStock=location.LoRefSt;
                            nmod.MLocMatId=location.LoRefId;
                        _dbContext.TMLocations.Add(nmod); 
                        _dbContext.SaveChanges();
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                return View(location);
                }
            }
            else{
            if (actionType=="Cancel"){}
            else {
                CreateViewBags(0,0);    
                return View(location);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=5;

            return RedirectToAction("MatLocal",new{id=id});
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
                RoRoWunit=1,
                RoRoMinLot=1,
                RoRoUEmb=1
                }).Distinct().SingleOrDefault();
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
                            nmod.RouMinLot=routing.RoRoMinLot;
                            nmod.RouUEmb=routing.RoRoUEmb;
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


        [HttpGet]
        public IActionResult TrCreate(string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=7;
            return View();      
        }

        [HttpPost]
        public IActionResult TrCreate(TCTruck truck,string actionType) {
            ViewData["panel"]=7;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TCTrucks.Add(truck); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0,0,"",0,truck.TruckCustId);    
                return View(truck);
                }
            }
            else {
                CreateViewBags(0,0,"",0,truck.TruckCustId);    
                return View(truck);
                }
            CreateViewBags(0,0,"",0,truck.TruckCustId);    

            return RedirectToAction("Index",new{panel=7});
        }

        [HttpGet]
        public IActionResult TrSCreate(int tid ,string actionType) {
            CreateViewBags(0,0);
            ViewData["panel"]=7;
            ViewData["truck"]=tid;
            return View();      
        }

        [HttpPost]
        public IActionResult TrSCreate(TCTrSched struck,int TrScTruck,string actionType) {
            ViewData["panel"]=7;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        struck.TrScTruckId=TrScTruck;
                        _dbContext.TCTrScheds.Add(struck); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                return View(struck);
                }
            }
            CreateViewBags(0,0);    

            return RedirectToAction("TrEdit",new{id=TrScTruck});
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

        public IActionResult LoDelete(int id) {
            var mode = _dbContext.TLocations
                .SingleOrDefault(u => u.LocId.Equals(id));
            try{
            _dbContext.TLocations.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=5;
            return RedirectToAction("Index",new{panel=5});
        }

        public IActionResult OphDelete(int id) {
            var mode = _dbContext.TOperators
                .SingleOrDefault(u => u.OpeId.Equals(id));
            try{
            _dbContext.TOperators.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=6;
            return RedirectToAction("Index",new{panel=6});
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

        public IActionResult LMatDelete(int id) {
            int? Mid=0;
            var mode = _dbContext.TMLocations
                .SingleOrDefault(u => u.MLocId.Equals(id));
            try{
            Mid=mode.MLocMatId;
            _dbContext.TMLocations.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=4;
            return RedirectToAction("MatLocal",new{id=Mid});
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

        public IActionResult TrDelete(int id) {
            var mode = _dbContext.TCTrucks
                .SingleOrDefault(u => u.TruckId.Equals(id));
            try{
            _dbContext.TCTrucks.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=7;
            return RedirectToAction("Index",new{panel=7});
        }

        public IActionResult TrSDelete(int id) {
            var mode = _dbContext.TCTrScheds
                .SingleOrDefault(u => u.TrScId.Equals(id));
            try{
            _dbContext.TCTrScheds.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,0);                
            ViewData["panel"]=7;
            return RedirectToAction("Index",new{panel=7});
        }


        [HttpGet]
        public IActionResult FacEdit(int id, int wrem,int wrel, int wass,int wasl, int assign,int assigl,int panel,int vpanel, int WcdId, int LocId) {
            ViewData["panel"]=panel;
            ViewData["vpanel"]=vpanel;
            try{
                if (vpanel==1){
                    if (assign==1){ViewData["Assign"]=1;}
                    if (wrem!=0){WCeRemove(wrem);}
                    if (wass!=0){WCeAssign(id,WcdId);}
                }
                else{
                    if (assigl==1){ViewData["LAssign"]=1;}
                    if (wrel!=0){LoRemove(wrel);}
                    if (wasl!=0){LoAssign(id,LocId);}
                }
            var model = _dbContext.TFacilities
                .SingleOrDefault(u => u.FaId.Equals(id));
            CreateViewBags(0,model.FaId);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult FacEdit(TFacility facility,int id ,int WcdId , int LocId,int wass,int wasl, string actionType) {
            ViewData["panel"]=1;
            if (actionType=="Cancel"){}
            else{
            if (wass!=0 && WcdId!=0){
                WCeAssign(id,WcdId);
                var model = _dbContext.TFacilities
                    .SingleOrDefault(u => u.FaId.Equals(id));
                CreateViewBags(0,model.FaId);  
                ViewData["vpanel"]=1;
                return View(model);
            }
            if (wasl!=0 && LocId!=0){
                LoAssign(id,LocId);
                var model = _dbContext.TFacilities
                    .SingleOrDefault(u => u.FaId.Equals(id));
                CreateViewBags(0,model.FaId);  
                ViewData["vpanel"]=2;
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
        public IActionResult WCeEdit(int id, int wrem, int wass,int assign, int WcoId,int OpeId, float opnum, int panem) {
            ViewData["panel"]=2;
            ViewData["panem"]=panem;
            try{
            ViewData["Assign"]=assign;
            //if (assign==1){ViewData["Assign"]=1;}
            if (assign==1){
                if (wrem!=0){
                    ViewData["Assign"]=0;
                    WCoRemove(wrem);}
                if (wass!=0){
                    ViewData["Assign"]=0;
                    WCoAssign(id,WcoId);}
            }
            if (assign==2){
                if (wrem!=0){
                    ViewData["Assign"]=0;
                    WOpRemove(id,wrem);}
                if (wass!=0){
                    ViewData["Assign"]=0;
                    WOpAssign(id,OpeId,opnum);}
            }
            var model = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
            CreateViewBags(id,model.WcfaId);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult WCeEdit(TWorkCenter wcenter,int id ,int WcoId ,int OpeId, float opnum, int wass, int assign,int panem,string actionType) {
            ViewData["panem"]=panem;
            if (actionType=="Cancel"){}
            else{
                if (assign ==1){
                    if (wass!=0 && WcoId!=0){
                        WCoAssign(id,WcoId);
                        var model = _dbContext.TWorkCenters
                            .SingleOrDefault(u => u.WcdId.Equals(id));
                         CreateViewBags(id,model.WcfaId);  
                        ViewData["panel"]=2;
                        return View(model);
                    }
                }
                if (assign ==2){
                    if (wass!=0 && OpeId!=0){
                        WOpAssign(id,OpeId,opnum);
                        var model = _dbContext.TWorkCenters
                            .SingleOrDefault(u => u.WcdId.Equals(id));
                         CreateViewBags(id,model.WcfaId); 
                         ViewData["panel"]=2;
                         return View(model);
                      }
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
            if (actionType=="Cancel_")
            {
                ViewData["Assign"]=0;
                var model = _dbContext.TWorkCenters
                    .SingleOrDefault(u => u.WcdId.Equals(id));
                CreateViewBags(id,model.WcfaId);  
                ViewData["panel"]=2;
                return View(model);

            }

            return RedirectToAction("Index",new{panel=2, FaId=wcenter.WcfaId});
        } 


        [HttpGet]
        public IActionResult LoEdit(int id, int wrem, int wass,int assign, int WcoId) {
            ViewData["panel"]=5;
            try{
            var model = _dbContext.TLocations
                .SingleOrDefault(u => u.LocId.Equals(id));
            CreateViewBags(id,model.LocFaId);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult LoEdit(TLocation location,int id ,int WcoId , int wass, string actionType) {
            if (actionType=="Cancel"){}
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TLocations.Update(location);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,location.LocFaId);    
                    ViewData["panel"]=5;
                 return View(location);
                }
            }
            CreateViewBags(0,location.LocFaId);    
            ViewData["panel"]=5;

            return RedirectToAction("Index",new{panel=5, FaId=location.LocFaId});
        } 

        [HttpGet]
        public IActionResult OphEdit(int id, int wrem, int wass,int assign, int WcoId) {
            ViewData["panel"]=6;
            try{
            var model = _dbContext.TOperators
                .SingleOrDefault(u => u.OpeId.Equals(id));
            CreateViewBags(0,0);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult OphEdit(TOperator myoperator,int id ,int WcoId , int wass, string actionType) {
            if (actionType=="Cancel"){}
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TOperators.Update(myoperator);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,0);    
                    ViewData["panel"]=6;
                 return View(myoperator);
                }
            }
            CreateViewBags(0,0);    
            ViewData["panel"]=6;

            return RedirectToAction("Index",new{panel=6, FaId=0});
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
            if (id==0){return View();}
            else{
            var model = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,model.MatClass);  
            return View(model);
            }
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
        public IActionResult LMatEdit(int id, int MId ,int pamen){
            CreateViewBags(0,0);
            ViewData["pamen"]=pamen;
            ViewData["panel"]=5;
            try{
            VTMLocation model =(from pl in _dbContext.TMLocations 
            join p in _dbContext.TMaterials on pl.MLocMatId equals p.MatId
            join q in _dbContext.TLocations on pl.MLocLodId equals q.LocId
            orderby p.MatDescr 
            where pl.MLocId ==id 
            select new VTMLocation { 
                LoLoId=pl.MLocLodId  ,LoRefRe = p.MatRefer ,
                LoRefDes=p.MatDescr ,LoRefUM = p.MatUnMed,
                LoRefSt=pl.MLocStock,LoRefId=p.MatId}).SingleOrDefault();
            return View(model);
            }
            catch{return View("Error");}  

         }

        [HttpPost]
        public IActionResult LMatEdit(VTMLocation location,int id ,int MId, string actionType) {
            
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    TMLocation nmod = new TMLocation();
                        nmod.MLocId=id;
                        nmod.MLocLodId=location.LoLoId; 
                        nmod.MLocStock=location.LoRefSt;
                        nmod.MLocMatId=location.LoRefId;
                        _dbContext.TMLocations.Update(nmod); 
                        _dbContext.SaveChanges();
                }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,0);    
                ViewData["panel"]=5;
                return View(location);
                }
            }
            else{
                if (actionType=="Cancel"){}
                else{
                CreateViewBags(0,0);    
                ViewData["panel"]=5;
                return View(location);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=5;

            return RedirectToAction("MatLocal",new{id=MId});

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
                RoRoWunit=pl.RouWunit,
                RoRoMinLot=pl.RouMinLot,
                RoRoUEmb=pl.RouUEmb
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
                            nmod.RouMinLot=routing.RoRoMinLot;
                            nmod.RouUEmb=routing.RoRoUEmb;
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


        [HttpGet]
        public IActionResult TrEdit(int id) {
            ViewData["panel"]=7;
            try{
            var model = _dbContext.TCTrucks
                .SingleOrDefault(u => u.TruckId.Equals(id));
            CreateViewBags(0,0,"",0,model.TruckCustId,model.TruckId);    
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult TrEdit(TCTruck truck,int id ,string actionType) {
            if (actionType=="Cancel")
            {
            CreateViewBags(0,0,"",0,truck.TruckCustId);    
            ViewData["panel"]=7;
            return RedirectToAction("Index",new{panel=7,WcdId=truck.TruckId});
            }
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TCTrucks.Update(truck);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,0,"",0,truck.TruckCustId);    
                    ViewData["panel"]=7;
                    return View(truck);
                }
            }
            else
            {
                    CreateViewBags(0,0,"",0,truck.TruckCustId);    
                    ViewData["panel"]=7;
                    return View(truck);
            }
            CreateViewBags(0,0,"",0,truck.TruckCustId);    
            ViewData["panel"]=7;

            return RedirectToAction("TrEdit",new{panel=7,WcdId=truck.TruckId});
        } 

        [HttpGet]
        public IActionResult TrSEdit(int id) {
            ViewData["panel"]=7;
            try{
            var model = _dbContext.TCTrScheds
                .SingleOrDefault(u => u.TrScId.Equals(id));
            CreateViewBags(0,0);  
            ViewData["truck"]=model.TrScTruckId;
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult TrSEdit(TCTrSched struck,int TrScTruck ,string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TCTrScheds.Update(struck);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(0,0);    
                    ViewData["panel"]=7;
                 return View(struck);
                }
            }
            CreateViewBags(0,0);    
            ViewData["panel"]=7;

            return RedirectToAction("TrEdit",new{id=TrScTruck});
        } 

        public IActionResult MatComp(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,"",id);    
            ViewData["panel"]=4;
            ViewBag.Material=mode;   

            return View(mode);

        }
        
        [HttpGet]
        public IActionResult WCEComp(int id, int wrem, int wass,int assign, int WcoId) {
            ViewData["panel"]=2;
            try{
            if (assign==1){ViewData["Assign"]=1;}
            if (wrem!=0){WCoRemove(wrem);}
            if (wass!=0){WCoAssign(id,WcoId);}
            var model = _dbContext.TWorkCenters
                .SingleOrDefault(u => u.WcdId.Equals(id));
            CreateViewBags(id,model.WcfaId);  
            ViewBag.WCenter=model;   
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult WCEComp(TWorkCenter wcenter,int id ,int WcoId , int wass, string actionType) {
            if (wass!=0 && WcoId!=0){
                WCoAssign(id,WcoId);
            }

            ViewData["panel"]=2;
            var model = _dbContext.TWorkCenters
                    .SingleOrDefault(u => u.WcdId.Equals(id));
            CreateViewBags(id,model.WcfaId);  
            ViewData["panel"]=2;
            ViewBag.WCenter=model;   
            return View(model);
        } 


        public IActionResult MatLocal(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            CreateViewBags(0,0,"",id);    
            ViewData["panel"]=5;
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

        public IActionResult MatImp(int id) {
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
