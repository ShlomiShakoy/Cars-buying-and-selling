using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_menu
{
    public class lisence
    {
        Random rnd;
        public lisence()
        {
            rnd = new Random();
        }
        public string id{ get; set; }
        public string ID() {
            int i , j;
            
            string str;
            str = Convert.ToString(rnd.Next());
            return str;
        }
    }
}
