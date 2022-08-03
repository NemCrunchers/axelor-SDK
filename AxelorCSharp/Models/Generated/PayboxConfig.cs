using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PayboxConfig")]
	public class PayboxConfig : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("payboxRetour")]
		[Field("payboxRetour", false, null, Int32.MaxValue)]
		public string? PayboxRetour;

		[JsonProperty("payboxSite")]
		[Field("payboxSite", false, null, 7)]
		public string? PayboxSite;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("payboxDefaultEmail")]
		[Field("payboxDefaultEmail", false, null, Int32.MaxValue)]
		public string? PayboxDefaultEmail;

		[JsonProperty("payboxRetourUrlAnnule")]
		[Field("payboxRetourUrlAnnule", false, "http://localhost:8080/axelor/#/ds/account.root.periodic.processing.account.voucher/edit/%id?retour=3", Int32.MaxValue)]
		public string? PayboxRetourUrlAnnule;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("payboxPublicKeyPath")]
		[Field("payboxPublicKeyPath", false, "/home/axelor/Paybox/pubkey.pem", Int32.MaxValue)]
		public string? PayboxPublicKeyPath;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("payboxRetourUrlEffectue")]
		[Field("payboxRetourUrlEffectue", false, "http://localhost:8080/axelor/#/ds/account.root.periodic.processing.account.voucher/edit/%id?retour=1", Int32.MaxValue)]
		public string? PayboxRetourUrlEffectue;

		[JsonProperty("payboxRang")]
		[Field("payboxRang", false, null, 2)]
		public string? PayboxRang;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("payboxHmac")]
		[Field("payboxHmac", false, null, Int32.MaxValue)]
		public string? PayboxHmac;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("payboxDevise")]
		[Field("payboxDevise", false, "978", 3)]
		public string? PayboxDevise;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("payboxRetourUrlRefuse")]
		[Field("payboxRetourUrlRefuse", false, "http://localhost:8080/axelor/#/ds/account.root.periodic.processing.account.voucher/edit/%id?retour=2", Int32.MaxValue)]
		public string? PayboxRetourUrlRefuse;

		[JsonProperty("payboxUrl")]
		[Field("payboxUrl", false, null, Int32.MaxValue)]
		public string? PayboxUrl;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("payboxIdentifiant")]
		[Field("payboxIdentifiant", false, null, 9)]
		public string? PayboxIdentifiant;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("payboxHashSelect")]
		[Field("payboxHashSelect", false, "SHA512", Int32.MaxValue)]
		public string? PayboxHashSelect;

	}
}
