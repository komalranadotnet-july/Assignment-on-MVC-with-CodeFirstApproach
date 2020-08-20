namespace MovieCustomerMvcAppWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDobinCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Dob", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Dob", c => c.DateTime(nullable: false));
        }
    }
}
