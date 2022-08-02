using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.ActionBuilderView")]
	public class ActionBuilderView : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("actionBuilder")]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

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

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("viewName")]
		public string? ViewName;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("viewType")]
		public string? ViewType;

		[Field("id")]
		public long? Id;

	}
}
