using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.EbicsRequestLog")]
	public class EbicsRequestLog : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("requestType")]
		public string? RequestType;

		[Field("ebicsUser")]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? EbicsUser;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("responseCode")]
		public string? ResponseCode;

		[Field("requestTime")]
		public DateTime? RequestTime;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("responseFile")]
		public Axelor.Meta.Db.MetaFile? ResponseFile;

	}
}
