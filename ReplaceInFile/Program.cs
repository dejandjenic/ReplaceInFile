using System.Xml;

try
{
	if(!args.Any())
	{
		Console.WriteLine("No file specified");
		return;
	}

	var fileContent = File.ReadAllText(args.FirstOrDefault());
	fileContent = fileContent.Replace(args.Skip(1).FirstOrDefault(), args.Skip(2).FirstOrDefault());
	File.WriteAllText(args.FirstOrDefault(), fileContent);
}
catch(Exception ex)
{
	Console.WriteLine($"An error occured {ex.Message}");
}
