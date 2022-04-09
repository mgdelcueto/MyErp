namespace AspNetCoreMvcSharedLocalization.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Localization;
    using Microsoft.AspNetCore.Mvc;

    public class SetPrivacyController : Controller
    {
        [HttpPost]
        public IActionResult SetPrivacy(string actionType)
        {
            ViewData["Name"]="LO";//"Modulo"]=99;//88;
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
        }
    }
}
