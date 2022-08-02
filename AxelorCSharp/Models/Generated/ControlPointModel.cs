using Axelor.SDK;

namespace Axelor.Apps.Quality.Db
{
	[Model("com.axelor.apps.quality.db.ControlPointModel")]
	public class ControlPointModel : AxelorModel
	{
		[Field("instructions")]
		public string? Instructions;

		[Field("messageIfFailure")]
		public string? MessageIfFailure;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("notes")]
		public string? Notes;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("testTypeSelect")]
		public int? TestTypeSelect;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("controlTypeSelect")]
		public int? ControlTypeSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("responsible")]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[Field("name")]
		public string? Name;

		[Field("qualityProcess")]
		public Axelor.Apps.Quality.Db.QualityProcess? QualityProcess;

		[Field("id")]
		public long? Id;

	}
}
