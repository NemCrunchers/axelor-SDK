using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.TrainingRegister")]
	public class TrainingRegister : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("toDate")]
		public DateTime? ToDate;

		[Field("training")]
		public Axelor.Apps.Talent.Db.Training? Training;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("fromDate")]
		public DateTime? FromDate;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("ratingSelect")]
		public int? RatingSelect;

		[Field("id")]
		public long? Id;

		[Field("trainingSession")]
		public Axelor.Apps.Talent.Db.TrainingSession? TrainingSession;

	}
}
