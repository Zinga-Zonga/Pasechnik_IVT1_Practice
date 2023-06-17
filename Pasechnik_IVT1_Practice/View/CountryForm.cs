using Pasechnik_IVT1_Practice.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasechnik_IVT1_Practice.View
{
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
            RegionService regionService = new RegionService();
            List<Data.Entities.Region> regions = regionService.GetList();
            region.DataSource = regions;
            region.DisplayMember = "Name";
            region.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
