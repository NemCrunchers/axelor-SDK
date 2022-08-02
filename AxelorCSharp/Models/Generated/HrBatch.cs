using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.HrBatch")]
	public class HrBatch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("exportAlreadyExported")]
		public bool? ExportAlreadyExported;

		[Field("useWeeklyPlanningCoef")]
		public bool? UseWeeklyPlanningCoef;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("planningSet")]
		public IEnumerable<Axelor.Apps.Base.Db.WeeklyPlanning>? PlanningSet;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("payrollPreparationExportTypeSelect")]
		public int? PayrollPreparationExportTypeSelect;

		[Field("actionSelect")]
		public int? ActionSelect;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("comments")]
		public string? Comments;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("employeeSet")]
		public IEnumerable<Axelor.Apps.Hr.Db.Employee>? EmployeeSet;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("leaveReason")]
		public Axelor.Apps.Hr.Db.LeaveReason? LeaveReason;

	}
}
