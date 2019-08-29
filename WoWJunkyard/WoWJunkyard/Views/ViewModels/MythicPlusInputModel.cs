using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WoWJunkyard.Views.ViewModels
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class MythicPlusInputModel
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("best_runs")]
        public List<BestRun> BestRuns { get; set; }

        [JsonProperty("character")]
        public MythicPlusInputModelCharacter Character { get; set; }
    }

    public partial class BestRun
    {
        [JsonProperty("completed_timestamp")]
        public long CompletedTimestamp { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("keystone_level")]
        public long KeystoneLevel { get; set; }

        [JsonProperty("keystone_affixes")]
        public List<Dungeon> KeystoneAffixes { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }

        [JsonProperty("dungeon")]
        public Dungeon Dungeon { get; set; }

        [JsonProperty("is_completed_within_time")]
        public bool IsCompletedWithinTime { get; set; }
    }

    public partial class Dungeon
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("character")]
        public MemberCharacter Character { get; set; }

        [JsonProperty("specialization")]
        public Dungeon Specialization { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("equipped_item_level")]
        public long EquippedItemLevel { get; set; }
    }

    public partial class MemberCharacter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("realm")]
        public PurpleRealm Realm { get; set; }
    }

    public partial class PurpleRealm
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class Race
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class MythicPlusInputModelCharacter
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("realm")]
        public FluffyRealm Realm { get; set; }
    }

    public partial class FluffyRealm
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Self SelfMp { get; set; }
    }

    public partial class Season
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public enum Name { BloodElf, Goblin, MagHarOrc, Orc, Tauren, Troll, Undead, ZandalariTroll };

    public partial class MythicPlusInputModel
    {
        public static MythicPlusInputModel FromJson(string json) => JsonConvert.DeserializeObject<MythicPlusInputModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MythicPlusInputModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                NameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Blood Elf":
                    return Name.BloodElf;
                case "Goblin":
                    return Name.Goblin;
                case "Mag'har Orc":
                    return Name.MagHarOrc;
                case "Orc":
                    return Name.Orc;
                case "Tauren":
                    return Name.Tauren;
                case "Troll":
                    return Name.Troll;
                case "Undead":
                    return Name.Undead;
                case "Zandalari Troll":
                    return Name.ZandalariTroll;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.BloodElf:
                    serializer.Serialize(writer, "Blood Elf");
                    return;
                case Name.Goblin:
                    serializer.Serialize(writer, "Goblin");
                    return;
                case Name.MagHarOrc:
                    serializer.Serialize(writer, "Mag'har Orc");
                    return;
                case Name.Orc:
                    serializer.Serialize(writer, "Orc");
                    return;
                case Name.Tauren:
                    serializer.Serialize(writer, "Tauren");
                    return;
                case Name.Troll:
                    serializer.Serialize(writer, "Troll");
                    return;
                case Name.Undead:
                    serializer.Serialize(writer, "Undead");
                    return;
                case Name.ZandalariTroll:
                    serializer.Serialize(writer, "Zandalari Troll");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }
}