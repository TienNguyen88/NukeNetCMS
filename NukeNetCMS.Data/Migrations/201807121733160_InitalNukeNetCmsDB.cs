namespace NukeNetCMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalNukeNetCmsDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountryID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ContactFields",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Shortcode = c.String(nullable: false, maxLength: 250, unicode: false),
                        Content = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Controls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Percent = c.Int(),
                        ExpireDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Image = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDefault = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.MenuDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 500),
                        Target = c.String(maxLength: 10, unicode: false),
                        IsActive = c.Boolean(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.MenuID, cascadeDelete: true)
                .Index(t => t.MenuID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        DisplayOrder = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Guid(nullable: false),
                        ProductID = c.Int(nullable: false),
                        PriceOriginal = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promotion = c.Decimal(precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        ShippingID = c.Int(),
                        CouponID = c.Int(),
                        PaymentMethodID = c.Int(),
                        PaymentTransactionID = c.Int(),
                        CustomerName = c.String(nullable: false, maxLength: 250),
                        CustomerAddress = c.String(nullable: false, maxLength: 250),
                        CustomerEmail = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerMobile = c.String(nullable: false, maxLength: 20, unicode: false),
                        CustomerMessage = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50, unicode: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Coupons", t => t.CouponID)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethodID)
                .ForeignKey("dbo.Shippings", t => t.ShippingID)
                .Index(t => t.ShippingID)
                .Index(t => t.CouponID)
                .Index(t => t.PaymentMethodID);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shippings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShippingMethodID = c.Int(nullable: false),
                        AreaID = c.Int(nullable: false),
                        Fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Percent = c.Int(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Areas", t => t.AreaID, cascadeDelete: true)
                .ForeignKey("dbo.ShippingMethods", t => t.ShippingMethodID, cascadeDelete: true)
                .Index(t => t.ShippingMethodID)
                .Index(t => t.AreaID);
            
            CreateTable(
                "dbo.ShippingMethods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        CategoryID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Slug = c.String(nullable: false, maxLength: 500, unicode: false),
                        Code = c.String(maxLength: 50),
                        Image = c.String(maxLength: 500),
                        UnitInStock = c.Int(),
                        Manufacturer = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        PriceOriginal = c.Decimal(precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Promotion = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        PublishedDate = c.DateTime(),
                        ExpireDate = c.DateTime(),
                        IsComment = c.Boolean(),
                        DisplayOrder = c.Int(nullable: false),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        Visibility = c.String(nullable: false, maxLength: 50, unicode: false),
                        PasswordProtected = c.String(maxLength: 50, unicode: false),
                        IsTrash = c.Boolean(),
                        IsHot = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        ParentID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Slug = c.String(nullable: false, maxLength: 500, unicode: false),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Icon = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProductCategories", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.PageComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        PageID = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        Star = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pages", t => t.PageID, cascadeDelete: true)
                .Index(t => t.PageID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Slug = c.String(nullable: false, maxLength: 250),
                        Content = c.String(),
                        Image = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 250),
                        MetaKeywords = c.String(maxLength: 250),
                        DisplayOrder = c.Int(nullable: false),
                        ExpireDate = c.DateTime(),
                        PublishedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Visibility = c.String(nullable: false, maxLength: 50, unicode: false),
                        PasswordProtected = c.String(maxLength: 50, unicode: false),
                        IsTrash = c.Boolean(),
                        IsDefault = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaymentTransactions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Guid(),
                        TransactionCode = c.String(nullable: false, maxLength: 250, unicode: false),
                        Portal = c.String(maxLength: 250),
                        CardID = c.String(nullable: false, maxLength: 20, unicode: false),
                        CardName = c.String(nullable: false, maxLength: 50),
                        CardExpireMonth = c.String(nullable: false, maxLength: 2, unicode: false),
                        CardExpireYear = c.String(nullable: false, maxLength: 2, unicode: false),
                        CardCVV = c.String(maxLength: 50, unicode: false),
                        BankName = c.String(maxLength: 100),
                        Token = c.String(maxLength: 250, unicode: false),
                        TokenExpire = c.DateTime(),
                        IsStatus = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        SuccessDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Plugins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        ParentID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Slug = c.String(nullable: false, maxLength: 500),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Icon = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        IsHot = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        Taxonomy = c.String(maxLength: 50, unicode: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCategories", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        PostID = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        Star = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        CategoryID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 250),
                        Slug = c.String(nullable: false, maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        PublishedDate = c.DateTime(),
                        ExpireDate = c.DateTime(),
                        IsComment = c.Boolean(),
                        DisplayOrder = c.Int(nullable: false),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescription = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        Visibility = c.String(nullable: false, maxLength: 50, unicode: false),
                        PasswordProtected = c.String(maxLength: 50, unicode: false),
                        IsTrash = c.Boolean(),
                        IsHot = c.Boolean(nullable: false),
                        IsHome = c.Boolean(nullable: false),
                        ViewCount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PostCategories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 100, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductComments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        ProductID = c.Int(nullable: false),
                        Comment = c.String(nullable: false),
                        Star = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Image = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500),
                        Image = c.String(nullable: false, maxLength: 500),
                        URL = c.String(maxLength: 500),
                        DisplayOrder = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Language = c.String(nullable: false, maxLength: 2, unicode: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        Department = c.String(maxLength: 250),
                        Skype = c.String(maxLength: 100),
                        Mobile = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100),
                        Facebook = c.String(maxLength: 250),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 250, unicode: false),
                        Value = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 128),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(maxLength: 128),
                        VisitedDate = c.DateTime(),
                        IPAddress = c.String(maxLength: 20, unicode: false),
                        Browser = c.String(maxLength: 250),
                        OperateSystem = c.String(maxLength: 100),
                        OutVisitedDate = c.DateTime(),
                        VisitedTime = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Widgets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductImages", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductComments", "ProductID", "dbo.Products");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.PostComments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.PostCategories", "ParentID", "dbo.PostCategories");
            DropForeignKey("dbo.PaymentTransactions", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.PageComments", "PageID", "dbo.Pages");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductCategories", "ParentID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ShippingID", "dbo.Shippings");
            DropForeignKey("dbo.Shippings", "ShippingMethodID", "dbo.ShippingMethods");
            DropForeignKey("dbo.Shippings", "AreaID", "dbo.Areas");
            DropForeignKey("dbo.Orders", "PaymentMethodID", "dbo.PaymentMethods");
            DropForeignKey("dbo.Orders", "CouponID", "dbo.Coupons");
            DropForeignKey("dbo.MenuDetails", "MenuID", "dbo.Menus");
            DropForeignKey("dbo.Areas", "CountryID", "dbo.Countries");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.ProductImages", new[] { "ProductID" });
            DropIndex("dbo.ProductComments", new[] { "ProductID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.PostComments", new[] { "PostID" });
            DropIndex("dbo.PostCategories", new[] { "ParentID" });
            DropIndex("dbo.PaymentTransactions", new[] { "OrderID" });
            DropIndex("dbo.PageComments", new[] { "PageID" });
            DropIndex("dbo.ProductCategories", new[] { "ParentID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Shippings", new[] { "AreaID" });
            DropIndex("dbo.Shippings", new[] { "ShippingMethodID" });
            DropIndex("dbo.Orders", new[] { "PaymentMethodID" });
            DropIndex("dbo.Orders", new[] { "CouponID" });
            DropIndex("dbo.Orders", new[] { "ShippingID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.MenuDetails", new[] { "MenuID" });
            DropIndex("dbo.Areas", new[] { "CountryID" });
            DropTable("dbo.Widgets");
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.Templates");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Slides");
            DropTable("dbo.ProductTags");
            DropTable("dbo.ProductImages");
            DropTable("dbo.ProductComments");
            DropTable("dbo.Tags");
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostComments");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Plugins");
            DropTable("dbo.PaymentTransactions");
            DropTable("dbo.Pages");
            DropTable("dbo.PageComments");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.ShippingMethods");
            DropTable("dbo.Shippings");
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuDetails");
            DropTable("dbo.Languages");
            DropTable("dbo.Coupons");
            DropTable("dbo.Controls");
            DropTable("dbo.Contacts");
            DropTable("dbo.ContactFields");
            DropTable("dbo.Countries");
            DropTable("dbo.Areas");
            DropTable("dbo.Advertisings");
        }
    }
}
