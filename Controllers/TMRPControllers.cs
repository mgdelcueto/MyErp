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
using System.Web;

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

        private void CreateVB_cMRP(DateTime? F1, DateTime? F2,bool accStock,int? wcent=0,int? material=0){
            if (wcent==null){wcent=0;}
            if (material==null){material=0;}
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
                //var sqlm = "SELECT * FROM [Matex_"+Table+"] ORDER BY MatDescr";
                var sqlm = "SELECT ExpComp,TComQty,MatRefer,MatDescr,MatUnMed,TCom  FROM [Matex_"+Table+"] as m left join (select SPOCProdId, sum(SpoPcRep) as TCom  from T_S_POrder where SPOStatus =1 group by SPOCProdId) as p on m.ExpComp = p.SPOCProdId ORDER BY MatDescr";
                var sqlw = "SELECT * FROM [Operw_"+Table+"] WHERE RouWCId = "+wcent.ToString()+" ORDER BY MatRefer,RouFase";
                //var sqlx ="select expcomp,MatRefer,MatDescr, TComQty,MatUnMed,case when SpoId is null then 0 else spoid end as SpoId,case when SPoSupId is null then 0 else SPOSupId end as SPoSupId,case when SPOReferEx is null then 0 else  SPOReferEx end as SPoReferEx , case when SPOPO is null then 'No_PO' else SPOPO end as SPOPO ,case when SPOPrice is null then 0 else SPOPrice end as SPoPrice ,case when SPoCurcy is null then 'No_Curr' else SpoCurcy end as SPoCurcy ,case when SPoPcRep is null then 0 else SPoPcRep end as SPoPcRep ,case when SupId is null then 0 else SupId end as SupId,case when SupRaSoc is null then 'No_Suplier' else SupRaSoc end as SupRaSoc from [Matex_"+Table+"] as m left join (select * from T_S_POrder where SPOStatus =1) as po on m.expcomp = po.spocprodid left join T_Suplier as s on po.SPOSupId = s.SupId  where expcomp ="+material.ToString();
                var sqlx ="select expcomp,MatRefer,MatDescr, TComQty,MatUnMed,case when SpoId is null then 0 else spoid end as SpoId,case when SPoSupId is null then 0 else SPOSupId end as SPoSupId,case when SPOReferEx is null then 0 else  SPOReferEx end as SPoReferEx , case when SPOPO is null then 'No_PO' else SPOPO end as SPOPO ,case when SPOPrice is null then 0 else SPOPrice end as SPoPrice ,case when SPoCurcy is null then 'No_Curr' else SpoCurcy end as SPoCurcy ,case when SPoPcRep is null then 0 else SPoPcRep end as SPoPcRep ,case when SupId is null then 0 else SupId end as SupId,case when SupRaSoc is null then 'No_Suplier' else SupRaSoc end as SupRaSoc ,case when SPoPcRep is null then 0 else SPoPcRep*TComQty end as SPoPcRequ from [Matex_"+Table+"]  as m left join (select * from T_S_POrder where SPOStatus =1) as po on m.expcomp = po.spocprodid left join T_Suplier as s on po.SPOSupId = s.SupId  where expcomp ="+material.ToString();                
                var sqlt ="select expcomp,MatRefer,MatDescr, TComQty,MatUnMed,case when SpoId is null then 0 else spoid end as SpoId,case when SPoSupId is null then 0 else SPOSupId end as SPoSupId,case when SPOReferEx is null then 0 else  SPOReferEx end as SPoReferEx , case when SPOPO is null then 'No_PO' else SPOPO end as SPOPO ,case when SPOPrice is null then 0 else SPOPrice end as SPoPrice ,case when SPoCurcy is null then 'No_Curr' else SpoCurcy end as SPoCurcy ,case when SPoPcRep is null then 0 else SPoPcRep end as SPoPcRep ,case when SupId is null then 0 else SupId end as SupId,case when SupRaSoc is null then 'No_Suplier' else SupRaSoc end as SupRaSoc ,case when SPoPcRep is null then 0 else SPoPcRep*TComQty end as SPoPcRequ from [Matex_"+Table+"]  as m left join (select * from T_S_POrder where SPOStatus =1) as po on m.expcomp = po.spocprodid left join T_Suplier as s on po.SPOSupId = s.SupId ";                
                var explosiop = _dbContext.TExpOpers.FromSqlRaw(sqlo).ToList();
                var explosiom = _dbContext.TExpMaters.FromSqlRaw(sqlm).ToList();
                var explosiow = _dbContext.TExpOperds.FromSqlRaw(sqlw).ToList();
                var explosiox = _dbContext.TExpMatds.FromSqlRaw(sqlx).ToList();
                var explosiot = _dbContext.TExpMatds.FromSqlRaw(sqlt).ToList();
                _dbContext.Database.ExecuteSqlRaw("Xz_Explosion {0}", table);
                ViewBag.ListMatExp=explosiom; //querybo;
                ViewBag.ListOpeExp=explosiop; //querybo;
                ViewBag.ListOpeDet=explosiow; //querybo;
                ViewBag.ListMatPO=explosiox;
                ViewBag.ListMatPOT=explosiot;
                 
        }
        private void CreateVB_LCP(DateTime? F1, DateTime? F2)
        {  
            var queryco =(from pl in _dbContext.TCCplannings 
            join t in _dbContext.TCCplants on new{C_customer =pl.CplanCustId,     C_plant = pl.CplanCplantId} equals 
                                              new{C_customer = t.CplantCustId,    C_plant =t.CplantId}
            join c in _dbContext.TCustomers on t.CplantCustId equals c.CustId
            join m in _dbContext.TMaterials on pl.CplanCprodId equals m.MatId
            where pl.CplanDateFrom>=F1 && pl.CplanDateTo<= F2
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

        public IActionResult CapDetma(int? id,string F1,string F2, string accStock,string _parqs) {
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
            int ? material=id;
            CreateVB_cMRP(_F1, _F2,_accStock, 0,material);
            return RedirectToAction("Capacity",new{material=id, F1=_F1,F2=_F2,accStock=_accStock,panel=5,panel1=1});
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
        public IActionResult Capacity(int ? wcent,int? material, DateTime? F1, DateTime? F2,bool accStock, int panel, int panel1,string actionType,string parqs) {
            //decodifica _parqs y carga todos los pares key value 
            /*
            try{
            var _parqs = HttpUtility.ParseQueryString(parqs);
            foreach (String s in _parqs.AllKeys)
                {
                    switch(s)
                    {
                        case "F1":
                            F1=Convert.ToDateTime(_parqs[s]);
                            break;
                        case "F2":
                            F2=Convert.ToDateTime(_parqs[s]);
                            break;
                        case "wcent":
                            wcent=Convert.ToInt32(_parqs[s]);
                            break;
                        case "material":
                            material=Convert.ToInt32(_parqs[s]);
                            break;
                        case "accStock":
                            accStock=Convert.ToBoolean(_parqs[s]);
                            break;
                        case "panel":
                            panel=Convert.ToInt32(_parqs[s]);
                            break;
                        case "panel1":
                            panel1=Convert.ToInt32(_parqs[s]);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception ex){
                string mensaje = ex.Message;
            }
            */
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
             ViewData["WCent"]=wcent;
             ViewData["MatPO"]=material;
            try{
                    CreateVB_LCP(F1,F2);
                    CreateVB_cMRP(F1,F2,accStock,wcent,material);  //ListCustPlan

            //List<VCCplanning> _mode = (List<VCCplanning>)ViewBag.ListCustPlan;
            //var model = _mode[0];
            VCXplanning model = new VCXplanning{
                CplanDateFrom=F1,
                CplanDateTo=F2,
                CPlancStock=accStock
            };
            //model.CplanDateFrom=F1;
            //model.CplanDateTo=F2;
             return View(model);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
            
        }
        private void  ValidateReqs(DateTime? F1,DateTime? F2,bool accStock)
        {
                //graba Planning data por proveedor,po, material, cantidad
                //actualiza material stock Location en transito con lo que lo 
                //tendra en cuenta en el proximo calculo MRP
                CreateVB_cMRP(F1,F2,accStock);  
                List<TExpMatd> mode_ = (List<TExpMatd>) ViewBag.ListMatPOT;
                foreach (TExpMatd rec in mode_)
                {
                    int ? _idmat= rec.expcomp;
                    double? qtyreq=rec.SPoPcRequ;
                    int? _idSup = rec.SupId;
                    int? _idPo=rec.SPoId;
                    //SpocprodId SporeferEx SposupId 
                    var qpo = (from po in _dbContext.TSPorders where po.SpocprodId == _idmat 
                                && po.SposupId==_idSup
                                select po.SporeferEx).ToList();
                    int? _IdRe = qpo[0];
                    try{
                        TSPlanning modpl = new TSPlanning();
                            modpl.PlanSupId=_idSup; 
                            modpl.PlanProdId=_IdRe;
                            modpl.PlanDateFrom=F1;
                            modpl.PlanDateTo=F2;
                            modpl.PlanQty=qtyreq;
                            modpl.PlanFirmSt="PLAN";
                        _dbContext.TSPlannings.Add(modpl); 
                        _dbContext.SaveChanges();
                    }
                    catch{}
                    try{
                        var query = (from ml in _dbContext.TMLocations
                            join lo in _dbContext.TLocations on ml.MLocLodId  equals lo.LocId
                            where lo.LocType=="TRAN" && ml.MLocMatId==_idmat
                            select ml.MLocId ).ToList();
                        int _locId=query[0];
                        var modlo = _dbContext.TMLocations
                            .SingleOrDefault(u => u.MLocId.Equals(_locId));
                            modlo.MLocStock+=qtyreq;
                        _dbContext.TMLocations.Update(modlo);
                        _dbContext.SaveChanges();
                    }
                    catch{}
                }
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
            if (actionType=="Validate"){
                //graba Planning data por proveedor,po, material, cantidad
                //actualiza material stock Location en transito con lo que lo 
                //tendra en cuenta en el proximo calculo MRP
                ValidateReqs(F1,F2,accStock);
            }
            try{
                CreateVB_LCP(F1,F2);
                CreateVB_cMRP(F1,F2,accStock);  //ListCustPlan
                return View(model);
            }
            catch(Exception Ex){
                string mensaje = Ex.Message;
                return View("Error");}
        }


        public IActionResult MRPcGo(DateTime? F1, DateTime? F2, string actionType) {
            if (F1==null){F1=System.DateTime.Now;}
            if (F2==null){F2=System.DateTime.Now;}
            CreateVB_cMRP(F1,F2,false);   //Carga ViewBag con el resultado del analisis de capacidad
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