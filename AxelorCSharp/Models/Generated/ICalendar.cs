using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.ICalendar")]
	public class ICalendar : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("synchronizationDuration")]
		public int? SynchronizationDuration;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("login")]
		public string? Login;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("password")]
		public string? Password;

		[Field("keepRemote")]
		public bool? KeepRemote;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isValid")]
		public bool? IsValid;

		[Field("synchronizationSelect")]
		public string? SynchronizationSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("url")]
		public string? Url;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("port")]
		public int? Port;

		[Field("name")]
		public string? Name;

		[Field("lastSynchronizationDateT")]
		public DateTime? LastSynchronizationDateT;

		[Field("isSslConnection")]
		public bool? IsSslConnection;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("cid")]
		public string? Cid;

	}
}
