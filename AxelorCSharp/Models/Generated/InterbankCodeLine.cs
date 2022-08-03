using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.InterbankCodeLine")]
	public class InterbankCodeLine : AxelorModel
	{
		[JsonProperty("lcrBorOk")]
		[Field("lcrBorOk", false, "False", Int32.MaxValue)]
		public bool? LcrBorOk;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("technicalRejectOk")]
		[Field("technicalRejectOk", false, "False", Int32.MaxValue)]
		public bool? TechnicalRejectOk;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("interbankCode")]
		[Field("interbankCode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCode? InterbankCode;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("directDebitSepaOk")]
		[Field("directDebitSepaOk", false, "False", Int32.MaxValue)]
		public bool? DirectDebitSepaOk;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("directDebitAndTipCfonbOk")]
		[Field("directDebitAndTipCfonbOk", false, "False", Int32.MaxValue)]
		public bool? DirectDebitAndTipCfonbOk;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("chequeOk")]
		[Field("chequeOk", false, "False", Int32.MaxValue)]
		public bool? ChequeOk;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("transferCfonbOk")]
		[Field("transferCfonbOk", false, "False", Int32.MaxValue)]
		public bool? TransferCfonbOk;

	}
}
