using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankOrderLineOrigin")]
	public class BankOrderLineOrigin : AxelorModel
	{
		[Field("bankOrderLine")]
		public Axelor.Apps.Bankpayment.Db.BankOrderLine? BankOrderLine;

		[Field("relatedToSelectId")]
		public long? RelatedToSelectId;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("relatedToSelectName")]
		public string? RelatedToSelectName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("relatedToSelect")]
		public string? RelatedToSelect;

	}
}
