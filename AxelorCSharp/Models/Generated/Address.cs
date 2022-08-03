using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Address")]
	public class Address : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("certifiedOk")]
		[Field("certifiedOk", false, "False", Int32.MaxValue)]
		public bool? CertifiedOk;

		[JsonProperty("city")]
		[Field("city", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.City? City;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("inseeCode")]
		[Field("inseeCode", false, null, Int32.MaxValue)]
		public string? InseeCode;

		[JsonProperty("latit")]
		[Field("latit", false, null, Int32.MaxValue)]
		public decimal? Latit;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("zip")]
		[Field("zip", false, null, Int32.MaxValue)]
		public string? Zip;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("zoom")]
		[Field("zoom", false, "0", Int32.MaxValue)]
		public int? Zoom;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("pickList")]
		[Field("pickList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.PickListEntry>? PickList;

		[JsonProperty("addressL2")]
		[Field("addressL2", false, null, Int32.MaxValue)]
		public string? AddressL2;

		[JsonProperty("addressL3")]
		[Field("addressL3", false, null, Int32.MaxValue)]
		public string? AddressL3;

		[JsonProperty("addressL4")]
		[Field("addressL4", true, null, Int32.MaxValue)]
		public string? AddressL4;

		[JsonProperty("longit")]
		[Field("longit", false, null, Int32.MaxValue)]
		public decimal? Longit;

		[JsonProperty("addressL5")]
		[Field("addressL5", false, null, Int32.MaxValue)]
		public string? AddressL5;

		[JsonProperty("addressL6")]
		[Field("addressL6", false, null, Int32.MaxValue)]
		public string? AddressL6;

		[JsonProperty("addressL7Country")]
		[Field("addressL7Country", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? AddressL7Country;

	}
}
