using LochMalloch.Models;
using Microsoft.AspNetCore.Mvc;

namespace LochMalloch.Controllers
{
    public class ProjectsController : Controller
    {        
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            List<ProjectModel> projects = new();
            projects.Add(new()
            {
                Name = "Project 1",
                Description = "A very interesting project"
            });

            projects.Add(new()
            {
                Name = "Project 2",
                Description = "Omg why isn't this the first one! It's so much better! Wow!"
            });
            
            return View(projects);
        }

        [Route("Home/Welcome")]
        public string Welcome() 
        {
            return "Welcome!";
        }
    }
}
