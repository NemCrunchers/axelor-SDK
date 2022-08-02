using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaSequence")]
	public class MetaSequence : AxelorModel
	{
		[Field("next")]
		public long? Next;

		[Field("padding")]
		public int? Padding;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("initial")]
		public long? Initial;

		[Field("prefix")]
		public string? Prefix;

		[Field("increment")]
		public int? Increment;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("suffix")]
		public string? Suffix;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
