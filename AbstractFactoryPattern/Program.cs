//using AbstractFactoryPattern.FurnituresDemo;
//using AbstractFactoryPattern.FurnituresDemo.Factories;
//using AbstractFactoryPattern.FurnituresDemo.Interfaces;

//IFurnitureAbstractFactory factory = FurnitureFactory.GetFactory(StyleType.ARTDECO);
//IChairCreator chairCreator = factory.CreateChair();
//chairCreator.Create();

// -------------------------------------------------------------------------//

using AbstractFactoryPattern.ExportersDemo;
using AbstractFactoryPattern.ExportersDemo.Factories;

//// Example of using Email Export with dynamic format
//IExportAbstractFactory emailExportFactory = new EmailExportFactory(FileType.PDF);
//IExportedFile emailExportedFile = emailExportFactory.CreateFile();
//emailExportedFile.Export("Data to export via email in PDF");

//// You can also change the format dynamically
//emailExportFactory = new EmailExportFactory(FileType.EXCEL);
//emailExportedFile = emailExportFactory.CreateFile();
//emailExportedFile.Export("Data to export via email in Excel");


// -------------------------------------------------------------------------//

ExportFactory
    .GetFactory(ExporterType.EMAIL, FileType.PDF)
    .CreateFile()
    .Export("Data to export via email in PDF");