using Axelor.SDK;
using Axelor.SDK.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;

const string generatedFilesPath = "..\\..\\..\\..\\AxelorCSharp\\Models\\Generated";
const string generatedTestPath = "..\\..\\..\\..\\Axelor.SDK.Test\\Generated";

List<string> ignoredTests = new List<string>()
{
    "AccountingReportTest",
    "DebtRecoveryLevelTest",
    "DepositSlipTest",
    "InvoicePaymentTest",
    "PaymentVoucherTest",
    "ReconcileGroupTest",
    "BankOrderTest",
    "BankAddressTest",
    "DebtRecoveryLevelTest",
    "SequenceTest",
    "ContractTest",
    "LunchVoucherAdvanceTest",
    "TimesheetLineTest",
    "PartnerTest",
    "ManufOrderTest",
    "RawMaterialRequirementTest",
    "WorkshopSequenceConfigLineTest",
    "AdvancePaymentTest",
    "CustomsCodeNomenclatureTest",
    "LogisticalFormTest",
    "TrainingRegisterTest",
    "TrainingSessionTest",
    "DMSPermissionTest",
    "MailFlagsTest",
    "ChartBuilderTest",
    "TeamTaskTest",
    "MoveLineTest"
};


HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://7ebb376912.axelor.nemcrunchers.dev");
AxelorClient axelorClient = new AxelorClient(httpClient);
await axelorClient.AuthorizeUser( "admin", "admin");
ServiceMetadata serviceMetadata = await axelorClient.GetServiceMetadataAsync();
foreach(string modelName in serviceMetadata.data)
{
    ModelMetadata model = await axelorClient.GetModelMetadataAsync(modelName);
    IEnumerable<String> nameSpace = ToNameSpace(model.Data.Model);
    string className = nameSpace.LastOrDefault();
    var sb = new StringBuilder();
    sb.Append($"using Axelor.SDK;\nusing Newtonsoft.Json;\n\nnamespace {String.Join(".", nameSpace.SkipLast(1))}\n{{\n\t[Serializable]\n\t[Model(\"{model.Data.Model}\")]\n\tpublic class {className} : AxelorModel\n\t{{\n");
    Console.WriteLine(model.Data.Model);
    foreach(Field field in model.Data.Fields)
    {
        string FieldName = ToPascalCase(field.Name);
        if (FieldName == className)
        {
            FieldName = FieldName + "Field";
        }
        switch (field.Type)
        {
            case "STRING":
                AddField(ref sb, FieldName, field, "string");
                break;
            case "TEXT":
                AddField(ref sb, FieldName, field, "string");
                break;
            case "DATETIME":
                AddField(ref sb, FieldName, field, "DateTime");
                break;
            case "DATE":
                AddField(ref sb, FieldName, field, "DateTime");
                break;
            case "INTEGER":
                AddField(ref sb, FieldName, field, "int");
                break;
            case "DECIMAL":
                AddField(ref sb, FieldName, field, "decimal");
                break;
            case "LONG":
                AddField(ref sb, FieldName, field, "long");
                break;
            case "BOOLEAN":
                AddField(ref sb, FieldName, field, "bool");
                break;
            case "MANY_TO_ONE":
                AddField(ref sb, FieldName, field, $"{String.Join(".", ToNameSpace(field.Target))}");
                break;
            case "ONE_TO_ONE":
                AddField(ref sb, FieldName, field, $"{String.Join(".", ToNameSpace(field.Target))}");
                break;
            case "MANY_TO_MANY":
                AddField(ref sb, FieldName, field, $"IEnumerable<{String.Join(".", ToNameSpace(field.Target))}>");
                break;
            case "ONE_TO_MANY":
                AddField(ref sb, FieldName, field, $"IEnumerable<{String.Join(".", ToNameSpace(field.Target))}>");
                break;
            //    break;
            default:
                break;
        }
    }
    sb.Append("\t}\n}");
    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@$"{generatedFilesPath}\{className}.cs"))
    {
        file.WriteLine(sb.ToString());
    }
    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@$"{generatedTestPath}\{className}Test.cs"))
    {
        string ignoreAttr = "";
        if (ignoredTests.Contains($"{className}Test"))
        {
            ignoreAttr = "\n    [Ignore]"; 
        }
        List<string> testNamespace = nameSpace.SkipLast(1).Skip(1).ToList();
            file.WriteLine($"using Axelor.SDK.Test;\n\nnamespace Axelor.SDK.Test.{String.Join(".", testNamespace)}\n{{{ignoreAttr}\n    [TestClass]\n    public class {className}Test: TestModel\n    {{\n        public {className}Test(): base(typeof({String.Join(".", nameSpace)})){{}}\n    }}\n}}");
        }
}

string UpperCaseFirstChar(string text)
{
    return Regex.Replace(text, "^[a-z]", m => m.Value.ToUpper());
}
string ToPascalCase(string? label)
{
    if (label == null)
    {
        return "";
    }
    return String.Join("",
            label.Split(" ") // Split words so we can join them together again excluding special chars
            .Where(word => Regex.IsMatch(word, @"^\w+$", RegexOptions.IgnoreCase)) // Check that word contains only valid characters, if not we will exclude it
            .Select(UpperCaseFirstChar) // Map to PascalCase of word
            .ToArray());
}
IEnumerable<string> ToNameSpace(string model)
{
    IEnumerable<string> namespaceSplit = model.Split(".").Select(t => ToPascalCase(t));

    if (namespaceSplit.First() == "Com")
    {
        namespaceSplit = namespaceSplit.Skip(1);
    }
    return namespaceSplit;
}


void AddField(ref StringBuilder sb, string attributeName, Field field, string type)
{
    string maxSize = "Int32.MaxValue";
    if (field.MaxSize != Int32.MaxValue)
    {
        maxSize = $"{field.MaxSize}";
    }
    if (field.DefaultValue != null)
    {
        field.DefaultValue = $"\"{field.DefaultValue}\"";
    }
    else if(field.DefaultValue == null)
    {
        field.DefaultValue = "null";
    }
    sb.AppendLine($"\t\t[JsonProperty(\"{field.Name}\")]\n\t\t[Field(\"{field.Name}\", {field.Required.ToString().ToLower()}, {field.DefaultValue}, {maxSize})]\n\t\tpublic {type}? {attributeName};\n");
    return;
}