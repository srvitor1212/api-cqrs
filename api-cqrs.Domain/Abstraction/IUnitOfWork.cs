namespace api_cqrs.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        IMemberRepository MemberRepository { get; }
        Task CommitAsync();
    }
}
