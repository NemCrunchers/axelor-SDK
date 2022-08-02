using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.LunchVoucherAdvance")]
	public class LunchVoucherAdvance : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("nbrLunchVouchersUsed")]
		public int? NbrLunchVouchersUsed;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

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

		[Field("nbrLunchVouchers")]
		public int? NbrLunchVouchers;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
