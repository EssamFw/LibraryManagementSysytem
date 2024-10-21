using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories.Members
{
    public interface IMemberRepository
    {
        Task<List<Member>> GetAll();
        Task<Member?> GetMemberbyId(int id);
        Task Add(Member id);

        void update(Member id);
        Task Delete(int id);

        Task SaveChanges();
    }
}
