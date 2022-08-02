using Axelor.SDK;

namespace Axelor.Apps.Talent.Db
{
	[Model("com.axelor.apps.talent.db.Training")]
	public class Training : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("skillSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Skill>? SkillSet;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("requiredTrainingSet")]
		public IEnumerable<Axelor.Apps.Talent.Db.Training>? RequiredTrainingSet;

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

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("mandatoryTraining")]
		public bool? MandatoryTraining;

		[Field("category")]
		public Axelor.Apps.Talent.Db.TrainingCategory? Category;

	}
}
