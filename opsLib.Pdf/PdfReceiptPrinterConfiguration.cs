﻿using opsLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opsLib.Pdf
{
    public class PdfReceiptPrinterConfiguration : IReceiptPrinterConfiguration
    {
        public string PrinterName { get; set; }
    }
}
