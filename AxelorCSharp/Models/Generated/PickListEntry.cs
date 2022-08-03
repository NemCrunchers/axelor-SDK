using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.PickListEntry")]
	public class PickListEntry : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("address")]
		[Field("address", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? Address;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("l2")]
		[Field("l2", false, null, Int32.MaxValue)]
		public string? L2;

		[JsonProperty("l3")]
		[Field("l3", false, null, Int32.MaxValue)]
		public string? L3;

		[JsonProperty("picklist")]
		[Field("picklist", false, null, Int32.MaxValue)]
		public string? Picklist;

		[JsonProperty("postcode")]
		[Field("postcode", false, null, Int32.MaxValue)]
		public string? Postcode;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("l5")]
		[Field("l5", false, null, Int32.MaxValue)]
		public string? L5;

		[JsonProperty("moniker")]
		[Field("moniker", false, null, Int32.MaxValue)]
		public string? Moniker;

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

		[JsonProperty("score")]
		[Field("score", false, null, Int32.MaxValue)]
		public string? Score;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("inseeCode")]
		[Field("inseeCode", false, null, Int32.MaxValue)]
		public string? InseeCode;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("partialAddress")]
		[Field("partialAddress", false, null, Int32.MaxValue)]
		public string? PartialAddress;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
