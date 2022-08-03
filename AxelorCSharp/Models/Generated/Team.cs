using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Team.Db
{
	[Serializable]
	[Model("com.axelor.team.db.Team")]
	public class Team : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("topics")]
		[Field("topics", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Team.Db.TeamTopic>? Topics;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, null, Int32.MaxValue)]
		public string? TypeSelect;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("members")]
		[Field("members", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? Members;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
