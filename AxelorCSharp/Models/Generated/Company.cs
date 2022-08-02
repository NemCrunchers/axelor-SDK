using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Company")]
	public class Company : AxelorModel
	{
		[Field("parent")]
		public Axelor.Apps.Base.Db.Company? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("bankDetailsSet")]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetailsSet;

		[Field("tradingNameSet")]
		public IEnumerable<Axelor.Apps.Base.Db.TradingName>? TradingNameSet;

		[Field("archived")]
		public bool? Archived;

		[Field("printingSettings")]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[Field("logo")]
		public Axelor.Meta.Db.MetaFile? Logo;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("address")]
		public Axelor.Apps.Base.Db.Address? Address;

		[Field("defaultBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? DefaultBankDetails;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("defaultPartnerTypeSelect")]
		public int? DefaultPartnerTypeSelect;

		[Field("publicHolidayEventsPlanning")]
		public Axelor.Apps.Base.Db.EventsPlanning? PublicHolidayEventsPlanning;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("weeklyPlanning")]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

	}
}
