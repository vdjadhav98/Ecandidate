using evoting.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace evoting.Services.CandidateService
{
    public class CandidateService : ICandidateService
    {
        public static readonly List<Candidate> candidates = new List<Candidate>()
       {
           new Candidate{ CandidateId="c1", CandidateEmail="c1@gmail.com",
               CandidateMobile=9876543210, CandidateName="xyz"
         }
        };

        public async Task<IEnumerable<Candidate>> GetCandidates()
        {
            return candidates;
        }

        public async Task<Candidate> CreateCandidate(Candidate candidateObj)
        {
            candidates.Add(candidateObj);

            return candidateObj;
        }
    }
}
