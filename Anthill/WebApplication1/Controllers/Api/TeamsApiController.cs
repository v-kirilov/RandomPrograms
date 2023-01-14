using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helpers.Contracts;
using WebApplication1.Models;
using WebApplication1.Models.Dto;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Controllers.Api
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsApiController : ControllerBase
    {
        private readonly ITeamsRepository teamsRepository;
        private readonly IModelMapper modelMapper;


        public TeamsApiController(ITeamsRepository teamsRepository, IModelMapper modelMapper)
        {
            this.modelMapper = modelMapper;
            this.teamsRepository = teamsRepository;
        }

        [HttpGet("")]
        public IActionResult GetTeams()
        {
            List<Team> result = teamsRepository.GetAllTeamsSP();
            var resultDto = result.Select(x => this.modelMapper.MapTeamToDto(x)).ToList();
            return StatusCode(StatusCodes.Status200OK, resultDto);
        }


        [HttpGet("TopScorer")]
        public IActionResult GetTopScorer()
        {
            List<TopScorersSP> result = teamsRepository.GetTopScores();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        [HttpGet("TopConceeder")]
        public IActionResult GetTopConceeder()
        {
            List<TopScorersSP> result = teamsRepository.GetTopConceeder();
            return StatusCode(StatusCodes.Status200OK, result);
        }
        [HttpGet("{teamId}")]

        public IActionResult GetTeamById(int teamId)
        {
           var result = teamsRepository.GetById(teamId);
            var resultDto = result.Select(x => this.modelMapper.MapTeamToDto(x)).ToList();
            return StatusCode(StatusCodes.Status200OK, resultDto);
        }


    }
}
