using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Entities;
using backend.IServices;
using backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlinkerController : ControllerBase
    {
        private readonly IVerifyBlinkerService _verifyBlinkerService;
        public BlinkerController(IVerifyBlinkerService verifyBlinkerService)
        {
            _verifyBlinkerService = verifyBlinkerService;
        }
        [HttpPost]
        public ActionResult postCommand([FromBody] BlinkerCommandModel model)
        {
            if (_verifyBlinkerService.AddCommand(model).Result)
                return Ok();
            return NotFound("Ia la mumu");
        }

        [HttpGet]
        public List<Commands> getAll()
        {
            return _verifyBlinkerService.GetAllCommands();
        }
    }
}
