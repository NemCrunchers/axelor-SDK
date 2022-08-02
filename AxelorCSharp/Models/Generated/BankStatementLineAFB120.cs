using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankStatementLineAFB120")]
	public class BankStatementLineAFB120 : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("origin")]
		public string? Origin;

		[Field("bankStatement")]
		public Axelor.Apps.Bankpayment.Db.BankStatement? BankStatement;

		[Field("rejectInterbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? RejectInterbankCodeLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("commissionExemptionIndexSelect")]
		public int? CommissionExemptionIndexSelect;

		[Field("unavailabilityIndexSelect")]
		public int? UnavailabilityIndexSelect;

		[Field("operationInterbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? OperationInterbankCodeLine;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("lineTypeSelect")]
		public int? LineTypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
