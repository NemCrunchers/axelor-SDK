using Axelor.SDK;

namespace Axelor.Apps.Quality.Db
{
	[Model("com.axelor.apps.quality.db.QualityAlert")]
	public class QualityAlert : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("correctiveActions")]
		public string? CorrectiveActions;

		[Field("description")]
		public string? Description;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("responsible")]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[Field("rootCause")]
		public Axelor.Apps.Quality.Db.RootCause? RootCause;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("prioritySelect")]
		public int? PrioritySelect;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("preventiveActions")]
		public string? PreventiveActions;

		[Field("workCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("qualityTagSet")]
		public IEnumerable<Axelor.Apps.Quality.Db.QualityTag>? QualityTagSet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
