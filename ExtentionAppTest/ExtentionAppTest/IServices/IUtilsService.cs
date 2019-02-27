using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionAppTest.IServices
{
    public interface IUtilsService
    {
        Task<bool> CheckInternet();
    }
}
