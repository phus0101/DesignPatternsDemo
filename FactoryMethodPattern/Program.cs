// Factory - TransportationDemo
//ITransport transport = TransportFactory.GetTransport(TransportType.TRUCK);
//transport.Delivery();

using FactoryMethodPattern.ExportDataDemo;

// Factory - ExporterDemo
IExporter exporter = ExportFactory.GetFactory(ExporterType.DOWNLOAD_WORD_EXPORTER);
exporter.Export("123");