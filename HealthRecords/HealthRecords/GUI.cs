using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HealthRecords
{
    class GUI
    {
        public GUI(Fachkonzept fachkonzept)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUIForm(fachkonzept));
        }
    }
}
