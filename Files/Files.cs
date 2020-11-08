﻿//  package for Azure Files

using System;
using System.IO;
using Azure.Storage.Files.Shares;
using language.generic.common;
//using language.azure.files;

namespace language.azure.files
{
    public static class Func
    {
        //  upload file
        public static void Upload(ConnectionString connection_string,ShareName share_name,FilesDirectory files_directory,FilesName files_name,language.generic.common.io.Directory directory_from,language.generic.common.io.File file_from,language.generic.common.io.PathSeparatore path_separatore)
        {
            //
            //  upload file using ShareFileClient.UploadAsync
            //  arguments
            //  for azure are
            //  ***************
            //  connection string,sharing name,folder name,file name
            //  for local are
            //  ***************
            //  path to source file
            //
            ShareClient share_client=new ShareClient(connection_string.Get(),share_name.Get());
            ShareDirectoryClient share_directory_client=share_client.GetDirectoryClient(files_directory.Get());
            ShareFileClient share_file_client=share_directory_client.GetFileClient(files_name.Get());
            String local_file_path="@" + files_name.Get();
            using(FileStream file_stream=File.OpenRead(local_file_path)){

                share_file_client.Create(file_stream.Length);
                share_file_client.UploadRange(new Azure.HttpRange(constants.CS_ZERO_AS_INT,file_stream.Length),file_stream);
            }
        }
    }

    //
    //
    //
    class test{
        static void Main(String[] args){

            String strCnnctnToAzure="DefaultEndpointsProtocol=https;AccountName=yzloglarge;AccountKey=bvfsXft7QcGaD19DiZrbIMBO/NFMk5egZrvtNlQOC1cnyP/f9Y0tLStGq6AhKGPxoVCxFkQqSVxEHyt77FOHNw==;EndpointSuffix=core.windows.net";
            String strShareNameToAzure="shrstrgyzlogistics";
            String strFilesDirectory=".";
            String strFileName="dbo_TBL_OUTFILE.txt";
            String strDirectoryFrom=".";
            String strFileNameFrom="dbo_TBL_OUTFILE.txt";

            Func.Upload(new ConnectionString(strCnnctnToAzure),new ShareName(strShareNameToAzure),new FilesDirectory(strFilesDirectory),new FilesName(strFileName),new generic.common.io.Directory(strDirectoryFrom),new generic.common.io.File(strFileNameFrom),new generic.common.io.PathSeparatore("/"));
        }
    }

}
