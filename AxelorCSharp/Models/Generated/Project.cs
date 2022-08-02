using Axelor.SDK;

namespace Axelor.Apps.Project.Db
{
	[Model("com.axelor.apps.project.db.Project")]
	public class Project : AxelorModel
	{
		[Field("excludeTimesheetEditor")]
		public bool? ExcludeTimesheetEditor;

		[Field("dueDate")]
		public DateTime? DueDate;

		[Field("isShowPhasesElements")]
		public bool? IsShowPhasesElements;

		[Field("isProject")]
		public bool? IsProject;

		[Field("productSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[Field("id")]
		public long? Id;

		[Field("synchronize")]
		public bool? Synchronize;

		[Field("parentProject")]
		public Axelor.Apps.Project.Db.Project? ParentProject;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("imputable")]
		public bool? Imputable;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("fromDate")]
		public DateTime? FromDate;

		[Field("clientPartner")]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[Field("unitOnPrinting")]
		public string? UnitOnPrinting;

		[Field("name")]
		public string? Name;

		[Field("orderByState")]
		public int? OrderByState;

		[Field("projectTypeSelect")]
		public int? ProjectTypeSelect;

		[Field("finishToFinishTaskSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? FinishToFinishTaskSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("projInvTypeSelect")]
		public int? ProjInvTypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("assignedTo")]
		public Axelor.Auth.Db.User? AssignedTo;

		[Field("priceList")]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[Field("archived")]
		public bool? Archived;

		[Field("projectFolderSet")]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectFolder>? ProjectFolderSet;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("membersUserSet")]
		public IEnumerable<Axelor.Auth.Db.User>? MembersUserSet;

		[Field("projectCategorySet")]
		public IEnumerable<Axelor.Apps.Project.Db.ProjectCategory>? ProjectCategorySet;

		[Field("startToStartTaskSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? StartToStartTaskSet;

		[Field("toDate")]
		public DateTime? ToDate;

		[Field("fullName")]
		public string? FullName;

		[Field("isBusinessProject")]
		public bool? IsBusinessProject;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("extendsMembersFromParent")]
		public bool? ExtendsMembersFromParent;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("startToFinishTaskSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? StartToFinishTaskSet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("excludePlanning")]
		public bool? ExcludePlanning;

		[Field("finishToStartTaskSet")]
		public IEnumerable<Axelor.Apps.Project.Db.Project>? FinishToStartTaskSet;

	}
}
