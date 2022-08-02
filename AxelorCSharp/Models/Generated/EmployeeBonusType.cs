using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmployeeBonusType")]
	public class EmployeeBonusType : AxelorModel
	{
		[Field("payrollPreparationExport")]
		public bool? PayrollPreparationExport;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("applicationCondition")]
		public string? ApplicationCondition;

		[Field("label")]
		public string? Label;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("exportCode")]
		public string? ExportCode;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("formula")]
		public string? Formula;

		[Field("id")]
		public long? Id;

	}
}
