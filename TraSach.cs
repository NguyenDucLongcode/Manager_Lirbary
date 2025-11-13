using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp1
{
    public class TraSach
    {
        public string MaSach { get; set; }
        public string MaDocGia { get; set; }
        public string HoTen { get; set; }
        public string SoLuong { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTraDuKien { get; set; }
        public string NgayTraThucTe { get; set; }
        public string TinhTrang { get; set; }

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

                return Path.Combine(dataPath, "TraSach.csv");
            }
            catch
            {
                string fallback = Path.Combine(Environment.CurrentDirectory, "Data", "TraSach.csv");
                Directory.CreateDirectory(Path.GetDirectoryName(fallback));
                return fallback;
            }
        }

        public TraSach()
        {
            MaSach = MaDocGia = HoTen = SoLuong = NgayMuon=NgayTraDuKien = NgayTraThucTe = string.Empty;
        }

        public TraSach(string csvLine)
        {
            if (string.IsNullOrWhiteSpace(csvLine))
                return;

            string[] values = csvLine.Split(',');

            if (values.Length >= 1) MaSach = values[0];
            if (values.Length >= 2) MaDocGia = values[1];
            if (values.Length >= 3) HoTen = values[2];
            if (values.Length >= 4) SoLuong = values[3];
            if (values.Length >= 5) NgayMuon = values[4];
            if (values.Length >= 5) NgayTraDuKien = values[4];
            if (values.Length >= 6) NgayTraThucTe = values[5];
        }

        public List<TraSach> GetList(string fileName = "")
        {
            List<TraSach> traSachList = new List<TraSach>();
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            if (!File.Exists(fileName))
                CreateSampleFile(fileName);

            if (!File.Exists(fileName))
                return traSachList;

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    if (!reader.EndOfStream)
                        reader.ReadLine();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            traSachList.Add(new TraSach(line.Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi đọc file {fileName}: {ex.Message}");
            }

            return traSachList;
        }

        private void CreateSampleFile(string fileName)
        {
            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaSach,MaDocGia,HoTen,SoLuong,NgayMuon,NgayTraDuKien,NgayTraThucTe");
                    
                    // 20 dữ liệu mẫu
                    writer.WriteLine("BK001,DG01,Nguyễn Văn An,2,01/11/2024,15/11/2024,14/11/2024");
                    writer.WriteLine("BK002,DG02,Trần Thị Bình,1,02/11/2024,20/11/2024,18/11/2024");
                    writer.WriteLine("BK003,DG03,Lê Văn Cường,3,03/11/2024,25/11/2024,26/11/2024");
                    writer.WriteLine("BK004,DG04,Phạm Thị Dung,2,04/11/2024,10/11/2024,09/11/2024");
                    writer.WriteLine("BK005,DG05,Hồ Văn Em,1,05/11/2024,30/11/2024,29/11/2024");
                    writer.WriteLine("BK006,DG06,Vũ Thị Phương,2,06/11/2024,05/12/2024,04/12/2024");
                    writer.WriteLine("BK007,DG07,Đặng Văn Giang,1,07/11/2024,12/12/2024,11/12/2024");
                    writer.WriteLine("BK008,DG08,Bùi Thị Hà,3,08/11/2024,18/12/2024,17/12/2024");
                    writer.WriteLine("BK009,DG09,Ngô Văn Hùng,2,09/11/2024,22/12/2024,21/12/2024");
                    writer.WriteLine("BK010,DG10,Đỗ Thị Lan,1,10/11/2024,28/12/2024,27/12/2024");
                    writer.WriteLine("BK011,DG11,Mai Văn Minh,2,11/11/2024,03/01/2025,02/01/2025");
                    writer.WriteLine("BK012,DG12,Lý Thị Nga,1,12/11/2024,08/01/2025,07/01/2025");
                    writer.WriteLine("BK013,DG13,Trịnh Văn Phúc,3,13/11/2024,15/01/2025,14/01/2025");
                    writer.WriteLine("BK014,DG14,Cao Thị Quỳnh,2,14/11/2024,20/01/2025,19/01/2025");
                    writer.WriteLine("BK015,DG15,Phan Văn Sơn,1,15/11/2024,25/01/2025,24/01/2025");
                    writer.WriteLine("BK016,DG16,Võ Thị Tuyết,2,16/11/2024,01/02/2025,31/01/2025");
                    writer.WriteLine("BK017,DG17,Chu Văn Tuấn,1,17/11/2024,06/02/2025,05/02/2025");
                    writer.WriteLine("BK018,DG18,Dương Thị Uyên,3,18/11/2024,12/02/2025,11/02/2025");
                    writer.WriteLine("BK019,DG19,Nguyễn Văn Việt,2,19/11/2024,18/02/2025,17/02/2025");
                    writer.WriteLine("BK020,DG20,Trần Thị Xuán,1,20/11/2024,24/02/2025,23/02/2025");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi tạo file {fileName}: {ex.Message}");
            }
        }

        public bool SaveList(List<TraSach> traSachList, string fileName = "")
        {
            fileName = string.IsNullOrWhiteSpace(fileName) ? DefaultPath : fileName;

            try
            {
                string directory = Path.GetDirectoryName(fileName);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    writer.WriteLine("MaSach,MaDocGia,HoTen,SoLuong,NgayTraDuKien,NgayTraThucTe");

                    foreach (var item in traSachList)
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

        public string ToCsvString()
        {
            return $"{MaSach},{MaDocGia},{HoTen},{SoLuong},{NgayMuon},{NgayTraDuKien},{NgayTraThucTe}";
        }

        public List<TraSach> SearchByMaSach(List<TraSach> traSachList, string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return traSachList;

            return traSachList
                .Where(m => m.MaSach.Contains(maSach, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public bool IsMaSachExists(List<TraSach> traSachList, string maSach)
        {
            return traSachList.Any(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }

        public static bool ValidateData(string maSach, string soLuong, DateTime ngayTraDuKien, DateTime ngayTraThucTe)
        {
            if (string.IsNullOrWhiteSpace(maSach))
                return false;

            if (string.IsNullOrWhiteSpace(soLuong) || !int.TryParse(soLuong, out int sl) || sl <= 0)
                return false;

            return true;
        }

        public bool DeleteTraSach(List<TraSach> traSachList, string maSach)
        {
            var itemToRemove = traSachList.FirstOrDefault(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                traSachList.Remove(itemToRemove);
                return SaveList(traSachList);
            }
            return false;
        }

        public TraSach GetByMaSach(List<TraSach> traSachList, string maSach)
        {
            return traSachList.FirstOrDefault(m => m.MaSach.Equals(maSach, StringComparison.OrdinalIgnoreCase));
        }
    }
}
