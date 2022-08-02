using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmployeeAdvance")]
	public class EmployeeAdvance : AxelorModel
	{
		[Field("reason")]
		public string? Reason;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("typeSelect")]
		public int? TypeSelect;

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

		[Field("statusSelect")]
		public int? StatusSelect;

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
