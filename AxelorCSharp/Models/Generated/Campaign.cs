using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Marketing.Db
{
	[Serializable]
	[Model("com.axelor.apps.marketing.db.Campaign")]
	public class Campaign : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("invitedLeadSet")]
		[Field("invitedLeadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? InvitedLeadSet;

		[JsonProperty("leadReminderTemplate")]
		[Field("leadReminderTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? LeadReminderTemplate;

		[JsonProperty("presentPartnerSet")]
		[Field("presentPartnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PresentPartnerSet;

		[JsonProperty("subject")]
		[Field("subject", false, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("eventEndDateT")]
		[Field("eventEndDateT", false, null, Int32.MaxValue)]
		public DateTime? EventEndDateT;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("partnerTemplate")]
		[Field("partnerTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PartnerTemplate;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public long? Duration;

		[JsonProperty("notParticipatingLeadSet")]
		[Field("notParticipatingLeadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? NotParticipatingLeadSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("manageAnEventPerTarget")]
		[Field("manageAnEventPerTarget", false, "False", Int32.MaxValue)]
		public bool? ManageAnEventPerTarget;

		[JsonProperty("emailLog")]
		[Field("emailLog", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? EmailLog;

		[JsonProperty("emailAccount")]
		[Field("emailAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAccount? EmailAccount;

		[JsonProperty("partnerReminderTemplate")]
		[Field("partnerReminderTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PartnerReminderTemplate;

		[JsonProperty("emailing")]
		[Field("emailing", false, "False", Int32.MaxValue)]
		public bool? Emailing;

		[JsonProperty("eventUser")]
		[Field("eventUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? EventUser;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isAllowEditingOfTargets")]
		[Field("isAllowEditingOfTargets", false, "True", Int32.MaxValue)]
		public bool? IsAllowEditingOfTargets;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[JsonProperty("stageSelect")]
		[Field("stageSelect", false, "0", Int32.MaxValue)]
		public int? StageSelect;

		[JsonProperty("targetModelSet")]
		[Field("targetModelSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Marketing.Db.TargetList>? TargetModelSet;

		[JsonProperty("eventStartDateTime")]
		[Field("eventStartDateTime", false, null, Int32.MaxValue)]
		public DateTime? EventStartDateTime;

		[JsonProperty("eventStartDateT")]
		[Field("eventStartDateT", false, null, Int32.MaxValue)]
		public DateTime? EventStartDateT;

		[JsonProperty("campaignType")]
		[Field("campaignType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Marketing.Db.CampaignType? CampaignType;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("leadSet")]
		[Field("leadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[JsonProperty("leadTemplate")]
		[Field("leadTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? LeadTemplate;

		[JsonProperty("invitedPartnerSet")]
		[Field("invitedPartnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? InvitedPartnerSet;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("campaignReminderList")]
		[Field("campaignReminderList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Marketing.Db.CampaignReminder>? CampaignReminderList;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("generateEventPerPartnerOrLead")]
		[Field("generateEventPerPartnerOrLead", false, "False", Int32.MaxValue)]
		public bool? GenerateEventPerPartnerOrLead;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("eventTypeSelect")]
		[Field("eventTypeSelect", false, "0", Int32.MaxValue)]
		public int? EventTypeSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("manageAttendees")]
		[Field("manageAttendees", false, "False", Int32.MaxValue)]
		public bool? ManageAttendees;

		[JsonProperty("partners")]
		[Field("partners", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? Partners;

		[JsonProperty("leads")]
		[Field("leads", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? Leads;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("report")]
		[Field("report", false, null, Int32.MaxValue)]
		public string? Report;

		[JsonProperty("notParticipatingPartnerSet")]
		[Field("notParticipatingPartnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? NotParticipatingPartnerSet;

		[JsonProperty("presentLeadSet")]
		[Field("presentLeadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? PresentLeadSet;

	}
}
