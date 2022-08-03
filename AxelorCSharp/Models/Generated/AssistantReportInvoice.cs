using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AssistantReportInvoice")]
	public class AssistantReportInvoice : AxelorModel
	{
		[JsonProperty("formatSelect")]
		[Field("formatSelect", false, "pdf", Int32.MaxValue)]
		public string? FormatSelect;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("turnoverTypeSelect")]
		[Field("turnoverTypeSelect", false, "3", Int32.MaxValue)]
		public int? TurnoverTypeSelect;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("graphTypeSelect")]
		[Field("graphTypeSelect", false, "1", Int32.MaxValue)]
		public int? GraphTypeSelect;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("type")]
		[Field("type", false, "0", Int32.MaxValue)]
		public int? Type;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("productSet")]
		[Field("productSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productCategorySet")]
		[Field("productCategorySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductCategory>? ProductCategorySet;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("publicationDateTime")]
		[Field("publicationDateTime", false, null, Int32.MaxValue)]
		public DateTime? PublicationDateTime;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

	}
}
