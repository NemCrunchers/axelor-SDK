using Axelor.SDK;

namespace Axelor.Apps.Businessproject.Db
{
	[Model("com.axelor.apps.businessproject.db.ProductTaskTemplate")]
	public class ProductTaskTemplate : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("parentTaskTemplate")]
		public Axelor.Apps.Project.Db.TaskTemplate? ParentTaskTemplate;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("assignedTo")]
		public Axelor.Auth.Db.User? AssignedTo;

		[Field("attrs")]
		public string? Attrs;

		[Field("isUniqueTaskForMultipleQuantity")]
		public bool? IsUniqueTaskForMultipleQuantity;

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
