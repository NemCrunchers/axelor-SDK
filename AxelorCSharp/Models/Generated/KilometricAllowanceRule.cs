using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.KilometricAllowanceRule")]
	public class KilometricAllowanceRule : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("hrConfig")]
		public Axelor.Apps.Hr.Db.HRConfig? HrConfig;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("kilometricAllowanceRate")]
		public Axelor.Apps.Hr.Db.KilometricAllowanceRate? KilometricAllowanceRate;

		[Field("id")]
		public long? Id;

	}
}
