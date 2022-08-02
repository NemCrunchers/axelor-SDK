using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Bank")]
	public class Bank : AxelorModel
	{
		[Field("country")]
		public Axelor.Apps.Base.Db.Country? Country;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("bankName")]
		public string? BankName;

		[Field("businessPartyPrefix")]
		public string? BusinessPartyPrefix;

		[Field("businessPartySuffix")]
		public string? BusinessPartySuffix;

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

		[Field("branchIdentifier")]
		public string? BranchIdentifier;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("bankDetailsTypeSelect")]
		public int? BankDetailsTypeSelect;

		[Field("id")]
		public long? Id;

	}
}
