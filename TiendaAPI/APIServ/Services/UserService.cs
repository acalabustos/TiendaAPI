﻿using APIServ.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

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
            return userItem.Id;
        }
        public List<UserItem> GetAllUser()
        {
            return _userLogic.GetAllUser();

        }
        public void DeleteUser(int id) 
        {
            _userLogic.DeleteUserItem(id);
        }
        public void UpdateUser(int id)
        {
            _userLogic.UpdateUserItem(id);
        }    

    }
}





