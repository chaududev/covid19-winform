using DevExpress.DataAccess.Native.EntityFramework;
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
    public partial class tintuc : DevExpress.XtraEditors.XtraForm
    {
        public tintuc()
        {
            InitializeComponent();
            this.brower.Navigate("https://vnexpress.net/covid-19/tin-tuc");
            this.brower.ScriptErrorsSuppressed = true;
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrimaryForm form = new PrimaryForm();
            form.Visible = true;
            this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Canhiem canhiem = new Canhiem();
            canhiem.Visible = true;
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

        private void brower_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.brower.Document.Body.Style = "zoom:120%;";
            this.brower.ScrollBarsEnabled = true;
           

        }
    }
}