using Axelor.SDK;

namespace Axelor.Apps.Contract.Db
{
	[Model("com.axelor.apps.contract.db.ContractTemplate")]
	public class ContractTemplate : AxelorModel
	{
		[Field("engagementStartFromVersion")]
		public bool? EngagementStartFromVersion;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("invoicingDuration")]
		public Axelor.Apps.Base.Db.Duration? InvoicingDuration;

		[Field("isProratedInvoice")]
		public bool? IsProratedInvoice;

		[Field("isWithPriorNotice")]
		public bool? IsWithPriorNotice;

		[Field("isProratedFirstInvoice")]
		public bool? IsProratedFirstInvoice;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("automaticInvoicing")]
		public bool? AutomaticInvoicing;

		[Field("archived")]
		public bool? Archived;

		[Field("renewalDuration")]
		public Axelor.Apps.Base.Db.Duration? RenewalDuration;

		[Field("invoicingMomentSelect")]
		public int? InvoicingMomentSelect;

		[Field("isWithEngagement")]
		public bool? IsWithEngagement;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("targetTypeSelect")]
		public int? TargetTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("isTacitRenewal")]
		public bool? IsTacitRenewal;

		[Field("isConsumptionBeforeEndDate")]
		public bool? IsConsumptionBeforeEndDate;

		[Field("isConsumptionManagement")]
		public bool? IsConsumptionManagement;

		[Field("isTimeProratedInvoice")]
		public bool? IsTimeProratedInvoice;

		[Field("isAdditionaBenefitManagement")]
		public bool? IsAdditionaBenefitManagement;

		[Field("isInvoicingManagement")]
		public bool? IsInvoicingManagement;

		[Field("priorNoticeDuration")]
		public Axelor.Apps.Base.Db.Duration? PriorNoticeDuration;

		[Field("isVersionProratedInvoice")]
		public bool? IsVersionProratedInvoice;

		[Field("periodNumber")]
		public int? PeriodNumber;

		[Field("isPeriodicInvoicing")]
		public bool? IsPeriodicInvoicing;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("isAutoEnableVersionOnRenew")]
		public bool? IsAutoEnableVersionOnRenew;

		[Field("engagementDuration")]
		public Axelor.Apps.Base.Db.Duration? EngagementDuration;

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

		[Field("name")]
		public string? Name;

		[Field("isProratedLastInvoice")]
		public bool? IsProratedLastInvoice;

	}
}
