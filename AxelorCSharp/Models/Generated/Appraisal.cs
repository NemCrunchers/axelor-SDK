using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.Appraisal")]
	public class Appraisal : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("reviewerEmployee")]
		public Axelor.Apps.Hr.Db.Employee? ReviewerEmployee;

		[Field("appraisalType")]
		public Axelor.Apps.Talent.Db.AppraisalType? AppraisalType;

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

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isTemplate")]
		public bool? IsTemplate;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
