using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ConfiguratorBOM")]
	public class ConfiguratorBOM : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("defProductFromConfigurator")]
		[Field("defProductFromConfigurator", false, "True", Int32.MaxValue)]
		public bool? DefProductFromConfigurator;

		[JsonProperty("unitFormula")]
		[Field("unitFormula", false, null, Int32.MaxValue)]
		public string? UnitFormula;

		[JsonProperty("configuratorBomList")]
		[Field("configuratorBomList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ConfiguratorBOM>? ConfiguratorBomList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("configuratorProdProcess")]
		[Field("configuratorProdProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ConfiguratorProdProcess? ConfiguratorProdProcess;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("parentConfiguratorBOM")]
		[Field("parentConfiguratorBOM", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ConfiguratorBOM? ParentConfiguratorBOM;

		[JsonProperty("productFormula")]
		[Field("productFormula", false, null, Int32.MaxValue)]
		public string? ProductFormula;

		[JsonProperty("useCondition")]
		[Field("useCondition", false, null, Int32.MaxValue)]
		public string? UseCondition;

		[JsonProperty("defUnitAsFormula")]
		[Field("defUnitAsFormula", false, "False", Int32.MaxValue)]
		public bool? DefUnitAsFormula;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("defNameAsFormula")]
		[Field("defNameAsFormula", false, "False", Int32.MaxValue)]
		public bool? DefNameAsFormula;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("qtyFormula")]
		[Field("qtyFormula", false, null, Int32.MaxValue)]
		public string? QtyFormula;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("prodProcessFormula")]
		[Field("prodProcessFormula", false, null, Int32.MaxValue)]
		public string? ProdProcessFormula;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("nameFormula")]
		[Field("nameFormula", false, null, Int32.MaxValue)]
		public string? NameFormula;

		[JsonProperty("prodProcess")]
		[Field("prodProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("defProdProcessAsFormula")]
		[Field("defProdProcessAsFormula", false, "False", Int32.MaxValue)]
		public bool? DefProdProcessAsFormula;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("defQtyAsFormula")]
		[Field("defQtyAsFormula", false, "False", Int32.MaxValue)]
		public bool? DefQtyAsFormula;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("defProductAsFormula")]
		[Field("defProductAsFormula", false, "False", Int32.MaxValue)]
		public bool? DefProductAsFormula;

		[JsonProperty("billOfMaterialId")]
		[Field("billOfMaterialId", false, "0", Int32.MaxValue)]
		public long? BillOfMaterialId;

		[JsonProperty("defProdProcessAsConfigurator")]
		[Field("defProdProcessAsConfigurator", false, "False", Int32.MaxValue)]
		public bool? DefProdProcessAsConfigurator;

	}
}
