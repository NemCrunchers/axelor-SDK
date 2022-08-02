using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaSelectItem")]
	public class MetaSelectItem : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("select")]
		public Axelor.Meta.Db.MetaSelect? Select;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("data")]
		public string? Data;

		[Field("hidden")]
		public bool? Hidden;

		[Field("icon")]
		public string? Icon;

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

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("value")]
		public string? Value;

		[Field("order")]
		public int? Order;

	}
}
