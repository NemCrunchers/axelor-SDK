using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.PayrollPreparation")]
	public class PayrollPreparation : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("exportTypeSelect")]
		public int? ExportTypeSelect;

		[Field("employmentContract")]
		public Axelor.Apps.Hr.Db.EmploymentContract? EmploymentContract;

		[Field("otherCostsEmployeeSet")]
		public IEnumerable<Axelor.Apps.Hr.Db.OtherCostsEmployee>? OtherCostsEmployeeSet;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("batchList")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[Field("exported")]
		public bool? Exported;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
