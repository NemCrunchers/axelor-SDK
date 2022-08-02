using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.CostSheetLine")]
	public class CostSheetLine : AxelorModel
	{
		[Field("bomLevel")]
		public int? BomLevel;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("costSheetGroup")]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[Field("typeSelectIcon")]
		public int? TypeSelectIcon;

		[Field("id")]
		public long? Id;

		[Field("parentCostSheetLine")]
		public Axelor.Apps.Production.Db.CostSheetLine? ParentCostSheetLine;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("costSheet")]
		public Axelor.Apps.Production.Db.CostSheet? CostSheet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("workCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[Field("attrs")]
		public string? Attrs;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

	}
}
