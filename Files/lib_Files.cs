using System;

namespace myAure.files
{
    //
    //connection string class
    //for connecting to azure storage
    //
    public class ConnectionString
    {
        private String connection_String;
        public ConnectionString(String para)
        {
            this.connection_String = para;
        }
        public ConnectionString(ConnectionString para)
        {
            this.connection_String=para.Get();
        }
        public String Get(){
            return this.connection_String;
        }
        public void Set(String para)
        {
            this.connection_String=para;
        }
        public void Set(ConnectionString para)
        {
            this.connection_String=para.Get();
        }
    }
    //share name class
    public class ShareName
    {
        private String share_Name;
        public ShareName(String para)
        {
            this.share_Name=para;
        }
        public ShareName(ShareName para)
        {
            this.share_Name=para.Get();
        }
        public String Get()
        {
            return this.share_Name;
        }
        public void Set(String para)
        {
            this.share_Name=para;
        }
        public void Set(ShareName para)
        {
            this.share_Name=para.Get();
        }
    }
    public class FilesDirectory
    {

        private String files_directory;
        public FilesDirectory(FilesDirectory para)
        {
            this.files_directory=para.Get();
        }
        public FilesDirectory(String para)
        {
            this.files_directory=para;
        }
        public void Set(String para)
        {
            this.files_directory=para;
        }
        public String Get()
        {
            return this.files_directory;
        }
    }
    
}