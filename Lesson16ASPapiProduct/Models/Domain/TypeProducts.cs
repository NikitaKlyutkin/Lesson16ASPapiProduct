using System;
using System.ComponentModel;

namespace Lesson16ASPapiProduct.Models.Domain
{
    public enum TypeProducts
    {
        [Description("Food")]
        Food,
        [Description("Machinery")]
        Machinery,
        [Description("Chemicals")]
        Chemicals
    }

}
