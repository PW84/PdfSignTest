using org.apache.pdfbox.cos;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.pdmodel.interactive.digitalsignature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfSignDotNetFr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            
            string filePath = @"C:\tmp\Test_signed.pdf";
            var document = PDDocument.load(filePath);
            
            var signatureDictionaries = document.getSignatureDictionaries();
            var i2 = signatureDictionaries.get(0);
            var signature = (PDSignature)i2;

            Console.WriteLine($"Signiert von: {signature.getName()}");
            Console.WriteLine($"Signaturdatum: {signature.getSignDate().getTime()}");

            //signature.setName("John Doe");
            //signatureDictionaries.set(0, signature);

            //document.setEncryptionDictionary(signatureDictionaries);


            //byte[] certData = signature.getContents(new java.io.FileInputStream(pdfPath));
            //X509Certificate signerCert = new X509CertificateParser().ReadCertificate(certData);
            //Console.WriteLine($"Zertifikat des Signierers: {signerCert.SubjectDN}");




        }
    }
}
