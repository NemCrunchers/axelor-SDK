using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.InvoiceLineTax")]
	public class InvoiceLineTax : AxelorModel
	{
		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("reverseCharged")]
		[Field("reverseCharged", false, "False", Int32.MaxValue)]
		public bool? ReverseCharged;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("companyExTaxBase")]
		[Field("companyExTaxBase", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxBase;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("exTaxBase")]
		[Field("exTaxBase", false, "0", Int32.MaxValue)]
		public decimal? ExTaxBase;

		[JsonProperty("companyInTaxTotal")]
		[Field("companyInTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotal;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("companySubTotalOfFixedAssets")]
		[Field("companySubTotalOfFixedAssets", false, "0", Int32.MaxValue)]
		public decimal? CompanySubTotalOfFixedAssets;

		[JsonProperty("companySubTotalExcludingFixedAssets")]
		[Field("companySubTotalExcludingFixedAssets", false, "0", Int32.MaxValue)]
		public decimal? CompanySubTotalExcludingFixedAssets;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("companyTaxTotal")]
		[Field("companyTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyTaxTotal;

		[JsonProperty("subTotalExcludingFixedAssets")]
		[Field("subTotalExcludingFixedAssets", false, "0", Int32.MaxValue)]
		public decimal? SubTotalExcludingFixedAssets;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("subTotalOfFixedAssets")]
		[Field("subTotalOfFixedAssets", false, "0", Int32.MaxValue)]
		public decimal? SubTotalOfFixedAssets;

	}
}
