using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Umr")]
	public class Umr : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("debtorAddress")]
		[Field("debtorAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? DebtorAddress;

		[JsonProperty("activeBankDetails")]
		[Field("activeBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? ActiveBankDetails;

		[JsonProperty("umrNumber")]
		[Field("umrNumber", false, null, Int32.MaxValue)]
		public string? UmrNumber;

		[JsonProperty("debtorName")]
		[Field("debtorName", false, null, Int32.MaxValue)]
		public string? DebtorName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("creationDate")]
		[Field("creationDate", false, null, Int32.MaxValue)]
		public DateTime? CreationDate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("mandateSignatureDate")]
		[Field("mandateSignatureDate", false, null, Int32.MaxValue)]
		public DateTime? MandateSignatureDate;

		[JsonProperty("isUpdating")]
		[Field("isUpdating", false, "False", Int32.MaxValue)]
		public bool? IsUpdating;

		[JsonProperty("lastNumberIbanBic")]
		[Field("lastNumberIbanBic", false, null, Int32.MaxValue)]
		public string? LastNumberIbanBic;

		[JsonProperty("mandateSignatureCity")]
		[Field("mandateSignatureCity", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.City? MandateSignatureCity;

	}
}
