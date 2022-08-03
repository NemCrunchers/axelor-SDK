using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Talent.Db
{
	[Serializable]
	[Model("com.axelor.apps.talent.db.Training")]
	public class Training : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("skillSet")]
		[Field("skillSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("requiredTrainingSet")]
		[Field("requiredTrainingSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Talent.Db.Training>? RequiredTrainingSet;

		[JsonProperty("rating")]
		[Field("rating", false, "0", Int32.MaxValue)]
		public decimal? Rating;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("program")]
		[Field("program", false, null, Int32.MaxValue)]
		public string? Program;

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

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public decimal? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("objectives")]
		[Field("objectives", false, null, Int32.MaxValue)]
		public string? Objectives;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("mandatoryTraining")]
		[Field("mandatoryTraining", false, "False", Int32.MaxValue)]
		public bool? MandatoryTraining;

		[JsonProperty("category")]
		[Field("category", false, null, Int32.MaxValue)]
		public Axelor.Apps.Talent.Db.TrainingCategory? Category;

	}
}
