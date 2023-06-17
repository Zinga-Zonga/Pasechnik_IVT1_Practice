using AutoMapper;
using AutoMapper.EquivalencyExpression;
using Microsoft.VisualBasic.ApplicationServices;
using Pasechnik_IVT1_Practice.Data.Entities;
using Pasechnik_IVT1_Practice.Services;
using Pasechnik_IVT1_Practice.View;
using Pasechnik_IVT1_Practice.ViewModels;
using System.Drawing.Text;

namespace Pasechnik_IVT1_Practice
{
    public partial class MainForm : Form
    {
        private readonly IMapper _mapper;
        public MainForm()
        {
            InitializeComponent();
            CustomSidebar();
            _mapper = InitMapping();

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
            //RegionService regionService = new RegionService();
            ////Data.Entities.Region rg = new Data.Entities.Region { Name = "Europa", Population = 5555, Territory = 666 };
            ////regionService.Add(rg);
            //CountryService countryService = new CountryService();
            //Country country = new Country { Name = "Germany", Population = 222, RegionId = 2 };
            //countryService.AddCountry(country);

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
            // Отображение таблицы
            dataGridView1.DataSource = getCountryViewModels();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Население";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Регион";



        }

        private void buttonRegions_Click(object sender, EventArgs e)
        {
            RegionService regionService = new RegionService();
            dataGridView1.DataSource = regionService.GetList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Площадь";
            dataGridView1.Columns[3].HeaderText = "Население";
            

        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            CountryAddForm cf = new CountryAddForm();
            cf.FormClosed += new FormClosedEventHandler(RefreshDGV);
            cf.ShowDialog();
            
        }
        private void RefreshDGV(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = getCountryViewModels();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Население";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Регион";
        }

        private void updateCountryButton_Click(object sender, EventArgs e)
        {

            CountryAddForm cf = new CountryAddForm((int)dataGridView1.SelectedRows[0].Cells[0].Value, dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), (int)dataGridView1.SelectedRows[0].Cells[2].Value, (int)dataGridView1.SelectedRows[0].Cells[3].Value);
            cf.FormClosed += new FormClosedEventHandler(RefreshDGV);
            cf.ShowDialog();


        }
        
        
        private IMapper InitMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddCollectionMappers();

                cfg.CreateMap<Country, CountryViewModel>()
                   .ForMember(m => m.RegionName, opt => opt.MapFrom(f => f.Region.Name)).ReverseMap();
                cfg.CreateMap<CountryRing, CountryRingViewModel>()
                   .ForMember(m => m.CountryName, opt => opt.MapFrom(f => f.Country.Name))
                   .ForMember(m => m.RingName, opt => opt.MapFrom(f => f.Ring.Title))
                   .ReverseMap();
                cfg.CreateMap<CountryMat, CountryMatViewModel>()
                    .ForMember(m => m.CountryName, opt => opt.MapFrom(f => f.Country.Name))
                    .ForMember(m => m.MatName, opt => opt.MapFrom(f => f.Mat.Title))
                   .ReverseMap();
                cfg.CreateMap<CountrySportsEquipment, CountrySportsEquipmentViewModel>()
                    .ForMember(m => m.CountryName, opt => opt.MapFrom(f => f.Country.Name))
                    .ForMember(m => m.SportsEquipmentName, opt => opt.MapFrom(f => f.SportsEquipment.Title))
                   .ReverseMap();
                cfg.CreateMap<SportsEquipment, SportsEquipmentViewModel>()
                    .ForMember(m => m.SportTypeName, opt => opt.MapFrom(f => f.SportType.Title))
                   .ReverseMap();
            });
                
                
            
            return config.CreateMapper();
        }

        private List<CountryViewModel> getCountryViewModels()
        {
            CountryService countryService = new CountryService();

            List<CountryViewModel> countryViewModels = _mapper.Map<List<CountryViewModel>>(countryService.GetList());
            return countryViewModels;
        }
        
        private List<SportsEquipmentViewModel> getSportsEquipmentViewModels()
        {
            SportsEquipmentService sportsEquipmentService = new SportsEquipmentService();

            List<SportsEquipmentViewModel> sportsEquipmentViewModels = _mapper.Map<List<SportsEquipmentViewModel>>(sportsEquipmentService.GetList());
            return sportsEquipmentViewModels;
        }
        private List<CountryMatViewModel> getCountryMatViewModels()
        {
            CountryMatService countryMatService = new CountryMatService();

            List<CountryMatViewModel> countryMatViewModels = _mapper.Map<List<CountryMatViewModel>>(countryMatService.GetList());
            return countryMatViewModels;
        }
        private List<CountryRingViewModel> getCountryRingViewModels()
        {
            CountryRingsService countryRingService = new CountryRingsService();

            List<CountryRingViewModel> countryRingsViewModels = _mapper.Map<List<CountryRingViewModel>>(countryRingService.GetList());
            return countryRingsViewModels;
        }
        private List<CountrySportsEquipmentViewModel> getCountrySportEquipmentViewModels()
        {
            CountrySportsEquipmentService countrySportEquipmentService = new CountrySportsEquipmentService();

            List<CountrySportsEquipmentViewModel> countrySportEquipmentViewModels = _mapper.Map<List<CountrySportsEquipmentViewModel>>(countrySportEquipmentService.GetList());
            return countrySportEquipmentViewModels;
        }

        private void buttonSportsEquipment_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = getSportsEquipmentViewModels();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Вид спорта";
            dataGridView1.Columns[3].HeaderText = "Название";
            dataGridView1.Columns[4].HeaderText = "Цена, за 1 тыс.шт.";


        }

        private void buttonRings_Click(object sender, EventArgs e)
        {
            RingService ringService = new RingService();
            dataGridView1.DataSource = ringService.GetList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Площадь";
            dataGridView1.Columns[3].HeaderText = "Цена, за 1тыс";
        }

        private void buttonMats_Click(object sender, EventArgs e)
        {
            MatService matService = new MatService();
            dataGridView1.DataSource = matService.GetList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Площадь";
            dataGridView1.Columns[3].HeaderText = "Цена, за 1тыс";
        }

      

        private void buttonCountryMat_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getCountryMatViewModels();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Страна";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Название матов";
            dataGridView1.Columns[5].HeaderText = "Количество";



        }

        private void buttonRequests2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCountryRings_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getCountryRingViewModels();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Страна";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Название рингов";
            dataGridView1.Columns[5].HeaderText = "Количество";
        }

        private void buttonCountrySportEquipment_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getCountrySportEquipmentViewModels();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Страна";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Название спорт.инвентаря";
            dataGridView1.Columns[5].HeaderText = "Количество";
        }
    }
}