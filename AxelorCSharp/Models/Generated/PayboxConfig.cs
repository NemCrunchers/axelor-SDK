using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.PayboxConfig")]
	public class PayboxConfig : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("payboxRetour")]
		public string? PayboxRetour;

		[Field("payboxSite")]
		public string? PayboxSite;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("payboxDefaultEmail")]
		public string? PayboxDefaultEmail;

		[Field("payboxRetourUrlAnnule")]
		public string? PayboxRetourUrlAnnule;

		[Field("id")]
		public long? Id;

		[Field("payboxPublicKeyPath")]
		public string? PayboxPublicKeyPath;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("payboxRetourUrlEffectue")]
		public string? PayboxRetourUrlEffectue;

		[Field("payboxRang")]
		public string? PayboxRang;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("payboxHmac")]
		public string? PayboxHmac;

		[Field("version")]
		public int? Version;

		[Field("payboxDevise")]
		public string? PayboxDevise;

		[Field("attrs")]
		public string? Attrs;

		[Field("payboxRetourUrlRefuse")]
		public string? PayboxRetourUrlRefuse;

		[Field("payboxUrl")]
		public string? PayboxUrl;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("payboxIdentifiant")]
		public string? PayboxIdentifiant;

		[Field("name")]
		public string? Name;

		[Field("payboxHashSelect")]
		public string? PayboxHashSelect;

	}
}
