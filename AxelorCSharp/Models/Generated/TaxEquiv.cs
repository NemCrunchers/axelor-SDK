using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.TaxEquiv")]
	public class TaxEquiv : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("toTax")]
		[Field("toTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? ToTax;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("specificNote")]
		[Field("specificNote", false, null, Int32.MaxValue)]
		public string? SpecificNote;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("fromTax")]
		[Field("fromTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? FromTax;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("reverseCharge")]
		[Field("reverseCharge", false, "False", Int32.MaxValue)]
		public bool? ReverseCharge;

		[JsonProperty("reverseChargeTax")]
		[Field("reverseChargeTax", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Tax? ReverseChargeTax;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fiscalPosition")]
		[Field("fiscalPosition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FiscalPosition? FiscalPosition;

	}
}
