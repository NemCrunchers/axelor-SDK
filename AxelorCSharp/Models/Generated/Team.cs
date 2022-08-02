using Axelor.SDK;

namespace Axelor.Team.Db
{
	[Model("com.axelor.team.db.Team")]
	public class Team : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("typeSelect")]
		public string? TypeSelect;

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

		[Field("members")]
		public IEnumerable<Axelor.Auth.Db.User>? Members;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
