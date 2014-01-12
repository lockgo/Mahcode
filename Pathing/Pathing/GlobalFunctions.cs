using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathing
{
    public class Globalz
    {
        public static int GiveMe5()
        {
            return 5;
        }
        public static int calcCMB(int BaseAttack, int Str)
        {//Combat Manuver Bonus
            int CMB = 0;
            if (Str < 10)
            {
                CMB = BaseAttack + ((Str / 2) * -1);
            }
            else
            {
                CMB = BaseAttack + ((Str - 10) / 2);
            }
            return CMB;
        }

        public static int calcCMD(int BaseAttack, int Str, int Dex)
        {//Combat Manuver Defense
            int CMD;
            if (Str < 10 && Dex < 10)
            {
                CMD = BaseAttack + ((Str / 2) * -1) + 10 + ((Dex / 2) * -1);
            }
            else if (Str >= 10 && Dex < 10)
            {
                CMD = BaseAttack + ((Str - 10) / 2) + 10 + ((Dex / 2) * -1);
            }
            else if (Str < 10 && Dex >= 10)
            {
                CMD = BaseAttack + ((Str / 2) * -1) + 10 + ((Dex - 10) / 2);
            }
            else
            {
                CMD = (BaseAttack + ((Str - 10) / 2) + 10 + ((Dex - 10) / 2));
            }

            return CMD;
        }

    }
}
