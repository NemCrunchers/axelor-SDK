using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Country")]
	public class Country : AxelorModel
	{
		[JsonProperty("phonePrefix")]
		[Field("phonePrefix", false, null, Int32.MaxValue)]
		public string? PhonePrefix;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("alpha2Code")]
		[Field("alpha2Code", false, null, 2)]
		public string? Alpha2Code;

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

		[JsonProperty("numericCode")]
		[Field("numericCode", false, null, 3)]
		public string? NumericCode;

		[JsonProperty("alpha3Code")]
		[Field("alpha3Code", false, null, 3)]
		public string? Alpha3Code;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("economicArea")]
		[Field("economicArea", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.EconomicArea? EconomicArea;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isIspmRequired")]
		[Field("isIspmRequired", false, "False", Int32.MaxValue)]
		public bool? IsIspmRequired;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("cog")]
		[Field("cog", false, null, Int32.MaxValue)]
		public string? Cog;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
