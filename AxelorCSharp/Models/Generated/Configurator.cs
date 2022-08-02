using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.Configurator")]
	public class Configurator : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("configuratorCreatorName")]
		public string? ConfiguratorCreatorName;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("indicators")]
		public string? Indicators;

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

		[Field("configuratorCreator")]
		public Axelor.Apps.Sale.Db.ConfiguratorCreator? ConfiguratorCreator;

		[Field("attributes")]
		public string? Attributes;

		[Field("id")]
		public long? Id;

	}
}
