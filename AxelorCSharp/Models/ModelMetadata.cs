using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AxelorCSharp.Models
{
	public class ModelMetadata
    {
        public int Status;
        public FieldMetadata Data;
    }
    public class FieldMetadata
    {
        public JsonFields JsonFields;
        public string Model;
        public Perms Perms;
        public List<Field> Fields;
    }

    public class JsonFields
    {
        public Attrs attrs;
    }
    public class Perms
    {
        public bool MassUpdate;
    }
    public class Field
    {
        [JsonProperty("massUpdate")]
        public bool MassUpdate;
        [JsonProperty("defaultValue")]
        public object DefaultValue;
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("type")]
        public string Type;
        [JsonProperty("title")]
        public string Title;
        [JsonProperty("readonly")]
        public bool ReadOnly;
        [JsonProperty("required")]
        public bool Required;
        [JsonProperty("targetName")]
        public string TargetName;
        [JsonProperty("targetSearch")]
        public List<String> TargetSearch;
        [JsonProperty("perms")]
        public Perms Perms;
        [JsonProperty("target")]
        public string Target;
        [JsonProperty("hidden")]
        public bool Hidden;
        [JsonProperty("primary")]
        public bool Primary;
        [JsonProperty("virtual")]
        public bool Virtual;
        [JsonProperty("nameSearch")]
        public List<string> NameSearch;
        [JsonProperty("nameColumn")]
        public bool NameColumn;
        [JsonProperty("json")]
        public bool Json;
        [JsonProperty("nullable")]
        public bool Nullable;
        [JsonProperty("unique")]
        public bool Unique;
    }
    public class Attrs
    {
    }
}
