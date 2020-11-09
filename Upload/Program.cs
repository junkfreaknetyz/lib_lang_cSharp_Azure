using System;
using language.azure.files;
using language.generic.common;

namespace Upload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            String strCnnctnToAzure="DefaultEndpointsProtocol=https;AccountName=yzloglarge;AccountKey=bvfsXft7QcGaD19DiZrbIMBO/NFMk5egZrvtNlQOC1cnyP/f9Y0tLStGq6AhKGPxoVCxFkQqSVxEHyt77FOHNw==;EndpointSuffix=core.windows.net";
            String strShareNameToAzure="shrstrgyzlogistics";
            String strFilesDirectory=".";
            String strFileName="dbo_TBL_OUTFILE.txt";
            String strDirectoryFrom=".";
            String strFileNameFrom="dbo_TBL_OUTFILE.txt";

            Func.Upload(new ConnectionString(strCnnctnToAzure),new ShareName(strShareNameToAzure),new FilesDirectory(strFilesDirectory),new FilesName(strFileName),new language.generic.common.io.Directory(strDirectoryFrom),new language.generic.common.io.File(strFileNameFrom),new language.generic.common.io.PathSeparatore("/"));
        }
    }
}
