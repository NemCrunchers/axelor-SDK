using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.RecurrenceConfiguration")]
	public class RecurrenceConfiguration : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("saturday")]
		[Field("saturday", false, "False", Int32.MaxValue)]
		public bool? Saturday;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("endType")]
		[Field("endType", false, "0", Int32.MaxValue)]
		public int? EndType;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("recurrenceType")]
		[Field("recurrenceType", false, "0", Int32.MaxValue)]
		public int? RecurrenceType;

		[JsonProperty("repetitionsNumber")]
		[Field("repetitionsNumber", false, "0", Int32.MaxValue)]
		public int? RepetitionsNumber;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("recurrenceName")]
		[Field("recurrenceName", false, null, Int32.MaxValue)]
		public string? RecurrenceName;

		[JsonProperty("friday")]
		[Field("friday", false, "False", Int32.MaxValue)]
		public bool? Friday;

		[JsonProperty("wednesday")]
		[Field("wednesday", false, "False", Int32.MaxValue)]
		public bool? Wednesday;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("monday")]
		[Field("monday", false, "False", Int32.MaxValue)]
		public bool? Monday;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("thursday")]
		[Field("thursday", false, "False", Int32.MaxValue)]
		public bool? Thursday;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("monthRepeatType")]
		[Field("monthRepeatType", false, "0", Int32.MaxValue)]
		public int? MonthRepeatType;

		[JsonProperty("sunday")]
		[Field("sunday", false, "False", Int32.MaxValue)]
		public bool? Sunday;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("tuesday")]
		[Field("tuesday", false, "False", Int32.MaxValue)]
		public bool? Tuesday;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("periodicity")]
		[Field("periodicity", false, "0", Int32.MaxValue)]
		public int? Periodicity;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
