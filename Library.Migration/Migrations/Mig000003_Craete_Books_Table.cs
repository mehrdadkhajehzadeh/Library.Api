using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migration.Migrations
{
    [Migration(000003)]
    public class Mig000003_Craete_Books_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Books")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("BookTitle").AsString(40)
            .WithColumn("BookInventory").AsInt32()
            .WithColumn("PublishedDateBook").AsDateTime()
            .WithColumn("AuthorId").AsInt32()
            .WithColumn("CategoryId").AsInt32();
            Create.ForeignKey("FK_Book_Authors").FromTable("Books").ForeignColumn("AuthorId").ToTable("Authors").PrimaryColumns("Id");
            Create.ForeignKey("FK_Book_Categories").FromTable("Books").ForeignColumn("CategoryId").ToTable("Categories").PrimaryColumns("Id");
        }

        public override void Down()
        {
            Delete.Table("Books");
        }

    }
}
