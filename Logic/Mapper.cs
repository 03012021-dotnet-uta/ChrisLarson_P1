using System.Security.Cryptography;
using System.Text;
using ChrisLarson_P1.Models;
using Models;

namespace ChrisLarson_P1.Logic
{
    public class Mapper
    {
        public Customer GetANewCustomerWithHashedPassword(string passwordString)
        {
            using (var hmac = new HMACSHA512())
            {
                Customer user = new Customer()
                {
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordString)),
                    PasswordSalt = hmac.Key
                };
                return user;
            }
        }

        public byte[] HashThePassword(string password, byte[] key)
        {
            using HMACSHA512 hmac = new HMACSHA512(key: key);

            var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return hashedPassword;
        }        
    }
}