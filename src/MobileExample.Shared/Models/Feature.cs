// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feature.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace MobileExample.Models
{
    using Catel.Data;

    public class Feature : ModelBase
    {
        public Feature()
        {
            
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public object Tag { get; set; }
    }
}