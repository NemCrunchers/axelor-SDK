using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Journal")]
	public class Journal : AxelorModel
	{
		[Field("excessPaymentOk")]
		public bool? ExcessPaymentOk;

		[Field("editReceiptOk")]
		public bool? EditReceiptOk;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("validAccountSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? ValidAccountSet;

		[Field("descriptionIdentificationOk")]
		public bool? DescriptionIdentificationOk;

		[Field("validAccountTypeSet")]
		public IEnumerable<Axelor.Apps.Account.Db.AccountType>? ValidAccountTypeSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("notExportOk")]
		public bool? NotExportOk;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("exportCode")]
		public string? ExportCode;

		[Field("isInvoiceMoveConsolidated")]
		public bool? IsInvoiceMoveConsolidated;

		[Field("sequence")]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("journalType")]
		public Axelor.Apps.Account.Db.JournalType? JournalType;

		[Field("descriptionModel")]
		public string? DescriptionModel;

		[Field("name")]
		public string? Name;

	}
}
