using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class MuonSach
    {
        public string MaSach { get; set; }
        public string SoLuong { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }

        // ✅ Luôn load/save ở thư mục Data của project gốc
        private static readonly string DefaultPath = GetProjectDataPath();

        /// <summary>
        /// Xác định đường dẫn tuyệt đối đến file MuonSach.csv trong thư mục Data của project.
        /// </summary>
        private static string GetProjectDataPath()
        {
            try
            {
                // Thư mục thực thi hiện tại (thường là bin\Debug\net8.0-windows\)
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                // Đi ngược 3 cấp để quay lại thư mục project gốc
                DirectoryInfo? dir = new DirectoryInfo(baseDir);
                for (int i = 0; i < 3; i++)
                    dir = dir?.Parent;

                string projectRoot = dir?.FullName ?? baseDir;
                string dataPath = Path.Combine(projectRoot, "Data");

                if (!Directory.Exists(dataPath))
                    Directory.CreateDirectory(dataPath);

                return Path.Combine(dataPath, "MuonSach.csv");
            }
            catch
            {
                // Fallback nếu có lỗi — tạo trong thư mục hiện hành
                string fallback = Path.Combine(Environment.CurrentDirectory, "Data", "MuonSach.csv");
                Directory.CreateDirectory(Path.GetDirectoryName(fallback));
                return fallback;
            }
        }

        public MuonSach()
        {
            MaSach = SoLuong = NgayMuon = NgayTra = string.Empty;
        }

        public MuonSach(string csvLine)
        {
            if (string.IsNullOrWhiteSpace(csvLine))
                return;

            string[] values = csvLine.Split(',');

            if (values.Length >= 1) MaSach = values[0];
            if (values.Length >= 2) SoLuong = values[1];
            if (values.Length >= 3) NgayMuon = values[2];
            if (values.Length >= 4) NgayTra = values[3];
        }

        /// <summary>
        /// Đọc danh sách mượn sách từ file CSV.
        /// </summary>
        public List<MuonSach> GetList(string fileName = "")
        {
            List<MuonSach> muonSachList = new List<MuonSach>();
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            // Nếu file chưa tồn tại thì tạo file mẫu
            if (!File.Exists(fileName))
                CreateSampleFile(fileName);

            if (!File.Exists(fileName))
                return muonSachList;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // Bỏ qua dòng tiêu đề
                    if (!reader.EndOfStream)
                        reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            muonSachList.Add(new MuonSach(line.Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi đọc file {fileName}: {ex.Message}");
            }

            return muonSachList;
        }

        /// <summary>
        /// Tạo file mẫu nếu chưa có dữ liệu.
        /// </summary>
        private void CreateSampleFile(string fileName)
        {
            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaSach,SoLuong,NgayMuon,NgayTra");
                    writer.WriteLine("S001,2,31/10/2024,07/11/2024");
                    writer.WriteLine("S002,1,30/10/2024,06/11/2024");
                    writer.WriteLine("S003,3,29/10/2024,05/11/2024");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi tạo file {fileName}: {ex.Message}");
            }
        }

        /// <summary>
        /// Ghi danh sách mượn sách vào file CSV.
        /// </summary>
        public bool SaveList(List<MuonSach> muonSachList, string fileName = "")
        {
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaSach,SoLuong,NgayMuon,NgayTra");

                    foreach (var item in muonSachList)
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

        /// <summary>
        /// Trả về chuỗi CSV của một bản ghi.
        /// </summary>
        public string ToCsvString()
        {
            return $"{MaSach},{SoLuong},{NgayMuon},{NgayTra}";
        }

        /// <summary>
        /// Tìm kiếm mượn sách theo mã sách.
        /// </summary>
        public List<MuonSach> SearchByMaSach(List<MuonSach> muonSachList, string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return muonSachList;

            return muonSachList
                .Where(m => m.MaSach.Contains(maSach, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        /// <summary>
        /// Kiểm tra mã sách đã tồn tại hay chưa.
        /// </summary>
        public bool IsMaSachExists(List<MuonSach> muonSachList, string maSach)
        {
            return muonSachList.Any(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Kiểm tra dữ liệu nhập hợp lệ.
        /// </summary>
        public static bool ValidateData(string maSach, string soLuong, DateTime ngayMuon, DateTime ngayTra)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return false;

            if (string.IsNullOrWhiteSpace(soLuong) || !int.TryParse(soLuong, out int sl) || sl <= 0)
                return false;

            if (ngayTra <= ngayMuon)
                return false;

            return true;
        }

        /// <summary>
        /// Xóa một bản ghi mượn sách theo mã.
        /// </summary>
        public bool DeleteMuonSach(List<MuonSach> muonSachList, string maSach)
        {
            var itemToRemove = muonSachList.FirstOrDefault(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                muonSachList.Remove(itemToRemove);
                return SaveList(muonSachList);
            }
            return false;
        }

        /// <summary>
        /// Lấy thông tin mượn sách theo mã.
        /// </summary>
        public MuonSach GetByMaSach(List<MuonSach> muonSachList, string maSach)
        {
            return muonSachList.FirstOrDefault(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }
    }
}
