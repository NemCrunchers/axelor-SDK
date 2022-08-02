using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.DepositSlip")]
	public class DepositSlip : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentModeTypeSelect")]
		public int? PaymentModeTypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("chequeCount")]
		public int? ChequeCount;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("companyBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[Field("archived")]
		public bool? Archived;

		[Field("depositNumber")]
		public string? DepositNumber;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

	}
}
