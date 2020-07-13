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
    public partial class PokemonPage : Page
    {
        Frame MainContentFrame;
        public PokemonPage(Frame MainContentFrame, Task<dynamic> PokeClass)
        {
            dynamic PokemonClass = PokeClass.Result;
            this.MainContentFrame = MainContentFrame;
            InitializeComponent();

            Console.WriteLine((string)PokemonClass.sprites.front_default);

            MaleFront_Image.Source   = PokeApi.GetImage((string)PokemonClass.sprites.front_default);
            MaleBack_Image.Source    = PokeApi.GetImage((string)PokemonClass.sprites.back_default);
            FemaleFront_Image.Source = PokeApi.GetImage((string)PokemonClass.sprites.front_female);
            FemaleBack_Image.Source  = PokeApi.GetImage((string)PokemonClass.sprites.back_female);
        }
    }
}