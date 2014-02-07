using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathing
{
    public class Session
    {
        public Session()
        {

        }
        public Int32 Cid { get; set; }

        public String Name { get; set; }
        public String Class { get; set; }
        public Int32 Health { get; set; }
        public Int32 ArmorClass { get; set; }
        public Int32 Foritude { get; set; }
        public Int32 Reflex { get; set; }
        public Int32 Will { get; set; }
        public Int32 BaseAttack { get; set; }
        public Int32 Str { get; set; }
        public Int32 Dex { get; set; }
        public Int32 Con { get; set; }
        public Int32 Int { get; set; }
        public Int32 Wis { get; set; }
        public Int32 Cha { get; set; }
        public Int32 Initiative { get; set; }
        public Int32 HD { get; set; }

        public String Feats { get; set; }
        public String Skills { get; set; }
        

    }

}
