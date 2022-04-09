using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyErp.Models;

namespace MyErp.Controllers
{
    public class Account : Controller
    {
        private readonly MyErpDBContext _dbContext;
        private readonly ILogger<Account> _logger;

        public Account(MyErpDBContext dbContext,ILogger<Account> logger)
        {
            _dbContext = dbContext;
            _logger = (ILogger<Account>)logger;
        }
        public IActionResult  Noauthorized(string ReturnUrl)
        {
            ViewData["link"]=ReturnUrl;
            ViewData["Name"]="NA";
            return View();
        }

        public IActionResult  Forbidden(string ReturnUrl)
        {
            ViewData["link"]=ReturnUrl;
            //ViewData["Name"]="FO";
            return View();
        }
        public IActionResult  Languages()
        {
            ViewData["Name"]="NM"; //"Modulo"=99;
            return View(new{mensaje="NM"});

        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Name"]="NM"; 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string UserName, string Password,string actionType)
        {
            if (actionType=="Login")
            {
            if (UserName ==null ||UserName=="" ||Password =="" ||Password==null)
            {return View();}
            try{        
                        string Passw = Password;
                        string Login = UserName;
                        int Perem = 90;  //90 dias de perempcion de la contraseña
                        var login = new SqlParameter("@p0", Login);
                        var pass = new SqlParameter("@p1", Passw);
                        var perem = new SqlParameter{
                            ParameterName= "@p2", 
                            SqlDbType=System.Data.SqlDbType.Int,
                            Value= Perem};
                        var retor = new SqlParameter{                            
                            ParameterName="@ret",
                            SqlDbType=System.Data.SqlDbType.Int,
                            Direction= System.Data.ParameterDirection.Output,
                            Value=0};
                        var iretor = new SqlParameter{                            
                            ParameterName="@iret",
                            SqlDbType=System.Data.SqlDbType.Int,
                            Direction= System.Data.ParameterDirection.Output,
                            Value=0};
                        _dbContext.Database.ExecuteSqlRaw("dbo.uspLogin @p0,@p1,@p2,@ret OUT,@iret OUT",login,pass,perem, retor, iretor);
                        int mId =(int)retor.Value;
                        //">0" correct
                        //"-1" incorrect
                        //"-2" change password
                        //"-3" invalid username
                        switch (mId){
                            case -1:
                                break;
                            case -2:
                                break;
                            case -3:
                                break;
                            case 0:
                                break;
                            default:
                            {
                            var user = (from p in _dbContext.TUsers
                            orderby p.UserLastName,p.UserFirstName
                            where p.UserId==mId select p).SingleOrDefault();

                            var usrol = (from p in _dbContext.TUsRols
                            orderby p.UsRolName
                            where p.UsRolUsId==mId
                            select p).ToList();
                            //get the default culture info of the user

                            var claims = new List<Claim>
                            {
                                new Claim("UserId", mId.ToString()),
                                new Claim("UserName", UserName),
                                new Claim(ClaimTypes.Name, UserName),
                                new Claim("FullName", user.UserLastName+" "+user.UserFirstName),
                            };
                            int ind =3;
                            foreach(var c in usrol){
                                claims.Insert(ind,new Claim(ClaimTypes.Role,c.UsRolName));
                                ind = ind +1;
                            }

                            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                            var authProperties = new AuthenticationProperties
                             {
                            };

                            await HttpContext.SignInAsync(
                                CookieAuthenticationDefaults.AuthenticationScheme, 
                                new ClaimsPrincipal(claimsIdentity), 
                                authProperties);
                            break;
                            }
                        }
            }
            catch(Exception ex){
                string mensaje = ex.Message;
                ViewData["Error"]=mensaje;
                return RedirectToAction("Index", "Errores",new{mensaje=mensaje});
            }
            }
            ViewData["Name"]="LO";
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        //reemplazamos esto y ahora no solicita confirmacion de logout
        //{
        //    ViewData["Name"]="LO";
        //    return View();
        //}
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> LogOut(string UserName,string actionType)
        {
            if (actionType=="Go")
            {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            //return View();
            }
            return RedirectToAction("Index", "Home");
        }
        
        [HttpGet]
        public IActionResult ChLogin()
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(
                x => x.Type == "UserId")?.Value;
            ViewData["UserId"]=userId;
            /*
            var claims = new List<Claim>
                {
                new Claim(ClaimTypes.Name, "email"),
                new Claim("LastChanged", "")
                };

            var claimsIdentity = new ClaimsIdentity(
                claims, 
                CookieAuthenticationDefaults.AuthenticationScheme);

            
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, 
                new ClaimsPrincipal(claimsIdentity));
            
            //Get the current claims principal
            //var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;

            // Get the claims values
            var name = claimsIdentity.Claims.Where(c => c.Type == ClaimTypes.Name)
                               .Select(c => c.Value).SingleOrDefault();
            var sid = claimsIdentity.Claims.Where(c => c.Type == ClaimTypes.Sid)
                               .Select(c => c.Value).SingleOrDefault();
            */
            return View();
        }
        
        [HttpPost]
        public IActionResult ChLogin(int uid, string UserName, string Password, string NPassword, string RPassword, string actionType)
        {
            if (actionType=="Go")
            {
            if (UserName ==null ||UserName=="" ||Password =="" ||Password==null||NPassword=="" ||NPassword==null ||RPassword==""||RPassword==null)
            {return View();}
                //Try to login with old password
                        string Passw = Password;
                        string Login = UserName;
                        int Perem = 90;  //90 dias de perempcion de la contraseña
                        var login = new SqlParameter("@p0", Login);
                        var pass = new SqlParameter("@p1", Passw);
                        var perem = new SqlParameter{
                            ParameterName= "@p2", 
                            SqlDbType=System.Data.SqlDbType.Int,
                            Value= Perem};
                        var retor = new SqlParameter{                            
                            ParameterName="@ret",
                            SqlDbType=System.Data.SqlDbType.Int,
                            Direction= System.Data.ParameterDirection.Output,
                            Value=0};
                        var iretor = new SqlParameter{                            
                            ParameterName="@iret",
                            SqlDbType=System.Data.SqlDbType.Int,
                            Direction= System.Data.ParameterDirection.Output,
                            Value=0};
                        _dbContext.Database.ExecuteSqlRaw("dbo.uspLogin @p0,@p1,@p2,@ret OUT ,@iret OUT",login,pass,perem, retor,iretor);
                        int mes =(int)retor.Value;
                        //">0" correct
                        //"-1" incorrect
                        //"-2" change password
                        //"-3" invalid username

            if (mes>=0)
                {
                    int mId =(int)iretor.Value;
                    if (mId>0||mId==-2)
                        {
                            if (NPassword==RPassword)
                                {
                                    int type = 0;
                                    string nPassw = NPassword ;
                                    string nLogin = "";
                                    string nFname = "";
                                    string nLname = "";
                                    var pType = new SqlParameter{
                                        ParameterName="@ptype",
                                        SqlDbType=System.Data.SqlDbType.Int,
                                        Value=type};
                                    var pId = new SqlParameter{
                                        ParameterName="@pid",
                                        SqlDbType=System.Data.SqlDbType.Int,
                                        Value=mId};
                                    var nlogin = new SqlParameter("@plog", nLogin);
                                    var npass = new SqlParameter("@ppw", nPassw);
                                    var nfname = new SqlParameter("@pfnam", nFname);
                                    var nlname = new SqlParameter("@plnam", nLname);
                                    var nretor = new SqlParameter{                            
                                        ParameterName="@ret",
                                        SqlDbType=System.Data.SqlDbType.NVarChar,
                                        Direction= System.Data.ParameterDirection.Output,
                                        Value=" "};
                                    _dbContext.Database.ExecuteSqlRaw("uspUpdUser @pid,@ptype,@plog,@ppw,@pfnam,@plnam,@ret OUT", pId,pType,nlogin,npass,nfname,nlname,nretor);
                                    string mensaje =(string)nretor.Value;
                                        //"0" ok
                                        //"1" incorrect Throw exception
                                        //_dbContext.TUsers.Add(user); 
                                        //_dbContext.SaveChanges();
                                }
                            else{
                                ViewData["Coment"]="PassNoMatch";
                                return View();
                                }
                        }
                    //else{
                    //    return RedirectToAction("Index", "Home");
                    //    //ViewData["Coment"]="SomeErrorOccurred";
                    //    //return View();
                    //    }
                }
                    //return RedirectToAction("Index", "Home"); // RedirectToAction("Login", "Account");
            else{
                ViewData["Coment"]="SomeErrorOccurred";
                return View();
                }
            }
            ViewData["Name"]="LO";
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
        }
/*
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
*/
        [HttpGet]
        public IActionResult Privacy()
        {
            ViewData["Name"]="NM";
            return View(new{mensaje="NM"});
        }

        [HttpPost]
        public IActionResult Privacy(string actionType)
        {
            ViewData["Name"]="LO";//"Modulo"]=99;//88;
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
        }


        public IActionResult Index()
        {
            return View();
        }
/*
        public IActionResult Privacy()
        {
            return View();
        }
*/
        public IActionResult Journal()
        {
            return View();
        }
        public IActionResult Months()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
