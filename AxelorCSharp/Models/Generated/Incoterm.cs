using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.Incoterm")]
	public class Incoterm : AxelorModel
	{
		[Field("insurance")]
		public int? Insurance;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("carriageToPortOfImport")]
		public int? CarriageToPortOfImport;

		[Field("carriageToPortOfExport")]
		public int? CarriageToPortOfExport;

		[Field("unloadingInPortOfImport")]
		public int? UnloadingInPortOfImport;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("carriageToPlaceOfDestination")]
		public int? CarriageToPlaceOfDestination;

		[Field("id")]
		public long? Id;

		[Field("loadingOnTruckInPortOfImport")]
		public int? LoadingOnTruckInPortOfImport;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("unloadingOfTruckInPortOfExport")]
		public int? UnloadingOfTruckInPortOfExport;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("exportCustomsDeclaration")]
		public int? ExportCustomsDeclaration;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("importCustomsClearance")]
		public int? ImportCustomsClearance;

		[Field("importDutiesAndTaxes")]
		public int? ImportDutiesAndTaxes;

		[Field("loadingInPortOfExport")]
		public int? LoadingInPortOfExport;

		[Field("name")]
		public string? Name;

		[Field("fullname")]
		public string? Fullname;

	}
}
