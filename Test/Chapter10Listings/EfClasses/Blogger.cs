﻿// Copyright (c) 2018 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Test.Chapter10Listings.EfClasses
{
    public class Blogger
    {
        public int BloggerId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}