using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migration.Migrations
{
    [Migration(000005)]
    public class Mig000005_Craete_RentBooks_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("RentBooks")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("RentDate").AsDateTime()
            .WithColumn("BookId").AsInt32()
            .WithColumn("UserId").AsInt32();
            Create.ForeignKey("FK_RentBook_Books").FromTable("RentBooks").ForeignColumn("BookId").ToTable("Books").PrimaryColumns("Id");
            Create.ForeignKey("FK_RentBook_Users").FromTable("RentBooks").ForeignColumn("UserId").ToTable("Users").PrimaryColumns("Id");
        }

        public override void Down()
        {
            Delete.Table("BorrowBooks");
        }
    }
}
