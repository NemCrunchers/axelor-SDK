using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Crm.Db
{
	[Serializable]
	[Model("com.axelor.apps.crm.db.CrmConfig")]
	public class CrmConfig : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("meetingTemplate")]
		[Field("meetingTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? MeetingTemplate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("sendMail")]
		[Field("sendMail", false, "False", Int32.MaxValue)]
		public bool? SendMail;

		[JsonProperty("taskTemplate")]
		[Field("taskTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? TaskTemplate;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("callTemplate")]
		[Field("callTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? CallTemplate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("meetingGuestDeletedTemplate")]
		[Field("meetingGuestDeletedTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? MeetingGuestDeletedTemplate;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("meetingGuestAddedTemplate")]
		[Field("meetingGuestAddedTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? MeetingGuestAddedTemplate;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("meetingDateChangeTemplate")]
		[Field("meetingDateChangeTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? MeetingDateChangeTemplate;

	}
}
