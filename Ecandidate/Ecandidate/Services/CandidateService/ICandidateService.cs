using evoting.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace evoting.Services.CandidateService
{
    public interface ICandidateService
    {
        public Task<IEnumerable<Candidate>> GetCandidates();
        public Task<Candidate> CreateCandidate(Candidate candidateObj);
    }
}
