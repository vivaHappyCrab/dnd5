using System.Collections.Generic;
using CharacterBase.Enums;
using Newtonsoft.Json;

namespace CharacterBase.Entities
{
    public class From
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProficiencyChoice
    {
        [JsonProperty("from")]
        public List<From> From { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("choose")]
        public int Choose { get; set; }
    }

    public class Proficiency
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SavingThrow
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StartingEquipment
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class ClassLevels
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class Subclass
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Spellcasting
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class Class
    {
        #region JsonProperties
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hit_die")]
        public int HitDie { get; set; }

        [JsonProperty("proficiency_choices")]
        public List<ProficiencyChoice> ProficiencyChoices { get; set; }

        [JsonProperty("proficiencies")]
        public List<Proficiency> Proficiencies { get; set; }

        [JsonProperty("saving_throws")]
        public List<SavingThrow> SavingThrows { get; set; }

        [JsonProperty("starting_equipment")]
        public StartingEquipment StartingEquipment { get; set; }

        [JsonProperty("class_levels")]
        public ClassLevels ClassLevels { get; set; }

        [JsonProperty("subclasses")]
        public List<Subclass> Subclasses { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("spellcasting")]
        public Spellcasting Spellcasting { get; set; }
#endregion

        public Dice HitDice => (Dice) this.HitDie;
    }

    public class ClassList
    {
        [JsonProperty("classes")]
        public List<Class> Classes { get; set; }
    }

}