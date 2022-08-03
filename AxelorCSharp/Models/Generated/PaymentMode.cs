using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PaymentMode")]
	public class PaymentMode : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("generateBankOrder")]
		[Field("generateBankOrder", false, "False", Int32.MaxValue)]
		public bool? GenerateBankOrder;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("accountManagementList")]
		[Field("accountManagementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AccountManagement>? AccountManagementList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("consoBankOrderLinePerPartner")]
		[Field("consoBankOrderLinePerPartner", false, "False", Int32.MaxValue)]
		public bool? ConsoBankOrderLinePerPartner;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("bankOrderExportFolderPath")]
		[Field("bankOrderExportFolderPath", false, null, Int32.MaxValue)]
		public string? BankOrderExportFolderPath;

		[JsonProperty("inOutSelect")]
		[Field("inOutSelect", false, "0", Int32.MaxValue)]
		public int? InOutSelect;

		[JsonProperty("validatePaymentByDepositSlipPublication")]
		[Field("validatePaymentByDepositSlipPublication", false, "False", Int32.MaxValue)]
		public bool? ValidatePaymentByDepositSlipPublication;

		[JsonProperty("automaticTransmission")]
		[Field("automaticTransmission", false, "False", Int32.MaxValue)]
		public bool? AutomaticTransmission;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("autoConfirmBankOrder")]
		[Field("autoConfirmBankOrder", false, "False", Int32.MaxValue)]
		public bool? AutoConfirmBankOrder;

		[JsonProperty("generateMoveAutoFromBankOrder")]
		[Field("generateMoveAutoFromBankOrder", false, "False", Int32.MaxValue)]
		public bool? GenerateMoveAutoFromBankOrder;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("bankOrderFileFormat")]
		[Field("bankOrderFileFormat", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("orderTypeSelect")]
		[Field("orderTypeSelect", false, "0", Int32.MaxValue)]
		public int? OrderTypeSelect;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

	}
}
