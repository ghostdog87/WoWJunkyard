using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WoWJunkyard.Services.Utilities
{
    public class CharacterItemsConverter : JsonConverter
    {
        private readonly List<string> _propertyMappings = new List<string>
        {
            "head", "neck", "shoulder"
        };

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo().IsClass;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object instance = Activator.CreateInstance(objectType);
            var props = objectType.GetTypeInfo().DeclaredProperties.ToList();

            JObject jo = JObject.Load(reader);
            foreach (JProperty jp in jo.Properties())
            {
                var name = "";

                if (_propertyMappings.Contains(jp.Name))
                {
                    name = jp.Name;
                }
                
                PropertyInfo prop = props.FirstOrDefault(pi =>
                    pi.CanWrite && pi.GetCustomAttribute<JsonPropertyAttribute>().PropertyName == name);

                prop?.SetValue(instance, jp.Value.ToObject(prop.PropertyType, serializer));
            }

            return instance;
        }
    }
}