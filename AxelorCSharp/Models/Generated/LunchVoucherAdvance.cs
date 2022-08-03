using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LunchVoucherAdvance")]
	public class LunchVoucherAdvance : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("nbrLunchVouchersUsed")]
		[Field("nbrLunchVouchersUsed", false, "0", Int32.MaxValue)]
		public int? NbrLunchVouchersUsed;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("distributionDate")]
		[Field("distributionDate", false, null, Int32.MaxValue)]
		public DateTime? DistributionDate;

		[JsonProperty("lunchVoucherWageShare")]
		[Field("lunchVoucherWageShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherWageShare;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("employee")]
		[Field("employee", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Employee;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("nbrLunchVouchers")]
		[Field("nbrLunchVouchers", false, "0", Int32.MaxValue)]
		public int? NbrLunchVouchers;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("lunchVoucherEmployersShare")]
		[Field("lunchVoucherEmployersShare", false, "0", Int32.MaxValue)]
		public decimal? LunchVoucherEmployersShare;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
