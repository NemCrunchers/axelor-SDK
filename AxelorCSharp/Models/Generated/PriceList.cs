using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.PriceList")]
	public class PriceList : AxelorModel
	{
		[Field("parentPriceList")]
		public Axelor.Apps.Base.Db.PriceList? ParentPriceList;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("hideDiscount")]
		public bool? HideDiscount;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("isActive")]
		public bool? IsActive;

		[Field("title")]
		public string? Title;

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

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("basedOnSelect")]
		public int? BasedOnSelect;

		[Field("id")]
		public long? Id;

	}
}
