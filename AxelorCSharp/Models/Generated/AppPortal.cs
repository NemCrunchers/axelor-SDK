using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppPortal")]
	public class AppPortal : AxelorModel
	{
		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("manageInvoices")]
		public bool? ManageInvoices;

		[Field("onlinePaymentMethodSet")]
		public IEnumerable<Axelor.Apps.Client.Portal.Db.OnlinePaymentMethod>? OnlinePaymentMethodSet;

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

		[Field("canPayOnline")]
		public bool? CanPayOnline;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("canConfirmOnline")]
		public bool? CanConfirmOnline;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("manageSaleOrders")]
		public bool? ManageSaleOrders;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("manageTickets")]
		public bool? ManageTickets;

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

		[Field("name")]
		public string? Name;

	}
}
