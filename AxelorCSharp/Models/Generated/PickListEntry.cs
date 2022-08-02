using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.PickListEntry")]
	public class PickListEntry : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("address")]
		public Axelor.Apps.Base.Db.Address? Address;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("l2")]
		public string? L2;

		[Field("l3")]
		public string? L3;

		[Field("picklist")]
		public string? Picklist;

		[Field("postcode")]
		public string? Postcode;

		[Field("fullName")]
		public string? FullName;

		[Field("l5")]
		public string? L5;

		[Field("moniker")]
		public string? Moniker;

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

		[Field("score")]
		public string? Score;

		[Field("importId")]
		public string? ImportId;

		[Field("inseeCode")]
		public string? InseeCode;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("partialAddress")]
		public string? PartialAddress;

		[Field("id")]
		public long? Id;

	}
}
