using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsBank")]
	public class EbicsBank : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("hostId")]
		public string? HostId;

		[Field("language")]
		public Axelor.Apps.Base.Db.Language? Language;

		[Field("protocolSelect")]
		public string? ProtocolSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("url")]
		public string? Url;

		[Field("attrs")]
		public string? Attrs;

		[Field("useX509ExtentionForAutoSignedCert")]
		public bool? UseX509ExtentionForAutoSignedCert;

		[Field("archived")]
		public bool? Archived;

		[Field("bank")]
		public Axelor.Apps.Base.Db.Bank? Bank;

		[Field("emailAddress")]
		public string? EmailAddress;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("fax")]
		public string? Fax;

		[Field("certValidityPeriodSelect")]
		public int? CertValidityPeriodSelect;

	}
}
