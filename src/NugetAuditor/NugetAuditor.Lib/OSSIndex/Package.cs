﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetAuditor.Lib.OSSIndex
{
	public class Package
	{
		public string Coordinates { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public List<Vulnerability> Vulnerabilities { get; set; }
	}
}
