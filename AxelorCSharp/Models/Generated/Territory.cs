using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Territory")]
	public class Territory : AxelorModel
	{
		[Field("country")]
		public Axelor.Apps.Base.Db.Country? Country;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("city")]
		public Axelor.Apps.Base.Db.City? City;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("authorityPartner")]
		public Axelor.Apps.Base.Db.Partner? AuthorityPartner;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
