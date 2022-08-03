using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.CfonbConfig")]
	public class CfonbConfig : AxelorModel
	{
		[JsonProperty("transferOperationCodeExportCFONB")]
		[Field("transferOperationCodeExportCFONB", false, "02", Int32.MaxValue)]
		public string? TransferOperationCodeExportCFONB;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("directDebitOperationCodeExportCFONB")]
		[Field("directDebitOperationCodeExportCFONB", false, "08", Int32.MaxValue)]
		public string? DirectDebitOperationCodeExportCFONB;

		[JsonProperty("senderNumExportCFONB")]
		[Field("senderNumExportCFONB", false, null, Int32.MaxValue)]
		public string? SenderNumExportCFONB;

		[JsonProperty("directDebitOperationCodeImportCFONB")]
		[Field("directDebitOperationCodeImportCFONB", false, "81", Int32.MaxValue)]
		public string? DirectDebitOperationCodeImportCFONB;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("senderRecordCodeExportCFONB")]
		[Field("senderRecordCodeExportCFONB", false, "03", Int32.MaxValue)]
		public string? SenderRecordCodeExportCFONB;

		[JsonProperty("totalRecordCodeExportCFONB")]
		[Field("totalRecordCodeExportCFONB", false, "08", Int32.MaxValue)]
		public string? TotalRecordCodeExportCFONB;

		[JsonProperty("endingRecordCodeImportCFONB")]
		[Field("endingRecordCodeImportCFONB", false, "39", Int32.MaxValue)]
		public string? EndingRecordCodeImportCFONB;

		[JsonProperty("detailRecordCodeImportCFONB")]
		[Field("detailRecordCodeImportCFONB", false, "34", Int32.MaxValue)]
		public string? DetailRecordCodeImportCFONB;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("transferOperationCodeImportCFONB")]
		[Field("transferOperationCodeImportCFONB", false, "21", Int32.MaxValue)]
		public string? TransferOperationCodeImportCFONB;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[JsonProperty("headerRecordCodeImportCFONB")]
		[Field("headerRecordCodeImportCFONB", false, "31", Int32.MaxValue)]
		public string? HeaderRecordCodeImportCFONB;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("recipientRecordCodeExportCFONB")]
		[Field("recipientRecordCodeExportCFONB", false, "06", Int32.MaxValue)]
		public string? RecipientRecordCodeExportCFONB;

		[JsonProperty("senderNameCodeExportCFONB")]
		[Field("senderNameCodeExportCFONB", false, null, Int32.MaxValue)]
		public string? SenderNameCodeExportCFONB;

	}
}
