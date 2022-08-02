using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Address")]
	public class Address : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("certifiedOk")]
		public bool? CertifiedOk;

		[Field("city")]
		public Axelor.Apps.Base.Db.City? City;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("inseeCode")]
		public string? InseeCode;

		[Field("id")]
		public long? Id;

		[Field("zip")]
		public string? Zip;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("zoom")]
		public int? Zoom;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("addressL2")]
		public string? AddressL2;

		[Field("addressL3")]
		public string? AddressL3;

		[Field("addressL4")]
		public string? AddressL4;

		[Field("addressL5")]
		public string? AddressL5;

		[Field("addressL6")]
		public string? AddressL6;

		[Field("addressL7Country")]
		public Axelor.Apps.Base.Db.Country? AddressL7Country;

	}
}
