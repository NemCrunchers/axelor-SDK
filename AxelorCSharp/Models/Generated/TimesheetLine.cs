using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.TimesheetLine")]
	public class TimesheetLine : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", true, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("toInvoice")]
		[Field("toInvoice", false, "False", Int32.MaxValue)]
		public bool? ToInvoice;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("operationOrder")]
		[Field("operationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? OperationOrder;

		[JsonProperty("hoursDuration")]
		[Field("hoursDuration", false, "0", Int32.MaxValue)]
		public decimal? HoursDuration;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("manufOrder")]
		[Field("manufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("timesheet")]
		[Field("timesheet", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Timesheet? Timesheet;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("enableEditor")]
		[Field("enableEditor", false, null, Int32.MaxValue)]
		public bool? EnableEditor;

		[JsonProperty("projectPlanningTime")]
		[Field("projectPlanningTime", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.ProjectPlanningTime? ProjectPlanningTime;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
