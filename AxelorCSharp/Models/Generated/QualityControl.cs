using Axelor.SDK;

namespace Axelor.Apps.Quality.Db
{
	[Model("com.axelor.apps.quality.db.QualityControl")]
	public class QualityControl : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("reference")]
		public string? Reference;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("responsible")]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[Field("qualityProcess")]
		public Axelor.Apps.Quality.Db.QualityProcess? QualityProcess;

		[Field("id")]
		public long? Id;

	}
}
