using api_cqrs.Domain.Model;

namespace api_cqrs.Domain.Abstraction
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetAll();
    }
}
