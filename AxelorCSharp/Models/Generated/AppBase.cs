using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppBase")]
	public class AppBase : AxelorModel
	{
		[Field("hasQasValidation")]
		public bool? HasQasValidation;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("barcodeTypeConfig")]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[Field("mapApiSelect")]
		public int? MapApiSelect;

		[Field("passwordChangedTemplate")]
		public Axelor.Apps.Message.Db.Template? PasswordChangedTemplate;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("generatePartnerSequence")]
		public bool? GeneratePartnerSequence;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("enterpriseCommunication")]
		public bool? EnterpriseCommunication;

		[Field("generateProductSequence")]
		public bool? GenerateProductSequence;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("qasWsdlUrl")]
		public string? QasWsdlUrl;

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

		[Field("sequence")]
		public int? Sequence;

		[Field("name")]
		public string? Name;

		[Field("activateBarCodeGeneration")]
		public bool? ActivateBarCodeGeneration;

		[Field("activateSendingEmail")]
		public bool? ActivateSendingEmail;

		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("editProductBarcodeType")]
		public bool? EditProductBarcodeType;

		[Field("document")]
		public bool? Document;

		[Field("currencyWsURL")]
		public string? CurrencyWsURL;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("emailAccountByUser")]
		public bool? EmailAccountByUser;

		[Field("archived")]
		public bool? Archived;

		[Field("computeMethodDiscountSelect")]
		public int? ComputeMethodDiscountSelect;

		[Field("manageMultiBanks")]
		public bool? ManageMultiBanks;

		[Field("manageProductVariants")]
		public bool? ManageProductVariants;

		[Field("today")]
		public DateTime? Today;

		[Field("defaultPartnerLanguage")]
		public Axelor.Apps.Base.Db.Language? DefaultPartnerLanguage;

		[Field("enableCalendars")]
		public bool? EnableCalendars;

		[Field("timeLoggingPreferenceSelect")]
		public string? TimeLoggingPreferenceSelect;

		[Field("unitMinutes")]
		public Axelor.Apps.Base.Db.Unit? UnitMinutes;

		[Field("nbDecimalDigitForUnitPrice")]
		public int? NbDecimalDigitForUnitPrice;

		[Field("googleMapsApiKey")]
		public string? GoogleMapsApiKey;

		[Field("teamManagement")]
		public bool? TeamManagement;

		[Field("enableTradingNamesManagement")]
		public bool? EnableTradingNamesManagement;

		[Field("productInAtiSelect")]
		public int? ProductInAtiSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("defaultProjectUnit")]
		public Axelor.Apps.Base.Db.Unit? DefaultProjectUnit;

		[Field("unitHours")]
		public Axelor.Apps.Base.Db.Unit? UnitHours;

		[Field("unitDays")]
		public Axelor.Apps.Base.Db.Unit? UnitDays;

	}
}
