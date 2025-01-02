using System.Diagnostics;
using EmployeeManagement.Models;
using EmployeeManagement.Models.CoreModels;
using EmployeeManagement.Models.DTOModels;
using EmployeeManagement.Tools;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

public class HomeController : Controller
{
    private readonly IWebAppLogger _logger;

    public HomeController(IWebAppLogger logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInfo("+");
        
        _logger.LogInfo("-");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}