using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Sequence")]
	public class Sequence : AxelorModel
	{
		[JsonProperty("sequenceVersionList")]
		[Field("sequenceVersionList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.SequenceVersion>? SequenceVersionList;

		[JsonProperty("padding")]
		[Field("padding", true, "0", Int32.MaxValue)]
		public int? Padding;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("monthlyResetOk")]
		[Field("monthlyResetOk", false, "False", Int32.MaxValue)]
		public bool? MonthlyResetOk;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("yearlyResetOk")]
		[Field("yearlyResetOk", false, "False", Int32.MaxValue)]
		public bool? YearlyResetOk;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("prefixe")]
		[Field("prefixe", false, null, Int32.MaxValue)]
		public string? Prefixe;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("suffixe")]
		[Field("suffixe", false, null, Int32.MaxValue)]
		public string? Suffixe;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("toBeAdded")]
		[Field("toBeAdded", true, "0", Int32.MaxValue)]
		public int? ToBeAdded;

	}
}
