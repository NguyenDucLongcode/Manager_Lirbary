using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlDsSinhVien
{
    public class Author
    {
        public string AuthorID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CMND { get; set; }
        public string PenName { get; set; }
        
        public Author()
        {
            AuthorID = FullName = Gender = BirthDate = Address = PhoneNumber = CMND = PenName = "";
        }

        public Author(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.AuthorID = values[0];
            this.FullName = values[1];
            this.Gender = values[2];
            this.BirthDate = values[3];
            this.Address = values[4];
            this.PhoneNumber = values[5];
            this.CMND = values[6];
            this.PenName = values[7];
        }

        public List<Author> GetList(string fileName = "")
        {
            List<Author> authorList = new List<Author>();
            fileName = (fileName == "") ? GlobalSettingcs.AuthorFileName : fileName;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row                
                if (!reader.EndOfStream) reader.ReadLine();

                string line = "";
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Author author = new Author(line);
                    authorList.Add(author);
                }
            }
            return authorList;
        } 
        public DataTable ToDataTable(List<Author> authors)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("AuthorID", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("BirthDate", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("PenName", typeof(string));
            foreach (var s in authors)
            {
                dt.Rows.Add(s.AuthorID, s.FullName, s.Gender, s.BirthDate,s.Address, s.PhoneNumber, s.CMND,s.PenName);
            }
            return dt;
        }
    }
}
