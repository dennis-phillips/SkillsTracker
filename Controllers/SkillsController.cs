using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet("/skills/")]
        public IActionResult Index()
        {
            string html = "<h1><b>Skills Tracker</b></h1>" +
                "<h2><b>Coding skills to learn</b></h2>" +
                " <ol>" +
                "<li>C#</li>" +
                "<li>Javascript</li>" +
                "<li>Python</li>";
            return Content(html, "text/html");
        }
        [HttpGet("/skills/form/")]
        public IActionResult Form()
        {
            string html = "<form method = 'post' action = '/skills/form'>" +
                "<label><b>Start Date:</b></label>" +
                "<br>" +
                "<input type='date' name = 'date'>" +
                "<br>" +
                "<label><b>C#:</b></label>" +
                "<br>" +
                "<select name = 'csharp'>" +
                 "<option value=''>--Please choose an option--</option> " +
                  "<option value='Learning Basics! '> Learning Basics </option> " +

                 "<option value='Making Apps! '> Making Apps</option> " +

                 "<option value='Master Coder'> Master Coder </option> " +
                 "</select>" +
                 "<br>" +
                  "<label><b>Javascript:</b></label>" +
                "<br>" +
                "<select name = 'javascript'>" +
                 "<option value=''>--Please choose an option--</option> " +
                  "<option value='Learning Basics! '> Learning Basics </option> " +

                 "<option value='Making Apps! '> Making Apps</option> " +

                 "<option value='Master Coder'> Master Coder </option> " +
                 "</select>" +
                 "<br>" +
                  "<label><b>Python:</b></label>" +
                "<br>" +
                "<select name='python'>" +
                 "<option value=''>--Please choose an option--</option> " +
                  "<option value='Learning Basics! '> Learning Basics </option> " +

                 "<option value='Making Apps! '> Making Apps</option> " +

                 "<option value='Master Coder'> Master Coder </option> " +
                 "</select>" +
                  "<input type='submit' value = 'Whatever'/>" +
                 "</form>";
                 
            return Content(html, "text/html");
        }
        [HttpPost("/skills/form/")]
        public IActionResult InputResults(string date, string csharp, string javascript, string python)
        {
            string html = $"<h1><b>{date}</b></h1>" +
                " <ol>" +
                $"<li>C#: {csharp}</li>" +
                $"<li>Javascript: {javascript}</li>" +
                $"<li>Python: {python}</li>";
            return Content(html, "text/html");
        }
    }
}
