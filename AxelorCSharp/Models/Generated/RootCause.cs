using Axelor.SDK;

namespace Axelor.Apps.Quality.Db
{
	[Model("com.axelor.apps.quality.db.RootCause")]
	public class RootCause : AxelorModel
	{
		[Field("archived")]
		public bool? Archived;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("importId")]
		public string? ImportId;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

	}
}
