using ITSLocation.Domain.Entities;

namespace ITSLocation.Domain.RepositoryInterfaces
{
    public interface IPostalCodeRepository
    {
        PostalCode GetPostalCode(string code);
    }
}
