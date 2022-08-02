using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.TimesheetLine")]
	public class TimesheetLine : AxelorModel
	{
		[Field("toInvoice")]
		public bool? ToInvoice;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("operationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? OperationOrder;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("fullName")]
		public string? FullName;

		[Field("manufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("timesheet")]
		public Axelor.Apps.Hr.Db.Timesheet? Timesheet;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("enableEditor")]
		public bool? EnableEditor;

		[Field("projectPlanningTime")]
		public Axelor.Apps.Project.Db.ProjectPlanningTime? ProjectPlanningTime;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
