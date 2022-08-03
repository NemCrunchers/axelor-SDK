using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.ConfiguratorProductFormula")]
	public class ConfiguratorProductFormula : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("showOnConfigurator")]
		[Field("showOnConfigurator", false, "False", Int32.MaxValue)]
		public bool? ShowOnConfigurator;

		[JsonProperty("productCreator")]
		[Field("productCreator", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.ConfiguratorCreator? ProductCreator;

		[JsonProperty("metaField")]
		[Field("metaField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? MetaField;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("formula")]
		[Field("formula", false, null, Int32.MaxValue)]
		public string? Formula;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
