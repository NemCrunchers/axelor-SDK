using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaView")]
	public class MetaView : AxelorModel
	{
		[Field("extension")]
		public bool? Extension;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("module")]
		public string? Module;

		[Field("groups")]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("title")]
		public string? Title;

		[Field("type")]
		public string? Type;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("helpLink")]
		public string? HelpLink;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("xmlId")]
		public string? XmlId;

	}
}
