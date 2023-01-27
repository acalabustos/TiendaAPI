using APIServ.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace APIServ.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.IdUser;
        }
    }
}
