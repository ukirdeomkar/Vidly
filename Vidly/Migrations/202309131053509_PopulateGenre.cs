namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Action')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Animation')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Crime')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Documentary')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Drama')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Family')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Horror')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Musical')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Mystery')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Romance')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Sci-Fi')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('War')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Western')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Biographical')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Historical')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Superhero')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Sports')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Music')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Animation')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Film Noir')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Political')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Spy')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Disaster')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Post-Apocalyptic')");
            Sql("INSERT INTO MovieGenres (Name) VALUES ('Zombie')");

        }

        public override void Down()
        {
        }
    }
}
