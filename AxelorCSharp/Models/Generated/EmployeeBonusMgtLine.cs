using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmployeeBonusMgtLine")]
	public class EmployeeBonusMgtLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("payrollPreparation")]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("weeklyPlanning")]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

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

		[Field("employeeBonusMgt")]
		public Axelor.Apps.Hr.Db.EmployeeBonusMgt? EmployeeBonusMgt;

		[Field("id")]
		public long? Id;

	}
}
