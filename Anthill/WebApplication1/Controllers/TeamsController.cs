using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helpers.Contracts;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamsRepository teamsRepository;
        private readonly IModelMapper modelMapper;
        public TeamsController(ITeamsRepository teamsRepository, IModelMapper modelMapper)
        {
            this.teamsRepository = teamsRepository;
            this.modelMapper = modelMapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Team> result = teamsRepository.GetAllTeamsSP();
            var resultDto = result.Select(x => this.modelMapper.MapTeamToDto(x)).ToList();
            return View(resultDto);
        }

        [HttpGet]
        public IActionResult TopScorers()
        {
            List<TopScorersSP> result = teamsRepository.GetTopScores();
            return View(result);
        }
        [HttpGet]
        public IActionResult TopConceders()
        {
            List<TopScorersSP> result = teamsRepository.GetTopConceeder();
            return View(result);
        }
    }
}
