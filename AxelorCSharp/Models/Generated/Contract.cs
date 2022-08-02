using Axelor.SDK;

namespace Axelor.Apps.Contract.Db
{
	[Model("com.axelor.apps.contract.db.Contract")]
	public class Contract : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("renewalNumber")]
		public int? RenewalNumber;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("currentInvoicePeriod")]
		public Axelor.Apps.Contract.Db.InvoicePeriod? CurrentInvoicePeriod;

		[Field("archived")]
		public bool? Archived;

		[Field("toClosed")]
		public bool? ToClosed;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("targetTypeSelect")]
		public int? TargetTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("isConsumptionManagement")]
		public bool? IsConsumptionManagement;

		[Field("isAdditionaBenefitManagement")]
		public bool? IsAdditionaBenefitManagement;

		[Field("isInvoicingManagement")]
		public bool? IsInvoicingManagement;

		[Field("terminatedByUser")]
		public Axelor.Auth.Db.User? TerminatedByUser;

		[Field("periodNumber")]
		public int? PeriodNumber;

		[Field("terminatedManually")]
		public bool? TerminatedManually;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("versionNumber")]
		public int? VersionNumber;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("contractId")]
		public string? ContractId;

		[Field("name")]
		public string? Name;

	}
}
