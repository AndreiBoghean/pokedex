using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    class PokeApi
    {
        private static HttpClient client = new HttpClient();

        private static async Task<dynamic> test(string apistring = "")
        {
            return JsonConvert.DeserializeObject(await client.GetStringAsync("https://pokeapi.co/api/v2/" + apistring));
        }

        public static class berry
        {
            public static Task<dynamic> get(string IdOrType)
            { return test("" + IdOrType); }

            public static class berry_firmness
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class berry_flavor
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class contest
        {
            public static class contest_type
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class contest_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class super_contest_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class encounter
        {
            public static class encounter_method
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class encounter_condition
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class encounter_condition_value
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class evolution
        {
            public static class evolution_chain
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class evolution_trigger
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class game
        {
            public static class generation
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokedex
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class version
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class version_group
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class item
        {
            public static class item_attribute
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class item_category
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class item_fling_effect
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class item_pocket
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class location
        {
            public static Task<dynamic> get(string IdOrType)
            { return test("" + IdOrType); }

            public static class location_area
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pal_park_area
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class region
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class machine
        {
            public static Task<dynamic> get(string IdOrType)
            { return test("" + IdOrType); }
        }

        public static class move
        {
            public static Task<dynamic> get(string IdOrType)
            { return test("" + IdOrType); }

            public static class move_ailment
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class move_battle_style
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class move_category
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class move_damage_class
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class move_learn_method
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class move_target
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }

        public static class pokemon
        {
            public static Task<dynamic> get(string IdOrType)
            { return test("" + IdOrType); }

            public static class ability
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class characteristic
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class egg_group
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class gender
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class growth_rate
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class nature
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokeathlon_stat
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokemon_color
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokemon_form
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokemon_habitat
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokemon_shape
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class pokemon_species
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class stat
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }

            public static class type
            {
                public static Task<dynamic> get(string IdOrType)
                { return test("" + IdOrType); }
            }
        }
    }
}