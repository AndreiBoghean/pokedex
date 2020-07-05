using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 0649

namespace pokedex
{
    public class Pokemon
    {
        public class AbilitesClass
        {
            public class AbilityClass
            {
                public string name;
                public string url;
            }
            public AbilityClass ability;

            public bool is_hidden;
            public int slot;
        }
        public List<AbilitesClass> abilities;

        public int base_experience;

        public class FormsClass
        {
            public string name;
            public string url;
        }
        public List<FormsClass> forms;

        // missing game_indices beacuse not needed

        public int height;

        public class HeldItemsClass
        {
            public class ItemClass
            {
                public string name;
                public string url;
            }
            public ItemClass item;

            // missing version_details because not needed
        }
        public List<HeldItemsClass> held_Items;

        public int id;

        public bool is_default;

        public string location_area_encounters;

        public class MovesClass
        {
            public class MoveClass
            {
                public string name;
                public string url;
            }
            public MoveClass move;

            // missing version_group_details because not needed
        }
        public List<MovesClass> moves;

        public string name;

        public int order;

        public class SpeciesClass
        {
            public string name;
            public string url;
        }
        public SpeciesClass species;

        public class SpritesClass
        {
            public string back_default;
            public string back_female;
            public string back_shiny;
            public string back_shiny_female;
            public string front_default;
            public string front_female;
            public string front_shiny;
            public string front_shiny_female;
        }
        public SpritesClass sprites;

        public class StatsClass
        {
            public int base_stat;
            public int effort;

            public class StatClass
            {
                public string name;
                public string url;
            }
            public StatClass stat;
        }
        public List<StatsClass> stats;

        public class TypesClass
        {
            public int slot;

            public class TypeClass
            {
                public string name;
                public string url;
            }
            public TypeClass type;
        }
        public List<TypesClass> types;

        public int weight;
    }
}