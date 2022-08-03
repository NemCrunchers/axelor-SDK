using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Year")]
	public class Year : AxelorModel
	{
		[JsonProperty("closureDateTime")]
		[Field("closureDateTime", false, null, Int32.MaxValue)]
		public DateTime? ClosureDateTime;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("reportedBalanceDate")]
		[Field("reportedBalanceDate", false, null, Int32.MaxValue)]
		public DateTime? ReportedBalanceDate;

		[JsonProperty("toDate")]
		[Field("toDate", true, null, Int32.MaxValue)]
		public DateTime? ToDate;

		[JsonProperty("adjustHistoryList")]
		[Field("adjustHistoryList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AdjustHistory>? AdjustHistoryList;

		[JsonProperty("periodDurationSelect")]
		[Field("periodDurationSelect", false, "0", Int32.MaxValue)]
		public int? PeriodDurationSelect;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromDate")]
		[Field("fromDate", true, null, Int32.MaxValue)]
		public DateTime? FromDate;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
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

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("periodList")]
		[Field("periodList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Period>? PeriodList;

	}
}
