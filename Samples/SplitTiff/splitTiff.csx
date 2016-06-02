using System.Linq;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec.Tiff;

if (Env.ScriptArgs.Count < 2)
    throw new ArgumentException("Usage: scriptcs split.csx <file to split> <output folder>");

// Env class allow to get access to script arguments
var fileNameToSplit = Env.ScriptArgs[0];
var outputFolder = Env.ScriptArgs[1];

Console.WriteLine("Splitting {0} file into {1}", fileNameToSplit, outputFolder);

using (var file = File.OpenRead(fileNameToSplit))
{
    // open TIFF file
    var multipageTiff = new TiffDocument(file);
    var pageCount = multipageTiff.Pages.Count;
    Console.WriteLine("File contains {0} pages", pageCount);

    // iterate over pages...
    for (var i = 0; i < pageCount; ++i)
    {
        var tiff = new TiffDocument() { Pages = { multipageTiff.Pages[i] } };
        var fileName = Path.Combine(outputFolder, string.Format("{0}.tif", i));
        tiff.Save(fileName);

        Console.WriteLine("\tPage {0} saved into {1}", i, fileName);
    }
}