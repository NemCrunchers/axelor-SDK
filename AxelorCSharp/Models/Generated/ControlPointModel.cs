using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Quality.Db
{
	[Serializable]
	[Model("com.axelor.apps.quality.db.ControlPointModel")]
	public class ControlPointModel : AxelorModel
	{
		[JsonProperty("instructions")]
		[Field("instructions", false, null, Int32.MaxValue)]
		public string? Instructions;

		[JsonProperty("messageIfFailure")]
		[Field("messageIfFailure", false, null, Int32.MaxValue)]
		public string? MessageIfFailure;

		[JsonProperty("controlFrequency")]
		[Field("controlFrequency", false, "0", Int32.MaxValue)]
		public decimal? ControlFrequency;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("notes")]
		[Field("notes", false, null, Int32.MaxValue)]
		public string? Notes;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("testTypeSelect")]
		[Field("testTypeSelect", false, "0", Int32.MaxValue)]
		public int? TestTypeSelect;

		[JsonProperty("team")]
		[Field("team", true, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

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

		[JsonProperty("controlTypeSelect")]
		[Field("controlTypeSelect", false, "0", Int32.MaxValue)]
		public int? ControlTypeSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("responsible")]
		[Field("responsible", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.Employee? Responsible;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("qualityProcess")]
		[Field("qualityProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Quality.Db.QualityProcess? QualityProcess;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
