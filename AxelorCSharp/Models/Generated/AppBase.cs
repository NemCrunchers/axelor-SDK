using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppBase")]
	public class AppBase : AxelorModel
	{
		[JsonProperty("hasQasValidation")]
		[Field("hasQasValidation", false, "False", Int32.MaxValue)]
		public bool? HasQasValidation;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("barcodeTypeConfig")]
		[Field("barcodeTypeConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[JsonProperty("mapApiSelect")]
		[Field("mapApiSelect", false, "1", Int32.MaxValue)]
		public int? MapApiSelect;

		[JsonProperty("passwordChangedTemplate")]
		[Field("passwordChangedTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PasswordChangedTemplate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("generatePartnerSequence")]
		[Field("generatePartnerSequence", false, "True", Int32.MaxValue)]
		public bool? GeneratePartnerSequence;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("enterpriseCommunication")]
		[Field("enterpriseCommunication", false, "True", Int32.MaxValue)]
		public bool? EnterpriseCommunication;

		[JsonProperty("generateProductSequence")]
		[Field("generateProductSequence", false, "False", Int32.MaxValue)]
		public bool? GenerateProductSequence;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("qasWsdlUrl")]
		[Field("qasWsdlUrl", false, null, Int32.MaxValue)]
		public string? QasWsdlUrl;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

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

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("activateBarCodeGeneration")]
		[Field("activateBarCodeGeneration", false, "False", Int32.MaxValue)]
		public bool? ActivateBarCodeGeneration;

		[JsonProperty("activateSendingEmail")]
		[Field("activateSendingEmail", false, "True", Int32.MaxValue)]
		public bool? ActivateSendingEmail;

		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("editProductBarcodeType")]
		[Field("editProductBarcodeType", false, "False", Int32.MaxValue)]
		public bool? EditProductBarcodeType;

		[JsonProperty("document")]
		[Field("document", false, "True", Int32.MaxValue)]
		public bool? Document;

		[JsonProperty("currencyWsURL")]
		[Field("currencyWsURL", false, null, Int32.MaxValue)]
		public string? CurrencyWsURL;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("emailAccountByUser")]
		[Field("emailAccountByUser", false, "False", Int32.MaxValue)]
		public bool? EmailAccountByUser;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("computeMethodDiscountSelect")]
		[Field("computeMethodDiscountSelect", false, "1", Int32.MaxValue)]
		public int? ComputeMethodDiscountSelect;

		[JsonProperty("manageMultiBanks")]
		[Field("manageMultiBanks", false, "False", Int32.MaxValue)]
		public bool? ManageMultiBanks;

		[JsonProperty("currencyConversionLineList")]
		[Field("currencyConversionLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.CurrencyConversionLine>? CurrencyConversionLineList;

		[JsonProperty("manageProductVariants")]
		[Field("manageProductVariants", false, "False", Int32.MaxValue)]
		public bool? ManageProductVariants;

		[JsonProperty("today")]
		[Field("today", false, null, Int32.MaxValue)]
		public DateTime? Today;

		[JsonProperty("defaultPartnerLanguage")]
		[Field("defaultPartnerLanguage", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Language? DefaultPartnerLanguage;

		[JsonProperty("enableCalendars")]
		[Field("enableCalendars", false, "True", Int32.MaxValue)]
		public bool? EnableCalendars;

		[JsonProperty("timeLoggingPreferenceSelect")]
		[Field("timeLoggingPreferenceSelect", false, "days", Int32.MaxValue)]
		public string? TimeLoggingPreferenceSelect;

		[JsonProperty("unitMinutes")]
		[Field("unitMinutes", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? UnitMinutes;

		[JsonProperty("nbDecimalDigitForUnitPrice")]
		[Field("nbDecimalDigitForUnitPrice", false, "2", 10)]
		public int? NbDecimalDigitForUnitPrice;

		[JsonProperty("dailyWorkHours")]
		[Field("dailyWorkHours", false, "0", Int32.MaxValue)]
		public decimal? DailyWorkHours;

		[JsonProperty("googleMapsApiKey")]
		[Field("googleMapsApiKey", false, null, Int32.MaxValue)]
		public string? GoogleMapsApiKey;

		[JsonProperty("teamManagement")]
		[Field("teamManagement", false, "True", Int32.MaxValue)]
		public bool? TeamManagement;

		[JsonProperty("enableTradingNamesManagement")]
		[Field("enableTradingNamesManagement", false, "False", Int32.MaxValue)]
		public bool? EnableTradingNamesManagement;

		[JsonProperty("productInAtiSelect")]
		[Field("productInAtiSelect", false, "1", Int32.MaxValue)]
		public int? ProductInAtiSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("defaultProjectUnit")]
		[Field("defaultProjectUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? DefaultProjectUnit;

		[JsonProperty("unitHours")]
		[Field("unitHours", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? UnitHours;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("unitDays")]
		[Field("unitDays", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? UnitDays;

	}
}
