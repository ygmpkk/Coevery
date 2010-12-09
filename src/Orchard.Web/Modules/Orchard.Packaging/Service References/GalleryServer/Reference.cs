//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 12/8/2010 3:18:34 PM
namespace Orchard.Packaging.GalleryServer
{
    
    /// <summary>
    /// There are no comments for GalleryFeedContext in the schema.
    /// </summary>
    public partial class GalleryFeedContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new GalleryFeedContext object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public GalleryFeedContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Gallery.Infrastructure.FeedModels", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Orchard.Packaging.GalleryServer", typeName.Substring(33)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Orchard.Packaging.GalleryServer", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Gallery.Infrastructure.FeedModels.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Packages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<PublishedPackage> Packages
        {
            get
            {
                if ((this._Packages == null))
                {
                    this._Packages = base.CreateQuery<PublishedPackage>("Packages");
                }
                return this._Packages;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<PublishedPackage> _Packages;
        /// <summary>
        /// There are no comments for Screenshots in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<PublishedScreenshot> Screenshots
        {
            get
            {
                if ((this._Screenshots == null))
                {
                    this._Screenshots = base.CreateQuery<PublishedScreenshot>("Screenshots");
                }
                return this._Screenshots;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<PublishedScreenshot> _Screenshots;
        /// <summary>
        /// There are no comments for Packages in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPackages(PublishedPackage publishedPackage)
        {
            base.AddObject("Packages", publishedPackage);
        }
        /// <summary>
        /// There are no comments for Screenshots in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToScreenshots(PublishedScreenshot publishedScreenshot)
        {
            base.AddObject("Screenshots", publishedScreenshot);
        }
    }
    /// <summary>
    /// There are no comments for Gallery.Infrastructure.FeedModels.PublishedPackage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// Version
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id", "Version")]
    public partial class PublishedPackage
    {
        /// <summary>
        /// Create a new PublishedPackage object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="version">Initial value of Version.</param>
        /// <param name="downloadCount">Initial value of DownloadCount.</param>
        /// <param name="packageSize">Initial value of PackageSize.</param>
        /// <param name="rating">Initial value of Rating.</param>
        /// <param name="ratingCount">Initial value of RatingCount.</param>
        /// <param name="price">Initial value of Price.</param>
        /// <param name="requireLicenseAcceptance">Initial value of RequireLicenseAcceptance.</param>
        /// <param name="isLatestVersion">Initial value of IsLatestVersion.</param>
        /// <param name="created">Initial value of Created.</param>
        /// <param name="lastUpdated">Initial value of LastUpdated.</param>
        /// <param name="published">Initial value of Published.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static PublishedPackage CreatePublishedPackage(string ID, string version, int downloadCount, long packageSize, double rating, int ratingCount, decimal price, bool requireLicenseAcceptance, bool isLatestVersion, global::System.DateTime created, global::System.DateTime lastUpdated, global::System.DateTime published)
        {
            PublishedPackage publishedPackage = new PublishedPackage();
            publishedPackage.Id = ID;
            publishedPackage.Version = version;
            publishedPackage.DownloadCount = downloadCount;
            publishedPackage.PackageSize = packageSize;
            publishedPackage.Rating = rating;
            publishedPackage.RatingCount = ratingCount;
            publishedPackage.Price = price;
            publishedPackage.RequireLicenseAcceptance = requireLicenseAcceptance;
            publishedPackage.IsLatestVersion = isLatestVersion;
            publishedPackage.Created = created;
            publishedPackage.LastUpdated = lastUpdated;
            publishedPackage.Published = published;
            return publishedPackage;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Id;
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Authors in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Authors
        {
            get
            {
                return this._Authors;
            }
            set
            {
                this.OnAuthorsChanging(value);
                this._Authors = value;
                this.OnAuthorsChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Authors;
        partial void OnAuthorsChanging(string value);
        partial void OnAuthorsChanged();
        /// <summary>
        /// There are no comments for Property PackageType in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PackageType
        {
            get
            {
                return this._PackageType;
            }
            set
            {
                this.OnPackageTypeChanging(value);
                this._PackageType = value;
                this.OnPackageTypeChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PackageType;
        partial void OnPackageTypeChanging(string value);
        partial void OnPackageTypeChanged();
        /// <summary>
        /// There are no comments for Property Summary in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Summary
        {
            get
            {
                return this._Summary;
            }
            set
            {
                this.OnSummaryChanging(value);
                this._Summary = value;
                this.OnSummaryChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Summary;
        partial void OnSummaryChanging(string value);
        partial void OnSummaryChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DownloadCount in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int DownloadCount
        {
            get
            {
                return this._DownloadCount;
            }
            set
            {
                this.OnDownloadCountChanging(value);
                this._DownloadCount = value;
                this.OnDownloadCountChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _DownloadCount;
        partial void OnDownloadCountChanging(int value);
        partial void OnDownloadCountChanged();
        /// <summary>
        /// There are no comments for Property Copyright in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Copyright
        {
            get
            {
                return this._Copyright;
            }
            set
            {
                this.OnCopyrightChanging(value);
                this._Copyright = value;
                this.OnCopyrightChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Copyright;
        partial void OnCopyrightChanging(string value);
        partial void OnCopyrightChanged();
        /// <summary>
        /// There are no comments for Property PackageHashAlgorithm in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PackageHashAlgorithm
        {
            get
            {
                return this._PackageHashAlgorithm;
            }
            set
            {
                this.OnPackageHashAlgorithmChanging(value);
                this._PackageHashAlgorithm = value;
                this.OnPackageHashAlgorithmChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PackageHashAlgorithm;
        partial void OnPackageHashAlgorithmChanging(string value);
        partial void OnPackageHashAlgorithmChanged();
        /// <summary>
        /// There are no comments for Property PackageHash in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PackageHash
        {
            get
            {
                return this._PackageHash;
            }
            set
            {
                this.OnPackageHashChanging(value);
                this._PackageHash = value;
                this.OnPackageHashChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PackageHash;
        partial void OnPackageHashChanging(string value);
        partial void OnPackageHashChanged();
        /// <summary>
        /// There are no comments for Property PackageSize in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public long PackageSize
        {
            get
            {
                return this._PackageSize;
            }
            set
            {
                this.OnPackageSizeChanging(value);
                this._PackageSize = value;
                this.OnPackageSizeChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private long _PackageSize;
        partial void OnPackageSizeChanging(long value);
        partial void OnPackageSizeChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _Rating;
        partial void OnRatingChanging(double value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property RatingCount in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int RatingCount
        {
            get
            {
                return this._RatingCount;
            }
            set
            {
                this.OnRatingCountChanging(value);
                this._RatingCount = value;
                this.OnRatingCountChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _RatingCount;
        partial void OnRatingCountChanging(int value);
        partial void OnRatingCountChanged();
        /// <summary>
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public decimal Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private decimal _Price;
        partial void OnPriceChanging(decimal value);
        partial void OnPriceChanged();
        /// <summary>
        /// There are no comments for Property RequireLicenseAcceptance in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool RequireLicenseAcceptance
        {
            get
            {
                return this._RequireLicenseAcceptance;
            }
            set
            {
                this.OnRequireLicenseAcceptanceChanging(value);
                this._RequireLicenseAcceptance = value;
                this.OnRequireLicenseAcceptanceChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _RequireLicenseAcceptance;
        partial void OnRequireLicenseAcceptanceChanging(bool value);
        partial void OnRequireLicenseAcceptanceChanged();
        /// <summary>
        /// There are no comments for Property IsLatestVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool IsLatestVersion
        {
            get
            {
                return this._IsLatestVersion;
            }
            set
            {
                this.OnIsLatestVersionChanging(value);
                this._IsLatestVersion = value;
                this.OnIsLatestVersionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _IsLatestVersion;
        partial void OnIsLatestVersionChanging(bool value);
        partial void OnIsLatestVersionChanged();
        /// <summary>
        /// There are no comments for Property Created in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Created
        {
            get
            {
                return this._Created;
            }
            set
            {
                this.OnCreatedChanging(value);
                this._Created = value;
                this.OnCreatedChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Created;
        partial void OnCreatedChanging(global::System.DateTime value);
        partial void OnCreatedChanged();
        /// <summary>
        /// There are no comments for Property LastUpdated in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime LastUpdated
        {
            get
            {
                return this._LastUpdated;
            }
            set
            {
                this.OnLastUpdatedChanging(value);
                this._LastUpdated = value;
                this.OnLastUpdatedChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _LastUpdated;
        partial void OnLastUpdatedChanging(global::System.DateTime value);
        partial void OnLastUpdatedChanged();
        /// <summary>
        /// There are no comments for Property Published in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Published
        {
            get
            {
                return this._Published;
            }
            set
            {
                this.OnPublishedChanging(value);
                this._Published = value;
                this.OnPublishedChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Published;
        partial void OnPublishedChanging(global::System.DateTime value);
        partial void OnPublishedChanged();
        /// <summary>
        /// There are no comments for Property ExternalPackageUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ExternalPackageUrl
        {
            get
            {
                return this._ExternalPackageUrl;
            }
            set
            {
                this.OnExternalPackageUrlChanging(value);
                this._ExternalPackageUrl = value;
                this.OnExternalPackageUrlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ExternalPackageUrl;
        partial void OnExternalPackageUrlChanging(string value);
        partial void OnExternalPackageUrlChanged();
        /// <summary>
        /// There are no comments for Property ProjectUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ProjectUrl
        {
            get
            {
                return this._ProjectUrl;
            }
            set
            {
                this.OnProjectUrlChanging(value);
                this._ProjectUrl = value;
                this.OnProjectUrlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ProjectUrl;
        partial void OnProjectUrlChanging(string value);
        partial void OnProjectUrlChanged();
        /// <summary>
        /// There are no comments for Property LicenseUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string LicenseUrl
        {
            get
            {
                return this._LicenseUrl;
            }
            set
            {
                this.OnLicenseUrlChanging(value);
                this._LicenseUrl = value;
                this.OnLicenseUrlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _LicenseUrl;
        partial void OnLicenseUrlChanging(string value);
        partial void OnLicenseUrlChanged();
        /// <summary>
        /// There are no comments for Property IconUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string IconUrl
        {
            get
            {
                return this._IconUrl;
            }
            set
            {
                this.OnIconUrlChanging(value);
                this._IconUrl = value;
                this.OnIconUrlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _IconUrl;
        partial void OnIconUrlChanging(string value);
        partial void OnIconUrlChanged();
        /// <summary>
        /// There are no comments for Property ReportAbuseUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ReportAbuseUrl
        {
            get
            {
                return this._ReportAbuseUrl;
            }
            set
            {
                this.OnReportAbuseUrlChanging(value);
                this._ReportAbuseUrl = value;
                this.OnReportAbuseUrlChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ReportAbuseUrl;
        partial void OnReportAbuseUrlChanging(string value);
        partial void OnReportAbuseUrlChanged();
        /// <summary>
        /// There are no comments for Property Categories in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Categories
        {
            get
            {
                return this._Categories;
            }
            set
            {
                this.OnCategoriesChanging(value);
                this._Categories = value;
                this.OnCategoriesChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Categories;
        partial void OnCategoriesChanging(string value);
        partial void OnCategoriesChanged();
        /// <summary>
        /// There are no comments for Property Tags in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Tags
        {
            get
            {
                return this._Tags;
            }
            set
            {
                this.OnTagsChanging(value);
                this._Tags = value;
                this.OnTagsChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Tags;
        partial void OnTagsChanging(string value);
        partial void OnTagsChanged();
        /// <summary>
        /// There are no comments for Property Dependencies in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Dependencies
        {
            get
            {
                return this._Dependencies;
            }
            set
            {
                this.OnDependenciesChanging(value);
                this._Dependencies = value;
                this.OnDependenciesChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Dependencies;
        partial void OnDependenciesChanging(string value);
        partial void OnDependenciesChanged();
        /// <summary>
        /// There are no comments for Screenshots in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Collections.ObjectModel.Collection<PublishedScreenshot> Screenshots
        {
            get
            {
                return this._Screenshots;
            }
            set
            {
                if ((value != null))
                {
                    this._Screenshots = value;
                }
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Collections.ObjectModel.Collection<PublishedScreenshot> _Screenshots = new global::System.Collections.ObjectModel.Collection<PublishedScreenshot>();
    }
    /// <summary>
    /// There are no comments for Gallery.Infrastructure.FeedModels.PublishedScreenshot in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class PublishedScreenshot
    {
        /// <summary>
        /// Create a new PublishedScreenshot object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static PublishedScreenshot CreatePublishedScreenshot(int ID)
        {
            PublishedScreenshot publishedScreenshot = new PublishedScreenshot();
            publishedScreenshot.Id = ID;
            return publishedScreenshot;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property PublishedPackageId in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PublishedPackageId
        {
            get
            {
                return this._PublishedPackageId;
            }
            set
            {
                this.OnPublishedPackageIdChanging(value);
                this._PublishedPackageId = value;
                this.OnPublishedPackageIdChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PublishedPackageId;
        partial void OnPublishedPackageIdChanging(string value);
        partial void OnPublishedPackageIdChanged();
        /// <summary>
        /// There are no comments for Property PublishedPackageVersion in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PublishedPackageVersion
        {
            get
            {
                return this._PublishedPackageVersion;
            }
            set
            {
                this.OnPublishedPackageVersionChanging(value);
                this._PublishedPackageVersion = value;
                this.OnPublishedPackageVersionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PublishedPackageVersion;
        partial void OnPublishedPackageVersionChanging(string value);
        partial void OnPublishedPackageVersionChanged();
        /// <summary>
        /// There are no comments for Property ScreenshotUri in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string ScreenshotUri
        {
            get
            {
                return this._ScreenshotUri;
            }
            set
            {
                this.OnScreenshotUriChanging(value);
                this._ScreenshotUri = value;
                this.OnScreenshotUriChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _ScreenshotUri;
        partial void OnScreenshotUriChanging(string value);
        partial void OnScreenshotUriChanged();
        /// <summary>
        /// There are no comments for Property Caption in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Caption
        {
            get
            {
                return this._Caption;
            }
            set
            {
                this.OnCaptionChanging(value);
                this._Caption = value;
                this.OnCaptionChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Caption;
        partial void OnCaptionChanging(string value);
        partial void OnCaptionChanged();
    }
}
