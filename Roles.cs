using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Практическая
{
    public static class Roles
    {
        public static void UseRoles()
        {
            if (Global.Chel[3] == "Administrator")
            {
                AD AdminUsing = new AD();
                AdminUsing.Admin();
            }
        }
    }
}
