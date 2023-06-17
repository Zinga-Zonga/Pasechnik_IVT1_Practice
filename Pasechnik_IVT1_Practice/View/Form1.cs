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
        }

        private void buttonAddCountry_Click(object sender, EventArgs e)
        {
            CountryForm cf = new CountryForm();
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

        
        

    }
}