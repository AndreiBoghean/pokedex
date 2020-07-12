using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
using ImageSys = System.Drawing.Image;
using ImageWpf = System.Windows.Controls.Image;

namespace pokedex.Pages
{
    /// <summary>
    /// Interaction logic for PokemonPage.xaml
    /// </summary>
    public partial class PokemonPage : Page
    {
        public PokemonPage(Frame MainContentFrame, dynamic PokemonClass)
        {
            InitializeComponent();
        }
    }
}
