using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.UnitConversion")]
	public class UnitConversion : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("endUnit")]
		public Axelor.Apps.Base.Db.Unit? EndUnit;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("startUnit")]
		public Axelor.Apps.Base.Db.Unit? StartUnit;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("formula")]
		public string? Formula;

		[Field("id")]
		public long? Id;

	}
}
