using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.LunchVoucherMgtLine")]
	public class LunchVoucherMgtLine : AxelorModel
	{
		[JsonProperty("inAdvanceNbr")]
		[Field("inAdvanceNbr", false, "0", Int32.MaxValue)]
		public int? InAdvanceNbr;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("lunchVoucherNumber")]
		[Field("lunchVoucherNumber", false, "0", Int32.MaxValue)]
		public int? LunchVoucherNumber;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("daysWorkedNbr")]
		[Field("daysWorkedNbr", false, "0", Int32.MaxValue)]
		public int? DaysWorkedNbr;

		[JsonProperty("givenToEmployee")]
		[Field("givenToEmployee", false, "0", Int32.MaxValue)]
		public int? GivenToEmployee;

		[JsonProperty("lunchVoucherFormatSelect")]
		[Field("lunchVoucherFormatSelect", false, "0", Int32.MaxValue)]
		public int? LunchVoucherFormatSelect;

		[JsonProperty("invitation")]
		[Field("invitation", false, "0", Int32.MaxValue)]
		public int? Invitation;

		[JsonProperty("payrollPreparation")]
		[Field("payrollPreparation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.PayrollPreparation? PayrollPreparation;

		[JsonProperty("lunchVoucherMgt")]
		[Field("lunchVoucherMgt", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.LunchVoucherMgt? LunchVoucherMgt;

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

		[JsonProperty("canteenEntries")]
		[Field("canteenEntries", false, "0", Int32.MaxValue)]
		public int? CanteenEntries;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("daysOverseas")]
		[Field("daysOverseas", false, "0", Int32.MaxValue)]
		public int? DaysOverseas;

	}
}
