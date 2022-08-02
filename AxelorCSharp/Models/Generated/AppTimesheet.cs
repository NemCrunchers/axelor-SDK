using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppTimesheet")]
	public class AppTimesheet : AxelorModel
	{
		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("keepProject")]
		public bool? KeepProject;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("timesheetEditor")]
		public bool? TimesheetEditor;

		[Field("archived")]
		public bool? Archived;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("defaultEndFormat")]
		public int? DefaultEndFormat;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("consolidateTSLine")]
		public bool? ConsolidateTSLine;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("enableTimer")]
		public bool? EnableTimer;

		[Field("invoicingTypeLogTimesSelect")]
		public int? InvoicingTypeLogTimesSelect;

		[Field("name")]
		public string? Name;

		[Field("editModeTSTimer")]
		public bool? EditModeTSTimer;

	}
}
