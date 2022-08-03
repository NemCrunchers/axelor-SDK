using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.SupplyChainConfig")]
	public class SupplyChainConfig : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("hasInSmForStorableProduct")]
		[Field("hasInSmForStorableProduct", false, "False", Int32.MaxValue)]
		public bool? HasInSmForStorableProduct;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("hasOutSmForStorableProduct")]
		[Field("hasOutSmForStorableProduct", false, "False", Int32.MaxValue)]
		public bool? HasOutSmForStorableProduct;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("hasOutSmForNonStorableProduct")]
		[Field("hasOutSmForNonStorableProduct", false, "False", Int32.MaxValue)]
		public bool? HasOutSmForNonStorableProduct;

		[JsonProperty("autoAllocateOnReceipt")]
		[Field("autoAllocateOnReceipt", false, "False", Int32.MaxValue)]
		public bool? AutoAllocateOnReceipt;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("hasInSmForNonStorableProduct")]
		[Field("hasInSmForNonStorableProduct", false, "False", Int32.MaxValue)]
		public bool? HasInSmForNonStorableProduct;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
