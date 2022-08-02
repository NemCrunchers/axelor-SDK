using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.ChartBuilder")]
	public class ChartBuilder : AxelorModel
	{
		[Field("aggregateOnTargetType")]
		public string? AggregateOnTargetType;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("aggregateOnJson")]
		public Axelor.Meta.Db.MetaJsonField? AggregateOnJson;

		[Field("groupOn")]
		public Axelor.Meta.Db.MetaField? GroupOn;

		[Field("groupOnTargetType")]
		public string? GroupOnTargetType;

		[Field("metaViewGenerated")]
		public Axelor.Meta.Db.MetaView? MetaViewGenerated;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("groupOnJson")]
		public Axelor.Meta.Db.MetaJsonField? GroupOnJson;

		[Field("aggregateDateType")]
		public string? AggregateDateType;

		[Field("archived")]
		public bool? Archived;

		[Field("groupDateType")]
		public string? GroupDateType;

		[Field("isJsonAggregateOn")]
		public bool? IsJsonAggregateOn;

		[Field("aggregateOn")]
		public Axelor.Meta.Db.MetaField? AggregateOn;

		[Field("isJson")]
		public bool? IsJson;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("groupOnTarget")]
		public string? GroupOnTarget;

		[Field("isJsonDisplayField")]
		public bool? IsJsonDisplayField;

		[Field("isJsonGroupOn")]
		public bool? IsJsonGroupOn;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("aggregateOnTarget")]
		public string? AggregateOnTarget;

		[Field("attrs")]
		public string? Attrs;

		[Field("displayType")]
		public int? DisplayType;

		[Field("importId")]
		public string? ImportId;

		[Field("displayFieldJson")]
		public Axelor.Meta.Db.MetaJsonField? DisplayFieldJson;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("chartType")]
		public string? ChartType;

		[Field("name")]
		public string? Name;

		[Field("displayField")]
		public Axelor.Meta.Db.MetaField? DisplayField;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
