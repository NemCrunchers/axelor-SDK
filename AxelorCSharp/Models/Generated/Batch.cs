using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Batch")]
	public class Batch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("anomaly")]
		public int? Anomaly;

		[Field("supplychainBatch")]
		public Axelor.Apps.Supplychain.Db.SupplychainBatch? SupplychainBatch;

		[Field("endDate")]
		public DateTime? EndDate;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("alarmEngineBatch")]
		public Axelor.Apps.Base.Db.AlarmEngineBatch? AlarmEngineBatch;

		[Field("duration")]
		public long? Duration;

		[Field("archived")]
		public bool? Archived;

		[Field("crmBatch")]
		public Axelor.Apps.Crm.Db.CrmBatch? CrmBatch;

		[Field("productionBatch")]
		public Axelor.Apps.Production.Db.ProductionBatch? ProductionBatch;

		[Field("id")]
		public long? Id;

		[Field("contractBatch")]
		public Axelor.Apps.Contract.Db.ContractBatch? ContractBatch;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("bankOrder")]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[Field("bankPaymentBatch")]
		public Axelor.Apps.Bankpayment.Db.BankPaymentBatch? BankPaymentBatch;

		[Field("accountingBatch")]
		public Axelor.Apps.Account.Db.AccountingBatch? AccountingBatch;

		[Field("saleBatch")]
		public Axelor.Apps.Sale.Db.SaleBatch? SaleBatch;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("done")]
		public int? Done;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("hrBatch")]
		public Axelor.Apps.Hr.Db.HrBatch? HrBatch;

		[Field("baseBatch")]
		public Axelor.Apps.Base.Db.BaseBatch? BaseBatch;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("invoiceBatch")]
		public Axelor.Apps.Account.Db.InvoiceBatch? InvoiceBatch;

		[Field("mailBatch")]
		public Axelor.Apps.Base.Db.MailBatch? MailBatch;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

		[Field("startDate")]
		public DateTime? StartDate;

	}
}
