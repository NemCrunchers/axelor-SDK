using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PaymentCondition")]
	public class PaymentCondition : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

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

		[JsonProperty("isFree")]
		[Field("isFree", false, "False", Int32.MaxValue)]
		public bool? IsFree;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("periodTypeSelect")]
		[Field("periodTypeSelect", false, "1", Int32.MaxValue)]
		public int? PeriodTypeSelect;

		[JsonProperty("daySelect")]
		[Field("daySelect", false, "0", Int32.MaxValue)]
		public int? DaySelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("paymentTime")]
		[Field("paymentTime", false, "0", Int32.MaxValue)]
		public int? PaymentTime;

	}
}
