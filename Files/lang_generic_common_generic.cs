using System;

namespace language.generic.io{
    public class File{

        private String file_name;
        
        public File(String para){
            this.file_name=para;
        }
        public File(File para){
            this.file_name=para.Get();
        }
        public void Set(String para){
            this.file_name=para;
        }
        public void Set(File para){
            this.file_name=para.Get();
        }
        public String Get(){
            return this.file_name;
        }
    }

    public class Directory{
        private String directory_name;
        public Directory(String para){
            this.directory_name=para;
        }
        public Directory(Directory para){
            this.directory_name=para.directory_name;
        }
        public void Set(String para){
            this.directory_name=para;
        }
        public void Set(Directory para){
            this.directory_name=para.Get();
        }
        public String Get(){
            return this.directory_name;
        }
    }

    public class PathSeparatore{
        private String path_separatore;
        public PathSeparatore(String para){
            this.path_separatore=para;
        }
        public PathSeparatore(PathSeparatore para){
            this.path_separatore=para.Get();
        }
        public String Get(){
            return this.path_separatore;
        }
        public void Set(String para){
            this.path_separatore=para;
        }

        public void Set(PathSeparatore para){
            this.path_separatore=para.Get();
        }
    }
}