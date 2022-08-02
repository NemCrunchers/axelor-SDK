using Axelor.SDK;

namespace Axelor.Apps.Quality.Db
{
	[Model("com.axelor.apps.quality.db.ControlPoint")]
	public class ControlPoint : AxelorModel
	{
		[Field("instructions")]
		public string? Instructions;

		[Field("messageIfFailure")]
		public string? MessageIfFailure;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("notes")]
		public string? Notes;

		[Field("testTypeSelect")]
		public int? TestTypeSelect;

		[Field("qualityControl")]
		public Axelor.Apps.Quality.Db.QualityControl? QualityControl;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("controlTypeSelect")]
		public int? ControlTypeSelect;

		[Field("responsible")]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

	}
}
