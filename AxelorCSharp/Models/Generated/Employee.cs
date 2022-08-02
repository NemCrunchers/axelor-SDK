using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.Employee")]
	public class Employee : AxelorModel
	{
		[Field("trainingSkillSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? TrainingSkillSet;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("id")]
		public long? Id;

		[Field("companyCbDetails")]
		public string? CompanyCbDetails;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("phoneAtCustomer")]
		public string? PhoneAtCustomer;

		[Field("emergencyContact")]
		public string? EmergencyContact;

		[Field("timesheetImputationSelect")]
		public int? TimesheetImputationSelect;

		[Field("imposedDayEventsPlanning")]
		public Axelor.Apps.Base.Db.EventsPlanning? ImposedDayEventsPlanning;

		[Field("publicHolidayEventsPlanning")]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("timesheetReminder")]
		public bool? TimesheetReminder;

		[Field("mainEmploymentContract")]
		public Axelor.Apps.Hr.Db.EmploymentContract? MainEmploymentContract;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("exportCode")]
		public string? ExportCode;

		[Field("negativeValueLeave")]
		public bool? NegativeValueLeave;

		[Field("external")]
		public bool? External;

		[Field("fixedProPhone")]
		public string? FixedProPhone;

		[Field("name")]
		public string? Name;

		[Field("experienceSkillSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? ExperienceSkillSet;

		[Field("maritalStatus")]
		public string? MaritalStatus;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("profitSharingBeneficiary")]
		public bool? ProfitSharingBeneficiary;

		[Field("lunchVoucherFormatSelect")]
		public int? LunchVoucherFormatSelect;

		[Field("socialSecurityNumber")]
		public string? SocialSecurityNumber;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("managerUser")]
		public Axelor.Auth.Db.User? ManagerUser;

		[Field("archived")]
		public bool? Archived;

		[Field("companyCbSelect")]
		public int? CompanyCbSelect;

		[Field("hrManager")]
		public bool? HrManager;

		[Field("timeLoggingPreferenceSelect")]
		public string? TimeLoggingPreferenceSelect;

		[Field("contactPartner")]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("skillSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[Field("emergencyNumber")]
		public string? EmergencyNumber;

		[Field("mobileProPhone")]
		public string? MobileProPhone;

		[Field("weeklyPlanning")]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
