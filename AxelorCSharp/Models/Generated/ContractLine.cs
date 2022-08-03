using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.ContractLine")]
	public class ContractLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("isInvoiced")]
		[Field("isInvoiced", false, "False", Int32.MaxValue)]
		public bool? IsInvoiced;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("contractVersion")]
		[Field("contractVersion", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractVersion? ContractVersion;

		[JsonProperty("productName")]
		[Field("productName", true, null, Int32.MaxValue)]
		public string? ProductName;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("isConsumptionLine")]
		[Field("isConsumptionLine", false, "False", Int32.MaxValue)]
		public bool? IsConsumptionLine;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("qty")]
		[Field("qty", false, "1", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("fiscalPosition")]
		[Field("fiscalPosition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

	}
}
