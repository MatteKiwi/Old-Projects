using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_server
{  
    public class Pokemon
    {
        private string name;
        public int Strength {get; set;}

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value.ToUpper();
                }
            }
        }
        

    }
}
