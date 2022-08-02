using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.TaxEquiv")]
	public class TaxEquiv : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("toTax")]
		public Axelor.Apps.Account.Db.Tax? ToTax;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("fromTax")]
		public Axelor.Apps.Account.Db.Tax? FromTax;

		[Field("importId")]
		public string? ImportId;

		[Field("reverseCharge")]
		public bool? ReverseCharge;

		[Field("reverseChargeTax")]
		public Axelor.Apps.Account.Db.Tax? ReverseChargeTax;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("fiscalPosition")]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

	}
}
