using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace qlDsSinhVien
{
    public class ListBook
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string NhaXB { get; set; }
        public string NgayXB { get; set; }
        public string MaTacGia { get; set; }
        public string GiaTien { get; set; }

        public ListBook()
        {
            MaSach = TenSach = TheLoai = NhaXB = NgayXB = MaTacGia = GiaTien = "";
        }

        public ListBook(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.MaSach = values[0];
            this.TenSach = values[1];
            this.TheLoai = values[2];
            this.NhaXB = values[3];
            this.NgayXB = values[4];
            this.MaTacGia = values[5];
            this.GiaTien = values[6];
        }

        public List<ListBook> GetList(string fileName = "")
        {
            List<ListBook> bookList = new List<ListBook>();
            fileName = (fileName == "") ? GlobalSettingcs.ListBookFileName : fileName;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    ListBook listbook = new ListBook(line);
                    bookList.Add(listbook);
                }
            }
            return bookList;
        }

        public DataTable ToDataTable(List<ListBook> listbooks)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("MaSach", typeof(string));
            dt.Columns.Add("TenSach", typeof(string));
            dt.Columns.Add("TheLoai", typeof(string));
            dt.Columns.Add("NgayXB", typeof(string));
            dt.Columns.Add("NhaXB", typeof(string));
            dt.Columns.Add("MaTacGia", typeof(string));
            dt.Columns.Add("GiaTien", typeof(string));
            foreach (var s in listbooks)
            {
                dt.Rows.Add(s.MaSach, s.TenSach, s.TheLoai, s.NgayXB, s.NhaXB, s.MaTacGia, s.GiaTien);
            }
            return dt;
        }
        
    }
}
