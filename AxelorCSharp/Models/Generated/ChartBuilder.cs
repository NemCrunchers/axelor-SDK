using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.ChartBuilder")]
	public class ChartBuilder : AxelorModel
	{
		[JsonProperty("aggregateOnTargetType")]
		[Field("aggregateOnTargetType", false, null, Int32.MaxValue)]
		public string? AggregateOnTargetType;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("aggregateOnJson")]
		[Field("aggregateOnJson", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? AggregateOnJson;

		[JsonProperty("groupOn")]
		[Field("groupOn", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? GroupOn;

		[JsonProperty("groupOnTargetType")]
		[Field("groupOnTargetType", false, null, Int32.MaxValue)]
		public string? GroupOnTargetType;

		[JsonProperty("metaViewGenerated")]
		[Field("metaViewGenerated", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaView? MetaViewGenerated;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("groupOnJson")]
		[Field("groupOnJson", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? GroupOnJson;

		[JsonProperty("aggregateDateType")]
		[Field("aggregateDateType", false, null, Int32.MaxValue)]
		public string? AggregateDateType;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("groupDateType")]
		[Field("groupDateType", false, null, Int32.MaxValue)]
		public string? GroupDateType;

		[JsonProperty("isJsonAggregateOn")]
		[Field("isJsonAggregateOn", false, "False", Int32.MaxValue)]
		public bool? IsJsonAggregateOn;

		[JsonProperty("aggregateOn")]
		[Field("aggregateOn", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? AggregateOn;

		[JsonProperty("isJson")]
		[Field("isJson", false, "False", Int32.MaxValue)]
		public bool? IsJson;

		[JsonProperty("model")]
		[Field("model", false, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("filterList")]
		[Field("filterList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.Filter>? FilterList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("groupOnTarget")]
		[Field("groupOnTarget", false, null, Int32.MaxValue)]
		public string? GroupOnTarget;

		[JsonProperty("isJsonDisplayField")]
		[Field("isJsonDisplayField", false, "False", Int32.MaxValue)]
		public bool? IsJsonDisplayField;

		[JsonProperty("isJsonGroupOn")]
		[Field("isJsonGroupOn", false, "False", Int32.MaxValue)]
		public bool? IsJsonGroupOn;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("aggregateOnTarget")]
		[Field("aggregateOnTarget", false, null, Int32.MaxValue)]
		public string? AggregateOnTarget;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("displayType")]
		[Field("displayType", false, "0", Int32.MaxValue)]
		public int? DisplayType;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("displayFieldJson")]
		[Field("displayFieldJson", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? DisplayFieldJson;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("chartType")]
		[Field("chartType", false, "bar", Int32.MaxValue)]
		public string? ChartType;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("displayField")]
		[Field("displayField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? DisplayField;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
