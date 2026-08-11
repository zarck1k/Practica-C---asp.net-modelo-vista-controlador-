using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using ScottPlot;
using ScottPlot.Plottables;
using Colors = QuestPDF.Helpers.Colors;
namespace InventaMeCF.Pdf
{
    public class VolumenVentasDocument : IDocument
    {
        private List<VolumenVentasModel> Model { get; }
        public VolumenVentasDocument(List<VolumenVentasModel> model)
        {
            Model = model;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(14));

                page.Header()
                    .AlignCenter()
                    .Column(column =>
                    {
                        column.Item()
                            .Text("VOLUMEN DE VENTAS")
                            .SemiBold()
                            .FontSize(24)
                            .FontColor(Colors.Blue.Medium);

                        column.Item()
                            .Text("Top 3 productos con mayor volumen de ventas")
                            .FontSize(12)
                            .FontColor(Colors.Grey.Medium);
                    });

                page.Content()
                    .Column(column =>
                    {
                        column.Spacing(20);

                        column.Item().Column(column =>
                        {
                            column.Spacing(10);

                            column.Item()
                                .AspectRatio(1)
                                .Svg(size =>
                                {
                                    ScottPlot.Plot plot = new();
                                    PieSlice[] slices = new PieSlice[3];
                                    int i = 0;
                                    ScottPlot.Color[] cl = new ScottPlot.Color[] { new ScottPlot.Color(Colors.Yellow.Medium.Hex), new ScottPlot.Color(Colors.Green.Medium.Hex), new ScottPlot.Color(Colors.Blue.Medium.Hex) };
                                    foreach (var item in Model)
                                    {
                                        slices[i] = new() { Value = (double)item.Volumen, FillColor = cl[i], Label = item.Nombre };
                                        i++;
                                    }

                                    var pie = plot.Add.Pie(slices);
                                    pie.DonutFraction = 0.5;
                                    pie.SliceLabelDistance = 1.5;
                                    pie.LineColor = ScottPlot.Colors.White;
                                    pie.LineWidth = 3;

                                    foreach (var pieSlice in pie.Slices)
                                    {
                                        pieSlice.LabelStyle.FontName = "Lato";
                                        pieSlice.LabelStyle.FontSize = 16;
                                    }

                                    plot.Axes.Frameless();
                                    plot.HideGrid();

                                    return plot.GetSvgXml((int)size.Width, (int)size.Height);
                                });
                        });
                        column.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(2); // Id
                                columns.RelativeColumn(2); // Nombre
                                columns.RelativeColumn(2); // Volumen
                            });
                            // Header
                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("ID");
                                header.Cell().Element(CellStyle).Text("NOMBRE");
                                header.Cell().Element(CellStyle).Text("VOLUMEN");
                                static IContainer CellStyle(IContainer container) =>
                                    container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Grey.Medium);
                            });

                            // Rows
                            foreach (var item in Model)
                            {
                                table.Cell().Element(CellStyle).Text(item.Id.ToString());
                                table.Cell().Element(CellStyle).Text(item.Nombre);
                                table.Cell().Element(CellStyle).Text(item.Volumen.ToString());
                                static IContainer CellStyle(IContainer container) =>
                                        container.PaddingVertical(5);
                            }
                        });
                    });

                page.Footer()
                    .AlignCenter()
                    .Text(x =>
                    {
                        x.Span("Página ");
                        x.CurrentPageNumber();
                    });

            });
        }
    }
}