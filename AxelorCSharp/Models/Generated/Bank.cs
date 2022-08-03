using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Bank")]
	public class Bank : AxelorModel
	{
		[JsonProperty("country")]
		[Field("country", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? Country;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("bankName")]
		[Field("bankName", false, null, 255)]
		public string? BankName;

		[JsonProperty("businessPartyPrefix")]
		[Field("businessPartyPrefix", false, null, 4)]
		public string? BusinessPartyPrefix;

		[JsonProperty("businessPartySuffix")]
		[Field("businessPartySuffix", false, null, 2)]
		public string? BusinessPartySuffix;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

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

		[JsonProperty("bankDetails")]
		[Field("bankDetails", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankDetails>? BankDetails;

		[JsonProperty("branchIdentifier")]
		[Field("branchIdentifier", false, null, 3)]
		public string? BranchIdentifier;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("bankAddressList")]
		[Field("bankAddressList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.BankAddress>? BankAddressList;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("bankDetailsTypeSelect")]
		[Field("bankDetailsTypeSelect", true, "1", Int32.MaxValue)]
		public int? BankDetailsTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
