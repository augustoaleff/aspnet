using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //return new ContentResult() { Content = "Hello World", ContentType = "text/plain" };
            return View();

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "augustoaleff@gmail.com" && usuario.Senha == "123456")
                {
                    return RedirectToAction("index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos!";
                    return View();
                }
            }
            else
            {
                return View();
            }

            
           
        }
    }

}
