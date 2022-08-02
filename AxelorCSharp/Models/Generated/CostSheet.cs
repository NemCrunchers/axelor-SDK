using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.CostSheet")]
	public class CostSheet : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("billOfMaterial")]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[Field("manufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("calculationTypeSelect")]
		public int? CalculationTypeSelect;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

	}
}
