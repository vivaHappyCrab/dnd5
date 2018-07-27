using System.Collections.Generic;
using System.IO.Compression;

namespace CharacterBase.Entities
{
    public class Character
    {
        public string Name;

        public Class Class { get; set; } 

        public Race Race { get; set; }

        public Background Background { get; set; }

        public Inventory Inventory { get; set; }

        public int Level { get; set; }

        public List<Class> MultiClasses { get; set; }

        public int ProfiencyBonus => this.Level/5 + 2;
    }
}