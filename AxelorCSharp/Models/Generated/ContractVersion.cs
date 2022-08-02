using Axelor.SDK;

namespace Axelor.Apps.Contract.Db
{
	[Model("com.axelor.apps.contract.db.ContractVersion")]
	public class ContractVersion : AxelorModel
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

		[Field("contractHistory")]
		public Axelor.Apps.Contract.Db.Contract? ContractHistory;

		[Field("doNotRenew")]
		public bool? DoNotRenew;

		[Field("renewalDuration")]
		public Axelor.Apps.Base.Db.Duration? RenewalDuration;

		[Field("invoicingMomentSelect")]
		public int? InvoicingMomentSelect;

		[Field("isWithEngagement")]
		public bool? IsWithEngagement;

		[Field("id")]
		public long? Id;

		[Field("isTacitRenewal")]
		public bool? IsTacitRenewal;

		[Field("isConsumptionBeforeEndDate")]
		public bool? IsConsumptionBeforeEndDate;

		[Field("isTimeProratedInvoice")]
		public bool? IsTimeProratedInvoice;

		[Field("priorNoticeDuration")]
		public Axelor.Apps.Base.Db.Duration? PriorNoticeDuration;

		[Field("isVersionProratedInvoice")]
		public bool? IsVersionProratedInvoice;

		[Field("isPeriodicInvoicing")]
		public bool? IsPeriodicInvoicing;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("paymentCondition")]
		public Axelor.Apps.Account.Db.PaymentCondition? PaymentCondition;

		[Field("paymentMode")]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[Field("activatedByUser")]
		public Axelor.Auth.Db.User? ActivatedByUser;

		[Field("isAutoEnableVersionOnRenew")]
		public bool? IsAutoEnableVersionOnRenew;

		[Field("engagementDuration")]
		public Axelor.Apps.Base.Db.Duration? EngagementDuration;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isProratedLastInvoice")]
		public bool? IsProratedLastInvoice;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
