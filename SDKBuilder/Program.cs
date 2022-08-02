using Axelor.SDK;
using AxelorCSharp.Models;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;

const string generatedFilesPath = "..\\..\\..\\..\\AxelorCSharp\\Models\\Generated";

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
    sb.Append($"using Axelor.SDK;\n\nnamespace {String.Join(".", nameSpace.SkipLast(1))}\n{{\n\t[Model(\"{model.Data.Model}\")]\n\tpublic class {className} : AxelorModel\n\t{{\n");
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
                AddField(ref sb, FieldName, field.Name, "string");
                break;
            case "DATETIME":
                AddField(ref sb, FieldName, field.Name, "DateTime");
                break;
            case "INTEGER":
                AddField(ref sb, FieldName, field.Name, "int");
                break;
            case "LONG":
                AddField(ref sb, FieldName, field.Name, "long");
                break;
            case "BOOLEAN":
                AddField(ref sb, FieldName, field.Name, "bool");
                break;
            case "MANY_TO_ONE":
                AddField(ref sb, FieldName, field.Name, $"{String.Join(".", ToNameSpace(field.Target))}");
                break;
            case "MANY_TO_MANY":
                AddField(ref sb, FieldName, field.Name, $"IEnumerable<{String.Join(".", ToNameSpace(field.Target))}>");
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


void AddField(ref StringBuilder sb, string attributeName, string fieldName, string type)
{
    sb.AppendLine($"\t\t[Field(\"{fieldName}\")]\n\t\tpublic {type}? {attributeName};\n");
    return;
}