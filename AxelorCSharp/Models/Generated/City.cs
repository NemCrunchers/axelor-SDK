using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.City")]
	public class City : AxelorModel
	{
		[Field("zip")]
		public string? Zip;

		[Field("country")]
		public Axelor.Apps.Base.Db.Country? Country;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("nbInhCommune")]
		public int? NbInhCommune;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("artmin")]
		public string? Artmin;

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

		[Field("inseeCode")]
		public string? InseeCode;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("hasZipOnRight")]
		public bool? HasZipOnRight;

		[Field("name")]
		public string? Name;

		[Field("canton")]
		public Axelor.Apps.Base.Db.Canton? Canton;

		[Field("id")]
		public long? Id;

		[Field("department")]
		public Axelor.Apps.Base.Db.Department? Department;

	}
}
