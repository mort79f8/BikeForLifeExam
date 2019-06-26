using BikeForLife.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikeForLife.Dal
{
    public class MemberRepository : BaseRepository
    {
        public List<Member> GetAll()
        {
            string sql = "SELECT * FROM Members";
            DataTable dataTable = ExecuteQuery(sql);
            if (dataTable == null)
                throw new InvalidOperationException($"DataTable was null. SQL string is: {sql}");
            return HandleData(dataTable);
        }

        public Member GetMember(int memberId)
        {
            string sql = $"SELECT * FROM Members WHERE MemberId={memberId}";
            DataTable dataTable = ExecuteQuery(sql);
            if (dataTable == null)
                throw new InvalidOperationException($"DataTable was null. SQL string is: {sql}");
            return HandleData(dataTable).FirstOrDefault();
        }

        private List<Member> HandleData(DataTable dataTable)
        {
            if (dataTable == null)
                return null;

            List<Member> members = new List<Member>();

            foreach (DataRow row in dataTable.Rows)
            {
                members.Add(new Member()
                {
                    Id = (int)row["MemberId"],
                    Name = (string)row["Name"],
                    EnrollmentDate = (DateTime)row["EnrollmentDate"]
                });
            }
            return members;
        }

        public int Insert(Member member)
        {
            string sql = $"INSERT INTO Members VALUES ('{member.Name}', '{member.EnrollmentDate.Date:yyyy-MM-dd}')";

            return ExecuteNonQuery(sql);
        }
    }
}
