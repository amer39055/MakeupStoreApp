using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeupStoreAppUI
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

     

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // set Date label to show Time and Date
            DateTime dateTime = DateTime.Now;
            lblDateTime.Text = dateTime.ToString();
        }


        //Exit_Button function
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}
