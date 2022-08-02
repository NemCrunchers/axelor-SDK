using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.OperationOrderDuration")]
	public class OperationOrderDuration : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("startedBy")]
		public Axelor.Auth.Db.User? StartedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("stoppingDateTime")]
		public DateTime? StoppingDateTime;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("operationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? OperationOrder;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("startingDateTime")]
		public DateTime? StartingDateTime;

		[Field("stoppedBy")]
		public Axelor.Auth.Db.User? StoppedBy;

		[Field("id")]
		public long? Id;

	}
}
