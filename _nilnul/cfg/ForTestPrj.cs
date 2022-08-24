using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._nilnul.cfg
{
	class ForTestPrj
	{
		/*In response to the original question, I typically add the config file in my test project as a link; you can then use the DeploymentItem attribute to addit to the Out folder of the test run.
[TestClass]
[DeploymentItem("MyProject.Cache.dll.config")]
public class CacheTest
{
    .
    .
    .
    .
}
In response to the comments that Assemblies can't be project specific, they can and it provides great flexibility esp. when working with IOC frameworks.*/
	}
}
