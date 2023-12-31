namespace FactoryMethodPattern.ExportDataDemo
{
    public class ExportFactory
    {
        private ExportFactory() { }

        public static IExporter GetFactory(ExporterType type)
        {
            switch (type)
            {
                case ExporterType.DOWNLOAD_WORD_EXPORTER:
                    return new DownloadWordExporter();
                case ExporterType.DOWNLOAD_PDF_EXPORTER:
                    return new DownloadPDFExporter();
                case ExporterType.DOWNLOAD_EXCEL_EXPORTER:
                    return new DownloadExcelExporter();
                case ExporterType.EMAIL_WORD_EXPORTER:
                    return new EmailWordExporter();
                case ExporterType.EMAIL_PDF_EXPORTER:
                    return new EmailPDFExporter();
                case ExporterType.FTP_EXCEL_EXPORTER:
                    return new FTPExcelExporter();
                default:
                    throw new ArgumentException("This export method is unsupported.");
            }
        }
    }
}
