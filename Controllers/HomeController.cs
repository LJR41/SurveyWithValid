using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyWithValid.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("survey")]
    public IActionResult Survey()
    {
        return View("Survey");
    }

    [HttpGet("display")]
    public ViewResult Display()
    {
        return View("Display");
    }

    [HttpPost("survey/create")]
    public IActionResult CreateSurvey(Survey s)
    {
        if (ModelState.IsValid)
        {
            return View("Display",s);
        }
        return View("survey");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

