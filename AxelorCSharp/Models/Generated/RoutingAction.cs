using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.RoutingAction")]
	public class RoutingAction : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("routingActionCreate")]
		public Axelor.Apps.Base.Db.RoutingActionCreate? RoutingActionCreate;

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

		[Field("routing")]
		public Axelor.Apps.Base.Db.Routing? Routing;

		[Field("relatedToFilter2")]
		public string? RelatedToFilter2;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("relatedToFilter1")]
		public string? RelatedToFilter1;

		[Field("id")]
		public long? Id;

	}
}
