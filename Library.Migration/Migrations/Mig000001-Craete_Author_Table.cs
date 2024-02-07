
using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migration.Migrations
{
    [Migration(000001)]
    public class Mig000001_Craete_Author_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Authors")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("FullName").AsString(80);
        }
        public override void Down()
        {
            Delete.Table("Authors");
        }
    }
}
