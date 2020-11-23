using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using TesteRequisitoApiNotifications.Models;
using TesteRequisitoApiNotifications.Services;

namespace TesteRequisitoApiNotifications.Controllers
{
    public class HomeController : Controller
    {
        private readonly ServiceAluno _serviceAluno;

        public HomeController(ServiceAluno serviceAluno)
        {
            _serviceAluno = serviceAluno;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _serviceAluno.ListarAlunos();
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag["ERROR"] = ex.Message;
                return View();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AlunoCadastro alunoCadastro)
        {
            try
            {
                await _serviceAluno.AdicionarAluno(alunoCadastro);
            }
            catch (Exception ex)
            {
                var messages = JsonSerializer.Deserialize<IEnumerable<ErrorMessage>>(ex.Message);

                ViewBag["ERROR"] = messages;
                return View();
            }

            return RedirectToAction(nameof(Index));
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
}
