using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.EbicsPartner")]
	public class EbicsPartner : AxelorModel
	{
		[JsonProperty("bankStatementEndDate")]
		[Field("bankStatementEndDate", false, null, Int32.MaxValue)]
		public DateTime? BankStatementEndDate;

		[JsonProperty("boEbicsPartnerServiceList")]
		[Field("boEbicsPartnerServiceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsPartnerService>? BoEbicsPartnerServiceList;

		[JsonProperty("ebicsTypeSelect")]
		[Field("ebicsTypeSelect", false, "0", Int32.MaxValue)]
		public int? EbicsTypeSelect;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("filterReceiverBD")]
		[Field("filterReceiverBD", false, "False", Int32.MaxValue)]
		public bool? FilterReceiverBD;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("bankDetailsSet")]
		[Field("bankDetailsSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetailsSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bankStatementStartDate")]
		[Field("bankStatementStartDate", false, null, Int32.MaxValue)]
		public DateTime? BankStatementStartDate;

		[JsonProperty("receiverBankDetailsSet")]
		[Field("receiverBankDetailsSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? ReceiverBankDetailsSet;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("bankStatementLastExeDateT")]
		[Field("bankStatementLastExeDateT", false, null, Int32.MaxValue)]
		public DateTime? BankStatementLastExeDateT;

		[JsonProperty("usePSR")]
		[Field("usePSR", false, "False", Int32.MaxValue)]
		public bool? UsePSR;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("bankStatementGetModeSelect")]
		[Field("bankStatementGetModeSelect", false, "1", Int32.MaxValue)]
		public int? BankStatementGetModeSelect;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("pSRBankStatementFileFormat")]
		[Field("pSRBankStatementFileFormat", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? PSRBankStatementFileFormat;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("orderTypeSelect")]
		[Field("orderTypeSelect", false, "0", Int32.MaxValue)]
		public int? OrderTypeSelect;

		[JsonProperty("bsEbicsPartnerServiceList")]
		[Field("bsEbicsPartnerServiceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsPartnerService>? BsEbicsPartnerServiceList;

		[JsonProperty("testMode")]
		[Field("testMode", false, "False", Int32.MaxValue)]
		public bool? TestMode;

		[JsonProperty("defaultSignatoryEbicsUser")]
		[Field("defaultSignatoryEbicsUser", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? DefaultSignatoryEbicsUser;

		[JsonProperty("transportEbicsUser")]
		[Field("transportEbicsUser", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? TransportEbicsUser;

		[JsonProperty("partnerId")]
		[Field("partnerId", true, null, 35)]
		public string? PartnerId;

		[JsonProperty("ebicsBank")]
		[Field("ebicsBank", true, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsBank? EbicsBank;

	}
}
