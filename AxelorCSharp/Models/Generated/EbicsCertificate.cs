using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsCertificate")]
	public class EbicsCertificate : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("subject")]
		public string? Subject;

		[Field("typeSelect")]
		public string? TypeSelect;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("issuer")]
		public string? Issuer;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("serial")]
		public string? Serial;

		[Field("ebicsBank")]
		public Axelor.Apps.Bankpayment.Db.EbicsBank? EbicsBank;

		[Field("initLetterEditionDate")]
		public DateTime? InitLetterEditionDate;

	}
}
