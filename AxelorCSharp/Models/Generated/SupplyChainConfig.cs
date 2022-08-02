using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.SupplyChainConfig")]
	public class SupplyChainConfig : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("hasInSmForStorableProduct")]
		public bool? HasInSmForStorableProduct;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("hasOutSmForStorableProduct")]
		public bool? HasOutSmForStorableProduct;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("hasOutSmForNonStorableProduct")]
		public bool? HasOutSmForNonStorableProduct;

		[Field("autoAllocateOnReceipt")]
		public bool? AutoAllocateOnReceipt;

		[Field("hasInSmForNonStorableProduct")]
		public bool? HasInSmForNonStorableProduct;

		[Field("id")]
		public long? Id;

	}
}
