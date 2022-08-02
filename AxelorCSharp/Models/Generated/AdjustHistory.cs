using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AdjustHistory")]
	public class AdjustHistory : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("endDate")]
		public DateTime? EndDate;

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

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("fiscalYear")]
		public Axelor.Apps.Base.Db.Year? FiscalYear;

		[Field("startDate")]
		public DateTime? StartDate;

	}
}
