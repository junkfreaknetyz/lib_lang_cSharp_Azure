//  package for Azure Files

using System;
using Azure.Storage.Files.Shares;
using language.generic.common;
namespace myAzure.Files
{
    public class Files
    {
        //  upload file
        public static void Upload(ConnectionString cnnctnstrng)
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
        
        }
    }

    //
    public class ConnectionString
    {
        private String connection_String;
        public ConnectionString(String para)
        {
            this.connection_String = para;
        }
        public String Get(){
            return this.connection_String;
        }
        public void Set(String para)
        {
            this.connection_String=para;
        }
    }
    public class ShareName
    {
        private String share_Name;
        public ShareName(String para)
        {
            this.share_Name=para;
        }
        public String Get()
        {
            return this.share_Name;
        }
        public void Set(String para)
        {
            this.share_Name=para;
        }        
    }
    public class FilesDirectory
    {

    }
}
