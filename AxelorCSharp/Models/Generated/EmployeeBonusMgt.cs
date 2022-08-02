using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmployeeBonusMgt")]
	public class EmployeeBonusMgt : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("employeeBonusType")]
		public Axelor.Apps.Hr.Db.EmployeeBonusType? EmployeeBonusType;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

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

		[Field("leavePeriod")]
		public Axelor.Apps.Base.Db.Period? LeavePeriod;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("payPeriod")]
		public Axelor.Apps.Base.Db.Period? PayPeriod;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
