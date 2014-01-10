﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jufine.Backend.WebModel;


namespace Jufine.Backend.Security.WebUI
{
	public partial class Welcome : PageBase
	{
		public override bool IsNeedLogin
		{
			get
			{
				return true;
			}
		}
        public override bool IsNeedAuth
        {
            get
            {
                return false;
            }
        }
	}
}