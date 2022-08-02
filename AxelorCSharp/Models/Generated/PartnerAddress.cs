using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.PartnerAddress")]
	public class PartnerAddress : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("address")]
		public Axelor.Apps.Base.Db.Address? Address;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isDefaultAddr")]
		public bool? IsDefaultAddr;

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

		[Field("isDeliveryAddr")]
		public bool? IsDeliveryAddr;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isInvoicingAddr")]
		public bool? IsInvoicingAddr;

		[Field("id")]
		public long? Id;

	}
}
