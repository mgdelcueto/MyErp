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
    public class TLogController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TLogController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void CreateViewBags(int? Hid)
        {
            var querybl = (from bl in _dbContext.TInputBLHs
                            orderby bl.InBLnum 
                            select bl).ToList();
            ViewBag.ListBL=querybl;

            var querysup1 = (from p in _dbContext.TSupliers 
                        orderby p.SupRasoc
                        select new TSuplier{SupId=p.SupId,SupRasoc=p.SupRasoc} ).ToList();
            var querysup0 = ( from p in _dbContext.TSupliers  
            select new TSuplier{SupId=0,SupRasoc="Select a Suplier"}).Distinct().ToList();
            var querysup = querysup0.Concat(querysup1);
            ViewBag.ddlSU = new SelectList(querysup.ToList(), "SupId", "SupRasoc",0); 


            var querybld =(from pl in _dbContext.TInputBLDs
            join p in _dbContext.TMaterials on pl.InBLDProdId equals p.MatId
            orderby pl.InBLDId 
            where pl.InBLId ==Hid 
            select new VTBLDet { 
                InBLDId=pl.InBLDId,
                InBLId=pl.InBLId,
                //InBLDateRec=pl.InBLDateRec,
                InBLDMatUnMed=p.MatUnMed,
                InBLDMDescr=p.MatDescr,
                InBLDMRefer=p.MatRefer,
                //InBLDNum=pl.InBLDNum,
                InBLDProdId=pl.InBLDProdId,
                InBLDQty=pl.InBLDQty,
                InBLDStat=pl.InBLDStat,
                InBLDUM=pl.InBLDUM,
                InBLDUMRef=pl.InBLDUMRef
                }).ToList();
            ViewBag.ListBLDet=querybld;

            /*
            var querypro1 = (from p in _dbContext.TMaterials 
                join 
                        orderby p.MatRefer
                        where p.MatClass =="RM"
                        select new TMaterial{MatId=p.MatId,MatDescr=p.MatDescr} ).ToList();
            var querypro0 = ( from p in _dbContext.TMaterials  
            select new TMaterial{MatId=0,MatDescr="Select a Material"}).Distinct().ToList();
            var queryprod = querypro0.Concat(querypro1);
            ViewBag.ddlProd = new SelectList(queryprod.ToList(), "MatId", "MatDescr",0); 
            */

            int? Sid=0;
            try{
            var mode = _dbContext.TInputBLHs
                .SingleOrDefault(u => u.InBLId.Equals(Hid));
            Sid = mode.InBLSupId;}
            catch{}

            var result = (from p in _dbContext.TSPorders
                        join  mat in _dbContext.TMaterials on p.SpocprodId equals mat.MatId
                        orderby mat.MatDescr
                        where p.SposupId==Sid  //&& p.MatClass =="RM"
                        select new {mat.MatId,mat.MatDescr}).ToList();

            ViewBag.ddlProd = new SelectList(result.ToList(), "MatId", "MatDescr",0); 


        }
        public IActionResult Index(int panel, int? BlId) {
            if(panel ==0 ){panel=1;}
            if(BlId ==null ){BlId=int.Parse("0");}
            ViewData["panel"]=panel;
            try{
                CreateViewBags(0);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                ViewData["ErrorMs"]=mensaje;
                ViewData["panel"]=999;
                //return View('Error',new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
            return View();
        }

        [HttpGet]
        public IActionResult BLHCreate(string actionType) {
            CreateViewBags(0);
            ViewData["panel"]=1;
            return View();      
        }

        [HttpPost]
        public IActionResult BLHCreate(TInputBLH model,string actionType) {
            ViewData["panel"]=1;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TInputBLHs.Add(model); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(0);    
                return View(model);
                }
            }
            CreateViewBags(0);    
            ViewData["panel"]=1;

            return RedirectToAction("Index",new{panel=1});
        }


        [HttpGet]
        public IActionResult BLDCreate(int id,int Pid, string actionType) {
            CreateViewBags(Pid);

            TInputBLH mat=(from  ma in _dbContext.TInputBLHs
            where ma.InBLId==Pid select ma).SingleOrDefault();
            ViewData["panel"]=1;
            VTBLDet queryco=(from  ma in _dbContext.TInputBLHs
            join co in _dbContext.TInputBLDs on ma.InBLId equals co.InBLId
            into RefComp
            from pco in RefComp.DefaultIfEmpty()
            where ma.InBLId==Pid
            select new VTBLDet { 
                InBLDId=0,
                InBLId=Pid,
                //InBLDateRec=System.DateTime.Now,
                InBLDMatUnMed="",
                InBLDMDescr="",
                InBLDMRefer="",
                //InBLDNum="",
                InBLDProdId=0,
                InBLDQty=0,
                InBLDStat="",
                InBLDUM=0,
                InBLDUMRef=""
                }).Distinct().SingleOrDefault();
             //ViewBag.ListMatComp=queryco;
            return View((VTBLDet)queryco);      
        }

        [HttpPost]
        public IActionResult BLDCreate(VTBLDet routing,int id,string actionType) {
            ViewData["panel"]=1;
            if(actionType=="Add"){
             //if (ModelState.IsValid){
                    try{
                        TInputBLD nmod = new TInputBLD();
                        //nmod.InBLDId=routing.InBLDId,
                        nmod.InBLId=id;//routing.InBLId;
                        //nmod.InBLDateRec=routing.InBLDateRec;
                        //nmod.InBLDMatUnMed=routing.InBLDMatUnMed;
                        //nmod.InBLDMDescr=routing.InBLDMDescr;
                        //nmod.InBLDMRefer=routing.InBLDMRefer;
                        //nmod.InBLDNum=routing.InBLDNum;
                        nmod.InBLDProdId=routing.InBLDProdId;
                        nmod.InBLDQty=routing.InBLDQty;
                        nmod.InBLDStat=routing.InBLDStat;
                        nmod.InBLDUM=routing.InBLDUM;
                        nmod.InBLDUMRef=routing.InBLDUMRef;
 
                         _dbContext.TInputBLDs.Add(nmod); 
                        _dbContext.SaveChanges();
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
/*
                 } 
            else {
                CreateViewBags(0);    
                return View(routing);
                }
*/
            }
            else{
            if (actionType=="Cancel"){}
            else {
               try{
                //cambia el material componente idicar la unidad de medida
                }catch{}                
                CreateViewBags(0);    
                return View(routing);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=1;

            return RedirectToAction("BLHEdit",new{id=id});
        }


        [HttpGet]
        public IActionResult BLHEdit(int id) {
            ViewData["panel"]=1;
            try{
            if (id==0){return View();}
            else{
            var model = _dbContext.TInputBLHs
                .SingleOrDefault(u => u.InBLId.Equals(id));
            CreateViewBags(id);  
            return View(model);
            }
            }
            catch(Exception ex ){
                string mensaje = ex.Message;
                return View("Error");}            
        }

        [HttpPost]
        public IActionResult BLHEdit(TInputBLH material,int id ,string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    material.InBLId=id;
                    _dbContext.TInputBLHs.Update(material);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(id);    
                    ViewData["panel"]=1;
                 return View(material);
                }
            }
            CreateViewBags(id);    
            ViewData["panel"]=1;

            return RedirectToAction("Index");
        } 


        [HttpGet]
        public IActionResult BLDEdit(int id, int? Hid ,int pamen){
            var mode = _dbContext.TInputBLDs
                .SingleOrDefault(u => u.InBLDId.Equals(id));
            Hid=mode.InBLId;
            CreateViewBags(Hid);
            ViewData["panel"]=1;
            try{
            VTBLDet model =(from pl in _dbContext.TInputBLDs 
            join p in _dbContext.TMaterials on pl.InBLDProdId equals p.MatId
            //orderby pl.InBLId 
            where pl.InBLDId ==id 
            select new VTBLDet { 
                InBLDId=pl.InBLDId,
                InBLId=pl.InBLId,
                //InBLDateRec=pl.InBLDateRec,
                InBLDMatUnMed=p.MatUnMed,
                InBLDMDescr=p.MatDescr,
                InBLDMRefer=p.MatRefer,
                //InBLDNum=pl.InBLDNum,
                InBLDProdId=pl.InBLDProdId,
                InBLDQty=pl.InBLDQty,
                InBLDStat=pl.InBLDStat,
                InBLDUM=pl.InBLDUM,
                InBLDUMRef=pl.InBLDUMRef
                }).SingleOrDefault();
            /*
            MId=model.RoRoMatId;
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(MId));
            ViewBag.Material=mode;   
            */

            return View(model);
            }
            catch{return View("Error");}  

         }

        [HttpPost]
        public IActionResult BLDEdit(VTBLDet routing,int id ,int Hid, string actionType) {
            if(Hid==null){Hid=0;}
            if (actionType=="Update"){
            //if (ModelState.IsValid){
                try{
                    TInputBLD nmod = new TInputBLD();
                            nmod.InBLDId=id;
                            nmod.InBLId=Hid;//routing.InBLId,
                            //nmod.InBLDateRec=routing.InBLDateRec;
                            //nmod.InBLDMatUnMed=routing.InBLDMatUnMed;
                            //nmod.InBLDMDescr=routing.InBLDMDescr;
                            //nmod.InBLDMRefer=routing.InBLDMRefer;
                            //nmod.InBLDNum=routing.InBLDNum;
                            nmod.InBLDProdId=routing.InBLDProdId;
                            nmod.InBLDQty=routing.InBLDQty;
                            nmod.InBLDStat=routing.InBLDStat;
                            nmod.InBLDUM=routing.InBLDUM;
                            nmod.InBLDUMRef=routing.InBLDUMRef;
                            
                        _dbContext.TInputBLDs.Update(nmod); 
                        _dbContext.SaveChanges();
                }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
/*
                 } 
            else {
                CreateViewBags(0);    
                ViewData["panel"]=1;
                return View(routing);
                }
*/
            }
            else{
                if (actionType=="Cancel"){}
                else{
                try{
                //cambia el material componente idicar la unidad de medida
                }catch{}
                CreateViewBags(Hid);    
                ViewData["panel"]=1;
                return View(routing);
                }
            }
            //CreateViewBags(0,0);    
            ViewData["panel"]=1;

            return RedirectToAction("BLHEdit",new{id=Hid});

        } 

        public IActionResult BLHDelete(int id) {
            var mode = _dbContext.TInputBLHs
                .SingleOrDefault(u => u.InBLId.Equals(id));
            try{
            _dbContext.TInputBLHs.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0);                
            ViewData["panel"]=1;
            return RedirectToAction("Index",new{panel=1});
        }

        public IActionResult BLDDelete(int id) {
            int? Mid=0;
            var mode = _dbContext.TInputBLDs
                .SingleOrDefault(u => u.InBLDId.Equals(id));
            try{
            Mid=mode.InBLId;
            _dbContext.TInputBLDs.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0);                
            ViewData["panel"]=1;
            return RedirectToAction("BLHEdit",new{id=Mid});
        }


    }
}