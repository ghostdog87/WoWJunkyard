namespace WoWJunkyard.Views.ViewModels
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CharacterItemsInputModel
    {
        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("character")]
        public CharacterClass CharacterCharacter { get; set; }

        [JsonProperty("equipped_items")]
        public List<EquippedItemInputModel> EquippedItems { get; set; }

        [JsonProperty("equipped_item_sets")]
        public List<Set> EquippedItemSets { get; set; }
    }

    public partial class CharacterClass
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("realm")]
        public Realm Realm { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public partial class Realm
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class Set
    {
        [JsonProperty("item_set")]
        public ItemSet ItemSet { get; set; }

        [JsonProperty("items")]
        public List<ItemElement> Items { get; set; }

        [JsonProperty("effects")]
        public List<Effect> Effects { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }
    }

    public partial class Effect
    {
        [JsonProperty("display_string")]
        public object DisplayString { get; set; }

        [JsonProperty("required_count")]
        public long RequiredCount { get; set; }
    }

    public partial class ItemSet
    {
        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class ItemElement
    {
        [JsonProperty("item")]
        public ItemClass Item { get; set; }

        [JsonProperty("is_equipped", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEquipped { get; set; }
    }

    public partial class ItemClass
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class EquippedItemInputModel
    {
        [JsonProperty("item")]
        public MediaClass Item { get; set; }

        [JsonProperty("slot")]
        public InventoryTypeInputModel Slot { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("context")]
        public long Context { get; set; }

        [JsonProperty("bonus_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> BonusList { get; set; }

        [JsonProperty("quality")]
        public Quality Quality { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("modified_appearance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedAppearanceId { get; set; }

        [JsonProperty("azerite_details", NullValueHandling = NullValueHandling.Ignore)]
        public AzeriteDetails AzeriteDetails { get; set; }

        [JsonProperty("name_description")]
        public object NameDescription { get; set; }

        [JsonProperty("media")]
        public MediaClass Media { get; set; }

        [JsonProperty("item_class")]
        public ItemClass ItemClass { get; set; }

        [JsonProperty("item_subclass")]
        public ItemClass ItemSubclass { get; set; }

        [JsonProperty("inventory_type")]
        public InventoryTypeInputModel InventoryType { get; set; }

        [JsonProperty("binding")]
        public Binding Binding { get; set; }

        [JsonProperty("armor", NullValueHandling = NullValueHandling.Ignore)]
        public Armor Armor { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stat> Stats { get; set; }

        [JsonProperty("requirements")]
        public Requirements Requirements { get; set; }

        [JsonProperty("level")]
        public Armor Level { get; set; }

        [JsonProperty("durability", NullValueHandling = NullValueHandling.Ignore)]
        public Armor Durability { get; set; }

        [JsonProperty("unique_equipped")]
        public object UniqueEquipped { get; set; }

        [JsonProperty("spells", NullValueHandling = NullValueHandling.Ignore)]
        public List<Spell> Spells { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("sell_price", NullValueHandling = NullValueHandling.Ignore)]
        public SellPrice SellPrice { get; set; }

        [JsonProperty("sockets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Socket> Sockets { get; set; }

        [JsonProperty("enchantments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Enchantment> Enchantments { get; set; }

        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        public Set Set { get; set; }

        [JsonProperty("weapon", NullValueHandling = NullValueHandling.Ignore)]
        public Weapon Weapon { get; set; }
    }

    public partial class Armor
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }
    }

    public partial class AzeriteDetails
    {
        [JsonProperty("selected_powers", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectedPower> SelectedPowers { get; set; }

        [JsonProperty("selected_powers_string")]
        public object SelectedPowersString { get; set; }

        [JsonProperty("percentage_to_next_level", NullValueHandling = NullValueHandling.Ignore)]
        public double? PercentageToNextLevel { get; set; }

        [JsonProperty("selected_essences", NullValueHandling = NullValueHandling.Ignore)]
        public List<SelectedEssence> SelectedEssences { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public Armor Level { get; set; }
    }

    public partial class SelectedEssence
    {
        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("main_spell_tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public MainSpellTooltip MainSpellTooltip { get; set; }

        [JsonProperty("passive_spell_tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public SpellTooltip PassiveSpellTooltip { get; set; }

        [JsonProperty("essence", NullValueHandling = NullValueHandling.Ignore)]
        public ItemClass Essence { get; set; }

        [JsonProperty("media", NullValueHandling = NullValueHandling.Ignore)]
        public MediaClass Media { get; set; }
    }

    public partial class MainSpellTooltip
    {
        [JsonProperty("spell")]
        public ItemClass Spell { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("cast_time")]
        public object CastTime { get; set; }

        [JsonProperty("cooldown")]
        public object Cooldown { get; set; }
    }

    public partial class MediaClass
    {
        [JsonProperty("key")]
        public Self Key { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class SpellTooltip
    {
        [JsonProperty("spell")]
        public ItemClass Spell { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("cast_time")]
        public object CastTime { get; set; }
    }

    public partial class SelectedPower
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("spell_tooltip", NullValueHandling = NullValueHandling.Ignore)]
        public SpellTooltip SpellTooltip { get; set; }

        [JsonProperty("is_display_hidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisplayHidden { get; set; }
    }

    public partial class Binding
    {
        [JsonProperty("type")]
        public BindingType Type { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }

    public partial class Enchantment
    {
        [JsonProperty("display_string")]
        public object DisplayString { get; set; }

        [JsonProperty("source_item")]
        public ItemClass SourceItem { get; set; }

        [JsonProperty("enchantment_id")]
        public long EnchantmentId { get; set; }

        [JsonProperty("enchantment_slot")]
        public EnchantmentSlot EnchantmentSlot { get; set; }
    }

    public partial class EnchantmentSlot
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class InventoryTypeInputModel
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }

    public partial class Quality
    {
        [JsonProperty("type")]
        public QualityType Type { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }
    }

    public partial class Requirements
    {
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public Armor Level { get; set; }

        [JsonProperty("playable_races", NullValueHandling = NullValueHandling.Ignore)]
        public PlayableRaces PlayableRaces { get; set; }
    }

    public partial class PlayableRaces
    {
        [JsonProperty("links")]
        public List<ItemClass> Links { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }
    }

    public partial class SellPrice
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("display_strings")]
        public DisplayStrings DisplayStrings { get; set; }
    }

    public partial class DisplayStrings
    {
        [JsonProperty("header")]
        public object Header { get; set; }

        [JsonProperty("gold")]
        public object Gold { get; set; }

        [JsonProperty("silver")]
        public object Silver { get; set; }

        [JsonProperty("copper")]
        public object Copper { get; set; }
    }

    public partial class Socket
    {
        [JsonProperty("socket_type")]
        public InventoryTypeInputModel SocketType { get; set; }

        [JsonProperty("item")]
        public ItemClass Item { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }

        [JsonProperty("media")]
        public MediaClass Media { get; set; }
    }

    public partial class Spell
    {
        [JsonProperty("spell")]
        public ItemClass SpellSpell { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }
    }

    public partial class Stat
    {
        [JsonProperty("type")]
        public InventoryTypeInputModel Type { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }

        [JsonProperty("is_negated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNegated { get; set; }

        [JsonProperty("is_equip_bonus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEquipBonus { get; set; }
    }

    public partial class Weapon
    {
        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("attack_speed")]
        public Armor AttackSpeed { get; set; }

        [JsonProperty("dps")]
        public Dps Dps { get; set; }
    }

    public partial class Damage
    {
        [JsonProperty("min_value")]
        public long MinValue { get; set; }

        [JsonProperty("max_value")]
        public long MaxValue { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }
    }

    public partial class Dps
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display_string")]
        public object DisplayString { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }
    }

    public enum BindingType { OnAcquire };

    public enum QualityType { Artifact, Epic, Rare };

    internal class BindingTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BindingType) || t == typeof(BindingType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ON_ACQUIRE")
            {
                return BindingType.OnAcquire;
            }
            throw new Exception("Cannot unmarshal type BindingType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BindingType)untypedValue;
            if (value == BindingType.OnAcquire)
            {
                serializer.Serialize(writer, "ON_ACQUIRE");
                return;
            }
            throw new Exception("Cannot marshal type BindingType");
        }

        public static readonly BindingTypeConverter Singleton = new BindingTypeConverter();
    }

    public partial class CharacterItemsInputModel
    {
        public static CharacterItemsInputModel FromJson(string json) => JsonConvert.DeserializeObject<CharacterItemsInputModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CharacterItemsInputModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                BindingTypeConverter.Singleton,
                QualityTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class QualityTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(QualityType) || t == typeof(QualityType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ARTIFACT":
                    return QualityType.Artifact;
                case "EPIC":
                    return QualityType.Epic;
                case "RARE":
                    return QualityType.Rare;
            }
            throw new Exception("Cannot unmarshal type QualityType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (QualityType)untypedValue;
            switch (value)
            {
                case QualityType.Artifact:
                    serializer.Serialize(writer, "ARTIFACT");
                    return;
                case QualityType.Epic:
                    serializer.Serialize(writer, "EPIC");
                    return;
                case QualityType.Rare:
                    serializer.Serialize(writer, "RARE");
                    return;
            }
            throw new Exception("Cannot marshal type QualityType");
        }

        public static readonly QualityTypeConverter Singleton = new QualityTypeConverter();
    }
}