using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.HrBatch")]
	public class HrBatch : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("exportAlreadyExported")]
		[Field("exportAlreadyExported", false, "False", Int32.MaxValue)]
		public bool? ExportAlreadyExported;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("useWeeklyPlanningCoef")]
		[Field("useWeeklyPlanningCoef", false, "False", Int32.MaxValue)]
		public bool? UseWeeklyPlanningCoef;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("planningSet")]
		[Field("planningSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.WeeklyPlanning>? PlanningSet;

		[JsonProperty("dayNumber")]
		[Field("dayNumber", false, "0", Int32.MaxValue)]
		public decimal? DayNumber;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("payrollPreparationExportTypeSelect")]
		[Field("payrollPreparationExportTypeSelect", false, "0", Int32.MaxValue)]
		public int? PayrollPreparationExportTypeSelect;

		[JsonProperty("batchList")]
		[Field("batchList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[JsonProperty("actionSelect")]
		[Field("actionSelect", true, "0", Int32.MaxValue)]
		public int? ActionSelect;

		[JsonProperty("referentialDate")]
		[Field("referentialDate", false, null, Int32.MaxValue)]
		public DateTime? ReferentialDate;

		[JsonProperty("period")]
		[Field("period", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? Period;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("employeeSet")]
		[Field("employeeSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.Employee>? EmployeeSet;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("leaveReason")]
		[Field("leaveReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.LeaveReason? LeaveReason;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
