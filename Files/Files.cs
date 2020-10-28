//  package for Azure Files

using System;
using System.IO;
using Azure.Storage.Files.Shares;
using language.generic.common;
//using language.azure.files;

namespace language.azure.files
{
    public static class Files
    {
        //  upload file
        public static void Upload(ConnectionString connection_string,ShareName share_name,FilesDirectory files_directory,FilesName files_name,language.generic.common.Directory directory_from,language.generic.common.File file_from,language.generic.common.PathSeparatore path_separatore)
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

}
