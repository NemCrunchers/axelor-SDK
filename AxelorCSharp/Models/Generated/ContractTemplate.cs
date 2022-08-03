using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.ContractTemplate")]
	public class ContractTemplate : AxelorModel
	{
		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("engagementStartFromVersion")]
		[Field("engagementStartFromVersion", false, "False", Int32.MaxValue)]
		public bool? EngagementStartFromVersion;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("invoicingDuration")]
		[Field("invoicingDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? InvoicingDuration;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("isProratedInvoice")]
		[Field("isProratedInvoice", false, "False", Int32.MaxValue)]
		public bool? IsProratedInvoice;

		[JsonProperty("isWithPriorNotice")]
		[Field("isWithPriorNotice", false, "False", Int32.MaxValue)]
		public bool? IsWithPriorNotice;

		[JsonProperty("isProratedFirstInvoice")]
		[Field("isProratedFirstInvoice", false, "False", Int32.MaxValue)]
		public bool? IsProratedFirstInvoice;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("firstPeriodEndDate")]
		[Field("firstPeriodEndDate", false, null, Int32.MaxValue)]
		public DateTime? FirstPeriodEndDate;

		[JsonProperty("automaticInvoicing")]
		[Field("automaticInvoicing", false, "False", Int32.MaxValue)]
		public bool? AutomaticInvoicing;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("renewalDuration")]
		[Field("renewalDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? RenewalDuration;

		[JsonProperty("invoicingMomentSelect")]
		[Field("invoicingMomentSelect", false, "1", Int32.MaxValue)]
		public int? InvoicingMomentSelect;

		[JsonProperty("isWithEngagement")]
		[Field("isWithEngagement", false, "False", Int32.MaxValue)]
		public bool? IsWithEngagement;

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

		[JsonProperty("isTacitRenewal")]
		[Field("isTacitRenewal", false, "False", Int32.MaxValue)]
		public bool? IsTacitRenewal;

		[JsonProperty("isConsumptionBeforeEndDate")]
		[Field("isConsumptionBeforeEndDate", false, "False", Int32.MaxValue)]
		public bool? IsConsumptionBeforeEndDate;

		[JsonProperty("isConsumptionManagement")]
		[Field("isConsumptionManagement", false, "False", Int32.MaxValue)]
		public bool? IsConsumptionManagement;

		[JsonProperty("isTimeProratedInvoice")]
		[Field("isTimeProratedInvoice", false, "False", Int32.MaxValue)]
		public bool? IsTimeProratedInvoice;

		[JsonProperty("isAdditionaBenefitManagement")]
		[Field("isAdditionaBenefitManagement", false, "False", Int32.MaxValue)]
		public bool? IsAdditionaBenefitManagement;

		[JsonProperty("isInvoicingManagement")]
		[Field("isInvoicingManagement", false, "False", Int32.MaxValue)]
		public bool? IsInvoicingManagement;

		[JsonProperty("priorNoticeDuration")]
		[Field("priorNoticeDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? PriorNoticeDuration;

		[JsonProperty("isVersionProratedInvoice")]
		[Field("isVersionProratedInvoice", false, "False", Int32.MaxValue)]
		public bool? IsVersionProratedInvoice;

		[JsonProperty("periodNumber")]
		[Field("periodNumber", false, "0", Int32.MaxValue)]
		public int? PeriodNumber;

		[JsonProperty("isPeriodicInvoicing")]
		[Field("isPeriodicInvoicing", false, "False", Int32.MaxValue)]
		public bool? IsPeriodicInvoicing;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentCondition")]
		[Field("paymentCondition", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("isAutoEnableVersionOnRenew")]
		[Field("isAutoEnableVersionOnRenew", false, "False", Int32.MaxValue)]
		public bool? IsAutoEnableVersionOnRenew;

		[JsonProperty("engagementDuration")]
		[Field("engagementDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? EngagementDuration;

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

		[JsonProperty("contractLineList")]
		[Field("contractLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ContractLine>? ContractLineList;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("isProratedLastInvoice")]
		[Field("isProratedLastInvoice", false, "False", Int32.MaxValue)]
		public bool? IsProratedLastInvoice;

	}
}
