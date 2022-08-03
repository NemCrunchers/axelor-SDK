using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.ICalendar")]
	public class ICalendar : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("synchronizationDuration")]
		[Field("synchronizationDuration", false, "1", Int32.MaxValue)]
		public int? SynchronizationDuration;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("login")]
		[Field("login", false, null, Int32.MaxValue)]
		public string? Login;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("password")]
		[Field("password", false, null, Int32.MaxValue)]
		public string? Password;

		[JsonProperty("keepRemote")]
		[Field("keepRemote", false, "False", Int32.MaxValue)]
		public bool? KeepRemote;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isValid")]
		[Field("isValid", false, "False", Int32.MaxValue)]
		public bool? IsValid;

		[JsonProperty("synchronizationSelect")]
		[Field("synchronizationSelect", false, null, Int32.MaxValue)]
		public string? SynchronizationSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("url")]
		[Field("url", false, null, Int32.MaxValue)]
		public string? Url;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sharingSettingList")]
		[Field("sharingSettingList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.SharingSetting>? SharingSettingList;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("port")]
		[Field("port", false, "80", Int32.MaxValue)]
		public int? Port;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("lastSynchronizationDateT")]
		[Field("lastSynchronizationDateT", false, null, Int32.MaxValue)]
		public DateTime? LastSynchronizationDateT;

		[JsonProperty("isSslConnection")]
		[Field("isSslConnection", false, "False", Int32.MaxValue)]
		public bool? IsSslConnection;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("cid")]
		[Field("cid", false, null, Int32.MaxValue)]
		public string? Cid;

	}
}
