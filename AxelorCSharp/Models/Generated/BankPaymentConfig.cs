using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankPaymentConfig")]
	public class BankPaymentConfig : AxelorModel
	{
		[Field("otherBankOrderSequence")]
		public Axelor.Apps.Base.Db.Sequence? OtherBankOrderSequence;

		[Field("sepaCreditTransSequence")]
		public Axelor.Apps.Base.Db.Sequence? SepaCreditTransSequence;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("generateMoveOnBankOrderValidation")]
		public bool? GenerateMoveOnBankOrderValidation;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("defaultSignatoryUser")]
		public Axelor.Auth.Db.User? DefaultSignatoryUser;

		[Field("sepaDirectDebitSequence")]
		public Axelor.Apps.Base.Db.Sequence? SepaDirectDebitSequence;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("intCreditTransSequence")]
		public Axelor.Apps.Base.Db.Sequence? IntCreditTransSequence;

		[Field("version")]
		public int? Version;

		[Field("natTreasuryTransSequence")]
		public Axelor.Apps.Base.Db.Sequence? NatTreasuryTransSequence;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("icsNumber")]
		public string? IcsNumber;

		[Field("intDirectDebitSequence")]
		public Axelor.Apps.Base.Db.Sequence? IntDirectDebitSequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("internalBankToBankAccount")]
		public Axelor.Apps.Account.Db.Account? InternalBankToBankAccount;

		[Field("id")]
		public long? Id;

		[Field("externalBankToBankAccount")]
		public Axelor.Apps.Account.Db.Account? ExternalBankToBankAccount;

		[Field("intTreasuryTransSequence")]
		public Axelor.Apps.Base.Db.Sequence? IntTreasuryTransSequence;

	}
}
