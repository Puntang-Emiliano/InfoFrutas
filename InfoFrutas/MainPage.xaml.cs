using InfoFrutas.Models;

namespace InfoFrutas
{
    public partial class MainPage : ContentPage
    {
        public List<FrutaInformacion> PapayaInfo { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PapayaInfo = new List<FrutaInformacion>()
            {
                new FrutaInformacion()
                {
                    Micronutrientes = "Vitamina C",
                    Porcentaje= 101
                },
                new FrutaInformacion()
                {
                    Micronutrientes = "Vitamina A",
                    Porcentaje= 19
                },
                new FrutaInformacion()
                {
                    Micronutrientes = "Calcio",
                    Porcentaje= 2
                },
                new FrutaInformacion()
                {
                    Micronutrientes = "Magnecio",
                    Porcentaje= 5
                },
                new FrutaInformacion()
                {
                    Micronutrientes = "Potacio",
                    Porcentaje= 5
                },
            };
            this.BindingContext= this;
        }

        
    }

}
