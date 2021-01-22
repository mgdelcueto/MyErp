using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyErp.Controllers {
    public class TCustomerController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TCustomerController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void _loadCustomerViewBag( int? Pid,int? plant )
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

        }
        private void CreateViewBags(int? id, int? prod, int? plant)
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

            var querypa = from p in _dbContext.TCCplants 
                        orderby p.CplantDeno
                        where p.CplantCustId==id
                        select p;
            var qListpa = querypa.ToList();
            ViewBag.ListPlant=qListpa;

//se ha cambiado el diseño de modo que el producto no esta asignado a la planta
//solamante a nivel del pedido se asigna a la planta una referncia de producto de un cliente
//que puede estar asignado a varias plantas del mismo cliente
            var resulpo = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant 
                            join pro in _dbContext.TCCproducts  
                            on or.CpocprodId equals pro.CprodId 
                            into Popro
                          from Pop in Popro.DefaultIfEmpty()
                        where (Pop.CprodId!=0)
                        orderby Pop.CprodDescInt                        
                        select new {Pop.CprodId ,Pop.CprodDescInt};
            var resuld = from p in _dbContext.TCCproducts 
                        orderby p.CprodDescInt
                        where p.CprodCustId==id //&&p.CprodCplantId==plant
                        select new {p.CprodId ,p.CprodDescInt};
            var result = from p in _dbContext.TCCproducts 
                        orderby p.CprodRefInt
                        where p.CprodCustId==id //&&p.CprodCplantId==plant
                        select new {p.CprodId ,p.CprodRefInt};
            var resulpo_pr = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant
                            join pro in _dbContext.TCCproducts  
                            on or.CpocprodId equals pro.CprodId 
                            into Popro
                          from Pop in Popro.DefaultIfEmpty() 
                        where Pop.CprodId==prod   
                        select new {Pop.CprodId };        
            var resulpo_pl = from or in _dbContext.TCPorders
                            where or.CpocustId==id && or.CpocplantId==plant
                            join pro in _dbContext.TCCproducts  
                            on or.CpocprodId equals pro.CprodId 
                            into Popro
                          from Pop in Popro.DefaultIfEmpty() 
                        select new {Pop.CprodId };                  
            var result_pr = from p in _dbContext.TCCproducts 
                        orderby p.CprodRefInt
                        where p.CprodCustId==id && p.CprodId==prod //&&p.CprodCplantId==plant 
                        select new {p.CprodId ,p.CprodRefInt};
            try{
                prod =resulpo_pr.ToList()[0].CprodId; //ddlrefer puede contnener una referencia que no corresponde con la planta de ddl plabnta que ha cambiado
            }
            catch{prod=0;}   
                                       //ponemos prod a cer y lo tratamoa a continuacion
            if (prod==0 || prod==null){                 //si prod es cero le signa una referencia de la planta en cuestion
                try{
                    prod =resulpo_pl.ToList()[0].CprodId;
                }
                catch{prod =0;}
            }
            
            ViewBag.ddlReferVO = new SelectList(resulpo.ToList(), "CprodId", "CprodDescInt",prod); 
            ViewBag.ddlReferVD = new SelectList(resuld.ToList(), "CprodId", "CprodDescInt",prod); 
            ViewBag.ddlReferVB = new SelectList(result.ToList(), "CprodId", "CprodRefInt",prod); 
            ViewData["cProd"]=prod;

            var queryca = from p in _dbContext.TCCproducts 
                        orderby p.CprodRefInt 
                        where p.CprodCustId==id //&&p.CprodCplantId==plant //&&p.CprodId==prod
                        select p;
            var qListca = queryca.ToList();
            ViewBag.ListProd=qListca;


/*
            var queryco = from plan in _dbContext.TCCplannings   
                        orderby plan.CplanCprodId ,plan.CplanDateFrom 
                        where plan.CplanCustId ==id &&
                        plan.CplanCplantId==plant &&
                        (plan.CplanCprodId==prod ||prod==null || prod==0)
                        select plan;
*/
            var queryco =from pl in _dbContext.TCCplannings join p in _dbContext.TCCproducts on  
                            pl.CplanCprodId equals p.CprodId
                            orderby pl.CplanCprodId ,pl.CplanDateFrom 
                        where pl.CplanCustId ==id &&
                        pl.CplanCplantId==plant &&
                        (pl.CplanCprodId==prod ||prod==null || prod==0)
                        select new VTCCplanning {CplanCplantId=pl.CplanCplantId,CplanCprodId=pl.CplanCprodId,
                        CplanCustId=pl.CplanCustId, CplanDateFrom=pl.CplanDateFrom,
                        CplanDateTo=pl.CplanDateTo,CplanFirmSt=pl.CplanFirmSt,
                        CplanId=pl.CplanId,CplanQty=pl.CplanQty,CprodRefInt=p.CprodRefInt,
                        CprodDescInt=p.CprodDescInt};

            var qListco = queryco.ToList();
            ViewBag.ListPlan=qListco;




            var querypo_0 =(from po in _dbContext.TCPorders
                            join pro in _dbContext.TCCproducts  on po.CpocprodId equals pro.CprodId 
                        orderby po.Cpopo
                        where po.CpocustId==id && po.CpocplantId==plant
                        select new VTCPorder {Cpoid=po.Cpoid,CpocustId=po.CpocustId,Cpopo=po.Cpopo,CporeferEx=po.CporeferEx,
                                    CprodRefInt=pro.CprodRefInt,CpodescEx=po.CpodescEx,CprodDescInt=pro.CprodDescInt,
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

            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==id
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];

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

            return View();      
        }

        [HttpPost]
        public IActionResult Create(TCustomer Customer, string actionType) {
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
            return View();      
        }

        [HttpPost]
        public IActionResult ProCreate(TCCproduct product,int Pid, int plant ,  string actionType) {
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
            ViewData["panel"]=2;

            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,plant=product.CprodCplantId});

            //return View("Edit",model);
        }


        public IActionResult PlantCreate(int Pid) {
            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
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
                     //loadCustomerViewBag(Pid,porder.CpocplantId);
                     CreateViewBags(Pid,0,plant.CplantId);
                     return View(plant);
                }
            }
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));

            CreateViewBags(Pid,0,plant.CplantId);    
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=0,plant =plant.CplantId});
        }

        [HttpGet]
        public IActionResult PlanCreate(int Pid, int prod,int plant, string actionType) {
            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
            CreateViewBags(Pid,prod,plant);
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
            return View(model);      
        }

        [HttpPost]
        public IActionResult PlanCreate(TCCplanning planning,int Pid, int prod,int? plant, string actionType,int? CplantId,int? CprodId) {
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
            ViewData["panel"]=4;
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
            return View();      
        }

        [HttpPost]
        public IActionResult PoCreate(TCPorder porder,int Pid, int prod,int? plant, string actionType) {
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
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));
            try{
            _dbContext.TCustomers.Remove(model);
            _dbContext.SaveChanges();
            }  
            catch{}          
            return RedirectToAction("Index");
        }
        public IActionResult ProDelete(int id,int Pid) {
            var mode = _dbContext.TCCproducts
                .SingleOrDefault(u => u.CprodId.Equals(id));
            try{
            _dbContext.TCCproducts.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,0);                
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
            ViewData["panel"]=5;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=5,move=0,prod=pro,plant=plan});

            //return RedirectToAction("Edit");
        }


        [HttpGet]
        public IActionResult ProEdit(int id) {
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
            ViewData["panel"]=2;
            //return View("Edit",model);
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,prod=product.CprodId,plant=product.CprodCplantId});

            //return RedirectToAction("Index");
        } 

        [HttpGet]
        public IActionResult PlantEdit(int id) {
            try{
            var model = _dbContext.TCCplants
                .SingleOrDefault(u => u.CplantId.Equals(id));
            int?Pid=model.CplantCustId;

            var queryc = from p in _dbContext.TCustomers 
                        where p.CustId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Customer=qList[0];
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
            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(Pid));
            CreateViewBags(Pid,0,planta.CplantId);                
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=0,plant=planta.CplantId});
        } 

        [HttpGet]
        public IActionResult PlanEdit(int id) {
            try{
            var model = _dbContext.TCCplannings
                .SingleOrDefault(u => u.CplanId.Equals(id));
            int?Pid=model.CplanCustId;

            CreateViewBags(Pid,model.CplanCprodId,model.CplanCplantId);    

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
        public IActionResult PoEdit(int id) {
            try{
            var model = _dbContext.TCPorders
                .SingleOrDefault(u => u.Cpoid.Equals(id));
            int?Pid=model.CpocustId;

            CreateViewBags(Pid,model.CpocprodId,model.CpocplantId);    

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
            ViewData["panel"]=panel;
            try{

            var model = _dbContext.TCustomers
                .SingleOrDefault(u => u.CustId.Equals(id));

            CreateViewBags(id,prod,plant);
            return View("Edit",model);
            }
            catch{return View("Error");}    
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
            CreateViewBags(model.CustId,CprodId,CplantId);

            ViewData["panel"]=panel;
            return View("Edit",model);
            //return RedirectToAction("Index");
        }        
 
    }
}