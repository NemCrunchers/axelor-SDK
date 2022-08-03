using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.ConsumptionLine")]
	public class ConsumptionLine : AxelorModel
	{
		[JsonProperty("contractLine")]
		[Field("contractLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractLine? ContractLine;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isInvoiced")]
		[Field("isInvoiced", false, "False", Int32.MaxValue)]
		public bool? IsInvoiced;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

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

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("isError")]
		[Field("isError", false, "False", Int32.MaxValue)]
		public bool? IsError;

		[JsonProperty("lineDate")]
		[Field("lineDate", false, null, Int32.MaxValue)]
		public DateTime? LineDate;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("invoiceLine")]
		[Field("invoiceLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
