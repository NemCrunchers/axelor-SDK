using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ProductionOrder")]
	public class ProductionOrder : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("productionOrderSeq")]
		[Field("productionOrderSeq", true, null, Int32.MaxValue)]
		public string? ProductionOrderSeq;

		[JsonProperty("manufOrderList")]
		[Field("manufOrderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ManufOrder>? ManufOrderList;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("prioritySelect")]
		[Field("prioritySelect", false, "2", Int32.MaxValue)]
		public int? PrioritySelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("clientPartner")]
		[Field("clientPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ClientPartner;

		[JsonProperty("isClosed")]
		[Field("isClosed", false, null, Int32.MaxValue)]
		public bool? IsClosed;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
