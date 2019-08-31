using System.Collections.Generic;
using System.Globalization;
using AutoMapper.Configuration;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WoWJunkyard.Services.Utilities;

namespace WoWJunkyard.Views.Models
{
    public partial class CharacterInputModel
    {
        [JsonProperty("lastModified")]
        public long LastModified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("realm")]
        public string Realm { get; set; }

        [JsonProperty("battlegroup")]
        public string Battlegroup { get; set; }

        [JsonProperty("class")]
        public long Class { get; set; }

        [JsonProperty("race")]
        public long Race { get; set; }

        [JsonProperty("gender")]
        public long Gender { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("achievementPoints")]
        public long AchievementPoints { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("calcClass")]
        public string CalcClass { get; set; }

        [JsonProperty("faction")]
        public long Faction { get; set; }

        [JsonProperty("items")]
        public ItemsInputModel Items { get; set; }

        [JsonProperty("totalHonorableKills")]
        public long TotalHonorableKills { get; set; }
    }

    public partial class ItemsInputModel
    {

        public ItemsInputModel()
        {
            ItemInfo = new List<ItemInfoInputModel>();
        }

        [JsonProperty("averageItemLevel")]
        public long AverageItemLevel { get; set; }

        [JsonProperty("averageItemLevelEquipped")]
        public long AverageItemLevelEquipped { get; set; }

        [JsonIgnore]
        public List<ItemInfoInputModel> ItemInfo { get; set; }

        [JsonProperty("head")]
        public ItemInfoInputModel Head { get; set; }

        [JsonProperty("neck")]
        public ItemInfoInputModel Neck { get; set; }

        [JsonProperty("shoulder")]
        public ItemInfoInputModel Shoulder { get; set; }

        [JsonProperty("back")]
        public ItemInfoInputModel Back { get; set; }

        [JsonProperty("chest")]
        public ItemInfoInputModel Chest { get; set; }

        [JsonProperty("wrist")]
        public ItemInfoInputModel Wrist { get; set; }

        [JsonProperty("hands")]
        public ItemInfoInputModel Hands { get; set; }

        [JsonProperty("waist")]
        public ItemInfoInputModel Waist { get; set; }

        [JsonProperty("legs")]
        public ItemInfoInputModel Legs { get; set; }

        [JsonProperty("feet")]
        public ItemInfoInputModel Feet { get; set; }

        [JsonProperty("finger1")]
        public ItemInfoInputModel Finger1 { get; set; }

        [JsonProperty("finger2")]
        public ItemInfoInputModel Finger2 { get; set; }

        [JsonProperty("trinket1")]
        public ItemInfoInputModel Trinket1 { get; set; }

        [JsonProperty("trinket2")]
        public ItemInfoInputModel Trinket2 { get; set; }

        [JsonProperty("mainHand")]
        public ItemInfoInputModel MainHand { get; set; }

        [JsonProperty("offHand")]

        public ItemInfoInputModel OffHand { get; set; }

    }


    public partial class ItemInfoInputModel
    {
        [JsonIgnore]
        public string SlotName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("quality")]
        public long Quality { get; set; }

        [JsonProperty("itemLevel")]
        public long ItemLevel { get; set; }

        [JsonProperty("tooltipParams")]
        public Dictionary<string, long> TooltipParams { get; set; }

        [JsonProperty("stats")]
        public List<StatInputModel> Stats { get; set; }

        [JsonProperty("armor")]
        public long Armor { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("bonusLists")]
        public List<long> Bonus { get; set; }

        [JsonProperty("artifactId")]
        public long ArtifactId { get; set; }

        [JsonProperty("displayInfoId")]
        public long DisplayInfoId { get; set; }

        [JsonProperty("artifactAppearanceId")]
        public long ArtifactAppearanceId { get; set; }

        [JsonProperty("artifactTraits")]
        public List<object> ArtifactTraits { get; set; }

        [JsonProperty("relics")]
        public List<object> Relics { get; set; }

        [JsonProperty("azeriteItem")]
        public AzeriteItemInputModel AzeriteItem { get; set; }

        [JsonProperty("azeriteEmpoweredItem")]
        public AzeriteEmpoweredItemInputModel AzeriteEmpoweredItem { get; set; }
    }


    public partial class AzeriteEmpoweredItemInputModel
    {
        [JsonProperty("azeritePowers")]
        public List<AzeritePowerInputModel> AzeritePowers { get; set; }
    }

    public partial class AzeritePowerInputModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("spellId")]
        public long SpellId { get; set; }

        [JsonProperty("bonusListId")]
        public long BonusListId { get; set; }
    }

    public partial class AzeriteItemInputModel
    {
        [JsonProperty("azeriteLevel")]
        public long AzeriteLevel { get; set; }

        [JsonProperty("azeriteExperience")]
        public long AzeriteExperience { get; set; }

        [JsonProperty("azeriteExperienceRemaining")]
        public long AzeriteExperienceRemaining { get; set; }
    }

    public partial class StatInputModel
    {
        [JsonProperty("stat")]
        public long StatStat { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }
    }


    public partial class WeaponInfoInputModel
    {
        [JsonProperty("damage")]
        public DamageInputModel Damage { get; set; }

        [JsonProperty("weaponSpeed")]
        public double WeaponSpeed { get; set; }

        [JsonProperty("dps")]
        public double Dps { get; set; }
    }

    public partial class DamageInputModel
    {
        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("exactMin")]
        public long ExactMin { get; set; }

        [JsonProperty("exactMax")]
        public long ExactMax { get; set; }
    }


    public partial class CharacterInputModel
    {
        public static CharacterInputModel FromJson(string json) => JsonConvert.DeserializeObject<CharacterInputModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CharacterInputModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}