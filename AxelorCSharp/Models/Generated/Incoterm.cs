using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.Incoterm")]
	public class Incoterm : AxelorModel
	{
		[JsonProperty("insurance")]
		[Field("insurance", false, "0", Int32.MaxValue)]
		public int? Insurance;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("carriageToPortOfImport")]
		[Field("carriageToPortOfImport", false, "0", Int32.MaxValue)]
		public int? CarriageToPortOfImport;

		[JsonProperty("carriageToPortOfExport")]
		[Field("carriageToPortOfExport", false, "0", Int32.MaxValue)]
		public int? CarriageToPortOfExport;

		[JsonProperty("unloadingInPortOfImport")]
		[Field("unloadingInPortOfImport", false, "0", Int32.MaxValue)]
		public int? UnloadingInPortOfImport;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("carriageToPlaceOfDestination")]
		[Field("carriageToPlaceOfDestination", false, "0", Int32.MaxValue)]
		public int? CarriageToPlaceOfDestination;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("loadingOnTruckInPortOfImport")]
		[Field("loadingOnTruckInPortOfImport", false, "0", Int32.MaxValue)]
		public int? LoadingOnTruckInPortOfImport;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("unloadingOfTruckInPortOfExport")]
		[Field("unloadingOfTruckInPortOfExport", false, "0", Int32.MaxValue)]
		public int? UnloadingOfTruckInPortOfExport;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("exportCustomsDeclaration")]
		[Field("exportCustomsDeclaration", false, "0", Int32.MaxValue)]
		public int? ExportCustomsDeclaration;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("importCustomsClearance")]
		[Field("importCustomsClearance", false, "0", Int32.MaxValue)]
		public int? ImportCustomsClearance;

		[JsonProperty("importDutiesAndTaxes")]
		[Field("importDutiesAndTaxes", false, "0", Int32.MaxValue)]
		public int? ImportDutiesAndTaxes;

		[JsonProperty("loadingInPortOfExport")]
		[Field("loadingInPortOfExport", false, "0", Int32.MaxValue)]
		public int? LoadingInPortOfExport;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("fullname")]
		[Field("fullname", false, null, Int32.MaxValue)]
		public string? Fullname;

	}
}
