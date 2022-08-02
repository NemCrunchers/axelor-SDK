using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankReconciliationLine")]
	public class BankReconciliationLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("bankStatementLine")]
		public Axelor.Apps.Bankpayment.Db.BankStatementLine? BankStatementLine;

		[Field("moveLine")]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("bankReconciliation")]
		public Axelor.Apps.Bankpayment.Db.BankReconciliation? BankReconciliation;

		[Field("importId")]
		public string? ImportId;

		[Field("isPosted")]
		public bool? IsPosted;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
