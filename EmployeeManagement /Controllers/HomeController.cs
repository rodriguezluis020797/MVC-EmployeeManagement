using System.Diagnostics;
using EmployeeManagement.Models;
using EmployeeManagement.Models.DTOModels;
using EmployeeManagement.Models.ViewModels;
using EmployeeManagement.Services;
using EmployeeManagement.Tools;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers;

public class HomeController : Controller
{
    private readonly IEmployeeService _employeeService;
    private readonly IWebAppLogger _logger;
    private readonly ISupervisorService _supervisorService;

    public HomeController(IWebAppLogger logger, ISupervisorService supervisorService, IEmployeeService employeeService)
    {
        _logger = logger;
        _supervisorService = supervisorService;
        _employeeService = employeeService;
    }

    public IActionResult Index()
    {
        _logger.LogInfo("+");
        var supervisorDto = new SupervisorModelDTO();
        var employeeDto = new EmployeeModelDTO();
        var viewModel = new HomeViewModel();

        try
        {
            supervisorDto.AssignObject(_supervisorService.GetSupervisor());
            viewModel.Supervisor = supervisorDto;
            _logger.LogInfo($"SupervisorId: {supervisorDto.SupervisorId}");


            foreach (var employee in _employeeService.GetEmployees())
            {
                employeeDto = new EmployeeModelDTO();
                employeeDto.AssignObject(employee);
                _logger.LogInfo($"EmployeeId: {employeeDto.EmployeeId}");
                viewModel.Employees.Add(employeeDto);
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.ToString());
            _logger.LogInfo("-");
            return RedirectToAction("Error");
        }

        _logger.LogInfo("-");
        return View(viewModel);
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