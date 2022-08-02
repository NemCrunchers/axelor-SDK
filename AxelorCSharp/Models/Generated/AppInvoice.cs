using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppInvoice")]
	public class AppInvoice : AxelorModel
	{
		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("archived")]
		public bool? Archived;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("id")]
		public long? Id;

		[Field("isEnabledProductDescriptionCopyForCustomers")]
		public bool? IsEnabledProductDescriptionCopyForCustomers;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("isVentilationSkipped")]
		public bool? IsVentilationSkipped;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("isInvoiceMoveConsolidated")]
		public bool? IsInvoiceMoveConsolidated;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("isEnabledProductDescriptionCopyForSuppliers")]
		public bool? IsEnabledProductDescriptionCopyForSuppliers;

	}
}
