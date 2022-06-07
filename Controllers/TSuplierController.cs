using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyErp.Models;
using System.Linq;


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
    [Authorize(Roles="Supplier,Administrator")]
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
                        join por in _dbContext.TSPorders 
                        on new {X1=plan.PlanSupId,X2=plan.PlanProdId} equals new {X1=por.SposupId,X2=por.SporeferEx}
                        join mat in _dbContext.TMaterials on por.SpocprodId equals mat.MatId
                        orderby plan.PlanProdId,plan.PlanDateFrom
                        where plan.PlanSupId==id //&& (plan.PlanProdId==prod ||prod==null || prod==0)
                        select new TSPlanningV {PlanSupId=plan.PlanSupId,PlanQty=plan.PlanQty,
                        PlanProdId=plan.PlanProdId,PlanId=plan.PlanId,PlanFirmSt=plan.PlanFirmSt,
                        PlanDateTo=plan.PlanDateTo,PlanDateFrom=plan.PlanDateFrom,
                        ProdSupId=pro.ProdSupId,ProdStDate=pro.ProdStDate,
                        ProdStatus=pro.ProdStatus,ProdId=pro.ProdId,ProdRefer=pro.ProdRefer,
                        ProdDescr=pro.ProdDescr,ProdCrDate=pro.ProdCrDate,
                        MatRefer=mat.MatRefer,MatDescr=mat.MatDescr};
            var qListco = queryco.ToList();
            ViewBag.ListPlan=qListco;

            /*2022-06-03 muestra descripcion interna y pasa codigo externo para el planning*/
            var result = from p in _dbContext.TSPorders
                        join  mat in _dbContext.TMaterials on p.SpocprodId equals mat.MatId
                        orderby mat.MatDescr
                        where p.SposupId==id
                        select new {p.SporeferEx,mat.MatDescr};
            ViewBag.ddlReferVB = new SelectList(result.ToList(), "SporeferEx", "MatDescr",prod); 
            
            var resuld = from  mat in _dbContext.TMaterials
                        orderby mat.MatDescr
                        where mat.MatClass=="RM"
                        select new {mat.MatId ,mat.MatDescr};
            ViewBag.ddlReferVD = new SelectList(resuld.ToList(), "MatId", "MatDescr",prod); 

            var querycx = from p in _dbContext.TSProducts 
                        orderby p.ProdDescr
                        where p.ProdSupId==id
                        select p;
            ViewBag.ddlReferEX = new SelectList(querycx.ToList(), "ProdId", "ProdDescr",prod); 

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

            /*
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

--------
            var qListpo =(from mat in _dbContext.TMaterials 
                            join po in _dbContext.TSPorders on mat.MatId equals  po.SpocprodId
                            join spr in _dbContext.TSProducts on po.SporeferEx equals spr.ProdId
---------

            */
            var qListpo =(from po in _dbContext.TSPorders
                            join mat in _dbContext.TMaterials on po.SpocprodId equals mat.MatId 
                            join spr in _dbContext.TSProducts on po.SporeferEx equals spr.ProdId
                        orderby po.Spopo
                        where po.SposupId==id 
                        select new VTSPorder {Spoid=po.Spoid,SposupId=po.SposupId,Spopo=po.Spopo,SporeferEx=spr.ProdRefer,
                                    SprodRefInt=mat.MatRefer,SpodescEx=spr.ProdDescr,SprodDescInt=mat.MatDescr,
                                    Spoprice=po.Spoprice,Spocurcy=po.Spocurcy,Spostatus=po.Spostatus,
                                    SpoPcRep=po.SpoPcRep,SpoDateSt=po.SpoDateSt}).ToList();
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
            ViewData["panel"]=1;

            return View();      
        }

        [HttpPost]
        public IActionResult Create(TSuplier suplier, string actionType) {
            ViewData["panel"]=1;
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

             var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=2;

            return View();      
        }

        [HttpPost]
        public IActionResult ProCreate(TSProduct product,int Pid, string actionType) {
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

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

             var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=3;

            CreateViewBags(Pid,prod);
            return View();      
        }

        [HttpPost]
        public IActionResult PlanCreate(TSPlanning planning,int Pid, int prod, string actionType) {
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

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

             var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=4;

            CreateViewBags(Pid,prod);
            return View();      
        }

        [HttpPost]
        public IActionResult PoCreate(TSPorder porder,int Pid, int prod, string actionType) {
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

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
            ViewData["SupId"]=id;
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

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=2;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PlanDelete(int id,int Pid) {
            var mode = _dbContext.TSPlannings
                .SingleOrDefault(u => u.PlanId.Equals(id));
            int? pid = mode.PlanSupId;
            try{
            _dbContext.TSPlannings.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(pid));
            CreateViewBags(pid,mode.PlanProdId);                
            ViewData["panel"]=3;

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=pid;

            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PoDelete(int id,int Pid) {
            var mode = _dbContext.TSPorders
                .SingleOrDefault(u => u.Spoid.Equals(id));
            int? pro =mode.SpocprodId;
            int? pid =mode.SposupId;
            try{
            _dbContext.TSPorders.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}    

            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(pid));

            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=pid;


            CreateViewBags(pid,pro);                
            ViewData["panel"]=4;
            return RedirectToAction("Edit",new{id=pid,panel=4,move=0,prod=pro});
        }


        [HttpGet]
        public IActionResult ProEdit(int id,int suid) {
            try{
            var model = _dbContext.TSProducts
                .SingleOrDefault(u => u.ProdId.Equals(id));
            int?Pid=model.ProdSupId;

            var queryc = from p in _dbContext.TSupliers 
                        where p.SupId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Suplier=qList[0];

            var pmodel = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = pmodel.SupRasoc+" " +pmodel.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;//suid;

            ViewData["panel"]=2;


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

            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));
            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;


            CreateViewBags(Pid,0);    
            ViewData["panel"]=2;
            return RedirectToAction("Edit",new{id=Pid,panel=2,move=0,prod=product.ProdId});
        } 

        [HttpGet]
        public IActionResult PlanEdit(int id,int suid) {
            try{
            var model = _dbContext.TSPlannings
                .SingleOrDefault(u => u.PlanId.Equals(id));
            int?Pid=model.PlanSupId;

            CreateViewBags(Pid,model.PlanProdId);    

            var pmodel = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = pmodel.SupRasoc+" " +pmodel.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=3;

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
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));
            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            CreateViewBags(Pid,planning.PlanProdId);    
            ViewData["panel"]=3;
            return RedirectToAction("Edit",new{id=Pid,panel=3,move=0,prod=planning.PlanProdId});

        }     
        private Dictionary<string, string> newParams(string parqs)
        {
            var ret = new Dictionary<string, string>();
            try{
            var _parqs = HttpUtility.ParseQueryString(parqs);
            foreach (String s in _parqs.AllKeys)
                {
                    ret.Add(s,_parqs[s]);
                }
            }
            catch(Exception ex){
                string mensaje = ex.Message;
            }
            return ret;
        }
        private string _newParams(string parqs)
        {
            string ret ="";
            try{
            var _parqs = HttpUtility.ParseQueryString(parqs);
            int cont=1;
            foreach (String s in _parqs.AllKeys)
                {
                    ret+=s+"="+_parqs[s];
                    if (cont<_parqs.AllKeys.Count()){ret+=",";}
                    cont++;
                }
            }
            catch(Exception ex){
                string mensaje = ex.Message;
            }
            return ret;
        }

        [HttpGet]
        public IActionResult PoEdit(int id,int suid,string updField,string updValue,string retCont,string retAct,string _parqs) {
            if (updField!=null){
                var mode = _dbContext.TSPorders
                    .SingleOrDefault(u => u.Spoid.Equals(id));
                try{
                    bool update =true;
                    switch (updField)
                    {
                        case "SpoPcRep":
                            mode.SpoPcRep=Convert.ToDouble(updValue);
                            break;
                        default:
                            update = false;
                            break;
                    }
                    if (update){
                        _dbContext.TSPorders.Update(mode);
                        _dbContext.SaveChanges();
                    }
                    }
                catch(Exception ex){
                    string mensaje = ex.Message;
                }
                return RedirectToAction(retAct,retCont,newParams(_parqs));//new{newParams(_parqs)});//new{parqs=_parqs});
            }
        else{
            if (retCont!=null && retCont !="")
            {
                ViewData["RetCont"]=retCont;
                ViewData["RetAct"]=retAct;
                ViewData["_parqs"]=_parqs;
            }
            try{
            var model = _dbContext.TSPorders
                .SingleOrDefault(u => u.Spoid.Equals(id));
            int?Pid=model.SposupId;

            CreateViewBags(Pid,model.SpocprodId);    


            var pmodel = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));

            string sName = pmodel.SupRasoc+" " +pmodel.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            ViewData["panel"]=4;

            return View(model);
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                return View("Error");}            
        }
        }

        [HttpPost]
        public IActionResult PoEdit(TSPorder porder, string actionType,string retCont,string retAct,string _parqs) {
            int? Pid=porder.SposupId;

            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(Pid));
            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=Pid;

            if (actionType=="Update"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TSPorders.Update(porder);
                        _dbContext.SaveChanges();
                 }
                    catch{}
                    }
            else {
                /*
                 if (retCont!=null && retCont !="")
                 {
                    var xarams = newParams(_parqs);
                    return RedirectToAction(retAct,retCont,xarams);//new{parqs=_parqs});
                 }
                 else
                 {*/
                     CreateViewBags(Pid,porder.SpocprodId);  
                     return View(porder);
                 //}
            }
            }

            if (retCont!=null && retCont !="")
                {
                    var xarams = newParams(_parqs);
                    return RedirectToAction(retAct,retCont,xarams);//new{parqs=_parqs});
                }
            else
                {
                    CreateViewBags(Pid,porder.SpocprodId);    
                ViewData["panel"]=4;
                return RedirectToAction("Edit",new{id=Pid,panel=4,move=0,prod=porder.SpocprodId});
                }
        }     

        [HttpGet]
        public IActionResult Edit(int id, int panel, int move,int? prod, int supid) {
            if(prod==null){prod=0;}
            if(panel==0){panel=1;}
            ViewData["panel"]=panel;
            try{
            /*
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
            */
            try{
            var mode = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(id));
            string uniqueId=Request.Cookies["Grid-Suplier"].ToString().TrimStart().TrimEnd();
            string sortExpression=Request.Cookies["Grid-"+uniqueId+"-sortExpression"];
            string filterExpression=Request.Cookies["Grid-"+uniqueId+"-filterExpression"];
            var sqln="SELECT case when res._pID is null then 0 else res._pID  end as _idprev, SupId as _Id, case when res._nID is null then 0 else res._nID end as _Idnext FROM (SELECT *,lead(SupId) OVER (ORDER BY " + sortExpression + " ) as _nID, lag(SupId) OVER (ORDER BY "+ sortExpression+") as _pID FROM T_Suplier where "+filterExpression+") as res where res.SupId="+id.ToString();
            var ListnId = _dbContext.TNexPrevs.FromSqlRaw(sqln).ToList();
            int nId=id;
            int pId=id;
            try{ nId=ListnId[0]._Idnext;}
            catch{}
            try{ pId=ListnId[0]._idprev;}
            catch{}
            if (pId==0){pId=id;}
            if (nId==0){nId=id;}







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

            ViewData["Sort"]=sortExpression;
            ViewData["Filter"]=filterExpression;
            }
            catch{}
            var model = _dbContext.TSupliers
                .SingleOrDefault(u => u.SupId.Equals(id));
            string sName = model.SupRasoc+" " +model.SupNif;
            ViewData["SupId"]=id;
            ViewData["sName"]=sName;

            CreateViewBags(id,prod);
            return View("Edit",model);
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                return View("Error");
            }    
        }    
        [HttpPost]
        public IActionResult Edit(TSuplier suplier, string actionType,int? ProdId, int panel) {
            if (actionType=="Cancel"){
                return RedirectToAction("Index");
            }
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TSupliers.Update(suplier);
                _dbContext.SaveChanges();
            }
            catch(Exception ex){
                string mensaje = ex.Message;
            }
            }
            else{

            }
            }

            //var model = _dbContext.TSupliers
            //    .SingleOrDefault(u => u.SupId.Equals(id));

            string sName = suplier.SupRasoc+" " +suplier.SupNif;
            ViewData["sName"]=sName;
            ViewData["SupId"]=suplier.SupId;


            CreateViewBags(suplier.SupId,ProdId);

            ViewData["panel"]=panel;
            return View("Edit",suplier);
            //return RedirectToAction("Index");
        }        
 
    }
}