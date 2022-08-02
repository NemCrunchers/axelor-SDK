using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Umr")]
	public class Umr : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("debtorAddress")]
		public Axelor.Apps.Base.Db.Address? DebtorAddress;

		[Field("activeBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? ActiveBankDetails;

		[Field("umrNumber")]
		public string? UmrNumber;

		[Field("debtorName")]
		public string? DebtorName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("isUpdating")]
		public bool? IsUpdating;

		[Field("lastNumberIbanBic")]
		public string? LastNumberIbanBic;

		[Field("mandateSignatureCity")]
		public Axelor.Apps.Base.Db.City? MandateSignatureCity;

	}
}
