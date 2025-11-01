using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using qlDsSinhVien;

namespace WinFormsApp1
{
    public class MuonSach
    {
        public string MaSach { get; set; }
        public string SoLuong { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }

        private static string DefaultPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "MuonSach.csv");

        public MuonSach()
        {
            MaSach = SoLuong = NgayMuon = NgayTra = "";
        }

        public MuonSach(string csvLine)
        {
            if (string.IsNullOrEmpty(csvLine))
                return;

            string[] values = csvLine.Split(',');

            if (values.Length >= 1) MaSach = values[0];
            if (values.Length >= 2) SoLuong = values[1];
            if (values.Length >= 3) NgayMuon = values[2];
            if (values.Length >= 4) NgayTra = values[3];
        }

        public List<MuonSach> GetList(string fileName = "")
        {
            List<MuonSach> MuonSachList = new List<MuonSach>();
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            // Kiểm tra và tạo file nếu chưa tồn tại
            if (!File.Exists(fileName))
            {
                CreateSampleFile(fileName);
            }

            // Kiểm tra lại sau khi tạo file
            if (!File.Exists(fileName))
            {
                return MuonSachList;
            }

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    // Bỏ qua dòng header
                    if (!reader.EndOfStream)
                        reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            MuonSach muonSach = new MuonSach(line.Trim());
                            MuonSachList.Add(muonSach);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi đọc file {fileName}: {ex.Message}");
            }

            return MuonSachList;
        }

        private void CreateSampleFile(string fileName)
        {
            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

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

        public bool SaveList(List<MuonSach> muonSachList, string fileName = "")
        {
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaSach,SoLuong,NgayMuon,NgayTra");

                    foreach (var muonSach in muonSachList)
                    {
                        writer.WriteLine($"{muonSach.MaSach},{muonSach.SoLuong},{muonSach.NgayMuon},{muonSach.NgayTra}");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi ghi file {fileName}: {ex.Message}");
                return false;
            }
        }

        public string ToCsvString()
        {
            return $"{MaSach},{SoLuong},{NgayMuon},{NgayTra}";
        }

        public List<MuonSach> SearchByMaSach(List<MuonSach> muonSachList, string maSach)
        {
            if (string.IsNullOrEmpty(maSach))
                return muonSachList;

            return muonSachList.Where(m => m.MaSach.Contains(maSach, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public bool IsMaSachExists(List<MuonSach> muonSachList, string maSach)
        {
            return muonSachList.Any(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }

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

        // Thêm phương thức này vào class MuonSach
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

        public MuonSach GetByMaSach(List<MuonSach> muonSachList, string maSach)
        {
            return muonSachList.FirstOrDefault(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }
    }
}
