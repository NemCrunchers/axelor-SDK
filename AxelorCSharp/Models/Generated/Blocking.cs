using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Blocking")]
	public class Blocking : AxelorModel
	{
		[Field("blockingSelect")]
		public int? BlockingSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("blockingByUser")]
		public Axelor.Auth.Db.User? BlockingByUser;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("blockingReason")]
		public Axelor.Apps.Base.Db.StopReason? BlockingReason;

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

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("companySet")]
		public IEnumerable<Axelor.Apps.Base.Db.Company>? CompanySet;

	}
}
