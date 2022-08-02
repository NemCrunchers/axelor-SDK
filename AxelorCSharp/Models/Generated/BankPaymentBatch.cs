using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankPaymentBatch")]
	public class BankPaymentBatch : AxelorModel
	{
		[Field("template")]
		public Axelor.Apps.Message.Db.Template? Template;

		[Field("bankStatementFileFormatSet")]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankStatementFileFormat>? BankStatementFileFormatSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("ebicsPartnerSet")]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsPartner>? EbicsPartnerSet;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("daysNbr")]
		public int? DaysNbr;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("actionSelect")]
		public int? ActionSelect;

	}
}
