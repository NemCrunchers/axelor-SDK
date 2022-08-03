using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppProduction")]
	public class AppProduction : AxelorModel
	{
		[JsonProperty("finishMoMessageTemplate")]
		[Field("finishMoMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? FinishMoMessageTemplate;

		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("autoPlanManufOrderFromSO")]
		[Field("autoPlanManufOrderFromSO", false, "False", Int32.MaxValue)]
		public bool? AutoPlanManufOrderFromSO;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("nbDecimalDigitForBomQty")]
		[Field("nbDecimalDigitForBomQty", false, "2", 10)]
		public int? NbDecimalDigitForBomQty;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("manageBusinessProduction")]
		[Field("manageBusinessProduction", false, "False", Int32.MaxValue)]
		public bool? ManageBusinessProduction;

		[JsonProperty("productionOrderGenerationAuto")]
		[Field("productionOrderGenerationAuto", false, "False", Int32.MaxValue)]
		public bool? ProductionOrderGenerationAuto;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("subtractProdResidualOnCostSheet")]
		[Field("subtractProdResidualOnCostSheet", false, "False", Int32.MaxValue)]
		public bool? SubtractProdResidualOnCostSheet;

		[JsonProperty("printPlannedDateOnManufOrder")]
		[Field("printPlannedDateOnManufOrder", false, "True", Int32.MaxValue)]
		public bool? PrintPlannedDateOnManufOrder;

		[JsonProperty("finishMoAutomaticEmail")]
		[Field("finishMoAutomaticEmail", false, "False", Int32.MaxValue)]
		public bool? FinishMoAutomaticEmail;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("manageWorkshop")]
		[Field("manageWorkshop", false, "False", Int32.MaxValue)]
		public bool? ManageWorkshop;

		[JsonProperty("barcodeTypeConfig")]
		[Field("barcodeTypeConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("workCenterProduct")]
		[Field("workCenterProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? WorkCenterProduct;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("enableTimesheetOnManufOrder")]
		[Field("enableTimesheetOnManufOrder", false, "False", Int32.MaxValue)]
		public bool? EnableTimesheetOnManufOrder;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("workCenterCostSheetGroup")]
		[Field("workCenterCostSheetGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetGroup? WorkCenterCostSheetGroup;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("manageBillOfMaterialVersion")]
		[Field("manageBillOfMaterialVersion", false, "False", Int32.MaxValue)]
		public bool? ManageBillOfMaterialVersion;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("productCostSheetGroup")]
		[Field("productCostSheetGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetGroup? ProductCostSheetGroup;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("manageResidualProductOnBom")]
		[Field("manageResidualProductOnBom", false, "False", Int32.MaxValue)]
		public bool? ManageResidualProductOnBom;

		[JsonProperty("prodOrderMgtOnSO")]
		[Field("prodOrderMgtOnSO", false, "False", Int32.MaxValue)]
		public bool? ProdOrderMgtOnSO;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("manageProdProcessVersion")]
		[Field("manageProdProcessVersion", false, "False", Int32.MaxValue)]
		public bool? ManageProdProcessVersion;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("partFinishMoMessageTemplate")]
		[Field("partFinishMoMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PartFinishMoMessageTemplate;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("cycleUnit")]
		[Field("cycleUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? CycleUnit;

		[JsonProperty("enableConfigurator")]
		[Field("enableConfigurator", false, "False", Int32.MaxValue)]
		public bool? EnableConfigurator;

		[JsonProperty("partFinishMoAutomaticEmail")]
		[Field("partFinishMoAutomaticEmail", false, "False", Int32.MaxValue)]
		public bool? PartFinishMoAutomaticEmail;

		[JsonProperty("oneProdOrderPerSO")]
		[Field("oneProdOrderPerSO", false, "True", Int32.MaxValue)]
		public bool? OneProdOrderPerSO;

	}
}
