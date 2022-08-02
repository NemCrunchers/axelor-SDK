using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.LunchVoucherMgt")]
	public class LunchVoucherMgt : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("csvFile")]
		public Axelor.Meta.Db.MetaFile? CsvFile;

		[Field("totalLunchVouchers")]
		public int? TotalLunchVouchers;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("leavePeriod")]
		public Axelor.Apps.Base.Db.Period? LeavePeriod;

		[Field("payPeriod")]
		public Axelor.Apps.Base.Db.Period? PayPeriod;

		[Field("givenLunchVouchers")]
		public int? GivenLunchVouchers;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("stockQuantityStatus")]
		public int? StockQuantityStatus;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("requestedLunchVouchers")]
		public int? RequestedLunchVouchers;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("stockLineQuantity")]
		public int? StockLineQuantity;

	}
}
