using qlDsSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ShareData
    {
        public static List<Author> AuthorList { get; set; } = new List<Author>();
        public static List<ListBook> bookList { get; set; } = new List<ListBook>();
        public static List<DocGia> DocGiaList { get; set; } = new List<DocGia>();

        public static List<MuonSach> MuonSachList { get; set; } = new List<MuonSach>();
    }
}
