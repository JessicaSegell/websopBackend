using System.IO;
using System.IO.Pipelines; 
using System.Data; 
using System.Data.SqlClient; 
using System.Media; 




public class HatImage {
    public byte hatImg { get; set; }
     

/*     public string ConvertToString (HatImage img){
        byte [] byteArray = new byte[0];
        using(MemoryStream stream = new MemoryStream()){
            img.Save(stream, System.Drawing.ImageFormatConverter.ReferenceEquals(hatImg, img));
            stream.Close(); 

            byteArray = stream.ToArray();  
        } 
        string base64string = Convert.ToBase64string(byteArray); 
        return base64string; 
    } */
}