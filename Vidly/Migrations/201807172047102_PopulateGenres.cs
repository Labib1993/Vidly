namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) Values (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) Values (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) Values (4, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) Values (5, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) Values (6, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) Values (7, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) Values (8, 'Science Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
