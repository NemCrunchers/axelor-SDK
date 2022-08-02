using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.MrpLineOrigin")]
	public class MrpLineOrigin : AxelorModel
	{
		[Field("mrpLine")]
		public Axelor.Apps.Supplychain.Db.MrpLine? MrpLine;

		[Field("relatedToSelectId")]
		public long? RelatedToSelectId;

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
