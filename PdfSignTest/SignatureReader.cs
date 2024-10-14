using org.apache.pdfbox.cos;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.pdmodel.interactive.digitalsignature;
using org.apache.commons.logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfSignTest
{
    public class SignatureReader
    {

        public string GetDetails()
        {
            string filePath = @"C:\tmp\Test_signed.pdf";

            java.io.File file = new java.io.File(filePath);
            var document = PDDocument.load(file);

            var signatureDictionaries = document.getSignatureDictionaries();
            var i2 = signatureDictionaries.get(0);
            var signature = (PDSignature)i2;

            var result = new StringBuilder();
            result.AppendLine($"von: {signature.getName()}");
            result.AppendLine($"Datum: {signature.getSignDate().getTime()}");
            result.AppendLine($"Info: {signature.getContactInfo()}");
            result.AppendLine($"Filter: {signature.getFilter()}");
            result.AppendLine($"Location: {signature.getLocation()}");
            result.AppendLine($"Location: {signature.getReason()}");
            result.AppendLine($"SubFilter: {signature.getSubFilter()}");

            return result.ToString();
        }
    }
}
