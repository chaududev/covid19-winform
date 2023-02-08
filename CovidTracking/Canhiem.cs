using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidTracking
{
    public partial class Canhiem : DevExpress.XtraEditors.XtraForm
    {
        public Canhiem()
        {
            InitializeComponent();
            jsonDataSource1.FillAsync();
            jsonDataSource2.FillAsync();
            jsonDataSource3.FillAsync();
            this.panel1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimaryForm form = new PrimaryForm();
            form.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tiemchung tiemchung = new tiemchung();
            tiemchung.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pccovid pccovid = new pccovid();
            pccovid.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tintuc tintuc = new tintuc();
            tintuc.Visible = true;
            this.Visible = false;
        }
    }
}