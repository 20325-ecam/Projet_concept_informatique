using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace simulation_reseau_elec
{
    class Errors
    {
        public bool error1 = false;
        public bool error2 = false;
        public bool error3 = false;

        public Errors()
        {
        }
        public void Show_error1(Centrale centrale)
        {
            if(error1==false)
            {
                error1 = true;
                System.Windows.Forms.MessageBox.Show("Hello, you have error1 on plant : " 
                    + centrale.Get_name());
                //pseudo delay
                
                error1 = false;
                //Task.Delay(3000);
                


            }
        }
    }

}


