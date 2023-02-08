using DevExpress.XtraEditors;
using Newtonsoft.Json;
using RestSharp;
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
    public partial class SelectProvice : DevExpress.XtraEditors.XtraForm
    {
        public SelectProvice(Root root)
        {
            InitializeComponent();
            provice_name.Text = root.name;
            total_case.Text = root.total_case.ToString();
            total_populate.Text = root.population.ToString();
            total_death.Text = root.total_death.ToString();
            new_case.Text = root.new_case.ToString();
            new_death.Text = root.new_death.ToString();




        }

        private void provice_name_Click(object sender, EventArgs e)
        {

        }

        private void SelectProvice_Load(object sender, EventArgs e)
        {

        }
    }
}