namespace VoiceBot_Macro_Editor
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public partial class VoiceBot
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("global")]
        public bool Global { get; set; }

        [JsonProperty("culturecode")]
        public string Culturecode { get; set; }

        [JsonProperty("iconsmall")]
        public string Iconsmall { get; set; }

        [JsonProperty("iconmedium")]
        public string Iconmedium { get; set; }

        [JsonProperty("wpftagname")]
        public string Wpftagname { get; set; }

        [JsonProperty("wpftagslug")]
        public string Wpftagslug { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("macros")]
        public List<Macro> Macros { get; set; }
    }

    public partial class Macro
    {
        public Macro(string n, string desc, string hk, bool d, bool bi, string c, string g, List<Action> a)
        {
            Name = n;
            Description = desc;
            Hotkey = hk;
            Disabled = d;
            BuiltIn = bi;
            Command = c;
            Group = g;
            Actions = a;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hotkey")]
        public string Hotkey { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("built-in")]
        public bool BuiltIn { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }

        public void Replace(string rotton, string fresh)
        {
            if (Name.ToLower().Contains(rotton.ToLower()))
            {
                Name = Regex.Replace(Name, rotton, fresh, RegexOptions.IgnoreCase);
            }
            if (Command.ToLower().Contains(rotton.ToLower()))
            {
                Command = Regex.Replace(Command, rotton, fresh, RegexOptions.IgnoreCase);
            }
            if (Description.ToLower().Contains(rotton.ToLower()))
            {
                Description = Regex.Replace(Description, rotton, fresh, RegexOptions.IgnoreCase);
            }
        }

        public override string ToString()
        {
            return Name + "," + Command + "," + Description;
        }
    }

    public partial class Action
    {
        public Action(string actionAction, string value, string references)
        {
            ActionAction = actionAction;
            Value = value;
            References = references;
        }

        [JsonProperty("action")]
        public string ActionAction { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public string References { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public int Language { get; set; }

        [JsonProperty("audiodevicename", NullValueHandling = NullValueHandling.Ignore)]
        public string Audiodevicename { get; set; }

        [JsonProperty("audiodevicemode", NullValueHandling = NullValueHandling.Ignore)]
        public string Audiodevicemode { get; set; }

        [JsonProperty("audiodevicerole", NullValueHandling = NullValueHandling.Ignore)]
        public string Audiodevicerole { get; set; }

        public void Replace(string rotton, string fresh)
        {
            if (Value.ToLower().Contains(rotton.ToLower()))
            {
                Value = Regex.Replace(Value, rotton, fresh, RegexOptions.IgnoreCase);
            }
        }
    }

    public partial class VoiceBot
    {
        public static VoiceBot FromJson(string json) => JsonConvert.DeserializeObject<VoiceBot>(json, VoiceBot_Macro_Editor.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this VoiceBot self) => JsonConvert.SerializeObject(self, VoiceBot_Macro_Editor.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}