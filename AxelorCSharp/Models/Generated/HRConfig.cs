using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.HRConfig")]
	public class HRConfig : AxelorModel
	{
		[Field("exportCodeForLunchVoucherManagement")]
		public string? ExportCodeForLunchVoucherManagement;

		[Field("validatedExtraHoursTemplate")]
		public Axelor.Apps.Message.Db.Template? ValidatedExtraHoursTemplate;

		[Field("validatedLeaveTemplate")]
		public Axelor.Apps.Message.Db.Template? ValidatedLeaveTemplate;

		[Field("id")]
		public long? Id;

		[Field("refusedExpenseTemplate")]
		public Axelor.Apps.Message.Db.Template? RefusedExpenseTemplate;

		[Field("leaveMailNotification")]
		public bool? LeaveMailNotification;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("sentTimesheetTemplate")]
		public Axelor.Apps.Message.Db.Template? SentTimesheetTemplate;

		[Field("publicHolidayEventsPlanning")]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[Field("supplierLunchVoucher")]
		public Axelor.Apps.Base.Db.Partner? SupplierLunchVoucher;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("sentLeaveTemplate")]
		public Axelor.Apps.Message.Db.Template? SentLeaveTemplate;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sentExpenseTemplate")]
		public Axelor.Apps.Message.Db.Template? SentExpenseTemplate;

		[Field("toJustifyLeaveReason")]
		public Axelor.Apps.Hr.Db.LeaveReason? ToJustifyLeaveReason;

		[Field("timesheetMailNotification")]
		public bool? TimesheetMailNotification;

		[Field("refusedLeaveTemplate")]
		public Axelor.Apps.Message.Db.Template? RefusedLeaveTemplate;

		[Field("workingDaysVariableName")]
		public string? WorkingDaysVariableName;

		[Field("refusedExtraHoursTemplate")]
		public Axelor.Apps.Message.Db.Template? RefusedExtraHoursTemplate;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("canceledTimesheetTemplate")]
		public Axelor.Apps.Message.Db.Template? CanceledTimesheetTemplate;

		[Field("expenseSequence")]
		public Axelor.Apps.Base.Db.Sequence? ExpenseSequence;

		[Field("lunchVoucherFormatSelect")]
		public int? LunchVoucherFormatSelect;

		[Field("exportCodeForExtraHours")]
		public string? ExportCodeForExtraHours;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("sentExtraHoursTemplate")]
		public Axelor.Apps.Message.Db.Template? SentExtraHoursTemplate;

		[Field("useUniqueProductForTimesheet")]
		public bool? UseUniqueProductForTimesheet;

		[Field("archived")]
		public bool? Archived;

		[Field("canceledLeaveTemplate")]
		public Axelor.Apps.Message.Db.Template? CanceledLeaveTemplate;

		[Field("uniqueTimesheetProduct")]
		public Axelor.Apps.Base.Db.Product? UniqueTimesheetProduct;

		[Field("availableStockLunchVoucher")]
		public int? AvailableStockLunchVoucher;

		[Field("validatedTimesheetTemplate")]
		public Axelor.Apps.Message.Db.Template? ValidatedTimesheetTemplate;

		[Field("minStockLunchVoucher")]
		public int? MinStockLunchVoucher;

		[Field("canceledExpenseTemplate")]
		public Axelor.Apps.Message.Db.Template? CanceledExpenseTemplate;

		[Field("validatedExpenseTemplate")]
		public Axelor.Apps.Message.Db.Template? ValidatedExpenseTemplate;

		[Field("ageVariableName")]
		public string? AgeVariableName;

		[Field("canceledExtraHoursTemplate")]
		public Axelor.Apps.Message.Db.Template? CanceledExtraHoursTemplate;

		[Field("expenseMailNotification")]
		public bool? ExpenseMailNotification;

		[Field("weeklyPlanning")]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[Field("kilometricExpenseProduct")]
		public Axelor.Apps.Base.Db.Product? KilometricExpenseProduct;

		[Field("refusedTimesheetTemplate")]
		public Axelor.Apps.Message.Db.Template? RefusedTimesheetTemplate;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("extraHoursMailNotification")]
		public bool? ExtraHoursMailNotification;

		[Field("seniorityVariableName")]
		public string? SeniorityVariableName;

		[Field("totalWorkingDaysVariableName")]
		public string? TotalWorkingDaysVariableName;

	}
}
