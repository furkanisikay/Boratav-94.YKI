using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boratav_94.App.Bilesenler._360DrcKontBtn
{
    public partial class _360DrcKontBtn : UserControl
    {
        public _360DrcKontBtn()
        {
            InitializeComponent();
        }

        public event EventHandler<Yonler> ButonTiklandiginda;

        private void Btn_Click(object sender, EventArgs e)
        {
            ButonTiklandiginda?.Invoke(sender, YonlerTools.Parse(Convert.ToInt32((sender as Button).Tag)));
        }
    }
}
