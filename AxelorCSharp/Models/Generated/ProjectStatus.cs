using Axelor.SDK;

namespace Axelor.Apps.Project.Db
{
	[Model("com.axelor.apps.project.db.ProjectStatus")]
	public class ProjectStatus : AxelorModel
	{
		[Field("isClose")]
		public bool? IsClose;

		[Field("importOrigin")]
		public string? ImportOrigin;

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

		[Field("defaultStatus")]
		public bool? DefaultStatus;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("isOpen")]
		public bool? IsOpen;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
