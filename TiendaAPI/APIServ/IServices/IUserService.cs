using Entities.Entities;

namespace APIServ.IServices
{
    public interface IUserService
    {
        int InsertUser(UserItem userItem);
    }
}
