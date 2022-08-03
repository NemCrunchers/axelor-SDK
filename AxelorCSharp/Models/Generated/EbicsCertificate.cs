using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.EbicsCertificate")]
	public class EbicsCertificate : AxelorModel
	{
		[JsonProperty("pemString")]
		[Field("pemString", false, null, Int32.MaxValue)]
		public string? PemString;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("subject")]
		[Field("subject", false, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("sha2has")]
		[Field("sha2has", false, null, Int32.MaxValue)]
		public string? Sha2has;

		[JsonProperty("publicKeyModulus")]
		[Field("publicKeyModulus", false, null, Int32.MaxValue)]
		public string? PublicKeyModulus;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, null, Int32.MaxValue)]
		public string? TypeSelect;

		[JsonProperty("validFrom")]
		[Field("validFrom", false, null, Int32.MaxValue)]
		public DateTime? ValidFrom;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("issuer")]
		[Field("issuer", false, null, Int32.MaxValue)]
		public string? Issuer;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("publicKeyExponent")]
		[Field("publicKeyExponent", false, null, Int32.MaxValue)]
		public string? PublicKeyExponent;

		[JsonProperty("validTo")]
		[Field("validTo", false, null, Int32.MaxValue)]
		public DateTime? ValidTo;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("serial")]
		[Field("serial", false, null, Int32.MaxValue)]
		public string? Serial;

		[JsonProperty("ebicsBank")]
		[Field("ebicsBank", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsBank? EbicsBank;

		[JsonProperty("initLetterEditionDate")]
		[Field("initLetterEditionDate", false, null, Int32.MaxValue)]
		public DateTime? InitLetterEditionDate;

	}
}
