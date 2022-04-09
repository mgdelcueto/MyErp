namespace AspNetCoreMvcSharedLocalization.Controllers
{
    using System;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Localization;
    using Microsoft.AspNetCore.Mvc;

    public class SetLanguageController : Controller
    {
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl,string actionType)
        {
            ViewData["Name"]="LO";//"Modulo"]=99;//88;
            if (actionType=="setdateOK")
            {

            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            //return LocalRedirect(returnUrl);
            return Redirect("~/Account/Languages");
            }
            else{
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
            }
        }
    }
}
