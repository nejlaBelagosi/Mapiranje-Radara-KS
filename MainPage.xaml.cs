using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using System.Collections.ObjectModel;


namespace Radars
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MapItem> Positions { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Positions = new ObservableCollection<MapItem>();

            // Add sample data (you can replace this with your actual data)
            AddMapItem(new Location(43.8889722, 18.3151111111111), "Tunel 'Vukov Gaj' smjer Tarčin-Zenica", "Ogranicenje: 100");

            AddMapItem(new Location(43.8927778, 18.3176666666666), "Tunel 'Oštrik' smjer Zenica-Tarčin", "Ogranicenje: 100");

            AddMapItem(new Location(43.8476111, 18.3869722222222), "Raskrsnica ulica Zvornička-T.Osman paše (kod stadiona Grbavica), smjer Dobrinja-Centar", "Ogranicenje: 50");

            AddMapItem(new Location(43.8218056, 18.3584722222222), "Ul. Bulevar Mimar Sinana -ulaz Dobrinja", "Ogranicenje: 50");

            AddMapItem(new Location(43.8228611, 18.3502222222222), "Ulica Kurta Schorka", "Ogranicenje: 60");

            AddMapItem(new Location(43.85575, 18.3983611111111), "Zmaja od Bosne, Kampus", "Ogranicenje: 60");

            AddMapItem(new Location(43.85425, 18.4111388888888), "Ulica Terezija, pravac prema Skenderiji", "Ogranicenje: 60");

            AddMapItem(new Location(43.845, 18.3401666666666), "Ulica Džemala Bijedića, pravac Ilidža-Centar", "Ogranicenje: 60");

            AddMapItem(new Location(43.8488333, 18.363), "Bulevar Meše Selimovića(kod Doma zdravlja)", "Ogranicenje: 60");

            AddMapItem(new Location(43.8491389, 18.3670277777777), "Bulevar Meše Selimovića", "Ogranicenje: 60");

            AddMapItem(new Location(43.8538889, 18.3923888888888), "Zmaja od Bosne, kod ekonomske škole", "Ogranicenje: 60");

            AddMapItem(new Location(43.8563889, 18.3778333333333), "Ulica Drinska (kod pješačke pasarele)", "Ogranicenje: 50");

            AddMapItem(new Location(43.8583056, 18.3978611111111), "Ulica Put života (smjer od spoja sa ul. H. Ćemerlića prema spoju sa ul. H. Kajtaza)", "Ogranicenje: 60");

            AddMapItem(new Location(43.8585, 18.397), "Ulica Put života (smjer od spoja sa ul. H. Kajtaza prema spoju sa ul. H. Ćemerlića)", "Ogranicenje: 60");

            AddMapItem(new Location(43.8528611, 18.3855833333333), "Zmaja od Bosne, pravac Centar-Ilidža", "Ogranicenje: 60");

            AddMapItem(new Location(43.8426389, 18.3270833333333), "Ulica Džemala Bijedića, ispod Stupske petlje (smjer Centar-Ilidža)", "Ogranicenje: 60");





            // Set the BindingContext
            BindingContext = this;


        }
        private void AddMapItem(Location location, string address, string description)
        {
            Positions.Add(new MapItem
            {
                Location = location,
                Address = address,
                Description = description
            });
        }


    }
    public class MapItem
    {
        public Location Location { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
