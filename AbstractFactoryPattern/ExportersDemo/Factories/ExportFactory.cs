using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo.Factories
{
    public class ExportFactory
    {
        private ExportFactory() { }

        public static IExportAbstractFactory GetFactory(ExporterType exporterType, FileType fileType)
        {
            return exporterType switch
            {
                ExporterType.EMAIL => new EmailExportFactory(fileType),
                ExporterType.DOWNLOAD => new DownloadExportFactory(fileType),
                ExporterType.FTP => new FtpExportFactory(fileType),
                _ => throw new NotImplementedException("This exporter is unsupported."),
            };
        }
    }
}
