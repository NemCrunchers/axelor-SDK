using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Sequence")]
	public class Sequence : AxelorModel
	{
		[Field("padding")]
		public int? Padding;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("monthlyResetOk")]
		public bool? MonthlyResetOk;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("yearlyResetOk")]
		public bool? YearlyResetOk;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("prefixe")]
		public string? Prefixe;

		[Field("importId")]
		public string? ImportId;

		[Field("suffixe")]
		public string? Suffixe;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("toBeAdded")]
		public int? ToBeAdded;

	}
}
