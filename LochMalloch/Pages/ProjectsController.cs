using LochMalloch.Classes;
using Microsoft.AspNetCore.Mvc;

namespace LochMalloch.Pages
{
    public class ProjectsController : Controller
    {        
        public IActionResult Index()
        {
            List<Project> projects = new();
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
    }
}
