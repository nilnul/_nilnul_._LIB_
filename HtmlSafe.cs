using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace nilnul
{
	static public partial class HtmlSafeX
	{

		static public string Validate(this XmlNode node)
		{
			//if (node.NodeType == XmlNodeType.Text)
			//{
			//    //ok
			//    return null;

			//}

			if (AllowedTag.Contains(node.Name.ToLower()))
			{
				return Validate(node.ChildNodes);

			}

			return "Invalide Node:" + node.Name;


		}

		static public string Validate(this string s) {
			XmlDocument doc = new XmlDocument();


			XmlDocumentFragment r = doc.CreateDocumentFragment();
			try
			{
				r.InnerXml = s;

				return Validate(r.ChildNodes);



			}
			catch (Exception e)
			{

				return e.Message;
			}

				
		}

		static public string Validate(this XmlNodeList nodeList)
		{

			for (int i = 0; i < nodeList.Count; i++)
			{
				var t=Validate(nodeList[i]);
				if (t!=null)
				{
					return  nodeList[i].ToString() + t;
					
				}
				
			}
			return null;
		}




		public static string[] AllowedTag = { "p","br", "sub", "sup", "svg", "img", "table", "tb", "tr", "span", "div", "mathml","#text" };


		//public string explantion;
	}
}
