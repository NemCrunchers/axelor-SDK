using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaHelp")]
	public class MetaHelp : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("language")]
		public string? Language;

		[Field("menu")]
		public string? Menu;

		[Field("type")]
		public string? Type;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("view")]
		public string? View;

		[Field("importId")]
		public string? ImportId;

		[Field("field")]
		public string? Field;

		[Field("model")]
		public string? Model;

		[Field("style")]
		public string? Style;

		[Field("id")]
		public long? Id;

	}
}
