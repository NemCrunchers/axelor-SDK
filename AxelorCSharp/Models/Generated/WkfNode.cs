using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.WkfNode")]
	public class WkfNode : AxelorModel
	{
		[Field("incoming")]
		public IEnumerable<Axelor.Studio.Db.WkfTransition>? Incoming;

		[Field("outgoing")]
		public IEnumerable<Axelor.Studio.Db.WkfTransition>? Outgoing;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaField")]
		public Axelor.Meta.Db.MetaField? MetaField;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("nodeType")]
		public int? NodeType;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("wkf")]
		public Axelor.Studio.Db.Wkf? Wkf;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("xmlId")]
		public string? XmlId;

		[Field("roleSet")]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[Field("metaActionSet")]
		public IEnumerable<Axelor.Meta.Db.MetaAction>? MetaActionSet;

	}
}
