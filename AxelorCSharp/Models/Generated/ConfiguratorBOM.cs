using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ConfiguratorBOM")]
	public class ConfiguratorBOM : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("defProductFromConfigurator")]
		public bool? DefProductFromConfigurator;

		[Field("unitFormula")]
		public string? UnitFormula;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("configuratorProdProcess")]
		public Axelor.Apps.Production.Db.ConfiguratorProdProcess? ConfiguratorProdProcess;

		[Field("archived")]
		public bool? Archived;

		[Field("parentConfiguratorBOM")]
		public Axelor.Apps.Production.Db.ConfiguratorBOM? ParentConfiguratorBOM;

		[Field("productFormula")]
		public string? ProductFormula;

		[Field("useCondition")]
		public string? UseCondition;

		[Field("defUnitAsFormula")]
		public bool? DefUnitAsFormula;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("defNameAsFormula")]
		public bool? DefNameAsFormula;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("qtyFormula")]
		public string? QtyFormula;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("prodProcessFormula")]
		public string? ProdProcessFormula;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("nameFormula")]
		public string? NameFormula;

		[Field("prodProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("defProdProcessAsFormula")]
		public bool? DefProdProcessAsFormula;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("defQtyAsFormula")]
		public bool? DefQtyAsFormula;

		[Field("name")]
		public string? Name;

		[Field("defProductAsFormula")]
		public bool? DefProductAsFormula;

		[Field("billOfMaterialId")]
		public long? BillOfMaterialId;

		[Field("defProdProcessAsConfigurator")]
		public bool? DefProdProcessAsConfigurator;

	}
}
