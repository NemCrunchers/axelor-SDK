using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.BankDetails")]
	public class BankDetails : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("accountNbr")]
		public string? AccountNbr;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("bank")]
		public Axelor.Apps.Base.Db.Bank? Bank;

		[Field("ownerName")]
		public string? OwnerName;

		[Field("bbanKey")]
		public string? BbanKey;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("bankCode")]
		public string? BankCode;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("ibanBic")]
		public string? IbanBic;

		[Field("active")]
		public bool? Active;

		[Field("fullName")]
		public string? FullName;

		[Field("label")]
		public string? Label;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("bankAddress")]
		public Axelor.Apps.Base.Db.BankAddress? BankAddress;

		[Field("sortCode")]
		public string? SortCode;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("isDefault")]
		public bool? IsDefault;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("iban")]
		public string? Iban;

	}
}
