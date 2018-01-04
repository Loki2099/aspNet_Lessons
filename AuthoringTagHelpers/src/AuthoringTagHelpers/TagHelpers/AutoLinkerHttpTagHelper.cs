using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.RegularExpressions;

namespace AuthoringTagHelpers.TagHelpers
{
	[HtmlTargetElement("p")]
	public class AutoLinkerHttpTagHelper : TagHelper
	{
		public override int Order
		{
			get{return int.MinValue; }
			//get { return int.MinValue; }
		}

		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			//var childContent = await output.GetChildContentAsync();
			//output.Content.SetHtmlContent(Regex.Replace(childContent.GetContent(), @"\b(?:https?://)(\S+)\b", "<a target=\"_blank\" href=\"$0\">$0</a>"));

			var childContent = output.Content.IsModified ? output.Content.GetContent() : (await output.GetChildContentAsync()).GetContent();
			output.Content.SetHtmlContent(Regex.Replace(childContent, @"\b(?:https?://)(\S+)\b", "<a target=\"_blank\" href=\"$0\">$0</a>"));
		}
	}


	[HtmlTargetElement("p")]
	public class AutoLinkerWwwTagHelper : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			//var childContent = await output.GetChildContentAsync();
			//output.Content.SetHtmlContent(Regex.Replace(childContent.GetContent(), @"\b(www\.)(\S+)\b", "<a target=\"_blank\" href=\"http://$0\">$0</a>"));

			var childContent = output.Content.IsModified ? output.Content.GetContent() : (await output.GetChildContentAsync()).GetContent();
			output.Content.SetHtmlContent(Regex.Replace(childContent, @"\b(www\.)(\S+)\b", "<a target=\"_blank\" href=\"http://$0\">$0</a>"));
		}
	}
}
