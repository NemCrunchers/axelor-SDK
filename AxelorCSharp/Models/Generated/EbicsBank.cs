using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.EbicsBank")]
	public class EbicsBank : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("ebicsCertificateList")]
		[Field("ebicsCertificateList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.EbicsCertificate>? EbicsCertificateList;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("hostId")]
		[Field("hostId", false, null, Int32.MaxValue)]
		public string? HostId;

		[JsonProperty("language")]
		[Field("language", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Language? Language;

		[JsonProperty("protocolSelect")]
		[Field("protocolSelect", false, "ssl", Int32.MaxValue)]
		public string? ProtocolSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("url")]
		[Field("url", false, null, Int32.MaxValue)]
		public string? Url;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("useX509ExtentionForAutoSignedCert")]
		[Field("useX509ExtentionForAutoSignedCert", false, "True", Int32.MaxValue)]
		public bool? UseX509ExtentionForAutoSignedCert;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("bank")]
		[Field("bank", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Bank? Bank;

		[JsonProperty("emailAddress")]
		[Field("emailAddress", false, null, Int32.MaxValue)]
		public string? EmailAddress;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fax")]
		[Field("fax", false, null, Int32.MaxValue)]
		public string? Fax;

		[JsonProperty("certValidityPeriodSelect")]
		[Field("certValidityPeriodSelect", false, "5", Int32.MaxValue)]
		public int? CertValidityPeriodSelect;

	}
}
