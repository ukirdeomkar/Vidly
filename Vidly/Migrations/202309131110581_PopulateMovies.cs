namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberOfStocks)VALUES    ('Movie 1', 1, '2023-01-01', '2023-01-01', 10),    ('Movie 2', 2, '2023-02-15', '2023-02-15', 15),    ('Movie 3', 3, '2023-03-30', '2023-03-30', 20),    ('Movie 4', 4, '2023-04-10', '2023-04-10', 8),    ('Movie 5', 5, '2023-05-20', '2023-05-20', 12),    ('Movie 6', 6, '2023-06-05', '2023-06-05', 18)");
        }
        
        public override void Down()
        {
        }
    }
}
