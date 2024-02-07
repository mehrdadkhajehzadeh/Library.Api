using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migration.Migrations
{
    [Migration(000004)]
    public class Mig000004_Craete_Users_Table : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table("Users")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("FirstName").AsString(30)
            .WithColumn("LastName").AsString(40);
        }

        public override void Down()
        {
            Delete.Table("Users");
        }
    }
}
