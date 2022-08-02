using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.BankAddress")]
	public class BankAddress : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("address")]
		public string? Address;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("label")]
		public string? Label;

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

		[Field("bank")]
		public Axelor.Apps.Base.Db.Bank? Bank;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("fullAddress")]
		public string? FullAddress;

		[Field("id")]
		public long? Id;

	}
}
