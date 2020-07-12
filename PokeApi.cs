using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace pokedex
{
    class PokeApi
    {
        private static HttpClient client = new HttpClient();

        public static BitmapImage GetImage(string url)
        {
            return new BitmapImage(new Uri(url));
        }

        private static async Task<dynamic> GetFromApi(string apistring = "")
        {
            return JsonConvert.DeserializeObject(await client.GetStringAsync("https://pokeapi.co/api/v2/" + apistring));
        }

        public static class berry
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("berry/" + IdOrType); }

            public static class berry_firmness
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("berry-firmness/" + IdOrType); }
            }

            public static class berry_flavor
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("berry-flavor/" + IdOrType); }
            }
        }

        public static class contest
        {
            public static class contest_type
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("contest-type/" + IdOrType); }
            }

            public static class contest_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("contest-effect/" + IdOrType); }
            }

            public static class super_contest_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("super-contest-effect/" + IdOrType); }
            }
        }

        public static class encounter
        {
            public static class encounter_method
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("encounter-method/" + IdOrType); }
            }

            public static class encounter_condition
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("encounter-condition/" + IdOrType); }
            }

            public static class encounter_condition_value
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("encounter-condition-value/" + IdOrType); }
            }
        }

        public static class evolution
        {
            public static class evolution_chain
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("evolution-chain/" + IdOrType); }
            }

            public static class evolution_trigger
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("evolution-trigger/" + IdOrType); }
            }
        }

        public static class game
        {
            public static class generation
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("generation/" + IdOrType); }
            }

            public static class pokedex
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokedex/" + IdOrType); }
            }

            public static class version
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("version/" + IdOrType); }
            }

            public static class version_group
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("version-group/" + IdOrType); }
            }
        }

        public static class item
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("item/" + IdOrType); }

            public static class item_attribute
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("item-attribute/" + IdOrType); }
            }

            public static class item_category
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("item-category/" + IdOrType); }
            }

            public static class item_fling_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("item-fling-effect/" + IdOrType); }
            }

            public static class item_pocket
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("item-pocket/" + IdOrType); }
            }
        }

        public static class location
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("location/" + IdOrType); }

            public static class location_area
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("location-area/" + IdOrType); }
            }

            public static class pal_park_area
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pal-park-area/" + IdOrType); }
            }

            public static class region
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("region/" + IdOrType); }
            }
        }

        public static class machine
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("machine/" + IdOrType); }
        }

        public static class move
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("move/" + IdOrType); }

            public static class move_ailment
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-ailment/" + IdOrType); }
            }

            public static class move_battle_style
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-battle-style/" + IdOrType); }
            }

            public static class move_category
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-category/" + IdOrType); }
            }

            public static class move_damage_class
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-damage-class/" + IdOrType); }
            }

            public static class move_learn_method
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-learn-method/" + IdOrType); }
            }

            public static class move_target
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("move-target/" + IdOrType); }
            }
        }

        public static class pokemon
        {
            public static Task<dynamic> get(string IdOrType)
            { return GetFromApi("pokemon/" + IdOrType); }

            public static class ability
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("ability/" + IdOrType); }
            }

            public static class characteristic
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("characteristic/" + IdOrType); }
            }

            public static class egg_group
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("egg-group/" + IdOrType); }
            }

            public static class gender
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("gender/" + IdOrType); }
            }

            public static class growth_rate
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("growth-rate/" + IdOrType); }
            }

            public static class nature
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("nature/" + IdOrType); }
            }

            public static class pokeathlon_stat
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokeathlon-stat/" + IdOrType); }
            }

            public static class pokemon_color
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokemon-color/" + IdOrType); }
            }

            public static class pokemon_form
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokemon-form/" + IdOrType); }
            }

            public static class pokemon_habitat
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokemon-habitat/" + IdOrType); }
            }

            public static class pokemon_shape
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokemon-shape/" + IdOrType); }
            }

            public static class pokemon_species
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("pokemon-species/" + IdOrType); }
            }

            public static class stat
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("stat/" + IdOrType); }
            }

            public static class type
            {
                public static Task<dynamic> get(string IdOrType)
                { return GetFromApi("type/" + IdOrType); }
            }
        }
    }
}