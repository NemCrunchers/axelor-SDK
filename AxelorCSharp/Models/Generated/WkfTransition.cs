using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.WkfTransition")]
	public class WkfTransition : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("alertTypeSelect")]
		public int? AlertTypeSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("buttonTitle")]
		public string? ButtonTitle;

		[Field("source")]
		public Axelor.Studio.Db.WkfNode? Source;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("alertMsg")]
		public string? AlertMsg;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("target")]
		public Axelor.Studio.Db.WkfNode? Target;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("isButton")]
		public bool? IsButton;

		[Field("wkf")]
		public Axelor.Studio.Db.Wkf? Wkf;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("successMsg")]
		public string? SuccessMsg;

		[Field("xmlId")]
		public string? XmlId;

		[Field("roleSet")]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

	}
}
