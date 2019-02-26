
using System;
using ExtentionAppTest.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace ExtentionAppTest.IServices
{
    public interface IUserServices
    {

        Task<List<User>> GetUsers();
        Task<User> GetUserById(int id);

    }
}
