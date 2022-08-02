using Axelor.SDK;

namespace Axelor.Team.Db
{
	[Model("com.axelor.team.db.TeamTask")]
	public class TeamTask : AxelorModel
	{
		[Field("toInvoice")]
		public bool? ToInvoice;

		[Field("relatedName")]
		public string? RelatedName;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("relatedModel")]
		public string? RelatedModel;

		[Field("projectCategory")]
		public Axelor.Apps.Project.Db.ProjectCategory? ProjectCategory;

		[Field("id")]
		public long? Id;

		[Field("progressSelect")]
		public int? ProgressSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("parentTask")]
		public Axelor.Team.Db.TeamTask? ParentTask;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public string? Priority;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("relatedId")]
		public long? RelatedId;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("name")]
		public string? Name;

		[Field("status")]
		public string? Status;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("discountTypeSelect")]
		public int? DiscountTypeSelect;

		[Field("assignedTo")]
		public Axelor.Auth.Db.User? AssignedTo;

		[Field("archived")]
		public bool? Archived;

		[Field("finishToStartSet")]
		public IEnumerable<Axelor.Team.Db.TeamTask>? FinishToStartSet;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("membersUserSet")]
		public IEnumerable<Axelor.Auth.Db.User>? MembersUserSet;

		[Field("taskDuration")]
		public int? TaskDuration;

		[Field("fullName")]
		public string? FullName;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
