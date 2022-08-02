using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PaymentSchedule")]
	public class PaymentSchedule : AxelorModel
	{
		[Field("invoiceSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Invoice>? InvoiceSet;

		[Field("managementObject")]
		public Axelor.Apps.Account.Db.ManagementObject? ManagementObject;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("irrecoverableStatusSelect")]
		public int? IrrecoverableStatusSelect;

		[Field("id")]
		public long? Id;

		[Field("nbrTerm")]
		public int? NbrTerm;

		[Field("paymentScheduleSeq")]
		public string? PaymentScheduleSeq;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("rejectCounter")]
		public int? RejectCounter;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
