using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Windows.Data;

namespace DotNet_Deserialization.Controllers
{
    public class Feedback : Controller
    {
        public Feedback()
        {
        }

        // GET: /Feedback/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Index()
        { 
            return View();
        }

        //POST: /Feedback/Insecure/
        [HttpPost]
        public IActionResult Insecure([FromBody] Info value)
        {
            if (value == null)
            {
                return NotFound();
            }

            ViewData["Name"] = value.Name;
            ViewData["Email"] = value.Email;
            ViewData["Comments"] = value.Comments;

            dynamic instance = value.Comments;
            string temp = "Temp";

           
            if(!(Object.ReferenceEquals(temp.GetType(), instance.GetType())))
            {
                ViewData["Message"] = "Close enough, If you are an Instance of a well-known Class, I can help to run your \"Start\" Method provided it is been passed as your Name";
                if (value.Name.Equals("Start"))
                    { instance.Start(); }
            }
            
            return View();
        }
    }
}
