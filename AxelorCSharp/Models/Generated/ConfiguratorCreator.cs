using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.ConfiguratorCreator")]
	public class ConfiguratorCreator : AxelorModel
	{
		[JsonProperty("authorizedGroupSet")]
		[Field("authorizedGroupSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? AuthorizedGroupSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("generateProduct")]
		[Field("generateProduct", false, "True", Int32.MaxValue)]
		public bool? GenerateProduct;

		[JsonProperty("indicators")]
		[Field("indicators", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaJsonField>? Indicators;

		[JsonProperty("isActive")]
		[Field("isActive", false, "False", Int32.MaxValue)]
		public bool? IsActive;

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

		[JsonProperty("authorizedUserSet")]
		[Field("authorizedUserSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? AuthorizedUserSet;

		[JsonProperty("configuratorSOLineFormulaList")]
		[Field("configuratorSOLineFormulaList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.ConfiguratorSOLineFormula>? ConfiguratorSOLineFormulaList;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("configuratorBom")]
		[Field("configuratorBom", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ConfiguratorBOM? ConfiguratorBom;

		[JsonProperty("configuratorProductFormulaList")]
		[Field("configuratorProductFormulaList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.ConfiguratorProductFormula>? ConfiguratorProductFormulaList;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("attributes")]
		[Field("attributes", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaJsonField>? Attributes;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
