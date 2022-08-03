using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.HRConfig")]
	public class HRConfig : AxelorModel
	{
		[JsonProperty("exportCodeForLunchVoucherManagement")]
		[Field("exportCodeForLunchVoucherManagement", false, null, Int32.MaxValue)]
		public string? ExportCodeForLunchVoucherManagement;

		[JsonProperty("validatedExtraHoursTemplate")]
		[Field("validatedExtraHoursTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? ValidatedExtraHoursTemplate;

		[JsonProperty("validatedLeaveTemplate")]
		[Field("validatedLeaveTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? ValidatedLeaveTemplate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("refusedExpenseTemplate")]
		[Field("refusedExpenseTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RefusedExpenseTemplate;

		[JsonProperty("leaveMailNotification")]
		[Field("leaveMailNotification", false, "False", Int32.MaxValue)]
		public bool? LeaveMailNotification;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("sentTimesheetTemplate")]
		[Field("sentTimesheetTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? SentTimesheetTemplate;

		[JsonProperty("publicHolidayEventsPlanning")]
		[Field("publicHolidayEventsPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[JsonProperty("supplierLunchVoucher")]
		[Field("supplierLunchVoucher", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierLunchVoucher;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("sentLeaveTemplate")]
		[Field("sentLeaveTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? SentLeaveTemplate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sentExpenseTemplate")]
		[Field("sentExpenseTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? SentExpenseTemplate;

		[JsonProperty("lunchVoucherEmployersShare")]
		[Field("lunchVoucherEmployersShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherEmployersShare;

		[JsonProperty("toJustifyLeaveReason")]
		[Field("toJustifyLeaveReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.LeaveReason? ToJustifyLeaveReason;

		[JsonProperty("timesheetMailNotification")]
		[Field("timesheetMailNotification", false, "False", Int32.MaxValue)]
		public bool? TimesheetMailNotification;

		[JsonProperty("refusedLeaveTemplate")]
		[Field("refusedLeaveTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RefusedLeaveTemplate;

		[JsonProperty("workingDaysVariableName")]
		[Field("workingDaysVariableName", false, null, Int32.MaxValue)]
		public string? WorkingDaysVariableName;

		[JsonProperty("refusedExtraHoursTemplate")]
		[Field("refusedExtraHoursTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RefusedExtraHoursTemplate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("canceledTimesheetTemplate")]
		[Field("canceledTimesheetTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? CanceledTimesheetTemplate;

		[JsonProperty("expenseSequence")]
		[Field("expenseSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? ExpenseSequence;

		[JsonProperty("lunchVoucherFormatSelect")]
		[Field("lunchVoucherFormatSelect", false, "0", Int32.MaxValue)]
		public int? LunchVoucherFormatSelect;

		[JsonProperty("exportCodeForExtraHours")]
		[Field("exportCodeForExtraHours", false, null, Int32.MaxValue)]
		public string? ExportCodeForExtraHours;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("sentExtraHoursTemplate")]
		[Field("sentExtraHoursTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? SentExtraHoursTemplate;

		[JsonProperty("useUniqueProductForTimesheet")]
		[Field("useUniqueProductForTimesheet", false, "False", Int32.MaxValue)]
		public bool? UseUniqueProductForTimesheet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("canceledLeaveTemplate")]
		[Field("canceledLeaveTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? CanceledLeaveTemplate;

		[JsonProperty("uniqueTimesheetProduct")]
		[Field("uniqueTimesheetProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? UniqueTimesheetProduct;

		[JsonProperty("leaveManagementBatchRuleList")]
		[Field("leaveManagementBatchRuleList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LeaveManagementBatchRule>? LeaveManagementBatchRuleList;

		[JsonProperty("availableStockLunchVoucher")]
		[Field("availableStockLunchVoucher", false, "0", Int32.MaxValue)]
		public int? AvailableStockLunchVoucher;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("validatedTimesheetTemplate")]
		[Field("validatedTimesheetTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? ValidatedTimesheetTemplate;

		[JsonProperty("minStockLunchVoucher")]
		[Field("minStockLunchVoucher", false, "0", Int32.MaxValue)]
		public int? MinStockLunchVoucher;

		[JsonProperty("canceledExpenseTemplate")]
		[Field("canceledExpenseTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? CanceledExpenseTemplate;

		[JsonProperty("validatedExpenseTemplate")]
		[Field("validatedExpenseTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? ValidatedExpenseTemplate;

		[JsonProperty("ageVariableName")]
		[Field("ageVariableName", false, null, Int32.MaxValue)]
		public string? AgeVariableName;

		[JsonProperty("canceledExtraHoursTemplate")]
		[Field("canceledExtraHoursTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? CanceledExtraHoursTemplate;

		[JsonProperty("kilometricAllowanceRateList")]
		[Field("kilometricAllowanceRateList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.KilometricAllowanceRate>? KilometricAllowanceRateList;

		[JsonProperty("expenseMailNotification")]
		[Field("expenseMailNotification", false, "False", Int32.MaxValue)]
		public bool? ExpenseMailNotification;

		[JsonProperty("lunchVoucherWageShare")]
		[Field("lunchVoucherWageShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherWageShare;

		[JsonProperty("weeklyPlanning")]
		[Field("weeklyPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[JsonProperty("kilometricExpenseProduct")]
		[Field("kilometricExpenseProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? KilometricExpenseProduct;

		[JsonProperty("refusedTimesheetTemplate")]
		[Field("refusedTimesheetTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RefusedTimesheetTemplate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("extraHoursMailNotification")]
		[Field("extraHoursMailNotification", false, "False", Int32.MaxValue)]
		public bool? ExtraHoursMailNotification;

		[JsonProperty("seniorityVariableName")]
		[Field("seniorityVariableName", false, null, Int32.MaxValue)]
		public string? SeniorityVariableName;

		[JsonProperty("totalWorkingDaysVariableName")]
		[Field("totalWorkingDaysVariableName", false, null, Int32.MaxValue)]
		public string? TotalWorkingDaysVariableName;

	}
}
