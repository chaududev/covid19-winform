using DevExpress.ClipboardSource.SpreadsheetML;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CovidTracking
{
    public partial class PrimaryForm : DevExpress.XtraEditors.XtraForm
    {
        List<Root> dataRoot = new List<Root>();
            
        public PrimaryForm()
        {
            InitializeComponent();
            jsonDataSource3.FillAsync();
            var client = new RestClient("https://covid19.ncsc.gov.vn/api/v3/covid/provinces");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            // Console.WriteLine(response.Content);
            dataRoot = JsonConvert.DeserializeObject<List<Root>>(response.Content.ToString());
            dataRoot.ForEach((e) =>
            {
                selectBoxProvice.Items.Add(e.name);
            });

        }


        private void mapControl1_Click(object sender, EventArgs e)
        {

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
            this.Visible=false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tintuc tintuc = new tintuc();   
            tintuc.Visible = true;
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var index = selectBoxProvice.SelectedIndex;
            Root root = dataRoot[index];
            SelectProvice select = new SelectProvice(root);
            select.Visible = true;
            

        }
    }
}
