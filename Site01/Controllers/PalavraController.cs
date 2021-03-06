﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index()
        {
           // ViewBag.Palavras = _db.Palavras.ToList();
            var palavras = _db.Palavras.ToList();
            //return View();
            return View(palavras);
        }

        //CRUD - Create, Retrieve, Update, Delete
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            return View();

        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View("Cadastrar");

        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            return View("Cadastrar");

        }

        //Palavra/Exlcuir/42554
        //{Controller}/{Action}/{Id}
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            return RedirectToAction("Index");
        }
    }
}