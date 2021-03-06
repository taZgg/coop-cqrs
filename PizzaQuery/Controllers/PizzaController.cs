using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaQuery.Models;
using PizzaQuery.Services;
using System;
using System.Threading.Tasks;

namespace PizzaQuery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
        }

        [HttpGet]
        public Task<string> Getdata()
        {
            return PizzaService.Receive();
        }

        [HttpGet("{id}")]
        public Task<string> GetdataOne(int id)
        {
            return PizzaService.ReceiveOne(id);
        }

        [HttpPost]
        public IActionResult Received(Pizza newPizza)
        {
            PizzaService.Add(newPizza);
            return CreatedAtAction(nameof(Received), null);
        }
    }
}
