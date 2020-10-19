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
        public static void Upload(ConnectionString cnnctnstrng,ShareName sharename,FilesDirectory filesdirectory,FilesName filesname)
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
            ShareClient share_client=new ShareClient(cnnctnstrng.Get(),sharename.Get());
        }
    }

}
