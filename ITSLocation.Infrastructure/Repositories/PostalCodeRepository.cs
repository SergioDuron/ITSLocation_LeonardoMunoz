using ITSLocation.Domain.Entities;
using ITSLocation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSLocation.Infrastructure.Repositories
{
    public class PostalCodeRepository : IPostalCodeRepository
    {
        private readonly List<PostalCode> _postalCodes = new List<PostalCode>
        {
            new PostalCode { Id = 1, Code = "12345", City = "City A", State = "State A" },
            new PostalCode { Id = 2, Code = "67890", City = "City B", State = "State B" }
        };

        public PostalCode GetPostalCode(string code)
        {
            return _postalCodes.FirstOrDefault(p => p.Code == code);
        }
    }
}
