using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.LunchVoucherMgtLine")]
	public class LunchVoucherMgtLine : AxelorModel
	{
		[Field("inAdvanceNbr")]
		public int? InAdvanceNbr;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("lunchVoucherNumber")]
		public int? LunchVoucherNumber;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("daysWorkedNbr")]
		public int? DaysWorkedNbr;

		[Field("givenToEmployee")]
		public int? GivenToEmployee;

		[Field("lunchVoucherFormatSelect")]
		public int? LunchVoucherFormatSelect;

		[Field("invitation")]
		public int? Invitation;

		[Field("payrollPreparation")]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[Field("lunchVoucherMgt")]
		public Axelor.Apps.Hr.Db.LunchVoucherMgt? LunchVoucherMgt;

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

		[Field("canteenEntries")]
		public int? CanteenEntries;

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

		[Field("daysOverseas")]
		public int? DaysOverseas;

	}
}
