
using ExtentionAppTest.Models;
using ExtentionAppTest.IServices;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ExtentionAppTest.Services
{
    public class UserServices : IUserServices
    {
        HttpClient client;
        public UserServices()
        {
            client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000,
                Timeout = TimeSpan.FromMinutes(10),
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users")
            };
        }
        public Task<List<User>> GetUsers()
        {
            return Task.Run(async() => {

                Uri uri = new Uri(client.BaseAddress, "/users");
                var response = await client.GetAsync(uri);
                List<User> users = new List<User>();
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<User>>(content);

                }
                else
                {
                    return null;
                }

            });
        }

        public Task<User> GetUserById(int id)
        {
            return Task.Run(() => {
                User user = new User() {
                    id = 5,
                    name = "Chelsey Dietrich",
                    username = "Kamren",
                    email = "Lucio_Hettinger@annie.ca",
                    address = new Address() {
                        street = "Skiles Walks",
                        suite = "Suite 351",
                        city = "Roscoeview",
                        zipcode = "33263",
                        geo = new Geo() {
                            lat= "-31.8129",
                            lng= "62.5342"
                        }
                    },
                    phone = "(254)954 - 1289",
                    website = "demarco.info",
                    company = new Company() {
                        name = "Keebler LLC",
                        catchPhrase = "User-centric fault-tolerant solution",
                        bs = "revolutionize end-to-end systems"
                    }
                };


                return user;
            });
        }
    }
}
