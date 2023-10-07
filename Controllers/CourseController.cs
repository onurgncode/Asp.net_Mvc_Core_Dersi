using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers;

public class CourseController : Controller
{
    public IActionResult index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult index(Candidate model)
    {
        return View();
    }
}
