using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Country")]
	public class Country : AxelorModel
	{
		[Field("phonePrefix")]
		public string? PhonePrefix;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("alpha2Code")]
		public string? Alpha2Code;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("numericCode")]
		public string? NumericCode;

		[Field("alpha3Code")]
		public string? Alpha3Code;

		[Field("archived")]
		public bool? Archived;

		[Field("economicArea")]
		public Axelor.Apps.Base.Db.EconomicArea? EconomicArea;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isIspmRequired")]
		public bool? IsIspmRequired;

		[Field("name")]
		public string? Name;

		[Field("cog")]
		public string? Cog;

		[Field("id")]
		public long? Id;

	}
}
