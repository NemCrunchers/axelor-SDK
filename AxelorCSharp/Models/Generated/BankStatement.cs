using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankStatement")]
	public class BankStatement : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("getDateTime")]
		public DateTime? GetDateTime;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("bankStatementFile")]
		public Axelor.Meta.Db.MetaFile? BankStatementFile;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("ebicsPartner")]
		public Axelor.Apps.Bankpayment.Db.EbicsPartner? EbicsPartner;

		[Field("id")]
		public long? Id;

		[Field("bankStatementFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankStatementFileFormat? BankStatementFileFormat;

	}
}
