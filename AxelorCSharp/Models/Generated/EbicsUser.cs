using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.EbicsUser")]
	public class EbicsUser : AxelorModel
	{
		[JsonProperty("x002Certificate")]
		[Field("x002Certificate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? X002Certificate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("testDataFile")]
		[Field("testDataFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? TestDataFile;

		[JsonProperty("dn")]
		[Field("dn", false, null, Int32.MaxValue)]
		public string? Dn;

		[JsonProperty("testSignatureFile")]
		[Field("testSignatureFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? TestSignatureFile;

		[JsonProperty("associatedUser")]
		[Field("associatedUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? AssociatedUser;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("password")]
		[Field("password", false, null, Int32.MaxValue)]
		public string? Password;

		[JsonProperty("userTypeSelect")]
		[Field("userTypeSelect", false, "0", Int32.MaxValue)]
		public int? UserTypeSelect;

		[JsonProperty("testSignatoryEbicsUser")]
		[Field("testSignatoryEbicsUser", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? TestSignatoryEbicsUser;

		[JsonProperty("a005Certificate")]
		[Field("a005Certificate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? A005Certificate;

		[JsonProperty("e002Certificate")]
		[Field("e002Certificate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsCertificate? E002Certificate;

		[JsonProperty("ebicsPartner")]
		[Field("ebicsPartner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsPartner? EbicsPartner;

		[JsonProperty("ebicsRequestLogList")]
		[Field("ebicsRequestLogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsRequestLog>? EbicsRequestLogList;

		[JsonProperty("securityMedium")]
		[Field("securityMedium", false, "0000", Int32.MaxValue)]
		public string? SecurityMedium;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("userId")]
		[Field("userId", true, null, 35)]
		public string? UserId;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("testBankOrderFileFormat")]
		[Field("testBankOrderFileFormat", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? TestBankOrderFileFormat;

		[JsonProperty("nextOrderId")]
		[Field("nextOrderId", false, null, Int32.MaxValue)]
		public string? NextOrderId;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("testBankStatementFileFormat")]
		[Field("testBankStatementFileFormat", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? TestBankStatementFileFormat;

	}
}
