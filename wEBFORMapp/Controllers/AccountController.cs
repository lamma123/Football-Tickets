using Microsoft.AspNetCore.Mvc;
using wEBFORMapp.Models;
namespace wEBFORMapp.Controllers
{
    public class AccountController : Controller
    {

        [HttpPost ("/login")]
        
        public IActionResult Index(Account acc )
        {
            Prn211ProjectContext projectContext = new Prn211ProjectContext ();  
            Account account= projectContext.Accounts.FirstOrDefault (x=>x.Username==acc.Username);
            if (account==null|| !account.Password.Equals(acc.Password))
            {
                ViewBag.Message = "sai pass or username";  return View();
            }
            else 
            {
                HttpContext.Session.SetString("username", account.Username);



                if (account.Role == 0)
                {
                return RedirectToAction("Index" ,"Admin" );

                }
                else
                {
                    return RedirectToAction("Index", "User2");
                }


            }
            
              
        }
        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/home/index");
        }
        [HttpGet ("/account/login")]

        public IActionResult Index() {
            return View();
        }
    }
}
