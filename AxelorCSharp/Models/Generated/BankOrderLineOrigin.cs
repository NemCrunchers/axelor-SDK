using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankOrderLineOrigin")]
	public class BankOrderLineOrigin : AxelorModel
	{
		[JsonProperty("bankOrderLine")]
		[Field("bankOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderLine? BankOrderLine;

		[JsonProperty("relatedToSelectId")]
		[Field("relatedToSelectId", false, "0", Int32.MaxValue)]
		public long? RelatedToSelectId;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("relatedToSelectName")]
		[Field("relatedToSelectName", false, null, Int32.MaxValue)]
		public string? RelatedToSelectName;

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

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("relatedToSelect")]
		[Field("relatedToSelect", false, null, Int32.MaxValue)]
		public string? RelatedToSelect;

	}
}
