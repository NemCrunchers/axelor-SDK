using Axelor.SDK;

namespace Axelor.Apps.Contract.Db
{
	[Model("com.axelor.apps.contract.db.ContractLine")]
	public class ContractLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("isInvoiced")]
		public bool? IsInvoiced;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("contractVersion")]
		public Axelor.Apps.Contract.Db.ContractVersion? ContractVersion;

		[Field("productName")]
		public string? ProductName;

		[Field("archived")]
		public bool? Archived;

		[Field("isConsumptionLine")]
		public bool? IsConsumptionLine;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("fiscalPosition")]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

	}
}
