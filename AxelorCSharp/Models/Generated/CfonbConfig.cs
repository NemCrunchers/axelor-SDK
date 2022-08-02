using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.CfonbConfig")]
	public class CfonbConfig : AxelorModel
	{
		[Field("transferOperationCodeExportCFONB")]
		public string? TransferOperationCodeExportCFONB;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("directDebitOperationCodeExportCFONB")]
		public string? DirectDebitOperationCodeExportCFONB;

		[Field("senderNumExportCFONB")]
		public string? SenderNumExportCFONB;

		[Field("directDebitOperationCodeImportCFONB")]
		public string? DirectDebitOperationCodeImportCFONB;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("senderRecordCodeExportCFONB")]
		public string? SenderRecordCodeExportCFONB;

		[Field("totalRecordCodeExportCFONB")]
		public string? TotalRecordCodeExportCFONB;

		[Field("endingRecordCodeImportCFONB")]
		public string? EndingRecordCodeImportCFONB;

		[Field("detailRecordCodeImportCFONB")]
		public string? DetailRecordCodeImportCFONB;

		[Field("id")]
		public long? Id;

		[Field("transferOperationCodeImportCFONB")]
		public string? TransferOperationCodeImportCFONB;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("headerRecordCodeImportCFONB")]
		public string? HeaderRecordCodeImportCFONB;

		[Field("name")]
		public string? Name;

		[Field("recipientRecordCodeExportCFONB")]
		public string? RecipientRecordCodeExportCFONB;

		[Field("senderNameCodeExportCFONB")]
		public string? SenderNameCodeExportCFONB;

	}
}
