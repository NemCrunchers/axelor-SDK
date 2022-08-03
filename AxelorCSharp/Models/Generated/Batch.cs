using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Batch")]
	public class Batch : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("anomaly")]
		[Field("anomaly", false, "0", Int32.MaxValue)]
		public int? Anomaly;

		[JsonProperty("supplychainBatch")]
		[Field("supplychainBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Supplychain.Db.SupplychainBatch? SupplychainBatch;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("alarmEngineBatch")]
		[Field("alarmEngineBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.AlarmEngineBatch? AlarmEngineBatch;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public long? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("crmBatch")]
		[Field("crmBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.CrmBatch? CrmBatch;

		[JsonProperty("productionBatch")]
		[Field("productionBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProductionBatch? ProductionBatch;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("contractBatch")]
		[Field("contractBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractBatch? ContractBatch;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("bankOrder")]
		[Field("bankOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[JsonProperty("bankPaymentBatch")]
		[Field("bankPaymentBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankPaymentBatch? BankPaymentBatch;

		[JsonProperty("accountingBatch")]
		[Field("accountingBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountingBatch? AccountingBatch;

		[JsonProperty("saleBatch")]
		[Field("saleBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleBatch? SaleBatch;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("done")]
		[Field("done", false, "0", Int32.MaxValue)]
		public int? Done;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("hrBatch")]
		[Field("hrBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Hr.Db.HrBatch? HrBatch;

		[JsonProperty("baseBatch")]
		[Field("baseBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BaseBatch? BaseBatch;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("invoiceBatch")]
		[Field("invoiceBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoiceBatch? InvoiceBatch;

		[JsonProperty("mailBatch")]
		[Field("mailBatch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.MailBatch? MailBatch;

		[JsonProperty("metaFile")]
		[Field("metaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? MetaFile;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

	}
}
