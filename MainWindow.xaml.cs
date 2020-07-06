using Newtonsoft.Json;
using pokedex.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pokedex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();
        public MainWindow()
        { InitializeComponent(); MainContentFrame.Content = new PokemonPage(); }

        #region close / minimise
        private void Close_Click(object sender, RoutedEventArgs e) => Close();

        private void Minimise_Click(object sender, RoutedEventArgs e)
        { this.WindowState = WindowState.Minimized; }
        #endregion
        
        private void PokemonName_Go_Button_Click(object sender, RoutedEventArgs e)
        {
            Pokemon poke = GetPokemon(Pokemon_Name.Text);
            if ( poke == null )
            {
                MessageBox.Show($"{Pokemon_Name.Text} isnt a valid pokemon");
            }
            else Console.WriteLine(JsonConvert.SerializeObject(poke) );
        }
        Pokemon GetPokemon(string PokeName)
        {
            string APIstring = "";
            try
            {
                APIstring = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{PokeName}").Result;
                return JsonConvert.DeserializeObject<Pokemon>(APIstring);
            }
            catch(System.AggregateException e)
            {
                return null;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text != "") return;
            ((TextBox)sender).Foreground = new SolidColorBrush(Colors.Gray);
            ((TextBox)sender).Text = ((TextBox)sender).Name.Replace("_", " ");
        }
    }
}