using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.InvoicePeriod")]
	public class InvoicePeriod : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("consumptionLineList")]
		[Field("consumptionLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ConsumptionLine>? ConsumptionLineList;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("contract")]
		[Field("contract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.Contract? Contract;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("additionalBenefitList")]
		[Field("additionalBenefitList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ContractLine>? AdditionalBenefitList;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isLastPeriod")]
		[Field("isLastPeriod", false, "False", Int32.MaxValue)]
		public bool? IsLastPeriod;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
