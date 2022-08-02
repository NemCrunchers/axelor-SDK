using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsUser")]
	public class EbicsUser : AxelorModel
	{
		[Field("x002Certificate")]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? X002Certificate;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("testDataFile")]
		public Axelor.Meta.Db.MetaFile? TestDataFile;

		[Field("dn")]
		public string? Dn;

		[Field("testSignatureFile")]
		public Axelor.Meta.Db.MetaFile? TestSignatureFile;

		[Field("associatedUser")]
		public Axelor.Auth.Db.User? AssociatedUser;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("password")]
		public string? Password;

		[Field("userTypeSelect")]
		public int? UserTypeSelect;

		[Field("testSignatoryEbicsUser")]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? TestSignatoryEbicsUser;

		[Field("a005Certificate")]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? A005Certificate;

		[Field("e002Certificate")]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? E002Certificate;

		[Field("ebicsPartner")]
		public Axelor.Apps.Bankpayment.Db.EbicsPartner? EbicsPartner;

		[Field("securityMedium")]
		public string? SecurityMedium;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("userId")]
		public string? UserId;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("testBankOrderFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? TestBankOrderFileFormat;

		[Field("nextOrderId")]
		public string? NextOrderId;

		[Field("name")]
		public string? Name;

		[Field("testBankStatementFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? TestBankStatementFileFormat;

	}
}
