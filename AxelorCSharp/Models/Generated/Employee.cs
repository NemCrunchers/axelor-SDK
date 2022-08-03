using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Hr.Db
{
	[Serializable]
	[Model("com.axelor.apps.hr.db.Employee")]
	public class Employee : AxelorModel
	{
		[JsonProperty("leaveLineList")]
		[Field("leaveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LeaveLine>? LeaveLineList;

		[JsonProperty("kilometricLogList")]
		[Field("kilometricLogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.KilometricLog>? KilometricLogList;

		[JsonProperty("trainingSkillSet")]
		[Field("trainingSkillSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? TrainingSkillSet;

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[JsonProperty("bonusCoef")]
		[Field("bonusCoef", false, "0", Int32.MaxValue)]
		public decimal? BonusCoef;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("companyCbDetails")]
		[Field("companyCbDetails", false, null, Int32.MaxValue)]
		public string? CompanyCbDetails;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("phoneAtCustomer")]
		[Field("phoneAtCustomer", false, null, Int32.MaxValue)]
		public string? PhoneAtCustomer;

		[JsonProperty("emergencyContact")]
		[Field("emergencyContact", false, null, Int32.MaxValue)]
		public string? EmergencyContact;

		[JsonProperty("timesheetImputationSelect")]
		[Field("timesheetImputationSelect", false, "1", Int32.MaxValue)]
		public int? TimesheetImputationSelect;

		[JsonProperty("imposedDayEventsPlanning")]
		[Field("imposedDayEventsPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.EventsPlanning? ImposedDayEventsPlanning;

		[JsonProperty("lunchVoucherAdvanceList")]
		[Field("lunchVoucherAdvanceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.LunchVoucherAdvance>? LunchVoucherAdvanceList;

		[JsonProperty("publicHolidayEventsPlanning")]
		[Field("publicHolidayEventsPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("timesheetReminder")]
		[Field("timesheetReminder", false, "False", Int32.MaxValue)]
		public bool? TimesheetReminder;

		[JsonProperty("employeeAdvanceList")]
		[Field("employeeAdvanceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.EmployeeAdvance>? EmployeeAdvanceList;

		[JsonProperty("mainEmploymentContract")]
		[Field("mainEmploymentContract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.EmploymentContract? MainEmploymentContract;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("employeeVehicleList")]
		[Field("employeeVehicleList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.EmployeeVehicle>? EmployeeVehicleList;

		[JsonProperty("exportCode")]
		[Field("exportCode", false, null, Int32.MaxValue)]
		public string? ExportCode;

		[JsonProperty("negativeValueLeave")]
		[Field("negativeValueLeave", false, "False", Int32.MaxValue)]
		public bool? NegativeValueLeave;

		[JsonProperty("external")]
		[Field("external", false, "False", Int32.MaxValue)]
		public bool? External;

		[JsonProperty("dateOfHire")]
		[Field("dateOfHire", false, null, Int32.MaxValue)]
		public DateTime? DateOfHire;

		[JsonProperty("weeklyWorkHours")]
		[Field("weeklyWorkHours", false, "0", Int32.MaxValue)]
		public decimal? WeeklyWorkHours;

		[JsonProperty("fixedProPhone")]
		[Field("fixedProPhone", false, null, Int32.MaxValue)]
		public string? FixedProPhone;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("experienceSkillSet")]
		[Field("experienceSkillSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? ExperienceSkillSet;

		[JsonProperty("maritalStatus")]
		[Field("maritalStatus", false, null, Int32.MaxValue)]
		public string? MaritalStatus;

		[JsonProperty("seniorityDate")]
		[Field("seniorityDate", false, null, Int32.MaxValue)]
		public DateTime? SeniorityDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("profitSharingBeneficiary")]
		[Field("profitSharingBeneficiary", false, "False", Int32.MaxValue)]
		public bool? ProfitSharingBeneficiary;

		[JsonProperty("lunchVoucherFormatSelect")]
		[Field("lunchVoucherFormatSelect", false, "0", Int32.MaxValue)]
		public int? LunchVoucherFormatSelect;

		[JsonProperty("socialSecurityNumber")]
		[Field("socialSecurityNumber", false, null, Int32.MaxValue)]
		public string? SocialSecurityNumber;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("managerUser")]
		[Field("managerUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ManagerUser;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("companyCbSelect")]
		[Field("companyCbSelect", false, "1", Int32.MaxValue)]
		public int? CompanyCbSelect;

		[JsonProperty("hrManager")]
		[Field("hrManager", false, "False", Int32.MaxValue)]
		public bool? HrManager;

		[JsonProperty("timeLoggingPreferenceSelect")]
		[Field("timeLoggingPreferenceSelect", false, null, Int32.MaxValue)]
		public string? TimeLoggingPreferenceSelect;

		[JsonProperty("contactPartner")]
		[Field("contactPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ContactPartner;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("skillSet")]
		[Field("skillSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[JsonProperty("dailyWorkHours")]
		[Field("dailyWorkHours", false, "0", Int32.MaxValue)]
		public decimal? DailyWorkHours;

		[JsonProperty("emergencyNumber")]
		[Field("emergencyNumber", false, null, Int32.MaxValue)]
		public string? EmergencyNumber;

		[JsonProperty("mobileProPhone")]
		[Field("mobileProPhone", false, null, Int32.MaxValue)]
		public string? MobileProPhone;

		[JsonProperty("weeklyPlanning")]
		[Field("weeklyPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[JsonProperty("birthDate")]
		[Field("birthDate", false, null, Int32.MaxValue)]
		public DateTime? BirthDate;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("employmentContractList")]
		[Field("employmentContractList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Hr.Db.EmploymentContract>? EmploymentContractList;

		[JsonProperty("hourlyRate")]
		[Field("hourlyRate", false, "0", Int32.MaxValue)]
		public decimal? HourlyRate;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
