using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MyErp.Models;
using System;
using System.Linq;

namespace MyErp.Controllers {
   [Authorize(Roles="Organization,Administrator")]
    public class TOrganizaController : Controller {
        private readonly MyErpDBContext _dbContext;
        private readonly ILogger<TPersonController> _logger;    
        private void CreateViewBags(int chid=0,int usrid=0)
        {

            var chart = from p in _dbContext.TCharts
                        join e in _dbContext.TPersons 
                        on p.CharHeadId equals e.PerId into ps
                        from e in ps.DefaultIfEmpty()
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

            var user = from p in _dbContext.TUsers
                        orderby p.UserLastName,p.UserFirstName
                        select p;
            ViewBag.ListUS = user.ToList(); 

            var usrol = from p in _dbContext.TUsRols
                        orderby p.UsRolName
                        where p.UsRolUsId==usrid
                        select p;
            ViewBag.ListUserRol = usrol.ToList(); 

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
            select new TPerson{PerId=0,PerName="--Select Employee"}).Distinct().ToList();
            var resuld = resuld0.Concat(resuld1);
            ViewBag.ddlPerso = new SelectList(resuld.ToList(), "PerId", "PerName"); 


            var resuld2 = from p in _dbContext.TUsRols 
                        orderby p.UsRolName
                        select new TUsRol{UsRolId=p.UsRolId ,UsRolName=p.UsRolName};
            var resuld3 = ( from p in _dbContext.TUsRols  
            select new TUsRol{UsRolId=0,UsRolName="--Select Rol"}).Distinct().ToList();
            var resuldx = resuld3.Concat(resuld2);
            ViewBag.ddlRoles = new SelectList(resuldx.ToList(), "UsRolId", "UsRolName"); 

            SelectList rolesSelectList = new SelectList(DataSource.GetAppRols(), "Code", "Name"); 
            ViewBag.ddlRole =rolesSelectList;


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
                orderby or.OrgId
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
        public IActionResult UserCreate(string actionType) {
            CreateViewBags();
            ViewData["panel"]=5;
            return View();      
        }

        [HttpPost]
        public IActionResult UserCreate(TUser user,string actionType) {
            int id =0;
            ViewData["panel"]=5;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        id = user.UserId;
                        Guid guid = Guid.NewGuid();
                        string re = guid.ToString();
                        string Passw = re.Substring(1,4)+re.Substring(re.Length-5,4) ;
                        string Login = user.UserLoginName;
                        string Fname = user.UserFirstName;
                        string Lname = user.UserLastName;
                        var login = new SqlParameter("@plog", Login);
                        var pass = new SqlParameter("@ppw", Passw);
                        var fname = new SqlParameter("@pfn", Fname);
                        var lname = new SqlParameter("@pln", Lname);
                        var retor = new SqlParameter{                            
                            ParameterName="@ret",
                            SqlDbType=System.Data.SqlDbType.Int,
                            Direction= System.Data.ParameterDirection.Output,
                            Value=0};
                        _dbContext.Database.ExecuteSqlRaw("uspAddUser @plog,@ppw,@pfn,@pln,@ret OUT", login,pass,fname,lname,retor);
                        int mId =(int)retor.Value;
                        //"0" ok
                        //"1" incorrect Throw exception
                        //_dbContext.TUsers.Add(user); 
                        //_dbContext.SaveChanges();
                        CreateViewBags(0,id);    
                        ViewData["panel"]=5;
                        ViewData["Coment"]="PassChanged";
                        ViewData["NewPw"]=Passw;
                        //return View(user);
                        return RedirectToAction("UserEdit", new { id = mId ,panel=5,npassw=Passw});
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags();    
                return View(user);
                }
            }
            CreateViewBags(0,id);    

            return RedirectToAction("Index",new{panel=5});
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

        [HttpGet]
        public IActionResult RolCreate(int usid,string actionType) {
            CreateViewBags(0,usid);
            ViewData["panel"]=2;
            return View();      
        }

        [HttpPost]
        public IActionResult RolCreate(TUsRol rols,int usid,string actionType) {
            ViewData["panel"]=5;
            //int chid=chart.RcharCharId;
            rols.UsRolUsId=usid;
            rols.UsRolDateEnd=System.DateTime.Now;
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TUsRols.Add(rols); 
                        _dbContext.SaveChanges();
                   }
                 catch(Exception ex){
                     string mensaje = ex.Message;
                     return View("Error");}
                 } 
            else {
                CreateViewBags(0,usid);    
                return View(rols);
                }
            }
            CreateViewBags(0,usid);    

            return RedirectToAction("UserEdit",new{id=usid, panel=5});
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

        public IActionResult UserDelete(int id) {
            var mode = _dbContext.TUsers
                .SingleOrDefault(u => u.UserId.Equals(id));
            try{
            _dbContext.TUsers.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags();                
            ViewData["panel"]=5;
            return RedirectToAction("Index",new{panel=5});
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
        public IActionResult RolDelete(int id,int usid) {
            var mode = _dbContext.TUsRols
                .SingleOrDefault(u => u.UsRolId.Equals(id));
            try{
            _dbContext.TUsRols.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            CreateViewBags(0,usid);                
            ViewData["panel"]=5;
            return RedirectToAction("UserEdit",new{id =usid,panel=5});
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
        
        private void managePerChart(int id, int wrem,int PerId,int assign=0)
        {
            try{
                    if (assign==1){ViewData["Assign"]=1;}
                    if (wrem!=0){
                        var mode = _dbContext.TChartRols
                            .SingleOrDefault(u => u.RcharId.Equals(wrem));
                        try{
                        _dbContext.TChartRols.Remove(mode);
                        _dbContext.SaveChanges();
                        }  
                        catch(Exception ex){
                            string mensaje = ex.Message;}          
                        }
                    if (PerId!=0){
                        try{
                         TChartRol author = new TChartRol{ 
                            RcharCharId = id, RcharRolId = PerId };
                        _dbContext.TChartRols.Add(author);
                        _dbContext.SaveChanges();
                        }
                        catch{}
                    }
                }
            catch(Exception ex){
                string mensaje = ex.Message;
            }

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
        public IActionResult CharEdit(int id, int wrem, int wass,int assign, int PerId) {
            ViewData["panel"]=2;
            ViewData["ChartId"]=id;
            if (wrem!=0)
            {
                managePerChart(id,wrem,PerId,assign);  //for remove roles from chart
            }
            try{
            var model = _dbContext.TCharts
                .SingleOrDefault(u => u.CharId.Equals(id));
            CreateViewBags(id);  
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult CharEdit(TChart chart,int id ,int PerId , int wrem, string actionType) {
            if (PerId!=0)
            {
                managePerChart(id,wrem,PerId);     //for assign roles to chart
                CreateViewBags(id);    
                ViewData["panel"]=2;
                return View(chart);
            }

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

        private void manageRolUser(int id, int wrem,string RolCode,int assign=0)
        {
            try{
                    if (assign==1){ViewData["Assign"]=1;}
                    if (wrem!=0){
                        var mode = _dbContext.TUsRols
                            .SingleOrDefault(u => u.UsRolId.Equals(wrem));
                        try{
                        _dbContext.TUsRols.Remove(mode);
                        _dbContext.SaveChanges();
                        }  
                        catch(Exception ex){
                            string mensaje = ex.Message;}          
                        }
                    if (RolCode!=null){
                        try{
                         TUsRol author = new TUsRol{ 
                            UsRolUsId = id, UsRolName = RolCode, UsRolDateEnd=System.DateTime.Now };
                        _dbContext.TUsRols.Add(author);
                        _dbContext.SaveChanges();
                        }
                        catch(Exception ex){
                            string mensaje = ex.Message;
                        }
                    }
                }
            catch(Exception ex){
                string mensaje = ex.Message;
            }

        }

        
        [HttpGet]
        public IActionResult UserEdit(int id, int wrem,string Code,string npassw=null) {
            ViewData["panel"]=5;
            ViewData["UserId"]=id;

            if (wrem!=0)
            {
                manageRolUser(id,wrem,null);  //for remove roles from user
            }
            try{
            var model = _dbContext.TUsers
                .SingleOrDefault(u => u.UserId.Equals(id));
            CreateViewBags(0,id);  
            if (npassw !=null)
            {
                string Passw=npassw;
                ViewData["Coment"]="PassChanged";
                ViewData["NewPw"]=Passw;
            }
            return View(model);
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult UserEdit(TUser user,int id ,int wrem,string Code, string actionType,string npassw=null, string nresetpw=null ) {
            if (Code!=null && Code!="Select_Role")
            {
                manageRolUser(id,0,Code);     //for assign roles to user
                CreateViewBags(0,id);    
                ViewData["panel"]=5;
                return View(user);
            }
            if (actionType=="Cancel"){}
            if (actionType=="Update"){
            if (ModelState.IsValid){
            try{
            int type =1;
            if (nresetpw=="on"){type =2;}
            Guid guid = Guid.NewGuid();
            string re = guid.ToString();
            string Passw = re.Substring(1,4)+re.Substring(re.Length-5,4) ;
            string Login = user.UserLoginName;
            string Fname = user.UserFirstName;
            string Lname = user.UserLastName;
            var pType = new SqlParameter{
                ParameterName="@ptype",
                SqlDbType=System.Data.SqlDbType.Int,
                Value=type};
            var pId = new SqlParameter{
                ParameterName="@pid",
                SqlDbType=System.Data.SqlDbType.Int,
                Value=id};
            var login = new SqlParameter("@plog", Login);
            var pass = new SqlParameter("@ppw", Passw);
            var fname = new SqlParameter("@pfnam", Fname);
            var lname = new SqlParameter("@plnam", Lname);
            var retor = new SqlParameter{                            
                ParameterName="@ret",
                SqlDbType=System.Data.SqlDbType.NVarChar,
                Direction= System.Data.ParameterDirection.Output,
                Value=" "};
            _dbContext.Database.ExecuteSqlRaw("uspUpdUser @pid,@ptype,@plog,@ppw,@pfnam,@plnam,@ret OUT", pId,pType,login,pass,fname,lname,retor);
            string mensaje =(string)retor.Value;
                        //"0" ok
                        //"1" incorrect Throw exception
                        //_dbContext.TUsers.Add(user); 
                        //_dbContext.SaveChanges();
            if (type==2||npassw !=null)
            {
                if (npassw !=null){Passw=npassw;}
                CreateViewBags(0,id);    
                ViewData["panel"]=5;
                ViewData["Coment"]="PassChanged";
                ViewData["NewPw"]=Passw;
                return View(user);
            }
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                return View("Error");}
            } 
            }
            /*
            else {
                CreateViewBags(0,id);    
                ViewData["panel"]=5;
                return View(user);
            }
            */
            CreateViewBags(0,id);    
            ViewData["panel"]=5;

            return RedirectToAction("Index",new{panel=5, FaId=0});
        } 

    }
}