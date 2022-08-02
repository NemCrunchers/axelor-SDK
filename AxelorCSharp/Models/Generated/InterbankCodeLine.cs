using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InterbankCodeLine")]
	public class InterbankCodeLine : AxelorModel
	{
		[Field("lcrBorOk")]
		public bool? LcrBorOk;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("technicalRejectOk")]
		public bool? TechnicalRejectOk;

		[Field("interbankCode")]
		public Axelor.Apps.Account.Db.InterbankCode? InterbankCode;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("directDebitSepaOk")]
		public bool? DirectDebitSepaOk;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("directDebitAndTipCfonbOk")]
		public bool? DirectDebitAndTipCfonbOk;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("chequeOk")]
		public bool? ChequeOk;

		[Field("id")]
		public long? Id;

		[Field("transferCfonbOk")]
		public bool? TransferCfonbOk;

	}
}
