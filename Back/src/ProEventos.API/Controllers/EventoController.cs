using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento {
                EventoId = 1, 
                Tema = "Angular 11", 
                Local = "São Paulo", 
                Lote = "1° Lote",
                QtdPessoas = 250, 
                ImageURL = "foto-angular-11.png",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyy")
            }, 
             new Evento {
                EventoId = 2, 
                Tema = "Angular 11 + ASP NET CORE 6", 
                Local = "São Paulo", 
                Lote = "1° Lote",
                QtdPessoas = 250, 
                ImageURL = "foto-angular-11-aspnet-core-5.png",
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/mm/yyy")
            }, 
             new Evento {
                EventoId = 3, 
                Tema = "Entity Framework Core", 
                Local = "São Paulo", 
                Lote = "1° Lote",
                QtdPessoas = 250, 
                ImageURL = "foto-entity-framework.png",
                DataEvento = DateTime.Now.AddDays(10).ToString("dd/mm/yyy")
            }, 

        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Retorno da API POST: " + DateTime.Now;
        }
    
    }
}
