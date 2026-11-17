using DVLD.UI.Classic.Pages.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UI.Classic
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsddbtnPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople managePeople = new frmManagePeople();
     
            managePeople.ShowDialog();       
        }
    }
}
