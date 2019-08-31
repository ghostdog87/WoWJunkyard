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
        public LinksMp Links { get; set; }

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
        public List<DungeonInputModel> KeystoneAffixes { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }

        [JsonProperty("dungeon")]
        public DungeonInputModel Dungeon { get; set; }

        [JsonProperty("is_completed_within_time")]
        public bool IsCompletedWithinTime { get; set; }
    }

    public partial class DungeonInputModel
    {
        [JsonProperty("key")]
        public Href Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class Href
    {
        [JsonProperty("href")]
        public string HrefText { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("character")]
        public MemberCharacter Character { get; set; }

        [JsonProperty("specialization")]
        public DungeonInputModel Specialization { get; set; }

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
        public Href Key { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class Race
    {
        [JsonProperty("key")]
        public Href Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class MythicPlusInputModelCharacter
    {
        [JsonProperty("key")]
        public Href Key { get; set; }

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
        public Href Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class LinksMp
    {
        [JsonProperty("self")]
        public Href SelfMp { get; set; }
    }

    public partial class Season
    {
        [JsonProperty("key")]
        public Href Key { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class MythicPlusInputModel
    {
        public static MythicPlusInputModel FromJson(string json) => JsonConvert.DeserializeObject<MythicPlusInputModel>(json, ConverterMp.Settings);
    }

    public static class SerializeMp
    {
        public static string ToJson(this MythicPlusInputModel self) => JsonConvert.SerializeObject(self, ConverterMp.Settings);
    }

    internal static class ConverterMp
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