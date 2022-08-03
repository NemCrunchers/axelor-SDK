using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Journal")]
	public class Journal : AxelorModel
	{
		[JsonProperty("excessPaymentOk")]
		[Field("excessPaymentOk", false, "False", Int32.MaxValue)]
		public bool? ExcessPaymentOk;

		[JsonProperty("editReceiptOk")]
		[Field("editReceiptOk", false, "False", Int32.MaxValue)]
		public bool? EditReceiptOk;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("validAccountSet")]
		[Field("validAccountSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? ValidAccountSet;

		[JsonProperty("descriptionIdentificationOk")]
		[Field("descriptionIdentificationOk", false, "False", Int32.MaxValue)]
		public bool? DescriptionIdentificationOk;

		[JsonProperty("validAccountTypeSet")]
		[Field("validAccountTypeSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AccountType>? ValidAccountTypeSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("notExportOk")]
		[Field("notExportOk", false, "False", Int32.MaxValue)]
		public bool? NotExportOk;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("exportCode")]
		[Field("exportCode", false, null, Int32.MaxValue)]
		public string? ExportCode;

		[JsonProperty("isInvoiceMoveConsolidated")]
		[Field("isInvoiceMoveConsolidated", false, "False", Int32.MaxValue)]
		public bool? IsInvoiceMoveConsolidated;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("journalType")]
		[Field("journalType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.JournalType? JournalType;

		[JsonProperty("descriptionModel")]
		[Field("descriptionModel", false, null, Int32.MaxValue)]
		public string? DescriptionModel;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

	}
}
