using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace _nilnul.cfg_
{
	public static class _CachedX
	{
		public static Configuration MethodName()
		{
			//	Since the assembly resides in a temporary cache, you should combine the path to get the dll's config:

			Configuration appConfig = ConfigurationManager.OpenExeConfiguration(
				Path.Combine(
					Environment.CurrentDirectory
					, 
					Assembly.GetExecutingAssembly().ManifestModule.Name
				)
			);

			return appConfig;
		}
	}
}
