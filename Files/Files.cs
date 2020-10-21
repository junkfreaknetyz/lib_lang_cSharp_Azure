//  package for Azure Files

using System;
using Azure.Storage.Files.Shares;
using language.generic.common;
using myAure.files;

namespace myAure
{
    public static class Files
    {
        //  upload file
        public static void Upload(ConnectionString connection_string,ShareName share_name,FilesDirectory files_directory,FilesName files_name,lang.generic.common.Directory directory_from,lang.generic.common.File file_from,lang.generic.common.PathSeparatore path_separatore)
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
        }
    }

}
