namespace PdfSignTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            var tool = new SignatureReader();
            var result = tool.GetDetails();

            Console.WriteLine(result);
            Console.ReadKey();

            //// Pfad zu deiner PDF-Datei
            //string filePath = @"C:\tmp\Test_signed.pdf";

            //var document = PDDocument.load(filePath);

            //// Hole alle digitalen Signaturen
            //var signatureDictionaries = document.getSignatureDictionaries();

            //for (int i = 0; i < 10; i++)
            //{
            //    var item = (COSDictionary)signatureDictionaries.get(0);
                
            //    // Informationen zur Signatur extrahieren
            //    var signature = new PDSignature(item);

            //    Console.WriteLine($"Signiert von: {signature.getName()}");
            //    Console.WriteLine($"Signaturdatum: {signature.getSignDate().getTime()}");

            //    // Optional: Weiter mit BouncyCastle verarbeiten
            //    //byte[] certData = signature.getContents(new java.io.FileInputStream(pdfPath));
            //    //X509Certificate signerCert = new X509CertificateParser().ReadCertificate(certData);
            //    //Console.WriteLine($"Zertifikat des Signierers: {signerCert.SubjectDN}");

            //}

            

        }

        //private void IText(string filePath)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    PdfReader reader = new PdfReader(filePath);
        //    AcroFields af = reader.AcroFields;
        //    var names = af.GetSignatureNames();

        //    for (int i = 0; i < names.Count; ++i)
        //    {
        //        String name = (string)names[i];
        //        PdfPKCS7 pk = af.VerifySignature(name);
        //        sb.AppendFormat("Signature field name: {0}\n", name);
        //        sb.AppendFormat("Signature signer name: {0}\n", pk.SignName);
        //        sb.AppendFormat("Signature date: {0}\n", pk.SignDate);
        //        sb.AppendFormat("Signature country: {0}\n",
        //            CertificateInfo.GetSubjectFields(pk.SigningCertificate).GetField("C")
        //        );
        //        sb.AppendFormat("Signature organization: {0}\n",
        //          CertificateInfo.GetSubjectFields(pk.SigningCertificate).GetField("O")
        //        );
        //        sb.AppendFormat("Signature unit: {0}\n",
        //          CertificateInfo.GetSubjectFields(pk.SigningCertificate).GetField("OU")
        //        );

        //        Console.WriteLine(sb.ToString());
        //    }
        //}
    }
}
