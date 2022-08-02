using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.PriceListLine")]
	public class PriceListLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("amountTypeSelect")]
		public int? AmountTypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("priceList")]
		public Axelor.Apps.Base.Db.PriceList? PriceList;

		[Field("productCategory")]
		public Axelor.Apps.Base.Db.ProductCategory? ProductCategory;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
