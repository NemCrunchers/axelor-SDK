using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.TrainingSession")]
	public class TrainingSession : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("nbrRegistered")]
		public int? NbrRegistered;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("toDate")]
		public DateTime? ToDate;

		[Field("fullName")]
		public string? FullName;

		[Field("training")]
		public Axelor.Apps.Talent.Db.Training? Training;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

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

		[Field("location")]
		public string? Location;

		[Field("id")]
		public long? Id;

	}
}
