using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankPaymentBatch")]
	public class BankPaymentBatch : AxelorModel
	{
		[JsonProperty("template")]
		[Field("template", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? Template;

		[JsonProperty("bankStatementFileFormatSet")]
		[Field("bankStatementFileFormatSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankStatementFileFormat>? BankStatementFileFormatSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("ebicsPartnerSet")]
		[Field("ebicsPartnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsPartner>? EbicsPartnerSet;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("daysNbr")]
		[Field("daysNbr", false, "0", Int32.MaxValue)]
		public int? DaysNbr;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("batchList")]
		[Field("batchList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[JsonProperty("actionSelect")]
		[Field("actionSelect", true, "0", Int32.MaxValue)]
		public int? ActionSelect;

	}
}
