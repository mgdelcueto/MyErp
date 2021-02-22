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
    public class Errores : Controller
    {
        private readonly MyErpDBContext _dbContext;
        private readonly ILogger<Account> _logger;

        public Errores(MyErpDBContext dbContext,ILogger<Account> logger)
        {
            _dbContext = dbContext;
            _logger = (ILogger<Account>)logger;
        }
        public IActionResult Index(string mensaje)
        {
            ViewData["Error"]=mensaje;
            return View();
        }

    }
}