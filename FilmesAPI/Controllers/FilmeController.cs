﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public List<Filme> RecuperaFilme()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RetornaFilme(int id)
        {
            //foreach (Filme filme in filmes)
            //{
            //    if (filme.Id == id)
            //        return filme;
            //}
            //return null;

            return filmes.FirstOrDefault<Filme>(filme => filme.Id == id);
        }

    }
}
