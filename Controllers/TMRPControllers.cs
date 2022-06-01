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
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace MyErp.Controllers {
    [Authorize(Roles="Planner,Administrator")]
    public class TMRPController : Controller {
        private IConfiguration Configuration;
        private readonly MyErpDBContext _dbContext;
        public TMRPController(MyErpDBContext dbContext,IConfiguration _configuration) {
            _dbContext = dbContext;
            Configuration = _configuration;            
        }
    private void CreateViewBags(int ver=0)
    {
        //CreateVB_LCP();
        //CreateVB_cMRP();
            var queryshu =(from po in _dbContext.TCScShops
                        orderby po.ShopFrom,po.ShopVersion,po.ShopComent
                        select new VCScShop{
                            ShopFrom=po.ShopFrom,
                            ShopVersion=po.ShopVersion,
                            ShopComent=po.ShopComent}
                        ).Distinct().ToList();
            ViewBag.uListScShop=queryshu;        
            var querysh =(from po in _dbContext.TCScShops
                        join t in _dbContext.TMaterials on po.ShopCprodId equals t.MatId into jt
                        from jtResult in jt.DefaultIfEmpty()

                        join d in _dbContext.TMaterials on po.ShopDest equals d.MatId into jd
                        from jdResult in jd.DefaultIfEmpty()
                        
                        join w in _dbContext.TWorkCenters on po.ShopWctr equals w.WcdId into jw
                        from jwResult in jw.DefaultIfEmpty()
                        
                        join tr in _dbContext.TCTrucks on po.ShopDest equals tr.TruckId into jtr
                        from jtrResult in jtr.DefaultIfEmpty()
                        
                        where po.ShopVersion==ver
                        orderby po.ShopWctr,po.ShopDate descending //, po.ShopCProdId
                        select new ViScShop {
                            ShopFg=po.ShopFg,
                            ShopDate=po.ShopDate,
                            ShopQty=po.ShopQty,
                            ShopTunit=po.ShopTunit,
                            ShopaTunit=po.ShopaTunit,
                            ShopMinLot=po.ShopMinLot,
                            ShopUemb=po.ShopUemb,
                            ShopMDescr=jtResult.MatDescr,
                            ShopDDescr=jdResult.MatDescr,
                            ShopWDescr=jwResult.Wcdescr,
                            ShopTrDeno=jtrResult.TruckDeno}
                        ).ToList();
            ViewBag.ListScShop=querysh; 
    }
        private void CreateVB_cMRP(DateTime? F1, DateTime? F2,bool accStock,int? wcent){
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
                if (accStock){//Tiene en cuenta los stocks de los materiales en este momento
                    _dbContext.Database.ExecuteSqlRaw("Xi_ExplosionS {0},{1},{2}", table,pF1,pF2);
                }
                else {//no tiene en cuenta los stcoks de los materiales
                    _dbContext.Database.ExecuteSqlRaw("Xi_Explosion {0},{1},{2}", table,pF1,pF2);
                }
                var sqlo = "SELECT * FROM [Operx_"+Table+"] ORDER BY WCDescr";
                var sqlm = "SELECT * FROM [Matex_"+Table+"] ORDER BY MatDescr";
                var sqlw = "SELECT * FROM [Operw_"+Table+"] WHERE RouWCId = "+wcent.ToString()+" ORDER BY MatRefer,RouFase";
                var explosiop = _dbContext.TExpOpers.FromSqlRaw(sqlo).ToList();
                var explosiom = _dbContext.TExpMaters.FromSqlRaw(sqlm).ToList();
                var explosiow = _dbContext.TExpOperds.FromSqlRaw(sqlw).ToList();
                _dbContext.Database.ExecuteSqlRaw("Xz_Explosion {0}", table);
                ViewBag.ListMatExp=explosiom; //querybo;
                ViewBag.ListOpeExp=explosiop; //querybo;
                ViewBag.ListOpeDet=explosiow; //querybo;
                 
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
        public IActionResult Index(int panel,int panel1,string actionType) {
            ViewData["panel"]=panel;
            ViewData["panel1"]=panel1;
            ViewData["Title"] = "MRP Data";
            switch (panel){
                case 1:
                    return RedirectToAction("Capacity",new{F1=System.DateTime.Now,F2=System.DateTime.Now,panel=1,panel1=1});
                    break;
                default:
                    return View();
                    break;
            }
        }

        public IActionResult CapDetwc(int? id,string F1,string F2, string accStock) {
            F1 = F1.Replace("\"", "");
            F2 = F2.Replace("\"", "");
            accStock = accStock.Replace("\"", "");

            DateTime? _F1 = System.DateTime.Now;
            DateTime? _F2 = System.DateTime.Now;
            bool _accStock=false;
            try{
                if (F1!=null){ _F1 = Convert.ToDateTime(F1);}
                if (F2!=null){ _F2 = Convert.ToDateTime(F2);}
                if (accStock!=null) {_accStock=Convert.ToBoolean(accStock);}
            }
            catch{}
            ViewData["panel"]=4;
            ViewData["panel1"]=1;
            ViewData["Title"] = "MRP Detal WC Data";
            ViewData["F1"]=_F1;
            ViewData["F2"]=_F2;
            ViewData["ACSt"]=_accStock;
            /*
            var xdbContext = new MyErpDBContext();
            var model = xdbContext.TWorkCenters
                .SingleOrDefault(u => u.wcid.Equals(id));
            */
            int ? wcent=id;
            CreateVB_cMRP(_F1, _F2,_accStock, wcent);
            return RedirectToAction("Capacity",new{wcent=id, F1=_F1,F2=_F2,accStock=_accStock,panel=4,panel1=1});
        }


        [HttpGet]
        public IActionResult ScView(DateTime datp, int ver, int panel,int panel1, string actionType) {
            if(panel ==0 ){panel=2;}
            ViewData["panel"]=panel;
            ViewData["panel1"]=panel1;
            ViewData["Title"] = "MRP Data";
            var dbContext = new MyErpDBContext();
            try{
                CreateViewBags(ver);
             return View();
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }
        [HttpGet]
        public IActionResult ScTrView(DateTime datp, int ver, int panel,int panel1, string actionType) {
            if(panel ==0 ){panel=2;}
            ViewData["panel"]=panel;
            ViewData["panel1"]=panel1;
            ViewData["Title"] = "MRP Data";
            var dbContext = new MyErpDBContext();
            try{

                Guid g = Guid.NewGuid();
                string Table = g.ToString();

                var pVer = new SqlParameter("@p0", ver);
                var table = new SqlParameter("@p2", Table);

                _dbContext.Database.ExecuteSqlRaw("[Xs_Explosion_End] {0},{1}", pVer,table);

            //esta tabla (Table) ha sido creada como resyltado de la quere Xs_Explosion
            //que se ejecuto en PlanCreate [Post]
            //Ahora la cargamos en ViewBag
                var sqlo = "SELECT * FROM ["+Table+"] ";
                //var explosiop = _dbContext.Database.ExecuteSqlRaw(sqlo).ToList();
                string constr = Configuration.GetConnectionString("MyProjectConnectionString");
                DataTable dt = new DataTable(); //used to store the store procedure result.
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ["+Table+"] WHERE nRow IN (2,5,9,10,11,12,13,17) ", con))
                {
                    con.Open();
                   
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter ada = new SqlDataAdapter();
                    ada.SelectCommand = cmd;
                    ada.Fill(dt);
                    _dbContext.Database.ExecuteSqlRaw("[Xz_Explosion] {0}", table);
                     return View(dt);
                }
            }

            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }

        [HttpGet]
        public IActionResult MRP(DateTime datp, int ver, int panel,int panel1, string actionType) {
            if(panel ==0 ){panel=2;}
            ViewData["panel"]=panel;
            ViewData["panel"]=panel1;
            ViewData["Title"] = "MRP Data";

            var dbContext = new MyErpDBContext();
            try{
                CreateViewBags();
             return View();
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }


        [HttpGet]
        public IActionResult Capacity(int ? wcent, DateTime? F1, DateTime? F2,bool accStock, int panel, int panel1,string actionType) {
            if(wcent==null){wcent=0;}
            if(panel ==0 ){panel=1;}
            ViewData["panel"]=panel;
            ViewData["panel1"]=panel1;
            if (F1==null){F1=System.DateTime.Now;}
            if (F2==null){F2=System.DateTime.Now;}
        
            //////var dbContext = new MyErpDBContext();
             ViewData["F1"]=F1;
             ViewData["F2"]=F2;
             ViewData["ACSt"]=accStock;
            try{
                    CreateVB_LCP();
                    CreateVB_cMRP(F1,F2,accStock,wcent);  //ListCustPlan

            //List<VCCplanning> _mode = (List<VCCplanning>)ViewBag.ListCustPlan;
            //var model = _mode[0];
            VCXplanning model = new VCXplanning{
                CplanDateFrom=F1,
                CplanDateTo=F2
            };
            //model.CplanDateFrom=F1;
            //model.CplanDateTo=F2;
             return View(model);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }

        [HttpPost]
        public IActionResult Capacity(VCXplanning model,int panel, int panel1,string actionType) {
            if(panel ==0 ){panel=1;}
            ViewData["panel"]=panel;
            ViewData["Title"] = "MRP Data";

            DateTime? F1 = System.DateTime.Now;
            DateTime? F2 = System.DateTime.Now;
            bool accStock=false;
            if (ModelState.IsValid){
            try{
             F1 = model.CplanDateFrom;
             F2 = model.CplanDateTo;
             accStock=model.CPlancStock;
             ViewData["F1"]=F1;
             ViewData["F2"]=F2;
             ViewData["ACSt"]=accStock;
            }
            catch{}
            }
            else {panel1=1;} //solo valida en panel 1
            ViewData["panel1"]=panel1;
            ////var dbContext = new MyErpDBContext();
            try{
                CreateVB_LCP();
                CreateVB_cMRP(F1,F2,accStock,0);  //ListCustPlan
                return View(model);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
        }


        public IActionResult MRPcGo(DateTime? F1, DateTime? F2, string actionType) {
            if (F1==null){F1=System.DateTime.Now;}
            if (F2==null){F2=System.DateTime.Now;}
            CreateVB_cMRP(F1,F2,false,0);   //Carga ViewBag con el resultado del analisis de capacidad
            ViewData["panel"]=1;
            //return View();      
            return RedirectToAction("Index",new{panel=1,panel1=2});
        }

        [HttpGet]
        
        public IActionResult PlanCreate(string actionType) {
            ViewData["panel"]=2;
            return View();
        }

        [HttpPost]
        public IActionResult PlanCreate(VCScShop model, string actionType) {
            ViewData["panel"]=2;
            /*
                declare @ff datetime
                declare @ver int
                declare @com nvarchar(255)
                set @ff = convert (datetime, '2021-03-02',126)
                set @ver =3;
                set @com = 'Initial Planning Mars 3'
                exec Xs_Explosion_Start @ff,@ver,@com

            */
                DateTime? F1 = model.ShopFrom;
                string com = model.ShopComent;

                Guid g = Guid.NewGuid();
                string Table = g.ToString();

                var pF1 = new SqlParameter("@p0", F1);
                var Com = new SqlParameter("@p1", com);
                var table = new SqlParameter("@p2", Table);

                _dbContext.Database.ExecuteSqlRaw("Xs_Explosion_Start {0},{1},{2}", pF1,Com,table);
                /*
                var sqlo = "SELECT * FROM ["+Table+"] ";
                var explosiop = _dbContext.TExpOpers.FromSqlRaw(sqlo).ToList();
                ViewBag.ListOpeExp=explosiop; //querybo;
                */

                return RedirectToAction("MRP",new{panel=2,panel1=2});   
        }
        public IActionResult PlanDelete(int ver) {
            var pVer = new SqlParameter("@p0", ver);
            _dbContext.Database.ExecuteSqlRaw("Xs_Explosion_Stop {0}", pVer);
            CreateViewBags();                
            ViewData["panel"]=2;
            return RedirectToAction("MRP",new{panel=2,panel1=2});   
        }        

    }
}