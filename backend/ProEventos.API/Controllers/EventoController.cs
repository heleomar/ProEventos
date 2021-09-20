using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
          new Evento()
          {
                EventoId = 1,
                Tema = "Antular 11 e .NET 5",
                Local = "BH",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Lote = "1ª Lote",
                ImagemURL = "foto.png",
            },
          new Evento()
          {
                EventoId = 2,
                Tema = "JS e Novidades",
                Local = "SP",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Lote = "3ª Lote",
                ImagemURL = "foto.png",
            },

        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;


        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);


        }
    }
}
