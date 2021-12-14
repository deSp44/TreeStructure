using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using TreeStructure.Application.Interfaces;
using TreeStructure.Domain.Models;

namespace TreeStructure.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMainService _mainService;

        public HomeController(ILogger<HomeController> logger, IMainService mainService)
        {
            _logger = logger;
            _mainService = mainService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var nodeElements = _mainService.GetAllElements().ToList();
            return View(nodeElements);
        }

        [HttpGet]
        public ActionResult<List<NodeElement>> GetData()
        {
            var nodeElements = _mainService.GetAllElements().ToList();
            return nodeElements;
        }

        [HttpPost]
        public IActionResult AddNode([FromBody]NodeElement element)
        {
            _mainService.AddNewElement(element);
            return Ok();
        }

        [HttpPut]
        public IActionResult EditNode([FromBody]NodeElement editElement)
        {
            var nodeId = editElement.id;
            var newName = editElement.name;

            var isSucceded =  _mainService.EditElement(nodeId, newName);
            if (isSucceded)
                return Ok();
            return BadRequest();

        }

        [HttpDelete]
        public IActionResult DeleteNode([FromBody]int nodeId)
        {
            var isSucceded = _mainService.DeleteElement(nodeId);
            if (isSucceded)
                return Ok();
            return BadRequest();
        }

        [HttpPost]
        public IActionResult ChangeNode([FromBody]NodeElement editElement)
        {
            var nodeId = editElement.id;
            var nodeParentId = editElement.parentId;

            var isSucceded = _mainService.ChangeNode(nodeId, nodeParentId);
            if (isSucceded)
                return Ok();
            return BadRequest();
        }
    }
}
