using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaTranslation")]
	public class MetaTranslation : AxelorModel
	{
		[Field("archived")]
		public bool? Archived;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("importId")]
		public string? ImportId;

		[Field("language")]
		public string? Language;

		[Field("id")]
		public long? Id;

		[Field("version")]
		public int? Version;

	}
}
