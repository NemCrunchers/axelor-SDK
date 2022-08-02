using Axelor.SDK;

namespace Axelor.Apps.Contract.Db
{
	[Model("com.axelor.apps.contract.db.ConsumptionLine")]
	public class ConsumptionLine : AxelorModel
	{
		[Field("contractLine")]
		public Axelor.Apps.Contract.Db.ContractLine? ContractLine;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isInvoiced")]
		public bool? IsInvoiced;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("isError")]
		public bool? IsError;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoiceLine")]
		public Axelor.Apps.Account.Db.InvoiceLine? InvoiceLine;

		[Field("id")]
		public long? Id;

	}
}
