﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entities
{
  public  class Accomodation
    {
        public int Id { get; set; }
        public int AccomodationPackageId { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}