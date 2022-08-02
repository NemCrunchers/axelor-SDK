using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountingSituation")]
	public class AccountingSituation : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("employeeAccount")]
		public Axelor.Apps.Account.Db.Account? EmployeeAccount;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("companyInBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyInBankDetails;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("supplierAccount")]
		public Axelor.Apps.Account.Db.Account? SupplierAccount;

		[Field("invoiceMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? InvoiceMessageTemplate;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("invoiceAutomaticMail")]
		public bool? InvoiceAutomaticMail;

		[Field("companyOutBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyOutBankDetails;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("customerAccount")]
		public Axelor.Apps.Account.Db.Account? CustomerAccount;

		[Field("custAccountMustBeUpdateOk")]
		public bool? CustAccountMustBeUpdateOk;

	}
}
