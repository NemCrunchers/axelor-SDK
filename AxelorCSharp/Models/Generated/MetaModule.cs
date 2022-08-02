using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaModule")]
	public class MetaModule : AxelorModel
	{
		[Field("installed")]
		public bool? Installed;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("depends")]
		public IEnumerable<Axelor.Meta.Db.MetaModule>? Depends;

		[Field("pending")]
		public bool? Pending;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("application")]
		public bool? Application;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("moduleVersion")]
		public string? ModuleVersion;

		[Field("removable")]
		public bool? Removable;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
