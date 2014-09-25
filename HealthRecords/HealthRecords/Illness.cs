using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthRecords
{
  class Illness
  {
    public int IllnessID { get; set; }
    public String Name { get; set; }
    public Boolean Contagious { get; set; }
    public Boolean Lethal { get; set; }
    public Boolean Curable { get; set; }
  }
}
