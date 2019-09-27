using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace aws_lambda_netcore3_efcore
{
    [Table("test_member")]
    public class Member
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string Firstname { get; set; }

        [Column("lastname")]
        public string Lastname { get; set; }

    }

}
