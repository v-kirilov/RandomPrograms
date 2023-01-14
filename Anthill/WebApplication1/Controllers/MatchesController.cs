using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helpers.Contracts;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Controllers
{
    public class MatchesController : Controller
    {
        
        private readonly IMatchesRepository matchesRepository;
        private readonly IModelMapper modelMapper;
        public MatchesController(IMatchesRepository matchesRepository, IModelMapper modelMapper)
        {
            this.matchesRepository = matchesRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult TopMatch()
        {
              var result = matchesRepository.GetTopScoredMatch();
            return View(result);
        }
    }
}
