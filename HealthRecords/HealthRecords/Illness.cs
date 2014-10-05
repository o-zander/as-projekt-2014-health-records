using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
    class Illness
    {
        public long IllnessID { get; set; }
        public String Name { get; set; }
        public Boolean Contagious { get; set; }
        public Boolean Lethal { get; set; }
        public Boolean Curable { get; set; }

        public Illness()
        {
            this.IllnessID = 0;
            this.Name = "";
            this.Contagious = false;
            this.Lethal = false;
            this.Curable = false;
        }

        public Illness(string name, bool contagious, bool lethal, bool curable)
        {
            this.IllnessID = 0;
            this.Name = name;
            this.Contagious = contagious;
            this.Lethal = lethal;
            this.Curable = curable;
        }

        public Illness(long illnessID, string name, bool contagious, bool lethal, bool curable)
        {
            this.IllnessID = illnessID;
            this.Name = name;
            this.Contagious = contagious;
            this.Lethal = lethal;
            this.Curable = curable;
        }

        private static string YesNo(bool value)
        {
            return value ? "yes" : "no";
        }

        public override string ToString()
        {
            return String.Format(
                "Illness #{0} {1} (contagious: {2}, lethal: {3}, curable: {4})",
                this.IllnessID, this.Name, YesNo(this.Contagious), YesNo(this.Lethal), YesNo(this.Curable)
            );
        }
    }
}
