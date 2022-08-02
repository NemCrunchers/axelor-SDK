using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.CrmConfig")]
	public class CrmConfig : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("meetingTemplate")]
		public Axelor.Apps.Message.Db.Template? MeetingTemplate;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("sendMail")]
		public bool? SendMail;

		[Field("taskTemplate")]
		public Axelor.Apps.Message.Db.Template? TaskTemplate;

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

		[Field("callTemplate")]
		public Axelor.Apps.Message.Db.Template? CallTemplate;

		[Field("importId")]
		public string? ImportId;

		[Field("meetingGuestDeletedTemplate")]
		public Axelor.Apps.Message.Db.Template? MeetingGuestDeletedTemplate;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("meetingGuestAddedTemplate")]
		public Axelor.Apps.Message.Db.Template? MeetingGuestAddedTemplate;

		[Field("id")]
		public long? Id;

		[Field("meetingDateChangeTemplate")]
		public Axelor.Apps.Message.Db.Template? MeetingDateChangeTemplate;

	}
}
