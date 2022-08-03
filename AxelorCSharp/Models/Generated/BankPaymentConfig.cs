using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankPaymentConfig")]
	public class BankPaymentConfig : AxelorModel
	{
		[JsonProperty("otherBankOrderSequence")]
		[Field("otherBankOrderSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? OtherBankOrderSequence;

		[JsonProperty("sepaCreditTransSequence")]
		[Field("sepaCreditTransSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? SepaCreditTransSequence;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("generateMoveOnBankOrderValidation")]
		[Field("generateMoveOnBankOrderValidation", false, "False", Int32.MaxValue)]
		public bool? GenerateMoveOnBankOrderValidation;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("defaultSignatoryUser")]
		[Field("defaultSignatoryUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? DefaultSignatoryUser;

		[JsonProperty("sepaDirectDebitSequence")]
		[Field("sepaDirectDebitSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? SepaDirectDebitSequence;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("intCreditTransSequence")]
		[Field("intCreditTransSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? IntCreditTransSequence;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("natTreasuryTransSequence")]
		[Field("natTreasuryTransSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? NatTreasuryTransSequence;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("icsNumber")]
		[Field("icsNumber", false, null, 13)]
		public string? IcsNumber;

		[JsonProperty("intDirectDebitSequence")]
		[Field("intDirectDebitSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? IntDirectDebitSequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("internalBankToBankAccount")]
		[Field("internalBankToBankAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? InternalBankToBankAccount;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("externalBankToBankAccount")]
		[Field("externalBankToBankAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ExternalBankToBankAccount;

		[JsonProperty("intTreasuryTransSequence")]
		[Field("intTreasuryTransSequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? IntTreasuryTransSequence;

	}
}
