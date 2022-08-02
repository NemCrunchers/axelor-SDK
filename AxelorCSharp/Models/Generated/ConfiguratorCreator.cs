using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.ConfiguratorCreator")]
	public class ConfiguratorCreator : AxelorModel
	{
		[Field("authorizedGroupSet")]
		public IEnumerable<Axelor.Auth.Db.Group>? AuthorizedGroupSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("generateProduct")]
		public bool? GenerateProduct;

		[Field("isActive")]
		public bool? IsActive;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("authorizedUserSet")]
		public IEnumerable<Axelor.Auth.Db.User>? AuthorizedUserSet;

		[Field("importId")]
		public string? ImportId;

		[Field("configuratorBom")]
		public Axelor.Apps.Production.Db.ConfiguratorBOM? ConfiguratorBom;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
