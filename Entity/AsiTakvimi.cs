﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace WebProje.Entity
{
    public class AsiTakvimi
    {
        public int id { get; set; }
        public string asi_adi { get; set; }
        public DateTime asi_tarihi { get; set; }
        public bool asi_durumu { get; set; }

        public int kayitli_hayvan_id { get; set; }
        public virtual KayitliHayvanlar hayvan { get; set; }
    }
}
