using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Luna.Recruitment.VisaProcessing.Data.Models;
using Luna.Contracts;
using Microsoft.AspNetCore.Authorization;
using Luna.Recruitment.VisaProcessing.DTO;
using Luna.Recruitment.VisaProcessing.Data.DTO;

namespace Luna.Recruitment.VisaProcessing.Web.Controllers
{
    //[Authorize(Roles = "Administrator")]
    public class DatatableController : Controller
    {
        private readonly lunaContext _context;
        private readonly ILoggerManager _logger;
        public DatatableController(lunaContext context, ILoggerManager logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoadData([FromBody] DataTableAjaxPostModel model)
        {
            var draw = model.draw;
            var start = model.start;
            var length = model.length;
            var searchValue = model.search.value;
            var recordsTotal = await _context.Agent.CountAsync(); // Replace with your entity

            var data = await _context.Agent
                .Where(e => e.Name.Contains(searchValue))
                .Skip(start)
                .Take(length)
                .ToListAsync();
            return Json(new
            {
                draw = draw,
                recordsFiltered = recordsTotal,
                recordsTotal = recordsTotal,
                data = data
            });
        }
       
    }
}
