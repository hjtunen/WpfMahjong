using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMahjong
{
    internal class UserDetailsSingleton
    {
        public string Username { get; set; }
        private static UserDetailsSingleton instance;

        private UserDetailsSingleton() { }

        public static UserDetailsSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDetailsSingleton();
                }
                return instance;
            }
        }
    }
}
