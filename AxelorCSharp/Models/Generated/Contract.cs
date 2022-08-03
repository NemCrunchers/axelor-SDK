using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.Contract")]
	public class Contract : AxelorModel
	{
		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("currentContractVersion")]
		[Field("currentContractVersion", true, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractVersion? CurrentContractVersion;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("invoicePeriodStartDate")]
		[Field("invoicePeriodStartDate", false, null, Int32.MaxValue)]
		public DateTime? InvoicePeriodStartDate;

		[JsonProperty("consumptionLineList")]
		[Field("consumptionLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ConsumptionLine>? ConsumptionLineList;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("engagementStartDate")]
		[Field("engagementStartDate", false, null, Int32.MaxValue)]
		public DateTime? EngagementStartDate;

		[JsonProperty("invoicePeriodEndDate")]
		[Field("invoicePeriodEndDate", false, null, Int32.MaxValue)]
		public DateTime? InvoicePeriodEndDate;

		[JsonProperty("renewalNumber")]
		[Field("renewalNumber", false, "0", Int32.MaxValue)]
		public int? RenewalNumber;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("currentInvoicePeriod")]
		[Field("currentInvoicePeriod", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.InvoicePeriod? CurrentInvoicePeriod;

		[JsonProperty("firstPeriodEndDate")]
		[Field("firstPeriodEndDate", false, null, Int32.MaxValue)]
		public DateTime? FirstPeriodEndDate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("toClosed")]
		[Field("toClosed", false, "False", Int32.MaxValue)]
		public bool? ToClosed;

		[JsonProperty("invoicingDate")]
		[Field("invoicingDate", false, null, Int32.MaxValue)]
		public DateTime? InvoicingDate;

		[JsonProperty("versionHistory")]
		[Field("versionHistory", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ContractVersion>? VersionHistory;

		[JsonProperty("additionalBenefitContractLineList")]
		[Field("additionalBenefitContractLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ContractLine>? AdditionalBenefitContractLineList;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("targetTypeSelect")]
		[Field("targetTypeSelect", true, "1", Int32.MaxValue)]
		public int? TargetTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("lastRenewalDate")]
		[Field("lastRenewalDate", false, null, Int32.MaxValue)]
		public DateTime? LastRenewalDate;

		[JsonProperty("isConsumptionManagement")]
		[Field("isConsumptionManagement", false, "False", Int32.MaxValue)]
		public bool? IsConsumptionManagement;

		[JsonProperty("isAdditionaBenefitManagement")]
		[Field("isAdditionaBenefitManagement", false, "False", Int32.MaxValue)]
		public bool? IsAdditionaBenefitManagement;

		[JsonProperty("isInvoicingManagement")]
		[Field("isInvoicingManagement", false, "False", Int32.MaxValue)]
		public bool? IsInvoicingManagement;

		[JsonProperty("terminatedByUser")]
		[Field("terminatedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? TerminatedByUser;

		[JsonProperty("periodNumber")]
		[Field("periodNumber", false, "0", Int32.MaxValue)]
		public int? PeriodNumber;

		[JsonProperty("terminatedDate")]
		[Field("terminatedDate", false, null, Int32.MaxValue)]
		public DateTime? TerminatedDate;

		[JsonProperty("terminatedManually")]
		[Field("terminatedManually", false, "False", Int32.MaxValue)]
		public bool? TerminatedManually;

		[JsonProperty("terminationDemandDate")]
		[Field("terminationDemandDate", false, null, Int32.MaxValue)]
		public DateTime? TerminationDemandDate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("nextVersion")]
		[Field("nextVersion", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractVersion? NextVersion;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("versionNumber")]
		[Field("versionNumber", false, "-1", Int32.MaxValue)]
		public int? VersionNumber;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("historyInvoicePeriodList")]
		[Field("historyInvoicePeriodList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.InvoicePeriod>? HistoryInvoicePeriodList;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", true, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("contractId")]
		[Field("contractId", false, null, Int32.MaxValue)]
		public string? ContractId;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
