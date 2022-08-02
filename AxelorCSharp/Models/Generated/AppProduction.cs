using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppProduction")]
	public class AppProduction : AxelorModel
	{
		[Field("finishMoMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? FinishMoMessageTemplate;

		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("autoPlanManufOrderFromSO")]
		public bool? AutoPlanManufOrderFromSO;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("nbDecimalDigitForBomQty")]
		public int? NbDecimalDigitForBomQty;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("manageBusinessProduction")]
		public bool? ManageBusinessProduction;

		[Field("productionOrderGenerationAuto")]
		public bool? ProductionOrderGenerationAuto;

		[Field("archived")]
		public bool? Archived;

		[Field("subtractProdResidualOnCostSheet")]
		public bool? SubtractProdResidualOnCostSheet;

		[Field("printPlannedDateOnManufOrder")]
		public bool? PrintPlannedDateOnManufOrder;

		[Field("finishMoAutomaticEmail")]
		public bool? FinishMoAutomaticEmail;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("manageWorkshop")]
		public bool? ManageWorkshop;

		[Field("barcodeTypeConfig")]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("workCenterProduct")]
		public Axelor.Apps.Base.Db.Product? WorkCenterProduct;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("enableTimesheetOnManufOrder")]
		public bool? EnableTimesheetOnManufOrder;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("workCenterCostSheetGroup")]
		public Axelor.Apps.Production.Db.CostSheetGroup? WorkCenterCostSheetGroup;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("manageBillOfMaterialVersion")]
		public bool? ManageBillOfMaterialVersion;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("productCostSheetGroup")]
		public Axelor.Apps.Production.Db.CostSheetGroup? ProductCostSheetGroup;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("manageResidualProductOnBom")]
		public bool? ManageResidualProductOnBom;

		[Field("prodOrderMgtOnSO")]
		public bool? ProdOrderMgtOnSO;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("manageProdProcessVersion")]
		public bool? ManageProdProcessVersion;

		[Field("name")]
		public string? Name;

		[Field("partFinishMoMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? PartFinishMoMessageTemplate;

		[Field("cycleUnit")]
		public Axelor.Apps.Base.Db.Unit? CycleUnit;

		[Field("enableConfigurator")]
		public bool? EnableConfigurator;

		[Field("partFinishMoAutomaticEmail")]
		public bool? PartFinishMoAutomaticEmail;

		[Field("oneProdOrderPerSO")]
		public bool? OneProdOrderPerSO;

	}
}
