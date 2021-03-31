using System;
using ChrisLarson_P1.Models;
using ChrisLarson_P1.Logic;
using ChrisLarson_P1.Repository;

namespace ChrisLarson_p1.Logic
{
    public class UserMethods
    {
        private readonly TreeShopRepo _repolayer;
        private readonly Mapper mapper = new Mapper();

        public UserMethods() { }
        public UserMethods(TreeShopRepo repolayer)
        {
            this._repolayer = repolayer;
        }

        ///<summary>
        ///This method takes a user and returns a verified user, if it exists.
        ///</summary>
        ///<param name="user"></param>
        ///<returns></returns>
        public Customer Login(Customer user)
        {
            Customer user1 = _repolayer.Login(user);

            return user1;
        }

        public Customer Register(RawCustomer rawCustomer)
        {
            if (_repolayer.UserExists(rawCustomer.Username) == true)
            {
                return null;
            }else{
                Customer newCustomer = mapper.GetANewCustomerWithHashedPassword(rawCustomer.Password);

                newCustomer.Fname = rawCustomer.Fname;
                newCustomer.Lname = rawCustomer.Lname;
                newCustomer.Username = rawCustomer.Username;
                Customer registeredCustomer = _repolayer.Register(newCustomer);
                return registeredCustomer;
            }
        }

        public Customer Login(string username, string password)
        {
            if(_repolayer.UserExists(username) == false)
            {
                return null;
            }else{
                Customer foundCustomer = _repolayer.GetCustomerByUsername(username);
                byte[] hash = mapper.HashThePassword(password, foundCustomer.PasswordSalt);

                if (CompareTwoHashes(foundCustomer.PasswordHash, hash))
                {
                    return foundCustomer;
                }else{
                    return null;
                } 
            }
        }

        public bool CompareTwoHashes(byte[] arr1, byte[] arr2)
        {
            if(arr1.Length != arr2.Length){
                return false;
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}