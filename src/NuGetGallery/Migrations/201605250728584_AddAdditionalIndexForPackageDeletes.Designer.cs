// <auto-generated />
namespace NuGetGallery.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddAdditionalIndexForPackageDeletes : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddAdditionalIndexForPackageDeletes));
        
        string IMigrationMetadata.Id
        {
            get { return "201605250728584_AddAdditionalIndexForPackageDeletes"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}