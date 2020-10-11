using System;

namespace myAure.files
{
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
    //public class FilesDirectory
    //{

    //}
    
}