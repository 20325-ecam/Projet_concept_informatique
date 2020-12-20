using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_reseau_elec
{
    class Error_1 : Errors
    {
        public Error_1()
        {
        }
        public override void Show_error(Centrale centrale)
        {
            return 
            System.Windows.Forms.MessageBox.Show("Hello, you have error1 on plant : "
                + centrale.Get_name());
        }
    }
}
