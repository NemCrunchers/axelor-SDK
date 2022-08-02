using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.RecurrenceConfiguration")]
	public class RecurrenceConfiguration : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("saturday")]
		public bool? Saturday;

		[Field("endType")]
		public int? EndType;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("recurrenceType")]
		public int? RecurrenceType;

		[Field("repetitionsNumber")]
		public int? RepetitionsNumber;

		[Field("archived")]
		public bool? Archived;

		[Field("recurrenceName")]
		public string? RecurrenceName;

		[Field("friday")]
		public bool? Friday;

		[Field("wednesday")]
		public bool? Wednesday;

		[Field("id")]
		public long? Id;

		[Field("monday")]
		public bool? Monday;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("thursday")]
		public bool? Thursday;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("monthRepeatType")]
		public int? MonthRepeatType;

		[Field("sunday")]
		public bool? Sunday;

		[Field("importId")]
		public string? ImportId;

		[Field("tuesday")]
		public bool? Tuesday;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("periodicity")]
		public int? Periodicity;

	}
}
