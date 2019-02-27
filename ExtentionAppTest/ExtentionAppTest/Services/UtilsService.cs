using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExtentionAppTest.IServices;
using Xamarin.Essentials;

namespace ExtentionAppTest.Services
{
    class UtilsService : IUtilsService
    {
        public Task<bool> CheckInternet()
        {
            return Task.Run(() => {
                var NA = Connectivity.NetworkAccess;

                if (NA == NetworkAccess.Internet)
                {
                    return true;
                }
                else
                    return false;
            });

        }
    }
}
