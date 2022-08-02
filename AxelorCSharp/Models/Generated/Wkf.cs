using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.Wkf")]
	public class Wkf : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("jsonField")]
		public string? JsonField;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("statusField")]
		public Axelor.Meta.Db.MetaJsonField? StatusField;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isJson")]
		public bool? IsJson;

		[Field("name")]
		public string? Name;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("displayTypeSelect")]
		public int? DisplayTypeSelect;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
