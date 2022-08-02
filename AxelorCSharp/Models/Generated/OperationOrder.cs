using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.OperationOrder")]
	public class OperationOrder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("prodProcessLine")]
		public Axelor.Apps.Production.Db.ProdProcessLine? ProdProcessLine;

		[Field("plannedStartDateT")]
		public DateTime? PlannedStartDateT;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("isToInvoice")]
		public bool? IsToInvoice;

		[Field("plannedDuration")]
		public long? PlannedDuration;

		[Field("id")]
		public long? Id;

		[Field("plannedEndDateT")]
		public DateTime? PlannedEndDateT;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("manufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ManufOrder;

		[Field("operationName")]
		public string? OperationName;

		[Field("realStartDateT")]
		public DateTime? RealStartDateT;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("isWithDifference")]
		public bool? IsWithDifference;

		[Field("version")]
		public int? Version;

		[Field("workCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[Field("attrs")]
		public string? Attrs;

		[Field("barCode")]
		public Axelor.Meta.Db.MetaFile? BarCode;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("realEndDateT")]
		public DateTime? RealEndDateT;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("realDuration")]
		public long? RealDuration;

		[Field("name")]
		public string? Name;

		[Field("machineWorkCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? MachineWorkCenter;

	}
}
