using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AccountChart")]
	public class AccountChart : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("countryCode")]
		public string? CountryCode;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("companySet")]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
