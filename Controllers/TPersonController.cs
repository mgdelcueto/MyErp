using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MyErp.Models;
using System;
using System.Linq;

namespace MyErp.Controllers {
    [Authorize(Roles="Administrator,HR")]
    public class TPersonController : Controller {
        private readonly MyErpDBContext _dbContext;
        /*
        public TPersonController(MyErpDBContext dbContext) {
            _dbContext = dbContext;
        }
        */
        private readonly ILogger<TPersonController> _logger;    
        /* esta version de localizacion no la utilizamos ahora
        private readonly IStringLocalizer<TPersonController> _localizer;

        public TPersonController(MyErpDBContext dbContext,IStringLocalizer<TPersonController> localizer,
        
        ILogger<TPersonController> logger)
        {
            _dbContext = dbContext;
            _localizer = (IStringLocalizer<TPersonController>)localizer;
            _logger = (ILogger<TPersonController>)logger;
        }    
        */

        public TPersonController(MyErpDBContext dbContext,ILogger<TPersonController> logger)
        {
            _dbContext = dbContext;
            _logger = (ILogger<TPersonController>)logger;
        }    

        private void CreateViewBags(int? id)
        {
            var querype = from p in _dbContext.TPersons 
                        orderby p.PerName,p.PerName1
                        select p;
            var qListpe = querype.ToList();
            ViewBag.ListPerson=qListpe;

            var queryca = from p in _dbContext.TPCareers 
                        orderby p.CareDate
                        where p.CarePerId==id
                        select p;
            var qListca = queryca.ToList();
            ViewBag.ListCareer=qListca;

            var queryco = from p in _dbContext.TPContracts 
                        orderby p.ConRevDate
                        where p.ConPerId==id
                        select p;
            var qListco = queryco.ToList();
            ViewBag.ListContract=qListco;

            var querycu = from p in _dbContext.TPCurrics 
                        orderby p.CurrRevDate
                        where p.CurrPerId==id
                        select p;
            var qListcu = querycu.ToList();
            ViewBag.ListCurric=qListcu;

            var querypa = from p in _dbContext.TPPays 
                        orderby p.PayStDate
                        where p.PayPerId==id
                        select p;
            var qListpa = querypa.ToList();
            ViewBag.ListPay=qListpa;

            var querypre = from p in _dbContext.TPPresens 
                        orderby p.PresDateEvent
                        where p.PresPerId==id
                        select p;
            var qListpre = querypre.ToList();
            ViewBag.ListPre=qListpre;

            var queryre = from p in _dbContext.TPReviews 
                        orderby p.RevDate
                        where p.RevPerId==id
                        select p;
            var qListre = queryre.ToList();
            ViewBag.ListRev=qListre;

            var querytra = from p in _dbContext.TPTrains 
                        orderby p.TrainDate
                        where p.TrainPerId==id
                        select p;
            var qListra = querytra.ToList();
            ViewBag.ListTra=qListra;
        }
        private void loadPersonViewBag( int? Pid)
        {
                        var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];

        }
        public IActionResult Index(int filter,string pNam, string pNam1,string actionType) {
            if (actionType=="Cancel"){filter=0;}
            //string variable =_localizer["Indexmessage"];
            //ViewData["Title"] = _localizer["Indexmessage"];
            ViewData["Filter"]=filter;
            ViewData["Fil1"]=pNam;
            ViewData["Fil2"]=pNam1;
            var dbContext = new MyErpDBContext();
            try{
             var model = _dbContext.TPersons.OrderBy(p => p.PerName1).ThenBy(p=> p.PerName).ToList();
             if (filter ==2){
                var queryc = from p in _dbContext.TPersons 
                        where (p.PerName.Contains(pNam) || pNam ==null ) && (p.PerName1.Contains(pNam1) ||pNam1==null)
                        orderby p.PerName1, p.PerName
                        select p;
                var qList=queryc.ToList();
                model = qList;
             }
             return View(model);
            }
            catch(Exception ex)
            {
                string mensaje = ex.Message;
                return View("Error");}
            
        }
        public IActionResult ShowDetail(int id) {
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(id));
            if (model != null)
                return View("Detail", model);
            else
                return RedirectToAction("Index");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create() {
            return View();      
        }

        [HttpPost]
        public IActionResult Create(TPerson person, string actionType) {
            if(actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPersons.Add(person); 
                _dbContext.SaveChanges();
                }
            catch{}
            }
            else{                
                return View(person);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CarCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult CarCreate(TPCareer career,int Pid, string actionType) {
            if(actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPCareers.Add(career); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(career);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));

            CreateViewBags(Pid);    
            ViewData["panel"]=2;
            return View("Edit",model);
        }

        [HttpGet]
        public IActionResult ConCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult ConCreate(TPContract contract,int Pid, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPContracts.Add(contract); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(contract);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=3;
            return View("Edit",model);
        }

        [HttpGet]
        public IActionResult CurCreate(int Pid) {
            loadPersonViewBag(Pid);
            return View();      
        }

        [HttpPost]
        public IActionResult CurCreate(TPCurric curriculum, int? Pid, string actionType) {
            if (actionType=="Add"){
                if (ModelState.IsValid){
                    try{
                        _dbContext.TPCurrics.Add(curriculum); 
                        _dbContext.SaveChanges();
                        }
                    catch{return View("Error");}
                    }
                else {
                    loadPersonViewBag(Pid);
                    return View(curriculum);
                    }
                }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=4;
            return View("Edit",model);
        }


        [HttpGet]
        public IActionResult PayCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult PayCreate(TPPay pay, int Pid, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPPays.Add(pay); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(pay);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=5;
            return View("Edit",model);
        }


        [HttpGet]
        public IActionResult PreCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult PreCreate(TPPresen presen, int Pid, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPPresens.Add(presen); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(presen);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=6;
            return View("Edit",model);
        }

        [HttpGet]
        public IActionResult RevCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult RevCreate(TPReview rev, int Pid, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPReviews.Add(rev); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(rev);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=7;
            return View("Edit",model);
        }

        [HttpGet]
        public IActionResult TraCreate(int Pid) {
            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View();      
        }

        [HttpPost]
        public IActionResult TraCreate(TPTrain train, int Pid, string actionType) {
            if (actionType=="Add"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPTrains.Add(train); 
                _dbContext.SaveChanges();
            }
            catch{return View("Error");}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(train);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
                
            CreateViewBags(Pid);
            ViewData["panel"]=8;
            return View("Edit",model);
        }

        public IActionResult Delete(int id) {
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(id));
            try{
            _dbContext.TPersons.Remove(model);
            _dbContext.SaveChanges();
            }  
            catch{}          
            return RedirectToAction("Index");
        }
        public IActionResult CarDelete(int id,int Pid) {
            var mode = _dbContext.TPCareers
                .SingleOrDefault(u => u.CareId.Equals(id));
            try{
            _dbContext.TPCareers.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=2;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult ConDelete(int id,int Pid) {
            var mode = _dbContext.TPContracts
                .SingleOrDefault(u => u.ConId.Equals(id));
            try{
            _dbContext.TPContracts.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=3;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }


        public IActionResult CurDelete(int id,int Pid) {
            var mode = _dbContext.TPCurrics
                .SingleOrDefault(u => u.CurrId.Equals(id));
            try{
            _dbContext.TPCurrics.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=4;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PayDelete(int id,int Pid) {
            var mode = _dbContext.TPPays
                .SingleOrDefault(u => u.PayId.Equals(id));
            try{
            _dbContext.TPPays.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=5;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult PreDelete(int id,int Pid) {
            var mode = _dbContext.TPPresens
                .SingleOrDefault(u => u.PresId.Equals(id));
            try{
            _dbContext.TPPresens.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=6;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }

        public IActionResult RevDelete(int id,int Pid) {
            var mode = _dbContext.TPReviews
                .SingleOrDefault(u => u.RevId.Equals(id));
            try{
            _dbContext.TPReviews.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=7;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }


        public IActionResult TraDelete(int id,int Pid) {
            var mode = _dbContext.TPTrains
                .SingleOrDefault(u => u.TrainId.Equals(id));
            try{
            _dbContext.TPTrains.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=8;
            return View("Edit",model);

            //return RedirectToAction("Edit");
        }


        [HttpGet]
        public IActionResult CarEdit(int id) {
            try{
            var model = _dbContext.TPCareers
                .SingleOrDefault(u => u.CareId.Equals(id));
            int?Pid=model.CarePerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult CarEdit(TPCareer career, string actionType) {
            int? Pid=career.CarePerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPCareers.Update(career);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(career);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);                
            ViewData["panel"]=2;
            return View("Edit",model);
        } 

        [HttpGet]
        public IActionResult ConEdit(int id) {
            try{
            var model = _dbContext.TPContracts
                .SingleOrDefault(u => u.ConId.Equals(id));
            int?Pid=model.ConPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult ConEdit(TPContract contract, string actionType) {
            int? Pid=contract.ConPerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPContracts.Update(contract);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(contract);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=3;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     


        [HttpGet]
        public IActionResult CurEdit(int id) {
            try{
            var model = _dbContext.TPCurrics
                .SingleOrDefault(u => u.CurrId.Equals(id));
            int?Pid=model.CurrPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult CurEdit(TPCurric curriculum, string actionType) {
            int? Pid=curriculum.CurrPerId;
            if (actionType=="Update"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TPCurrics.Update(curriculum);
                        _dbContext.SaveChanges();}
                  catch{}
                }
             else {
                    loadPersonViewBag(Pid);
                    return View(curriculum);
                   }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=4;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     
        [HttpGet]
        public IActionResult PayEdit(int id) {
            try{
            var model = _dbContext.TPPays
                .SingleOrDefault(u => u.PayId.Equals(id));
            int?Pid=model.PayPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PayEdit(TPPay pay, string actionType) {
            int? Pid=pay.PayPerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPPays.Update(pay);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(pay);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=5;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     


        [HttpGet]
        public IActionResult PreEdit(int id) {
            try{
            var model = _dbContext.TPPresens
                .SingleOrDefault(u => u.PresId.Equals(id));
            int?Pid=model.PresPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult PreEdit(TPPresen pre, string actionType) {
            int? Pid=pre.PresPerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPPresens.Update(pre);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(pre);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=6;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     


        [HttpGet]
        public IActionResult RevEdit(int id) {
            try{
            var model = _dbContext.TPReviews
                .SingleOrDefault(u => u.RevId.Equals(id));
            int?Pid=model.RevPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult RevEdit(TPReview rev, string actionType) {
            int? Pid=rev.RevPerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPReviews.Update(rev);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(rev);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=7;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     

        [HttpGet]
        public IActionResult TraEdit(int id) {
            try{
            var model = _dbContext.TPTrains
                .SingleOrDefault(u => u.TrainId.Equals(id));
            int?Pid=model.TrainPerId;

            var queryc = from p in _dbContext.TPersons 
                        where p.PerId==Pid
                        select p;
            var qList=queryc.ToList();
            ViewBag.Person=qList[0];
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult TraEdit(TPTrain train, string actionType) {
            int? Pid=train.TrainPerId;
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPTrains.Update(train);
                _dbContext.SaveChanges();
            }
            catch{}
            }
            else{
                    loadPersonViewBag(Pid);
                    return View(train);
            }
            }
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(Pid));
            CreateViewBags(Pid);    
            ViewData["panel"]=8;
            return View("Edit",model);

            //return RedirectToAction("Index");
        }     

        [HttpGet]
        public IActionResult Edit(int id, int panel, int move) {
            ViewData["panel"]=panel;
            try{
            //string pna1=model.PerName1;
            var mode = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(id));
            string cName = mode.PerName1+mode.PerName;

            var query = from p in _dbContext.TPersons 
                        orderby p.PerName1+p.PerName
                        where string.Compare(p.PerName1+p.PerName,cName)==1
                        select p;
            var qList = query.ToList();
            int nId = id ;
            try{
                nId=qList[0].PerId;
            }
            catch{}
            query = from p in _dbContext.TPersons 
                        orderby p.PerName1+p.PerName descending
                        where string.Compare(cName,p.PerName1+p.PerName)==1
                        select p;
            qList = query.ToList();
            int pId = id ;
            try{
                pId=qList[0].PerId;
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
            var model = _dbContext.TPersons
                .SingleOrDefault(u => u.PerId.Equals(id));
                
            CreateViewBags(id);
            return View("Edit",model);
            }
            catch{return View("Error");}    
        }    
        [HttpPost]
        public IActionResult Edit(TPerson person, string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
                _dbContext.TPersons.Update(person);
                _dbContext.SaveChanges();
            }
            catch{}
            }else{
                CreateViewBags(0);    
                ViewData["panel"]=1;
                return View(person);
            }
            }
            return RedirectToAction("Index");
        }        
    }
}