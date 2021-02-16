using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System.Linq;

namespace MyErp.Controllers {
    [Authorize]
    public class TSuplierController : Controller {
        private readonly MyErpDBContext _dbContext;
        public TSuplierController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        private void CreateViewBags(int? id, int? prod)
        {
            var queryca = from p in _dbContext.TSProducts 
                        orderby p.ProdRefer
                        where p.ProdSupId==id
                        select p;
            var qListca = queryca.ToList();
            ViewBag.ListProd=qListca;
            var queryco = from plan in _dbContext.TSPlannings  
                        join pro in _dbContext.TSProducts on plan.PlanProdId equals pro.ProdId
                        orderby plan.PlanProdId,plan.PlanDateFrom
                        where plan.PlanSupId==id && (plan.PlanProdId==prod ||prod==null || prod==0)
                        select new TSPlanningV {PlanSupId=plan.PlanSupId,PlanQty=plan.PlanQty,
                        PlanProdId=plan.PlanProdId,PlanId=plan.PlanId,PlanFirmSt=plan.PlanFirmSt,
                        PlanDateTo=plan.PlanDateTo,PlanDateFrom=plan.PlanDateFrom,
                        ProdSupId=pro.ProdSupId,ProdStDate=pro.ProdStDate,
                        ProdStatus=pro.ProdStatus,ProdId=pro.ProdId,ProdRefer=pro.ProdRefer,
                        ProdDescr=pro.ProdDescr,ProdCrDate=pro.ProdCrDate};
            var qListco = queryco.ToList();
            ViewBag.ListPlan=qListco;

            var result = from p in _dbContext.TSPorders
                        join  mat in _dbContext.TMaterials on p.SpocprodId equals mat.MatId
                        orderby mat.MatDescr
                        where p.SposupId==id
                        select new {mat.MatId,mat.MatDescr};
            ViewBag.ddlReferVB = new SelectList(result.ToList(), "MatId", "MatDescr",prod); 
            
            var resuld = from  mat in _dbContext.TMaterials
                        orderby mat.MatDescr
                        where mat.MatClass=="RM"
                        select new {mat.MatId ,mat.MatDescr};
            ViewBag.ddlReferVD = new SelectList(resuld.ToList(), "MatId", "MatDescr",prod); 


            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==id
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];

           try{
            var mode = _dbContext.TSProducts
                .SingleOrDefault(u => u.ProdId.Equals(prod));
            ViewData["Prod"]=mode.ProdRefer;
            ViewData["cProd"]=prod;}
            catch{ViewData["Prod"]="No Filter <<<";
            ViewData["cProd"]=0;}

            var querypo_0 =(from po in _dbContext.TSPorders
                            join mat in _dbContext.TMaterials on po.SpocprodId equals mat.MatId 
                        orderby po.Spopo
                        where po.SposupId==id 
                        select new VTSPorder {Spoid=po.Spoid,SposupId=po.SposupId,Spopo=po.Spopo,SporeferEx=po.SporeferEx,
                                    SprodRefInt=mat.MatRefer,SpodescEx=po.SpodescEx,SprodDescInt=mat.MatDescr,
                                    Spoprice=po.Spoprice,Spocurcy=po.Spocurcy}).ToList();
            var querypo_1=(from po in _dbContext.TSPorders 
                        where  po.SposupId==id && (po.SpocprodId==null ||po.SpocprodId ==0) 
                        select new VTSPorder {Spoid=po.Spoid,SposupId=po.SposupId,Spopo=po.Spopo,SporeferEx=po.SporeferEx,
                                    SprodRefInt="NE",SpodescEx=po.SpodescEx,SprodDescInt="NE",
                                    Spoprice=po.Spoprice,Spocurcy=po.Spocurcy}).ToList();
            var querypo = querypo_0.Concat(querypo_1);
            var qListpo = querypo.ToList();
            ViewBag.ListSpo=qListpo;

        }

        public IActionResult Index(int filter,string pNam, string pNam1,string actionType) {
            if (actionType=="Cancel"){filter=0;}
            ViewData["Title"] = "All Items";
            ViewData["Filter"]=filter;
            ViewData["Fil1"]=pNam;
            ViewData["Fil2"]=pNam1;
            var dbContext = new MyErpDBContext();
            try{
             var model = _dbContext.TSupliers.OrderBy(p => p.SupRasoc).ToList();
             if (filter ==2){
                var queryc = from p in _dbContext.TSupliers 
                        where (p.SupRasoc.Contains(pNam) || pNam ==null ) && (p.SupNif.Contains(pNam1) ||pNam1==null)
                        orderby p.SupRasoc, p.SupNif
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
        public IActionResult Create(TSuplier suplier, string actionType) {
            if(actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSupliers.Add(suplier); 
                _dbContext.SaveChanges();
                }
            catch{}
            }
            else{
                 return View(suplier);
            }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ProCreate(int Pid) {
            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult ProCreate(TSProduct product,int Pid, string actionType) {
            if(actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSProducts.Add(product); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                CreateViewBags(Pid,product.ProdId);
                 return View(product);
            }
            }
            CreateViewBags(Pid,0);    
            ViewData["panel"]=2;
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,prod=product.ProdId});

        }

        [HttpGet]
        public IActionResult PlanCreate(int Pid, int prod, string actionType) {
            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];
            CreateViewBags(Pid,prod);
            return View();      
        }

        [HttpPost]
        public IActionResult PlanCreate(TSPlanning planning,int Pid, int prod, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSPlannings.Add(planning); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                CreateViewBags(Pid,planning.PlanProdId);
                 return View(planning);
            }
            }
            CreateViewBags(Pid,planning.PlanProdId);    
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=planning.PlanProdId});
        }


        [HttpGet]
        public IActionResult PoCreate(int Pid, int prod, string actionType) {
            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];
            CreateViewBags(Pid,prod);
            return View();      
        }

        [HttpPost]
        public IActionResult PoCreate(TSPorder porder,int Pid, int prod, string actionType) {
            if (actionType=="Add"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TSPorders.Add(porder); 
                        _dbContext.SaveChanges();
                    }
                    catch{return View("Error");}
                }
            else {
                 CreateViewBags(Pid,porder.SpocprodId);
                 return View(porder);
                }
            }
             CreateViewBags(Pid,porder.SpocprodId);
            ViewData["panel"]=4;
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=0});
        }


        public IActionResult Delete(int id) {
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(id));
            try{
            _dbContext.TSupliers.Remove(model);
            _dbContext.SaveChanges();
            }  
            catch{}          
            return RedirectToAction("Index");
        }
        public IActionResult ProDelete(int id,int Pid) {
            var mode = _dbContext.TSProducts
                .SingleOrDefault(u => u.ProdId.Equals(id));
            try{
            _dbContext.TSProducts.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));
            CreateViewBags(Pid,0);                
            ViewData["panel"]=2;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PlanDelete(int id,int Pid) {
            var mode = _dbContext.TSPlannings
                .SingleOrDefault(u => u.PlanId.Equals(id));
            try{
            _dbContext.TSPlannings.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));
            CreateViewBags(Pid,mode.PlanProdId);                
            ViewData["panel"]=3;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PoDelete(int id,int Pid) {
            var mode = _dbContext.TSPorders
                .SingleOrDefault(u => u.Spoid.Equals(id));
            int? pro =mode.SpocprodId;
            try{
            _dbContext.TSPorders.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}    

            CreateViewBags(Pid,pro);                
            ViewData["panel"]=4;
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=pro});
        }


        [HttpGet]
        public IActionResult ProEdit(int id) {
            try{
            var model = _dbContext.TSProducts
                .SingleOrDefault(u => u.ProdId.Equals(id));
            int?Pid=model.ProdSupId;

            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult ProEdit(TSProduct product, string actionType) {
            int? Pid=product.ProdSupId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSProducts.Update(product);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
              CreateViewBags(Pid,product.ProdId);    
              return View(product);
            }
            }
            CreateViewBags(Pid,0);    
            ViewData["panel"]=2;
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,prod=product.ProdId});
        } 

        [HttpGet]
        public IActionResult PlanEdit(int id) {
            try{
            var model = _dbContext.TSPlannings
                .SingleOrDefault(u => u.PlanId.Equals(id));
            int?Pid=model.PlanSupId;

            CreateViewBags(Pid,model.PlanProdId);    

            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PlanEdit(TSPlanning planning, string actionType) {
            int? Pid=planning.PlanSupId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSPlannings.Update(planning);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
              CreateViewBags(Pid,planning.PlanProdId);    
              return View(planning);
            }
            }
            CreateViewBags(Pid,planning.PlanProdId);    
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=planning.PlanProdId});

        }     

        [HttpGet]
        public IActionResult PoEdit(int id) {
            try{
            var model = _dbContext.TSPorders
                .SingleOrDefault(u => u.Spoid.Equals(id));
            int?Pid=model.SposupId;

            CreateViewBags(Pid,model.SpocprodId);    

            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PoEdit(TSPorder porder, string actionType) {
            int? Pid=porder.SposupId;
            if (actionType=="Update"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TSPorders.Update(porder);
                        _dbContext.SaveChanges();
                 }
                    catch{}
                    }
            else {
                 CreateViewBags(Pid,porder.SpocprodId);    
                 return View(porder);
            }
            }
            CreateViewBags(Pid,porder.SpocprodId);    
            ViewData["panel"]=4;
            return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=porder.SpocprodId});
        }     

        [HttpGet]
        public IActionResult Edit(int id, int panel, int move,int? prod) {
            if(prod==null){prod=0;}
            ViewData["panel"]=panel;
            try{

            var mode = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(id));
            string cName = mode.SupRasoc+mode.SupNif;

            var query = from p in _dbContext.TSupliers 
                        orderby p.SupRasoc+p.SupNif
                        where string.Compare(p.SupRasoc+p.SupNif,cName)==1
                        select p;
            var qList = query.ToList();
            int nId = id ;
            try{
                nId=qList[0].SupId;
            }
            catch{}
            query = from p in _dbContext.TSupliers 
                        orderby p.SupRasoc+p.SupNif descending
                        where string.Compare(cName,p.SupRasoc+p.SupNif)==1
                        select p;
            qList = query.ToList();
            int pId = id ;
            try{
                pId=qList[0].SupId;
            }
            catch{}

            switch (move){
                case 0:
                    break;
                case 1:
                    id =pId;
                    break;
                case 2:
                    id =nId;
                    break;
                default:
                    break;
            }
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(id));

            CreateViewBags(id,prod);
            return View("Edit",model);
            }
            catch{return View("Error");}    
        }    
        [HttpPost]
        public IActionResult Edit(TSuplier suplier, string actionType,int? ProdId, int panel) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSupliers.Update(suplier);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{

            }
            }

            CreateViewBags(suplier.SupId,ProdId);

            ViewData["panel"]=panel;
            return View("Edit",suplier);
            //return RedirectToAction("Index");
        }        
 
    }
}