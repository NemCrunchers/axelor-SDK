using Axelor.SDK;

namespace Axelor.Apps.Marketing.Db
{
	[Model("com.axelor.apps.marketing.db.Campaign")]
	public class Campaign : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("invitedLeadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? InvitedLeadSet;

		[Field("leadReminderTemplate")]
		public Axelor.Apps.Message.Db.Template? LeadReminderTemplate;

		[Field("presentPartnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PresentPartnerSet;

		[Field("subject")]
		public string? Subject;

		[Field("eventEndDateT")]
		public DateTime? EventEndDateT;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("partnerTemplate")]
		public Axelor.Apps.Message.Db.Template? PartnerTemplate;

		[Field("duration")]
		public long? Duration;

		[Field("notParticipatingLeadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? NotParticipatingLeadSet;

		[Field("archived")]
		public bool? Archived;

		[Field("manageAnEventPerTarget")]
		public bool? ManageAnEventPerTarget;

		[Field("emailLog")]
		public Axelor.Meta.Db.MetaFile? EmailLog;

		[Field("emailAccount")]
		public Axelor.Apps.Message.Db.EmailAccount? EmailAccount;

		[Field("partnerReminderTemplate")]
		public Axelor.Apps.Message.Db.Template? PartnerReminderTemplate;

		[Field("emailing")]
		public bool? Emailing;

		[Field("eventUser")]
		public Axelor.Auth.Db.User? EventUser;

		[Field("id")]
		public long? Id;

		[Field("isAllowEditingOfTargets")]
		public bool? IsAllowEditingOfTargets;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[Field("stageSelect")]
		public int? StageSelect;

		[Field("targetModelSet")]
		public IEnumerable<Axelor.Apps.Marketing.Db.TargetList>? TargetModelSet;

		[Field("eventStartDateTime")]
		public DateTime? EventStartDateTime;

		[Field("eventStartDateT")]
		public DateTime? EventStartDateT;

		[Field("campaignType")]
		public Axelor.Apps.Marketing.Db.CampaignType? CampaignType;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("leadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[Field("leadTemplate")]
		public Axelor.Apps.Message.Db.Template? LeadTemplate;

		[Field("invitedPartnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? InvitedPartnerSet;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("generateEventPerPartnerOrLead")]
		public bool? GenerateEventPerPartnerOrLead;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("eventTypeSelect")]
		public int? EventTypeSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("manageAttendees")]
		public bool? ManageAttendees;

		[Field("partners")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? Partners;

		[Field("leads")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? Leads;

		[Field("name")]
		public string? Name;

		[Field("report")]
		public string? Report;

		[Field("notParticipatingPartnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? NotParticipatingPartnerSet;

		[Field("presentLeadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? PresentLeadSet;

	}
}
