using AbstractFactoryPattern.ExportersDemo.Interfaces;

namespace AbstractFactoryPattern.ExportersDemo.Factories
{
    public class EmailExportFactory : IExportAbstractFactory
    {
        private FileType _fileType;

        public EmailExportFactory(FileType fileType)
        {
            _fileType = fileType;
        }

        public IExportedFile CreateFile()
        {
            return _fileType switch
            {
                FileType.WORD => new WordFile(),
                FileType.PDF => new PdfFile(),
                FileType.EXCEL => new ExcelFile(),
                FileType.CSV => new CsvFile(),
                FileType.TEXT => new TextFile(),
                _ => throw new ArgumentException("Unsupported format for email export"),
            };
        }
    }
}
