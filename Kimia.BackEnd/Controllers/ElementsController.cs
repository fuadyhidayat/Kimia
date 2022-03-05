using Microsoft.AspNetCore.Mvc;
using Kimia.BackEnd.Entities;

namespace Kimia.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElementsController
    {
        private readonly ChemistryDbContext _context;

        public ElementsController(ChemistryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Element>> GetElements()
        {
            return _context.Elements;
        }
    }
}
