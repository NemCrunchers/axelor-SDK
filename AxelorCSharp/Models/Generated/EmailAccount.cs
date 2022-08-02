using Axelor.SDK;

namespace Axelor.Apps.Message.Db
{
	[Model("com.axelor.apps.message.db.EmailAccount")]
	public class EmailAccount : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("serverTypeSelect")]
		public int? ServerTypeSelect;

		[Field("isValid")]
		public bool? IsValid;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("login")]
		public string? Login;

		[Field("securitySelect")]
		public int? SecuritySelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("isDefault")]
		public bool? IsDefault;

		[Field("password")]
		public string? Password;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("port")]
		public int? Port;

		[Field("host")]
		public string? Host;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
