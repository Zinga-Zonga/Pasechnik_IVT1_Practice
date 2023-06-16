using Microsoft.VisualBasic.ApplicationServices;
using Pasechnik_IVT1_Practice.Data.Entities;
using Pasechnik_IVT1_Practice.Services;

namespace Pasechnik_IVT1_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomSidebar();

            
        }


        public void CustomSidebar()
        {
            panelTablesButtons.Visible = false;
            panelRequestsButtons.Visible = false;
        }

        public void ShowSidebarMenu(Panel sideMenu)
        {
            if(sideMenu.Visible == false)
            {
                HideSidebarMenu();
                sideMenu.Visible = true;
            }
            else
            {
                sideMenu.Visible = false;
            }
        }
        public void HideSidebarMenu()
        {
            if (panelTablesButtons.Visible == true)
            {
                panelTablesButtons.Visible = false;
            }
            if (panelRequestsButtons.Visible == true)
            {
                panelRequestsButtons.Visible = false;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonTables_Click(object sender, EventArgs e)
        {
            ShowSidebarMenu(panelTablesButtons);
        }

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            ShowSidebarMenu(panelRequestsButtons);
        }

        private void buttonCountries_Click(object sender, EventArgs e)
        {
            CountryService countryService = new CountryService();
            List<Country> countries = countryService.GetList();
            dataGridView1.DataSource = countries;
            if (countries.Count != 0)
            {
                
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Население";
                dataGridView1.Columns[3].HeaderText = "Регион";
                dataGridView1.Columns[4].Visible = false;
            }
            
        }

        private void buttonRegions_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {

        }
    }
}