using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Alarm")]
	public class Alarm : AxelorModel
	{
		[Field("date")]
		public DateTime? Date;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("alarmEngine")]
		public Axelor.Apps.Base.Db.AlarmEngine? AlarmEngine;

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

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("acquitOk")]
		public bool? AcquitOk;

	}
}
