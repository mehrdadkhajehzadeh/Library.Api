using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migration.Migrations
{
    [Migration(000002)]
    public class Mig000002_Craete_Categories_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Categories")
           .WithColumn("Id").AsInt32().PrimaryKey().Identity()
           .WithColumn("CategoryName").AsString(40);
        }

        public override void Down()
        {
            Delete.Table("Categories");
        }
    }
}
