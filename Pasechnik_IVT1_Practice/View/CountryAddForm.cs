using Pasechnik_IVT1_Practice.Data.Entities;
using Pasechnik_IVT1_Practice.Services;
using Pasechnik_IVT1_Practice.ViewModels;
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
    public partial class CountryAddForm : Form
    {
        public CountryAddForm()
        {
            InitializeComponent();
        }

        public CountryAddForm(int Id, string Name, int Population, int RegionId)
        {
            InitializeComponent();
            id.Text = Id.ToString();
            name.Text = Name;
            population.Text = Population.ToString();
            region.SelectedValue = RegionId;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            CountryService countryService = new CountryService();
            if((sender as Button).Name == "buttonAddCountry")
            {
                country.Name = name.Text;
                country.Population = Convert.ToInt32(population.Text);
                country.RegionId = (int)region.SelectedValue;
                countryService.AddCountry(country);
            }
            else
            {
                
                
            }
            this.Close();
            
        }
    }
}
