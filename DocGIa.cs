using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class DocGia
    {
        public string MaDocGia { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string GioiTinh { get; set; } = "";
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = "";
        public string SoDienThoai { get; set; } = "";
        public DateTime NgayLamThe { get; set; }
        public string CMND { get; set; } = "";

        // ✅ Đường dẫn mặc định lưu file CSV trong thư mục Data của project
        private static readonly string DefaultPath = GetProjectDataPath();

        private static string GetProjectDataPath()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo? dir = new DirectoryInfo(baseDir);
                for (int i = 0; i < 3; i++)
                    dir = dir?.Parent;

                string projectRoot = dir?.FullName ?? baseDir;
                string dataPath = Path.Combine(projectRoot, "Data");

                if (!Directory.Exists(dataPath))
                    Directory.CreateDirectory(dataPath);

                return Path.Combine(dataPath, "DocGia.csv");
            }
            catch
            {
                string fallback = Path.Combine(Environment.CurrentDirectory, "Data", "DocGia.csv");
                Directory.CreateDirectory(Path.GetDirectoryName(fallback)!);
                return fallback;
            }
        }

        public DocGia()
        {
            MaDocGia = HoTen = GioiTinh = DiaChi = SoDienThoai = CMND = string.Empty;
            NgaySinh = DateTime.Now;
            NgayLamThe = DateTime.Now;
        }

        public DocGia(string csvLine)
        {
            if (string.IsNullOrWhiteSpace(csvLine))
                return;

            string[] values = csvLine.Split(',');

            if (values.Length >= 1) MaDocGia = values[0];
            if (values.Length >= 2) HoTen = values[1];
            if (values.Length >= 3) GioiTinh = values[2];
            if (values.Length >= 4) DiaChi = values[3];
            if (values.Length >= 5 && DateTime.TryParse(values[4], out DateTime ns)) NgaySinh = ns;
            if (values.Length >= 6) SoDienThoai = values[5];
            if (values.Length >= 7 && DateTime.TryParse(values[6], out DateTime nlt)) NgayLamThe = nlt;
            if (values.Length >= 8) CMND = values[7];
        }

        // 🔹 Đọc danh sách độc giả từ file CSV
        public List<DocGia> GetList(string fileName = "")
        {
            List<DocGia> list = new List<DocGia>();
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            if (!File.Exists(fileName))
                CreateSampleFile(fileName);

            if (!File.Exists(fileName))
                return list;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    if (!reader.EndOfStream)
                        reader.ReadLine(); // Bỏ dòng tiêu đề

                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            list.Add(new DocGia(line.Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi đọc file {fileName}: {ex.Message}");
            }

            return list;
        }

        // 🔹 Tạo file mẫu nếu chưa tồn tại
        private void CreateSampleFile(string fileName)
        {
            try
            {
                string? directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaDocGia,HoTen,GioiTinh,DiaChi,NgaySinh,SoDienThoai,NgayLamThe,CMND");
                    writer.WriteLine("DG001,Nguyen Van A,Nam,TP.HCM,01/01/2000,0901234567,01/01/2024,123456789012");
                    writer.WriteLine("DG002,Tran Thi B,Nu,Ha Noi,15/03/1999,0987654321,15/02/2024,987654321098");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi tạo file {fileName}: {ex.Message}");
            }
        }

        // 🔹 Ghi danh sách độc giả vào file CSV
        public bool SaveList(List<DocGia> list, string fileName = "")
        {
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            try
            {
                string? directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaDocGia,HoTen,GioiTinh,DiaChi,NgaySinh,SoDienThoai,NgayLamThe,CMND");
                    foreach (var item in list)
                        writer.WriteLine(item.ToCsvString());
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi ghi file {fileName}: {ex.Message}");
                return false;
            }
        }

        // 🔹 Chuyển đối tượng thành chuỗi CSV
        public string ToCsvString()
        {
            return $"{MaDocGia},{HoTen},{GioiTinh},{DiaChi},{NgaySinh:dd/MM/yyyy},{SoDienThoai},{NgayLamThe:dd/MM/yyyy},{CMND}";
        }

        // 🔹 Tìm độc giả theo mã
        public List<DocGia> SearchByMaDocGia(List<DocGia> list, string maDocGia)
        {
            if (string.IsNullOrWhiteSpace(maDocGia))
                return list;

            return list
                .Where(m => m.MaDocGia.Contains(maDocGia, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // 🔹 Kiểm tra mã độc giả đã tồn tại chưa
        public bool IsMaDocGiaExists(List<DocGia> list, string maDocGia)
        {
            return list.Any(m => m.MaDocGia.Equals(maDocGia, StringComparison.OrdinalIgnoreCase));
        }

        // 🔹 Xóa độc giả theo mã
        public bool DeleteDocGia(List<DocGia> list, string maDocGia)
        {
            var itemToRemove = list.FirstOrDefault(m => m.MaDocGia.Equals(maDocGia, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
                return SaveList(list);
            }
            return false;
        }

        // 🔹 Lấy thông tin độc giả theo mã
        public DocGia? GetByMaDocGia(List<DocGia> list, string maDocGia)
        {
            return list.FirstOrDefault(m => m.MaDocGia.Equals(maDocGia, StringComparison.OrdinalIgnoreCase));
        }
    }
}
