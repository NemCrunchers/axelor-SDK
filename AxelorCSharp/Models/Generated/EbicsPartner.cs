using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsPartner")]
	public class EbicsPartner : AxelorModel
	{
		[Field("ebicsTypeSelect")]
		public int? EbicsTypeSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("filterReceiverBD")]
		public bool? FilterReceiverBD;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("bankDetailsSet")]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetailsSet;

		[Field("archived")]
		public bool? Archived;

		[Field("receiverBankDetailsSet")]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? ReceiverBankDetailsSet;

		[Field("id")]
		public long? Id;

		[Field("bankStatementLastExeDateT")]
		public DateTime? BankStatementLastExeDateT;

		[Field("usePSR")]
		public bool? UsePSR;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("bankStatementGetModeSelect")]
		public int? BankStatementGetModeSelect;

		[Field("attrs")]
		public string? Attrs;

		[Field("pSRBankStatementFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? PSRBankStatementFileFormat;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("orderTypeSelect")]
		public int? OrderTypeSelect;

		[Field("testMode")]
		public bool? TestMode;

		[Field("defaultSignatoryEbicsUser")]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? DefaultSignatoryEbicsUser;

		[Field("transportEbicsUser")]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? TransportEbicsUser;

		[Field("partnerId")]
		public string? PartnerId;

		[Field("ebicsBank")]
		public Axelor.Apps.Bankpayment.Db.EbicsBank? EbicsBank;

	}
}
