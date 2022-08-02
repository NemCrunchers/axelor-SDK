using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankOrderFileFormatCountry")]
	public class BankOrderFileFormatCountry : AxelorModel
	{
		[Field("country")]
		public Axelor.Apps.Base.Db.Country? Country;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("bankOrderFileFormat")]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("receiverAddressRequired")]
		public bool? ReceiverAddressRequired;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
