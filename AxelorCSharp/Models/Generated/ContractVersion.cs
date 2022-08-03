using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Contract.Db
{
	[Serializable]
	[Model("com.axelor.apps.contract.db.ContractVersion")]
	public class ContractVersion : AxelorModel
	{
		[JsonProperty("engagementStartFromVersion")]
		[Field("engagementStartFromVersion", false, "False", Int32.MaxValue)]
		public bool? EngagementStartFromVersion;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("invoicingDuration")]
		[Field("invoicingDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? InvoicingDuration;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

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

		[JsonProperty("automaticInvoicing")]
		[Field("automaticInvoicing", false, "False", Int32.MaxValue)]
		public bool? AutomaticInvoicing;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("contractHistory")]
		[Field("contractHistory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.Contract? ContractHistory;

		[JsonProperty("doNotRenew")]
		[Field("doNotRenew", false, "False", Int32.MaxValue)]
		public bool? DoNotRenew;

		[JsonProperty("renewalDuration")]
		[Field("renewalDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? RenewalDuration;

		[JsonProperty("invoicingMomentSelect")]
		[Field("invoicingMomentSelect", false, "1", Int32.MaxValue)]
		public int? InvoicingMomentSelect;

		[JsonProperty("isWithEngagement")]
		[Field("isWithEngagement", false, "False", Int32.MaxValue)]
		public bool? IsWithEngagement;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isTacitRenewal")]
		[Field("isTacitRenewal", false, "False", Int32.MaxValue)]
		public bool? IsTacitRenewal;

		[JsonProperty("isConsumptionBeforeEndDate")]
		[Field("isConsumptionBeforeEndDate", false, "False", Int32.MaxValue)]
		public bool? IsConsumptionBeforeEndDate;

		[JsonProperty("isTimeProratedInvoice")]
		[Field("isTimeProratedInvoice", false, "False", Int32.MaxValue)]
		public bool? IsTimeProratedInvoice;

		[JsonProperty("priorNoticeDuration")]
		[Field("priorNoticeDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? PriorNoticeDuration;

		[JsonProperty("isVersionProratedInvoice")]
		[Field("isVersionProratedInvoice", false, "False", Int32.MaxValue)]
		public bool? IsVersionProratedInvoice;

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

		[JsonProperty("contract")]
		[Field("contract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.Contract? Contract;

		[JsonProperty("activatedByUser")]
		[Field("activatedByUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ActivatedByUser;

		[JsonProperty("isAutoEnableVersionOnRenew")]
		[Field("isAutoEnableVersionOnRenew", false, "False", Int32.MaxValue)]
		public bool? IsAutoEnableVersionOnRenew;

		[JsonProperty("engagementDuration")]
		[Field("engagementDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? EngagementDuration;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("nextContract")]
		[Field("nextContract", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.Contract? NextContract;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("supposedActivationDate")]
		[Field("supposedActivationDate", false, null, Int32.MaxValue)]
		public DateTime? SupposedActivationDate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", true, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("contractLineList")]
		[Field("contractLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Contract.Db.ContractLine>? ContractLineList;

		[JsonProperty("activationDate")]
		[Field("activationDate", false, null, Int32.MaxValue)]
		public DateTime? ActivationDate;

		[JsonProperty("isProratedLastInvoice")]
		[Field("isProratedLastInvoice", false, "False", Int32.MaxValue)]
		public bool? IsProratedLastInvoice;

		[JsonProperty("metaFile")]
		[Field("metaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? MetaFile;

		[JsonProperty("supposedEndDate")]
		[Field("supposedEndDate", false, null, Int32.MaxValue)]
		public DateTime? SupposedEndDate;

	}
}
