using Axelor.SDK;

namespace Axelor.Exception.Db
{
	[Model("com.axelor.exception.db.TraceBack")]
	public class TraceBack : AxelorModel
	{
		[Field("date")]
		public DateTime? Date;

		[Field("categorySelect")]
		public int? CategorySelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("origin")]
		public string? Origin;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("batchId")]
		public long? BatchId;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("ref")]
		public string? Ref;

		[Field("internalUser")]
		public Axelor.Auth.Db.User? InternalUser;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("refId")]
		public long? RefId;

	}
}
