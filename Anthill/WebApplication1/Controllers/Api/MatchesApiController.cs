using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helpers.Contracts;
using WebApplication1.Models;
using WebApplication1.Repositories.Contracts;

namespace WebApplication1.Controllers.Api
{
    [Route("api/matches")]
    [ApiController]
    public class MatchesApiController : ControllerBase
    {
        private readonly IMatchesRepository matchesRepository;
        private readonly IModelMapper modelMapper;

        public MatchesApiController(IMatchesRepository matchesRepository,IModelMapper modelMapper)
        {
            this.matchesRepository = matchesRepository;
            this.modelMapper = modelMapper;
        }

        [HttpGet("")]
        public IActionResult GetMatches()
        {

            List<Match> result = matchesRepository.GetAllMatches();
            var resultDto = result.Select(x => this.modelMapper.MapMatchToDto(x)).ToList();
            return StatusCode(StatusCodes.Status200OK, resultDto);
        }

        [HttpGet("Top")]
        public IActionResult GetTopMatch()
        {
            var result = matchesRepository.GetTopScoredMatch();
            return StatusCode(StatusCodes.Status200OK, result);
        }

    }
}
