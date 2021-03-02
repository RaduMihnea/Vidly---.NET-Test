namespace Test2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            //Users
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f77f600-f02e-4ba3-9da9-54082854b11e', N'admin@admin.com', 0, N'AAf5SWsmz/qbbKywhlFZozNYwyN3CjrZQNgNkrNlelzCb3zcEU2fMoOGb5+2Wz7u2g==', N'7f285973-6b7a-4806-9018-f5daeb61fba6', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f3abab50-252d-4079-8870-2194f55b9ac5', N'guest@guest.ro', 0, N'AAy28Ns+IiUR64nZf8YEocqub3Bsuwd4amXj/uIBTlzs7nzsXlwepsRE4CEUWQ5Mvw==', N'55ed5c95-9e7c-486e-8d1d-70c9ff907c8f', NULL, 0, 0, NULL, 1, 0, N'guest@guest.ro')
            ");
            //Roles
            Sql(@"
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ac6718e2-9ca2-464a-812b-d1db5ea5610a', N'CanManageMovies')
            ");
            //UserRoleLink
            Sql(@"
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7f77f600-f02e-4ba3-9da9-54082854b11e', N'ac6718e2-9ca2-464a-812b-d1db5ea5610a')
            ");
        }

        public override void Down()
        {
        }
    }
}