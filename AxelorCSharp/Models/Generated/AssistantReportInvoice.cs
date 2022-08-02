using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AssistantReportInvoice")]
	public class AssistantReportInvoice : AxelorModel
	{
		[Field("formatSelect")]
		public string? FormatSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("turnoverTypeSelect")]
		public int? TurnoverTypeSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("graphTypeSelect")]
		public int? GraphTypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("type")]
		public int? Type;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("productSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Product>? ProductSet;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("productCategorySet")]
		public IEnumerable<Axelor.Apps.Base.Db.ProductCategory>? ProductCategorySet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("publicationDateTime")]
		public DateTime? PublicationDateTime;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

	}
}
