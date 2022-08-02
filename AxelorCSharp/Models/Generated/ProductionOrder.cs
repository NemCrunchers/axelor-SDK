using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ProductionOrder")]
	public class ProductionOrder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("productionOrderSeq")]
		public string? ProductionOrderSeq;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("prioritySelect")]
		public int? PrioritySelect;

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

		[Field("clientPartner")]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[Field("isClosed")]
		public bool? IsClosed;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
