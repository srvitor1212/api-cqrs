using api_cqrs.Domain.Abstraction;

namespace api_cqrs.Domain.Model
{
    public class Member : IMemberRepository
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }

        public Task<IEnumerable<Member>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
