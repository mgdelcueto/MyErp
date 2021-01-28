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
    public class TMRPController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TMRPController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
    private void CreateViewBags()
    {
        //CreateVB_LCP();
        //CreateVB_cMRP();
    }
        private void CreateVB_cMRP(DateTime? F1, DateTime? F2){
            /*
             var qry = 
                from p in _dbContext.TCCplannings
                group p by p.CplanCprodId into g
                //select new   {TCCplannings =g.OrderBy(x=>x.CplanCprodId)}
                select new {Product=g.Key , CumQty = g.Sum(x=> x.CplanQty)}
                ;
            //foreach(TCCplanning c  in (List<TCCplanning>) qry )
            */
                Guid g = Guid.NewGuid();
                string Table = g.ToString();
                var table = new SqlParameter("@p0", Table);
                var pF1 = new SqlParameter("@p1", F1);
                var pF2 = new SqlParameter("@p2", F2);
                _dbContext.Database.ExecuteSqlRaw("Xi_Explosion {0},{1},{2}", table,pF1,pF2);
                var sqlo = "SELECT * FROM [Operx_"+Table+"] ORDER BY WCDescr";
                var sqlm = "SELECT * FROM [Matex_"+Table+"] ORDER BY MatDescr";
                var explosiop = _dbContext.TExpOpers.FromSqlRaw(sqlo).ToList();
                var explosiom = _dbContext.TExpMaters.FromSqlRaw(sqlm).ToList();
                _dbContext.Database.ExecuteSqlRaw("Xz_Explosion {0}", table);
                ViewBag.ListMatExp=explosiom; //querybo;
                ViewBag.ListOpeExp=explosiop; //querybo;
                 
        }
        private void CreateVB_LCP()
        {  
            var queryco =(from pl in _dbContext.TCCplannings 
            join t in _dbContext.TCCplants on new{C_customer =pl.CplanCustId,     C_plant = pl.CplanCplantId} equals 
                                              new{C_customer = t.CplantCustId,    C_plant =t.CplantId}
            join c in _dbContext.TCustomers on t.CplantCustId equals c.CustId
            join m in _dbContext.TMaterials on pl.CplanCprodId equals m.MatId
            select new VCCplanning { 
                CplanCplantId=pl.CplanCplantId,
                CplanCprodId=pl.CplanCprodId,
                CplanCustId=pl.CplanCustId,
                CplanDateFrom=pl.CplanDateFrom,
                CplanDateTo=pl.CplanDateTo,
                CplanFirmSt=pl.CplanFirmSt,
                CplanId=pl.CplanId,
                CplanQty=pl.CplanQty,
                CplanCplantCode = t.CplantCode,
                CplanCplantDeno=t.CplantDeno,
                CplanCustCode=c.CustCode,
                CplanCustRasoc=c.CustRasoc ,
                CplanCprodDescInt=m.MatDescr,
                CplanCprodRefInt=m.MatRefer}).ToList();
            ViewBag.ListCustPlan=queryco;

        }

        [HttpGet]
        public IActionResult Index(DateTime? F1, DateTime? F2,int panel, int panel1,string actionType) {
            if(panel ==0 ){panel=1;}
            if (F1==null){F1=System.DateTime.Now;}
            if (F2==null){F2=System.DateTime.Now;}
            ViewData["panel"]=panel;
            ViewData["panel1"]=panel1;
            ViewData["Title"] = "MRP Data";
            var dbContext = new MyErpDBContext();
            try{
                    CreateVB_LCP();
                    CreateVB_cMRP(F1,F2);  //ListCustPlan
             return View();
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }

        [HttpPost]
        public IActionResult Index(VCCplanning model, int panel, int panel1,string actionType) {
            if(panel ==0 ){panel=1;}
            ViewData["panel"]=panel;
            ViewData["Title"] = "MRP Data";
            DateTime? F1 = System.DateTime.Now;
            DateTime? F2 = System.DateTime.Now;
            if (ModelState.IsValid){
            try{
             F1 = model.CplanDateFrom;
             F2 = model.CplanDateTo;
            }
            catch{}
            }
            else {panel1=1;} //solo valida en panel 1
            ViewData["panel1"]=panel1;
            var dbContext = new MyErpDBContext();
            try{
                CreateVB_LCP();
                CreateVB_cMRP(F1,F2);  //ListCustPlan
             return View();
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
        }


        public IActionResult MRPcGo(DateTime? F1, DateTime? F2, string actionType) {
            if (F1==null){F1=System.DateTime.Now;}
            if (F2==null){F2=System.DateTime.Now;}
            CreateVB_cMRP(F1,F2);   //Carga ViewBag con el resultado del analisis de capacidad
            ViewData["panel"]=1;
            //return View();      
            return RedirectToAction("Index",new{panel=1,panel1=2});
        }

    }
}