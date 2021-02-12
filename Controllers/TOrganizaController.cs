using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MyErp.Models;
using System;
using System.Linq;

namespace MyErp.Controllers {
    public class TOrganizaController : Controller {
        private readonly MyErpDBContext _dbContext;
        private readonly ILogger<TPersonController> _logger;    
        private void CreateViewBags(int chid=0)
        {

            var chart = from p in _dbContext.TCharts
                        join e in _dbContext.TPersons 
                        on p.CharHeadId equals e.PerId
                        orderby p.CharName
                        select new VTChart {
                        CharAdress =p.CharAdress,
                        CharAdressad=p.CharAdressad,
                        CharCity=p.CharCity,
                        CharCode=p.CharCode,
                        CharCtry=p.CharCtry,
                        CharDate=p.CharDate,
                        CharEmail=p.CharEmail,
                        CharHeadId=p.CharHeadId,
                        CharId=p.CharId,
                        CharName=p.CharName,
                        CharTel=p.CharTel,
                        CharWeb=p.CharWeb,
                        CharHName=e.PerName+" "+e.PerName1
                        };
            ViewBag.ListChar = chart.ToList(); 

            var chartrol = from p in _dbContext.TChartRols
                        join e in _dbContext.TPersons 
                        on p.RcharRolId equals e.PerId
                        where p.RcharCharId==chid
                        orderby e.PerName1,e.PerName
                        select new VTChartRol {
                        RcharId=p.RcharId,
                        RcharCharId=p.RcharCharId,
                        RcharRolId=e.PerId,
                        RcharPerName=e.PerName1+" "+e.PerName
                        };
            ViewBag.ListCharRol = chartrol.ToList(); 


            var resuld1 = from p in _dbContext.TPersons 
                        orderby p.PerName1
                        //where p.WcfaId==plant
                        select new TPerson{PerId=p.PerId ,PerName=p.PerName1+" "+p.PerName};
            var resuld0 = ( from p in _dbContext.TPersons  
            select new TPerson{PerId=0,PerName=" Select a Work Center"}).Distinct().ToList();
            var resuld = resuld0.Concat(resuld1);
            ViewBag.ddlPerso = new SelectList(resuld.ToList(), "PerId", "PerName"); 
        }
        public TOrganizaController(MyErpDBContext dbContext,ILogger<TPersonController> logger)
        {
            _dbContext = dbContext;
            _logger = (ILogger<TPersonController>)logger;
        }   
        public IActionResult Index(int panel, int? FaId, int? WcdId, string Code, string actionType) {
            if(panel ==0 ){panel=1;}
            if (panel==3){ViewData["modulo"]=99;}
            ViewData["panel"]=panel;
            if (panel==1)
            {
            try{
                var qry=(from or in _dbContext.TOrganizacions
                 select or).FirstOrDefault();
                 return RedirectToAction("Edit");    
                 //return View("Edit",qry);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            }
            else {
                CreateViewBags();
                return View();}

        }
        
        [HttpGet]
        public IActionResult CharCreate(string actionType) {
            CreateViewBags();
            ViewData["panel"]=2;
            return View();      
        }

        [HttpPost]
        public IActionResult CharCreate(TChart chart,string actionType) {
            ViewData["panel"]=2;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TCharts.Add(chart); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags();    
                return View(chart);
                }
            }
            CreateViewBags();    

            return RedirectToAction("Index",new{panel=2});
        }

        [HttpGet]
        public IActionResult RCharCreate(int chid,string actionType) {
            CreateViewBags(chid);
            ViewData["panel"]=2;
            return View();      
        }

        [HttpPost]
        public IActionResult RCharCreate(TChartRol chart,int chid,string actionType) {
            ViewData["panel"]=2;
            //int chid=chart.RcharCharId;
            chart.RcharCharId=chid;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TChartRols.Add(chart); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                CreateViewBags(chid);    
                return View(chart);
                }
            }
            CreateViewBags(chid);    

            return RedirectToAction("CharEdit",new{id=chid, panel=2});
        }
        public IActionResult CharDelete(int id) {
            var mode = _dbContext.TCharts
                .SingleOrDefault(u => u.CharId.Equals(id));
            try{
            _dbContext.TCharts.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags();                
            ViewData["panel"]=2;
            return RedirectToAction("Index",new{panel=2});
        }
        public IActionResult RCharDelete(int id,int chid) {
            var mode = _dbContext.TChartRols
                .SingleOrDefault(u => u.RcharId.Equals(id));
            try{
            _dbContext.TChartRols.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(chid);                
            ViewData["panel"]=2;
            return RedirectToAction("CharEdit",new{id =chid,panel=2});
        }

        [HttpGet]
        public IActionResult Edit(int id, int panel, int move) {
            if (panel==0){panel=1;}
            ViewData["panel"]=panel;
            try{
            //string pna1=model.PerName1;
            if (id==0){
                var qry=(from or in _dbContext.TOrganizacions
                 select or).FirstOrDefault();
                 return View("Edit",qry);
            }
            var model = _dbContext.TOrganizacions
                .SingleOrDefault(u => u.OrgId.Equals(id));
            return View("Edit",model);
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                return RedirectToAction("Index");}    
        }    
        [HttpPost]
        public IActionResult Edit(TOrganizacion organiza, string actionType) {
             ViewData["panel"]=1;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TOrganizacions.Update(organiza);
                _dbContext.SaveChanges();
            }
            catch(Exception ex) {
                string mensaje = ex.Message;
            }
            }else{
                return View(organiza);
            }
            }
            return RedirectToAction("Index");
        }        

        [HttpGet]
        public IActionResult CharEdit(int id, int wrem, int wass,int assign, int WcoId) {
            ViewData["panel"]=2;
            ViewData["ChartId"]=id;
            try{
            var model = _dbContext.TCharts
                .SingleOrDefault(u => u.CharId.Equals(id));
            CreateViewBags(id);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult CharEdit(TChart chart,int id ,int WcoId , int wass, string actionType) {
            if (actionType=="Cancel"){}
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TCharts.Update(chart);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    CreateViewBags(id);    
                    ViewData["panel"]=2;
                 return View(chart);
                }
            }
            CreateViewBags();    
            ViewData["panel"]=2;

            return RedirectToAction("Index",new{panel=2, FaId=0});
        } 

    }
}