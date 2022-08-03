using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.BankDetails")]
	public class BankDetails : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("accountNbr")]
		[Field("accountNbr", false, null, 255)]
		public string? AccountNbr;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bank")]
		[Field("bank", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Bank? Bank;

		[JsonProperty("ownerName")]
		[Field("ownerName", false, null, 255)]
		public string? OwnerName;

		[JsonProperty("bbanKey")]
		[Field("bbanKey", false, null, 255)]
		public string? BbanKey;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("specificNoteOnInvoice")]
		[Field("specificNoteOnInvoice", false, null, Int32.MaxValue)]
		public string? SpecificNoteOnInvoice;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("bankCode")]
		[Field("bankCode", false, null, 255)]
		public string? BankCode;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("ibanBic")]
		[Field("ibanBic", false, null, 255)]
		public string? IbanBic;

		[JsonProperty("active")]
		[Field("active", false, "True", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("label")]
		[Field("label", false, null, Int32.MaxValue)]
		public string? Label;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("bankAddress")]
		[Field("bankAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankAddress? BankAddress;

		[JsonProperty("sortCode")]
		[Field("sortCode", false, null, 255)]
		public string? SortCode;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isDefault")]
		[Field("isDefault", false, "False", Int32.MaxValue)]
		public bool? IsDefault;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("iban")]
		[Field("iban", true, null, Int32.MaxValue)]
		public string? Iban;

	}
}
