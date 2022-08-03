using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.PriceList")]
	public class PriceList : AxelorModel
	{
		[JsonProperty("parentPriceList")]
		[Field("parentPriceList", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PriceList? ParentPriceList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("applicationEndDate")]
		[Field("applicationEndDate", false, null, Int32.MaxValue)]
		public DateTime? ApplicationEndDate;

		[JsonProperty("hideDiscount")]
		[Field("hideDiscount", false, "False", Int32.MaxValue)]
		public bool? HideDiscount;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("isActive")]
		[Field("isActive", false, "False", Int32.MaxValue)]
		public bool? IsActive;

		[JsonProperty("priceListLineList")]
		[Field("priceListLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.PriceListLine>? PriceListLineList;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

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

		[JsonProperty("generalDiscount")]
		[Field("generalDiscount", false, "0", Int32.MaxValue)]
		public decimal? GeneralDiscount;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("historizedPriceList")]
		[Field("historizedPriceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.PriceList>? HistorizedPriceList;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("basedOnSelect")]
		[Field("basedOnSelect", false, "0", Int32.MaxValue)]
		public int? BasedOnSelect;

		[JsonProperty("applicationBeginDate")]
		[Field("applicationBeginDate", false, null, Int32.MaxValue)]
		public DateTime? ApplicationBeginDate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
