using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsPartnerService")]
	public class EbicsPartnerService : AxelorModel
	{
		[Field("bankOrderEbicsPartner")]
		public Axelor.Apps.Bankpayment.Db.EbicsPartner? BankOrderEbicsPartner;

		[Field("bankStatementEbicsPartner")]
		public Axelor.Apps.Bankpayment.Db.EbicsPartner? BankStatementEbicsPartner;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("ebicsCodification")]
		public string? EbicsCodification;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("bankOrderFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("bankStatementFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? BankStatementFileFormat;

	}
}
