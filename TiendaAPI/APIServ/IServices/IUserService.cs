using Entities.Entities;

namespace APIServ.IServices
{
    public interface IUserService
    {
        List<UserItem> GetAllUser();
        int InsertUser(UserItem userItem);
        void UpdateUser(int id);
        void DeleteUser(int id);
    }
}
