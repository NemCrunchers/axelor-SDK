using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LunchVoucherMgt")]
	public class LunchVoucherMgt : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("csvFile")]
		[Field("csvFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? CsvFile;

		[JsonProperty("lunchVoucherMgtLineList")]
		[Field("lunchVoucherMgtLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LunchVoucherMgtLine>? LunchVoucherMgtLineList;

		[JsonProperty("totalLunchVouchers")]
		[Field("totalLunchVouchers", false, "0", Int32.MaxValue)]
		public int? TotalLunchVouchers;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("leavePeriod")]
		[Field("leavePeriod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? LeavePeriod;

		[JsonProperty("payPeriod")]
		[Field("payPeriod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Period? PayPeriod;

		[JsonProperty("givenLunchVouchers")]
		[Field("givenLunchVouchers", false, "0", Int32.MaxValue)]
		public int? GivenLunchVouchers;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("stockQuantityStatus")]
		[Field("stockQuantityStatus", false, "0", Int32.MaxValue)]
		public int? StockQuantityStatus;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("lunchVoucherWageShare")]
		[Field("lunchVoucherWageShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherWageShare;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("requestedLunchVouchers")]
		[Field("requestedLunchVouchers", false, "0", Int32.MaxValue)]
		public int? RequestedLunchVouchers;

		[JsonProperty("exportDate")]
		[Field("exportDate", false, null, Int32.MaxValue)]
		public DateTime? ExportDate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("lunchVoucherEmployersShare")]
		[Field("lunchVoucherEmployersShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherEmployersShare;

		[JsonProperty("stockLineQuantity")]
		[Field("stockLineQuantity", false, "0", Int32.MaxValue)]
		public int? StockLineQuantity;

		[JsonProperty("stockLineComment")]
		[Field("stockLineComment", false, null, Int32.MaxValue)]
		public string? StockLineComment;

	}
}
