namespace Vidly.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'pay as you go' WHERE DurationInMonths = 0;");
            Sql("UPDATE MembershipTypes SET Name = 'monthly' WHERE DurationInMonths = 1;");
            Sql("UPDATE MembershipTypes SET Name = 'quaterly' WHERE DurationInMonths = 3;");
            Sql("UPDATE MembershipTypes SET Name = 'anually' WHERE DurationInMonths = 12;");

        }

        public override void Down()
        {
        }
    }
}
