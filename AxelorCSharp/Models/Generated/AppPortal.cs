using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppPortal")]
	public class AppPortal : AxelorModel
	{
		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("manageInvoices")]
		[Field("manageInvoices", false, "False", Int32.MaxValue)]
		public bool? ManageInvoices;

		[JsonProperty("onlinePaymentMethodSet")]
		[Field("onlinePaymentMethodSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Client.Portal.Db.OnlinePaymentMethod>? OnlinePaymentMethodSet;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("canPayOnline")]
		[Field("canPayOnline", false, "False", Int32.MaxValue)]
		public bool? CanPayOnline;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("canConfirmOnline")]
		[Field("canConfirmOnline", false, "False", Int32.MaxValue)]
		public bool? CanConfirmOnline;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("manageSaleOrders")]
		[Field("manageSaleOrders", false, "False", Int32.MaxValue)]
		public bool? ManageSaleOrders;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("manageTickets")]
		[Field("manageTickets", false, "False", Int32.MaxValue)]
		public bool? ManageTickets;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

	}
}
