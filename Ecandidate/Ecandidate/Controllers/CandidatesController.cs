using evoting.Models;
using evoting.Services.CandidateService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace evoting.Controllers
{
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        [Route("api/[controller]/GetCandidates")]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidates()
        {
            return (await _candidateService.GetCandidates()).ToList();
        }

        [HttpPost]
        [Route("api/[controller]/CreateCandidate")]
        public async Task<ActionResult<Candidate>> CreateCandiate(Candidate candidate)
        {
            if (ModelState.IsValid == true)
            {
                var candidateToCreate = await _candidateService.CreateCandidate(candidate);
                return Ok(candidateToCreate);
            }
            else
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }
        }
    }
}
