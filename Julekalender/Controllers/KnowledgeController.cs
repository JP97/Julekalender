using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Julekalender.Data;
using Julekalender.Models;
using Julekalender.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Julekalender.Controllers
{
    public class KnowledgeController : Controller
    {
        private readonly JulekalenderContext _context;
        private readonly KnowledgeApi api = new KnowledgeApi();

        public KnowledgeController(JulekalenderContext context)
        {
            _context = context;

            if (!_context.knowledges.Any())
            {
                _context.knowledges.AddRange(api.GetKnowledges());
                _context.SaveChangesAsync();
            }
        }
        public IActionResult Index()
        {
            return View(_context.knowledges.ToList());
        }
    }
}