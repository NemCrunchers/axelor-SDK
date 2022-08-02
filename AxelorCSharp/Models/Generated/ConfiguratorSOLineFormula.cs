using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.ConfiguratorSOLineFormula")]
	public class ConfiguratorSOLineFormula : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("showOnConfigurator")]
		public bool? ShowOnConfigurator;

		[Field("updateFromSelect")]
		public int? UpdateFromSelect;

		[Field("metaField")]
		public Axelor.Meta.Db.MetaField? MetaField;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("soLineCreator")]
		public Axelor.Apps.Sale.Db.ConfiguratorCreator? SoLineCreator;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
