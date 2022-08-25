// --------------------------------------------------------------------------------------------------
// <copyright file="UploadType.cs" company="AccentDesign">
// </copyright>
// --------------------------------------------------------------------------------------------------

using System.ComponentModel;

namespace Shared.DTOs.Upload
{
    public enum UploadType
    {
        [Description(@"Images\Catalog\Products")]
        Product,

        [Description(@"Images\Catalog\Brands")]
        Brand,

        [Description(@"Images\Catalog\Categories")]
        Category,

        [Description(@"Images\People\Customers")]
        Customer
    }
}