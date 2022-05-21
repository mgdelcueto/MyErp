using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyErp.Controllers {
   [Authorize(Roles="Customer,Administrator")]
    public class TCustomerController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TCustomerController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void _loadCustomerViewBag( int? Pid,int? plant ,int? cust=0)
        {
                        var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];


            var resulp = from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
                        where p.CplantCustId==Pid
                        select new {p.CplantId ,p.CplantDeno};
            if (plant==0){
                try{
                    plant =resulp.ToList()[0].CplantId;
                }
                catch{plant =0;}
            }
            ViewBag.ddlPlantVB = new SelectList(resulp.ToList(), "CplantId", "CplantDeno",plant); 

            ViewData["Plant"]=plant;

            var queryplan = (from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
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

            var querytruc = (from p in _dbContext.TCTrucks 
                        where p.TruckCustId==cust && p.TruckPlantId==plant
                        orderby p.TruckDeno
                        select new TCTruck {TruckId=p.TruckId ,TruckDeno=p.TruckDeno}).ToList();
            var querytru0 = ( from p in _dbContext.TCCplants  
            select new TCTruck{TruckId=0,TruckDeno="Select a Truck"}).Distinct().ToList();
            var querytrucs = querytru0.Concat(querytruc);
            ViewBag.ddlCustoX = new SelectList(querycusts.ToList(), "TruckId", "TruckDeno",0); 


        }
        private void CreateViewBags(int? id, int? prod, int? plant,int? cust =0)
        {

            var resulp = from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
                        where p.CplantCustId==id
                        select new {p.CplantId ,p.CplantDeno};
            if (plant==0){
                try{
                    plant =resulp.ToList()[0].CplantId;
                }
                catch{plant =0;}
            }
            ViewBag.ddlPlantVB = new SelectList(resulp.ToList(), "CplantId", "CplantDeno",plant); 

            ViewData["Plant"]=plant;

            var queryplan = (from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
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

            var querytruc = (from p in _dbContext.TCTrucks 
                        where p.TruckCustId==cust //&& p.TruckPlantId==plant
                        orderby p.TruckDeno
                        select new TCTruck {TruckId=p.TruckId ,TruckDeno=p.TruckDeno}).ToList();
            var querytru0 = ( from p in _dbContext.TCTrucks  
            select new TCTruck{TruckId=0,TruckDeno="Select a Truck"}).Distinct().ToList();
            var querytrucs = querytru0.Concat(querytruc);
            ViewBag.ddlTruckX = new SelectList(querytrucs.ToList(), "TruckId", "TruckDeno",0); 


//se ha cambiado el diseño de modo que el producto no esta asignado a la planta
//solamante a nivel del pedido se asigna a la planta una referncia de producto de un cliente
//que puede estar asignado a varias plantas del mismo cliente
            var resulpo = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant &&or.CpocprodId !=null
                            join mat in _dbContext.TMaterials
                            on or.CpocprodId equals mat.MatId
                            into Popro
                          from Pop in Popro.DefaultIfEmpty()
                        where (Pop.MatId!=0)
                        orderby Pop.MatDescr                        
                        select new {Pop.MatId ,Pop.MatDescr};

            var resuld = from p in _dbContext.TCCproducts 
                        join mat in _dbContext.TMaterials
                        on p.CprodMatInt equals mat.MatId
                        orderby mat.MatDescr
                        where p.CprodCustId==id //&&p.CprodCplantId==plant
                        select new {mat.MatId ,mat.MatDescr};
                        
            var result = from p in _dbContext.TCCproducts 
                        join mat in _dbContext.TMaterials
                        on p.CprodMatInt equals mat.MatId
                        orderby mat.MatRefer
                        where p.CprodCustId==id //&&p.CprodCplantId==plant
                        select new {mat.MatId ,mat.MatRefer};
                        
            var resulpo_pr = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant
                            join mat in _dbContext.TMaterials
                            on or.CpocprodId equals mat.MatId 
                            into Popro
                          from Pop in Popro.DefaultIfEmpty() 
                        where Pop.MatId==prod   
                        select new {Pop.MatId };        
            var resulpo_pl = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant
                            join mat in _dbContext.TMaterials
                            on or.CpocprodId equals mat.MatId 
                            into Popro
                          from Pop in Popro.DefaultIfEmpty() 
                        select new {Pop.MatId };                  
            var result_pr = from p in _dbContext.TCCproducts 
                            join mat in _dbContext.TMaterials
                            on p.CprodMatInt equals mat.MatId
                        orderby mat.MatRefer
                        where p.CprodCustId==id && mat.MatId==prod //&&p.CprodCplantId==plant 
                        select new {mat.MatId ,mat.MatRefer};
            try{
                prod =resulpo_pr.ToList()[0].MatId; //ddlrefer puede contnener una referencia que no corresponde con la planta de ddl plabnta que ha cambiado
            }
            catch{prod=0;}   
                                       //ponemos prod a cer y lo tratamoa a continuacion
            if (prod==0 || prod==null){                 //si prod es cero le signa una referencia de la planta en cuestion
                try{
                    prod =resulpo_pl.ToList()[0].MatId;
                }
                catch{prod =0;}
            }
            
            ViewBag.ddlReferVO = new SelectList(resulpo.ToList(), "MatId", "MatDescr",prod); 
            ViewBag.ddlReferVD = new SelectList(resuld.ToList(), "MatId", "MatDescr",prod); 
            ViewBag.ddlReferVB = new SelectList(result.ToList(), "MatId", "MatRefer",prod); 
            ViewData["cProd"]=prod;
            
            var querypa = from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
                        where p.CplantCustId==id
                        select p;
            var qListpa = querypa.ToList();
            ViewBag.ListPlant=qListpa;

            var queryca = from p in _dbContext.TCCproducts 
                        join r in _dbContext.TMaterials on p.CprodMatInt equals r.MatId
                        orderby p.CprodRefInt 
                        where p.CprodCustId==id //&&p.CprodCplantId==plant //&&p.CprodId==prod
                        select new TCCproduct {
                            CprodCplantId=p.CprodCplantId,
                            CprodCrDate=p.CprodCrDate,
                            CprodCustId=p.CprodCustId,
                            CprodDescInt=r.MatDescr,
                            CprodId=p.CprodId,
                            CprodMatInt=p.CprodMatInt,
                            CprodPoid=p.CprodPoid,
                            CprodRefInt=r.MatRefer,
                            CprodStatus=p.CprodStatus
                            };
            var qListca = queryca.ToList();
            ViewBag.ListProd=qListca;

            var queryran1 = (from p in _dbContext.TMaterials 
                        orderby p.MatRefer
                        where p.MatClass =="FG"
                        select new TMaterial{MatId=p.MatId,MatDescr=p.MatDescr} ).ToList();
            var queryran0 = ( from p in _dbContext.TMaterials  
            select new TMaterial{MatId=0,MatDescr="Select a Finish Good"}).Distinct().ToList();
            var queryrans = queryran0.Concat(queryran1);
            ViewBag.ddlMatCOM = new SelectList(queryrans.ToList(), "MatId", "MatDescr",0); 


/*
            var queryco = from plan in _dbContext.TCCplannings   
                        orderby plan.CplanCprodId ,plan.CplanDateFrom 
                        where plan.CplanCustId ==id &&
                        plan.CplanCplantId==plant &&
                        (plan.CplanCprodId==prod ||prod==null || prod==0)
                        select plan;
*/
            var queryco =from pl in _dbContext.TCCplannings join p in _dbContext.TMaterials on  
                            pl.CplanCprodId equals p.MatId
                            orderby pl.CplanCprodId ,pl.CplanDateFrom 
                        where pl.CplanCustId ==id &&
                        pl.CplanCplantId==plant &&
                        (pl.CplanCprodId==prod ||prod==null || prod==0)
                        select new VTCCplanning {CplanCplantId=pl.CplanCplantId,CplanCprodId=pl.CplanCprodId,
                        CplanCustId=pl.CplanCustId, CplanDateFrom=pl.CplanDateFrom,
                        CplanDateTo=pl.CplanDateTo,CplanFirmSt=pl.CplanFirmSt,
                        CplanId=pl.CplanId,CplanQty=pl.CplanQty,CprodRefInt=p.MatRefer,
                        CprodDescInt=p.MatDescr};

            var qListco = queryco.ToList();
            ViewBag.ListPlan=qListco;




            var querypo_0 =(from po in _dbContext.TCPorders
                            join pro in _dbContext.TCCproducts  on 
                            new{ prod=po.CpocprodId, cust=po.CpocustId} equals 
                            new {prod =pro.CprodMatInt,cust=pro.CprodCustId}
                            //new{ prod=po.CpocprodId, cust=po.CpocustId,plan=po.CpocplantId} equals 
                            //new {prod =pro.CprodMatInt,cust=pro.CprodCustId, plan=pro.CprodCplantId}
                            join mat in _dbContext.TMaterials on pro.CprodMatInt equals mat.MatId 
                        orderby po.Cpopo
                        where po.CpocustId==id && po.CpocplantId==plant
                        select new VTCPorder {Cpoid=po.Cpoid,CpocustId=po.CpocustId,Cpopo=po.Cpopo,CporeferEx=po.CporeferEx,
                                    CprodRefInt=mat.MatRefer,CpodescEx=po.CpodescEx,CprodDescInt=mat.MatDescr,
                                    Cpoprice=po.Cpoprice,Cpocurcy=po.Cpocurcy}).ToList();
            var querypo_1=(from po in _dbContext.TCPorders 
                        where  po.CpocustId==id && po.CpocplantId==plant &&
                                    (po.CpocprodId==null ||po.CpocprodId ==0) 
                        select new VTCPorder {Cpoid=po.Cpoid,CpocustId=po.CpocustId,Cpopo=po.Cpopo,CporeferEx=po.CporeferEx,
                                    CprodRefInt="NE",CpodescEx=po.CpodescEx,CprodDescInt="NE",
                                    Cpoprice=po.Cpoprice,Cpocurcy=po.Cpocurcy}).ToList();
            var querypo = querypo_0.Concat(querypo_1);
//            querypo = querypo_0;
/*
            var querypo = from un in  (from po in _dbContext.TCPorders select po).Union 
                              (from pon in _dbContext.TCPorders where pon.Cpoid ==null || pon.Cpoid==0 select pon)
                            join pro in _dbContext.TCCproducts  
                            on un.CpocprodId equals pro.CprodId                             
                        orderby un.Cpopo
                        where un.CpocustId==id && un.CpocplantId==plant
                        select new VTCPorder {Cpoid=un.Cpoid,CpocustId=un.CpocustId,Cpopo=un.Cpopo,CporeferEx=un.CporeferEx,
                                    CprodRefInt=pro.CprodRefInt,CpodescEx=un.CpodescEx,CprodDescInt=pro.CprodDescInt,
                                    Cpoprice=un.Cpoprice,Cpocurcy=un.Cpocurcy};
*/
/*
            var querypo = from po in _dbContext.TCPorders   
                        orderby po.Cpopo 
                        where po.CpocustId ==id &&
                        po.CpocplantId==plant
                        select po;
*/
            var qListpo = querypo.ToList();
            ViewBag.ListPO=qListpo;

            var queryc = (from p in _dbContext.TCustomers 
                        where p.CustId==id
                        select p).SingleOrDefault();
            ViewBag.Customer=queryc;

/*
           try{
            var mode = _dbContext.TCCproducts
                .SingleOrDefault(u => u.CprodId.Equals(prod));
            ViewData["Prod"]=mode.CprodRefInt;
            ViewData["cProd"]=prod;}
            catch{ViewData["Prod"]="No Filter <<<";
            ViewData["cProd"]=0;}

           try{
            var mode = _dbContext.TCCproducts
                .SingleOrDefault(u => u.CprodId.Equals(prod));
            ViewData["Prod"]=mode.CprodRefInt;
            ViewData["cProd"]=prod;}
            catch{ViewData["Prod"]="No Filter <<<";
            ViewData["cProd"]=0;}
*/
        }

        public IActionResult Index(int filter,string pNam, string pNam1,string actionType) {
            if (actionType=="Cancel"){filter=0;}
            ViewData["Title"] = "All Items";
            ViewData["Filter"]=filter;
            ViewData["Fil1"]=pNam;
            ViewData["Fil2"]=pNam1;
            var dbContext = new MyErpDBContext();
            try{
             var model = _dbContext.TCustomers.OrderBy(p => p.CustRasoc).ToList();
             if (filter ==2){
                var queryc = from p in _dbContext.TCustomers 
                        where (p.CustRasoc.Contains(pNam) || pNam ==null ) && (p.CustNif.Contains(pNam1) ||pNam1==null)
                        orderby p.CustRasoc, p.CustNif
                        select p;
                var qList=queryc.ToList();
                model = qList;
             }
             return View(model);
            }
            catch{return View("Error");}
            
        }

        [HttpGet]
        public IActionResult Create() {
            ViewData["panel"]=1;
            return View();      
        }

        [HttpPost]
        public IActionResult Create(TCustomer Customer, string actionType) {
            ViewData["panel"]=1;            
            if(actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TCustomers.Add(Customer); 
                _dbContext.SaveChanges();
                }
            catch{}
            }
            else{
                //CreateViewBags(Customer.CustId,0,0);    
                return View(Customer);
            }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ProCreate(int Pid, int? plant, string actionType) {
            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
            CreateViewBags(Pid,0,plant);

             var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=2;

            return View();      
        }

        [HttpPost]
        public IActionResult ProCreate(TCCproduct product,int Pid, int plant ,  string actionType) {
            ViewData["panel"]=2;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TCCproducts.Add(product); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                //loadCustomerViewBag(Pid,product.CprodCplantId);
                CreateViewBags(Pid,0,product.CprodCplantId);    
                return View(product);
                }
            }
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            CreateViewBags(Pid,0,product.CprodCplantId);    
            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=2;

            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,plant=product.CprodCplantId});

            //return View("Edit",model);
        }

        [HttpGet]
        public IActionResult PlantCreate(int Pid) {
            var queryc = (from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p).FirstOrDefault();
            ViewBag.Customer=queryc;
            CreateViewBags(Pid,0,0,Pid);  //Carag ddlTruck para el cliente indicado
             var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=3;
            return View();      
        }

        [HttpPost]
        public IActionResult PlantCreate(TCCplant plant,int Pid, string actionType) {
            if(actionType=="Add"){
                if (ModelState.IsValid){
                try{
                    _dbContext.TCCplants.Add(plant); 
                    _dbContext.SaveChanges();
                }
                catch{return View("Error");}
                }
                else{
                     CreateViewBags(Pid,0,plant.CplantId,Pid);
                     return View(plant);
                }
            }
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            CreateViewBags(Pid,0,plant.CplantId,Pid);    
            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=0,plant =plant.CplantId});
        }

        [HttpGet]
        public IActionResult PlanCreate(int Pid, int prod,int plant, string actionType) {
            var queryc = (from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p).SingleOrDefault();
            ViewBag.Customer=queryc;
            CreateViewBags(Pid,prod,plant,Pid);

            var query = (from p in _dbContext.TCCplants 
            where p.CplantId==plant
            select p).FirstOrDefault();
            ViewData["truck"]=query.CplantTruckId;

            TCCplanning model = (TCCplanning) (from p in _dbContext.TCCplannings 
                        where p.CplanCustId==Pid && p.CplanCplantId==plant
                        select p).FirstOrDefault();
            try{
                model.CplanCprodId=prod;
                model.CplanDateFrom=System.DateTime.Now;
                model.CplanDateTo=System.DateTime.Now;
                model.CplanFirmSt="";
                model.CplanQty=0;
            }
            catch{
                model = new TCCplanning();
                model.CplanCplantId=plant;
                model.CplanCustId=Pid;
            }
             var cmodel = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = cmodel.CustRasoc+" " +cmodel.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=4;
            return View(model);      
        }

        [HttpPost]
        public IActionResult PlanCreate(TCCplanning planning,int Pid, int prod,int? plant, string actionType,int? CplantId,int? CprodId,int? CPlanTruckId) {
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=4;
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                if (planning.CplanCprodId==null||planning.CplanCprodId==0)
                {planning.CplanCprodId=CprodId;}
                _dbContext.TCCplannings.Add(planning); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else {
                //loadCustomerViewBag(Pid,product.CprodCplantId);
                CreateViewBags(Pid,0,planning.CplanCplantId);    
                return View(planning);
                }
            }
            if (actionType=="Cancel"||actionType=="Add"){
             CreateViewBags(Pid,planning.CplanCprodId,planning.CplanCplantId);
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=planning.CplanCprodId,plant =planning.CplanCplantId});
            }
            else{
                planning.CplanCplantId=CplantId;
                planning.CplanCprodId=CprodId;
                 CreateViewBags(Pid,planning.CplanCprodId,planning.CplanCplantId);
                return View(planning);                
            }
        }

        [HttpGet]
        public IActionResult PoCreate(int Pid, int prod,int plant, string actionType) {
            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
            CreateViewBags(Pid,prod,plant);

             var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=5;
            return View();      
        }

        [HttpPost]
        public IActionResult PoCreate(TCPorder porder,int Pid, int prod,int? plant, string actionType) {
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            if (actionType=="Add"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TCPorders.Add(porder); 
                        _dbContext.SaveChanges();
                    }
                    catch{return View("Error");}
                }
            else {
                 //loadCustomerViewBag(Pid,porder.CpocplantId);
                 CreateViewBags(Pid,porder.CpocprodId,porder.CpocplantId);
                 return View(porder);
                }
            }
             CreateViewBags(Pid,porder.CpocprodId,porder.CpocplantId);
            ViewData["panel"]=5;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=5,move=0,prod=0,plant =porder.CpocplantId});
            //(int id, int panel, int move,int? prod
        }

        public IActionResult Delete(int id) {
            ViewData["CusId"]=id;
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
            try{
            _dbContext.TCustomers.Remove(model);
            _dbContext.SaveChanges();
            }  
            catch{}          
            return RedirectToAction("Index");
        }
        public IActionResult ProDelete(int id,int? Pid) {
            var mode = _dbContext.TCCproducts
                .SingleOrDefault(u => u.CprodId.Equals(id));
            try{
            Pid=mode.CprodCustId;
            _dbContext.TCCproducts.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,0);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=4;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0});

            //return RedirectToAction("Edit");
        }


        public IActionResult PlantDelete(int id,int Pid) {
            var mode = _dbContext.TCCplants
                .SingleOrDefault(u => u.CplantId.Equals(id));
            try{
            _dbContext.TCCplants.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,0);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=3;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PlanDelete(int id,int Pid) {
            var mode = _dbContext.TCCplannings
                .SingleOrDefault(u => u.CplanId.Equals(id));
            int? plan = mode.CplanCplantId;
            int? pro =mode.CplanCprodId;
            try{
            _dbContext.TCCplannings.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}    

            CreateViewBags(Pid,pro,plan);                

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,0);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=4;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=pro,plant=plan});

            //return RedirectToAction("Edit");
        }


        public IActionResult PoDelete(int id,int Pid) {
            var mode = _dbContext.TCPorders
                .SingleOrDefault(u => u.Cpoid.Equals(id));
            int? plan = mode.CpocplantId;
            int? pro =mode.CpocprodId;
            try{
            _dbContext.TCPorders.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}    

            CreateViewBags(Pid,pro,plan);                

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,0);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;
            ViewData["panel"]=5;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=5,move=0,prod=pro,plant=plan});

            //return RedirectToAction("Edit");
        }


        [HttpGet]
        public IActionResult ProEdit(int id,int cuid) {
            try{
            var model = _dbContext.TCCproducts
                .SingleOrDefault(u => u.CprodId.Equals(id));
            int?Pid=model.CprodCustId;

            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
            CreateViewBags(Pid,id,model.CprodCplantId);  

            var pmodel = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = pmodel.CustRasoc+" " +pmodel.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=2;

            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult ProEdit(TCCproduct product,int id ,string actionType) {
            int? Pid=product.CprodCustId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TCCproducts.Update(product);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                 //loadCustomerViewBag(Pid,product.CprodCplantId);
                 CreateViewBags(Pid,product.CprodId,product.CprodCplantId);                
                 return View(product);
                }
            }
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,product.CprodId,product.CprodCplantId);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=2;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,prod=product.CprodId,plant=product.CprodCplantId});

            //return RedirectToAction("Index");
        } 

        [HttpGet]
        public IActionResult PlantEdit(int id,int cuid) {
            try{
            var model = _dbContext.TCCplants
                .SingleOrDefault(u => u.CplantId.Equals(id));
            int?Pid=model.CplantCustId;

            var queryc = (from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p).SingleOrDefault();
            ViewBag.Customer=queryc;
            CreateViewBags(Pid,0,id,Pid);                

            var pmodel = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = pmodel.CustRasoc+" " +pmodel.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=3;

            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public  IActionResult PlantEdit(TCCplant planta, int id, string actionType) {
            int? Pid=planta.CplantCustId;
            if (actionType=="Update"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TCCplants.Update(planta);
                        _dbContext.SaveChanges();
                    }
                    catch{}
                }
                else{
                     //loadCustomerViewBag(Pid,porder.CpocplantId);
                     CreateViewBags(Pid,0,planta.CplantId);    
                     return View(planta);
                }
            }
            else
            {
                if (actionType=="Cancel"){}
                else{
                    CreateViewBags(Pid,0,planta.CplantId);    
                     return View(planta);
                }
            }
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,planta.CplantId);                

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;


            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=0,plant=planta.CplantId});
        } 

        [HttpGet]
        public IActionResult PlanEdit(int id,int cuid) {
            try{
            var model = _dbContext.TCCplannings
                .SingleOrDefault(u => u.CplanId.Equals(id));
            int?Pid=model.CplanCustId;

            CreateViewBags(Pid,model.CplanCprodId,model.CplanCplantId);    

            var pmodel = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = pmodel.CustRasoc+" " +pmodel.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=4;

            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PlanEdit(TCCplanning planning, string actionType,int? CplantId, int? CprodId) {
            int? Pid=planning.CplanCustId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                planning.CplanCplantId=CplantId;
                planning.CplanCprodId=CprodId;
                _dbContext.TCCplannings.Update(planning);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                 //loadCustomerViewBag(Pid,porder.CpocplantId);
                 CreateViewBags(Pid,planning.CplanCprodId,planning.CplanCplantId);    
                 return View(planning);
            }
            }

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=4;
            if (actionType=="Cancel"||actionType=="Update"){
             CreateViewBags(Pid,planning.CplanCprodId,planning.CplanCplantId);
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=planning.CplanCprodId,plant =planning.CplanCplantId});
            }
            else{
                planning.CplanCplantId=CplantId;
                planning.CplanCprodId=CprodId;
                 CreateViewBags(Pid,planning.CplanCprodId,planning.CplanCplantId);
                return View(planning);                
            }
        }     

        [HttpGet]
        public IActionResult PoEdit(int id,int cuid) {
            try{
            var model = _dbContext.TCPorders
                .SingleOrDefault(u => u.Cpoid.Equals(id));
            int?Pid=model.CpocustId;

            CreateViewBags(Pid,model.CpocprodId,model.CpocplantId);    

            var pmodel = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = pmodel.CustRasoc+" " +pmodel.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;

            ViewData["panel"]=5;


            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PoEdit(TCPorder porder, string actionType) {
            int? Pid=porder.CpocustId;
            if (actionType=="Update"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TCPorders.Update(porder);
                        _dbContext.SaveChanges();
                 }
                    catch{}
                    }
            else {
                 CreateViewBags(Pid,porder.CpocprodId,porder.CpocplantId);    
                 return View(porder);
            }
            }
            CreateViewBags(Pid,porder.CpocprodId,porder.CpocplantId);    

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=Pid;


            ViewData["panel"]=5;
            return RedirectToAction("Edit",new{id=Pid,panel=5,move=0,prod=porder.CpocprodId,plant=porder.CpocplantId});
        }     

        [HttpGet]
        public IActionResult Prev(int id, int panel, int move,int? prod,int? plant,string actionType) {
            if(prod==null){prod=0;}
            if(plant==null){plant=0;}
            ViewData["panel"]=panel;
            try{

            var mode = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
            string cName = mode.CustRasoc+mode.CustNif;

            var query = from p in _dbContext.TCustomers 
                        orderby p.CustRasoc+p.CustNif descending
                        where string.Compare(cName,p.CustRasoc+p.CustNif)==1
                        select p;
            var qList = query.ToList();
            int pId = id ;
            try{
                pId=qList[0].CustId;
            }
            catch{}
            id=pId;
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
            CreateViewBags(id,prod,plant);

            return RedirectToAction("Edit",new{id=id,panel=panel,move=0,prod=prod,plant=plant});

//          return View("Edit",model);
            }
        catch{return View("Error");}   
        }
        [HttpGet]
        public IActionResult Next(int id, int panel, int move,int? prod,int? plant,string actionType) {
            if(prod==null){prod=0;}
            if(plant==null){plant=0;}
            ViewData["panel"]=panel;
            try{

            var mode = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
            string cName = mode.CustRasoc+mode.CustNif;

            var query = from p in _dbContext.TCustomers 
                        orderby p.CustRasoc+p.CustNif
                        where string.Compare(p.CustRasoc+p.CustNif,cName)==1
                        select p;
            var qList = query.ToList();
            int nId = id ;
            try{
                nId=qList[0].CustId;
            }
            catch{}
            id =nId;
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
           CreateViewBags(id,prod,plant);
           return RedirectToAction("Edit",new{id=id,panel=panel,move=0,prod=prod,plant=plant});

            //return View("Edit",model);
        }
        catch{return View("Error");}   
        }


        [HttpGet]
        public IActionResult Edit(int id, int panel, int move,int? prod,int? plant,string actionType) {
            if(prod==null){prod=0;} 
            if(plant==null){plant=0;}
            if (panel==0){panel=1;}
            ViewData["panel"]=panel;
            try{

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=id;


            CreateViewBags(id,prod,plant);
            return View("Edit",model);
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                return View("Error");}    
        }    
        [HttpPost]
        public IActionResult Edit(TCustomer Customer, int id, int panel,int move,int? CprodId, int? CplantId,string actionType) {
            if (actionType=="Add"||actionType=="Update"){
            if (ModelState.IsValid){
            try{               
                _dbContext.TCustomers.Update(Customer);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                 ViewData["panel"]=1;
                 CreateViewBags(id,CprodId,CplantId);    
                 return View(Customer);
            }
            }
            if (id==0){try{id=Customer.CustId; }catch{}}
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));

            string cName = model.CustRasoc+" " +model.CustNif;
            ViewData["cName"]=cName;
            ViewData["CusId"]=id;


            ViewData["panel"]=panel;
            CreateViewBags(model.CustId,CprodId,CplantId);
            return View("Edit",model);
            //return RedirectToAction("Index");
        }        
 
    }
}