﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using MySql.Data.MySqlClient;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            dbs.CadastraInteresse(cad);
            try
            {
                dbs.CadastraInteresse(cad);
            }
            catch (MySqlException m)
            {
                _logger.LogError("Erro do MySql: " + m.Message);
            }
            catch(Exception e)
            {
                _logger.LogError("Erro no cadastro: " + e.Message);
            }
            return View("Index",cad);
        }

    }
}
