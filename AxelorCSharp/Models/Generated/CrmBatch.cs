using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.CrmBatch")]
	public class CrmBatch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("durationTypeSelect")]
		public int? DurationTypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("targetConfigurationSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.TargetConfiguration>? TargetConfigurationSet;

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

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("actionSelect")]
		public int? ActionSelect;

	}
}
