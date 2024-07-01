using ITSLocation.Domain.Entities;
using ITSLocation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSLocation.Application.Services
{
    public class PostalCodeService
    {
        private readonly IPostalCodeRepository _postalCodeRepository;

        public PostalCodeService(IPostalCodeRepository postalCodeRepository)
        {
            _postalCodeRepository = postalCodeRepository;
        }

        public PostalCode GetPostalCode(string code)
        {
            return _postalCodeRepository.GetPostalCode(code);
        }
    }
}
