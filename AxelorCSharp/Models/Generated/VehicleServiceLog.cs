using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.VehicleServiceLog")]
	public class VehicleServiceLog : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("purchasePartner")]
		public Axelor.Apps.Base.Db.Partner? PurchasePartner;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("vehicle")]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[Field("archived")]
		public bool? Archived;

		[Field("invoiceRef")]
		public string? InvoiceRef;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("vendorPartner")]
		public Axelor.Apps.Base.Db.Partner? VendorPartner;

		[Field("id")]
		public long? Id;

	}
}
