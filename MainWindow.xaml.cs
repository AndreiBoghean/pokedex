using Newtonsoft.Json;
using pokedex.Pages;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace pokedex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainContentFrame.Content = new PokemonPage(MainContentFrame, PokeApi.pokemon.get("pikachu"));
        }

        #region close / minimise
        private void Close_Click(object sender, RoutedEventArgs e) => Close();

        private void Minimise_Click(object sender, RoutedEventArgs e)
        { this.WindowState = WindowState.Minimized; }
        #endregion
        
        private void PokemonName_Go_Button_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new PokemonPage(MainContentFrame, PokeApi.pokemon.get(Pokemon_Name.Text) );
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox sndr = (TextBox)sender;

            if (sndr.Text != sndr.Name.Replace("_", " ")) return;
            sndr.Foreground = new SolidColorBrush(Colors.Black);
            sndr.Text = " ";
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox sndr = (TextBox)sender;

            if ( sndr.Text != "") return;
            sndr.Foreground = new SolidColorBrush(Colors.Gray);
            sndr.Text = sndr.Name.Replace("_", " ");
        }
    }
}