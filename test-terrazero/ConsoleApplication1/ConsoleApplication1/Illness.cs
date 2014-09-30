using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Illness
    {

        public int IllnessID { get; set; }
        public String Name { get; set; }
        public Boolean Contagious { get; set; }
        public Boolean Lethal { get; set; }
        public Boolean Curable { get; set; }

        public Illness()
        {
        }

        public Illness(string name, bool contagious, bool lethal, bool curable)
        {
            this.Name = name;
            this.Contagious = contagious;
            this.Lethal = lethal;
            this.Curable = curable;
        }

    }
}
