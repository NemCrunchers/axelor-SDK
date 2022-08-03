using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Project.Db
{
	[Serializable]
	[Model("com.axelor.apps.project.db.Project")]
	public class Project : AxelorModel
	{
		[JsonProperty("totalEstimatedCosts")]
		[Field("totalEstimatedCosts", false, "0", Int32.MaxValue)]
		public decimal? TotalEstimatedCosts;

		[JsonProperty("totalSaleOrdersInvoiced")]
		[Field("totalSaleOrdersInvoiced", false, "0", Int32.MaxValue)]
		public decimal? TotalSaleOrdersInvoiced;

		[JsonProperty("excludeTimesheetEditor")]
		[Field("excludeTimesheetEditor", false, "False", Int32.MaxValue)]
		public bool? ExcludeTimesheetEditor;

		[JsonProperty("dueDate")]
		[Field("dueDate", false, null, Int32.MaxValue)]
		public DateTime? DueDate;

		[JsonProperty("isShowPhasesElements")]
		[Field("isShowPhasesElements", false, "True", Int32.MaxValue)]
		public bool? IsShowPhasesElements;

		[JsonProperty("totalProducedTurnOver")]
		[Field("totalProducedTurnOver", false, "0", Int32.MaxValue)]
		public decimal? TotalProducedTurnOver;

		[JsonProperty("isProject")]
		[Field("isProject", false, "True", Int32.MaxValue)]
		public bool? IsProject;

		[JsonProperty("productSet")]
		[Field("productSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[JsonProperty("totalSaleOrdersConfirmed")]
		[Field("totalSaleOrdersConfirmed", false, "0", Int32.MaxValue)]
		public decimal? TotalSaleOrdersConfirmed;

		[JsonProperty("childProjectList")]
		[Field("childProjectList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? ChildProjectList;

		[JsonProperty("purchaseOrderLineList")]
		[Field("purchaseOrderLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.PurchaseOrderLine>? PurchaseOrderLineList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("synchronize")]
		[Field("synchronize", false, "False", Int32.MaxValue)]
		public bool? Synchronize;

		[JsonProperty("parentProject")]
		[Field("parentProject", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? ParentProject;

		[JsonProperty("timesheetLineList")]
		[Field("timesheetLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.TimesheetLine>? TimesheetLineList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("timeSpent")]
		[Field("timeSpent", false, "0", Int32.MaxValue)]
		public decimal? TimeSpent;

		[JsonProperty("invoicingComment")]
		[Field("invoicingComment", false, null, Int32.MaxValue)]
		public string? InvoicingComment;

		[JsonProperty("imputable")]
		[Field("imputable", false, "False", Int32.MaxValue)]
		public bool? Imputable;

		[JsonProperty("projectPlanningTimeList")]
		[Field("projectPlanningTimeList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectPlanningTime>? ProjectPlanningTimeList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", false, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("saleOrderLineList")]
		[Field("saleOrderLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SaleOrderLineList;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public decimal? Sequence;

		[JsonProperty("clientPartner")]
		[Field("clientPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[JsonProperty("unitOnPrinting")]
		[Field("unitOnPrinting", false, null, Int32.MaxValue)]
		public string? UnitOnPrinting;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("totalRealHrs")]
		[Field("totalRealHrs", false, "0", Int32.MaxValue)]
		public decimal? TotalRealHrs;

		[JsonProperty("orderByState")]
		[Field("orderByState", false, "0", Int32.MaxValue)]
		public int? OrderByState;

		[JsonProperty("projectTypeSelect")]
		[Field("projectTypeSelect", false, "1", Int32.MaxValue)]
		public int? ProjectTypeSelect;

		[JsonProperty("finishToFinishTaskSet")]
		[Field("finishToFinishTaskSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? FinishToFinishTaskSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("realInvoicingMargin")]
		[Field("realInvoicingMargin", false, "0", Int32.MaxValue)]
		public decimal? RealInvoicingMargin;

		[JsonProperty("totalTimesPlanned")]
		[Field("totalTimesPlanned", false, "0", Int32.MaxValue)]
		public decimal? TotalTimesPlanned;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("projInvTypeSelect")]
		[Field("projInvTypeSelect", false, "1", Int32.MaxValue)]
		public int? ProjInvTypeSelect;

		[JsonProperty("totalPurchaseOrdersInvoiced")]
		[Field("totalPurchaseOrdersInvoiced", false, "0", Int32.MaxValue)]
		public decimal? TotalPurchaseOrdersInvoiced;

		[JsonProperty("totalRealCosts")]
		[Field("totalRealCosts", false, "0", Int32.MaxValue)]
		public decimal? TotalRealCosts;

		[JsonProperty("totalExpenses")]
		[Field("totalExpenses", false, "0", Int32.MaxValue)]
		public decimal? TotalExpenses;

		[JsonProperty("totalPurchaseOrdersFinalized")]
		[Field("totalPurchaseOrdersFinalized", false, "0", Int32.MaxValue)]
		public decimal? TotalPurchaseOrdersFinalized;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("totalTimesRealised")]
		[Field("totalTimesRealised", false, "0", Int32.MaxValue)]
		public decimal? TotalTimesRealised;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("assignedTo")]
		[Field("assignedTo", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? AssignedTo;

		[JsonProperty("priceList")]
		[Field("priceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("estimatedMargin")]
		[Field("estimatedMargin", false, "0", Int32.MaxValue)]
		public decimal? EstimatedMargin;

		[JsonProperty("teamTaskList")]
		[Field("teamTaskList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.TeamTask>? TeamTaskList;

		[JsonProperty("projectFolderSet")]
		[Field("projectFolderSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectFolder>? ProjectFolderSet;

		[JsonProperty("realTimesMargin")]
		[Field("realTimesMargin", false, "0", Int32.MaxValue)]
		public decimal? RealTimesMargin;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("totalPurchaseOrdersConfirmed")]
		[Field("totalPurchaseOrdersConfirmed", false, "0", Int32.MaxValue)]
		public decimal? TotalPurchaseOrdersConfirmed;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("membersUserSet")]
		[Field("membersUserSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? MembersUserSet;

		[JsonProperty("invoiceLineList")]
		[Field("invoiceLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.InvoiceLine>? InvoiceLineList;

		[JsonProperty("projectCategorySet")]
		[Field("projectCategorySet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectCategory>? ProjectCategorySet;

		[JsonProperty("startToStartTaskSet")]
		[Field("startToStartTaskSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? StartToStartTaskSet;

		[JsonProperty("toDate")]
		[Field("toDate", false, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("productionOrderList")]
		[Field("productionOrderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProductionOrder>? ProductionOrderList;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("isBusinessProject")]
		[Field("isBusinessProject", false, "False", Int32.MaxValue)]
		public bool? IsBusinessProject;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("extendsMembersFromParent")]
		[Field("extendsMembersFromParent", false, "False", Int32.MaxValue)]
		public bool? ExtendsMembersFromParent;

		[JsonProperty("totalPlannedHrs")]
		[Field("totalPlannedHrs", false, "0", Int32.MaxValue)]
		public decimal? TotalPlannedHrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("manualElementList")]
		[Field("manualElementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Businessproject.Db.ManualElement>? ManualElementList;

		[JsonProperty("wikiList")]
		[Field("wikiList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Wiki>? WikiList;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("expensesLineList")]
		[Field("expensesLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.ExpenseLine>? ExpensesLineList;

		[JsonProperty("startToFinishTaskSet")]
		[Field("startToFinishTaskSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? StartToFinishTaskSet;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("excludePlanning")]
		[Field("excludePlanning", false, "False", Int32.MaxValue)]
		public bool? ExcludePlanning;

		[JsonProperty("finishToStartTaskSet")]
		[Field("finishToStartTaskSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? FinishToStartTaskSet;

		[JsonProperty("totalSaleOrdersFinalized")]
		[Field("totalSaleOrdersFinalized", false, "0", Int32.MaxValue)]
		public decimal? TotalSaleOrdersFinalized;

		[JsonProperty("progress")]
		[Field("progress", false, "0", Int32.MaxValue)]
		public decimal? Progress;

		[JsonProperty("resourceBookingList")]
		[Field("resourceBookingList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Project.Db.ResourceBooking>? ResourceBookingList;

	}
}
