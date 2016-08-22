﻿/*
 
 * Author:	Bob Limnor (info@limnor.com)
 * Project: Limnor Studio
 * Item:	Visual Object Builder Utility
 * License: GNU General Public License v3.0
 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace VPL
{
	public interface ISupportWebClientMethods
	{
		void CreateActionJavaScript(string codeName, string methodName, StringCollection sb, StringCollection parameters, string returnReceiver);
	}
}
