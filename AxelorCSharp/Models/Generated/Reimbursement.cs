using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Reimbursement")]
	public class Reimbursement : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("ref")]
		[Field("ref", false, null, Int32.MaxValue)]
		public string? Ref;

		[JsonProperty("amountToReimburse")]
		[Field("amountToReimburse", false, null, Int32.MaxValue)]
		public decimal? AmountToReimburse;

		[JsonProperty("rejectDate")]
		[Field("rejectDate", false, null, Int32.MaxValue)]
		public DateTime? RejectDate;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("moveLineSet")]
		[Field("moveLineSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.MoveLine>? MoveLineSet;

		[JsonProperty("rejectMoveLine")]
		[Field("rejectMoveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? RejectMoveLine;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("rejectedOk")]
		[Field("rejectedOk", false, "False", Int32.MaxValue)]
		public bool? RejectedOk;

		[JsonProperty("amountReimbursed")]
		[Field("amountReimbursed", false, "0", Int32.MaxValue)]
		public decimal? AmountReimbursed;

	}
}
