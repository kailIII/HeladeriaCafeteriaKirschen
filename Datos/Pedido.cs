using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using OfficeOpenXml;
using System.IO;

namespace Datos
{
	public static class Pedido
	{
		private static DBHeladeria dbHeladeria = DBHeladeria.Instance;

		public static void Nuevo(Entidades.Pedido pedido)
		{
			dbHeladeria.Pedido.Add(pedido);
			dbHeladeria.SaveChanges();
		}

		public static int GetNewID()
		{
            try
            {
                int? maxNum = dbHeladeria.Pedido.Max(p => p.IDPedido);
                return (maxNum == null) ? 1 : (Convert.ToInt32(maxNum) + 1);
            }
            catch (InvalidOperationException)
            {
                return 1;
            }
		}

		public static List<Entidades.Pedido> ToList(DateTime fechaDesde, DateTime fechaHasta)
		{
			return (from p in dbHeladeria.Pedido
					where p.FechaHora >= fechaDesde && p.FechaHora <= fechaHasta
					select p).ToList();
		}

		public static string GuardarAExcel(List<Entidades.Pedido> pedidos, string path)
		{
			string filename = "VENTAS-" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ssZ") + ".xlsx";
			DataTable dtPedidos = ToDataTable(pedidos);
			using (ExcelPackage excel = new ExcelPackage(new FileInfo(path + "\\" + filename)))
			{
				ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Pedidos");
				ws.Cells["A1"].LoadFromDataTable(dtPedidos, true);
				excel.Save();
				return filename;
			}
		}

		public static DataTable ToDataTable(List<Entidades.Pedido> pedidos)
		{
			DataTable dtPedidos = new DataTable("Pedidos");
			dtPedidos.Columns.Add("Numero", typeof(int));
			dtPedidos.Columns.Add("Fecha", typeof(string));
			dtPedidos.Columns.Add("Delivery", typeof(string));
			dtPedidos.Columns.Add("Efectivo", typeof(string));
			dtPedidos.Columns.Add("Total", typeof(double));
			foreach (Entidades.Pedido pedido in pedidos)
			{
				object[] values = new object [5];
				values[0] = pedido.IDPedido;
				values[1] = pedido.FechaHora.ToString();
				values[2] = (pedido.Delivery) ? "Sí" : "No";
				values[3] = (pedido.Efectivo) ? "Sí" : "No";
				values[4] = pedido.Monto;
				dtPedidos.Rows.Add(values);
			}
			object[] totalRow = new object[5];
			totalRow[0] = 0;
			totalRow[1] = "";
			totalRow[2] = "";
			totalRow[3] = "";
			totalRow[4] = pedidos.Sum(p => p.Monto);
			dtPedidos.Rows.Add(totalRow);
			return dtPedidos;
		}
	}
}
