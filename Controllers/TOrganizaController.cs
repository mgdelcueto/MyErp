using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MyErp.Models;
using System;
using System.Linq;

namespace MyErp.Controllers {
    public class TOrganizaController : Controller {
        private readonly MyErpDBContext _dbContext;
        private readonly ILogger<TPersonController> _logger;    

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
            else {return View();}

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
    
    }
}