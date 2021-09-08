using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;



namespace PortKatmanli.MvcWebUI.HtmlHelpers
{
    public static class PagingHelper
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagingInfo pagingInfo)
        {
            int totalPage = (int)Math.Ceiling((decimal)pagingInfo.ToplamItem / pagingInfo.SayfaBasiItem);

            

            var stringBuilder = new StringBuilder();

            stringBuilder.Append("<div class = 'pagination'>");
            for (int i = 1; i < totalPage + 1; i++)
            {
                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttribute("href", String.Format(format: "/Rule/Index/?page={0}", i));
                tagBuilder.InnerHtml = i.ToString();

                if (pagingInfo.SuAnkiSayfa == i)
                {
                    tagBuilder.AddCssClass("seciliLink");
                }

                stringBuilder.Append(tagBuilder);    
            }

            stringBuilder.Append("</div>");

            return MvcHtmlString.Create(stringBuilder.ToString());
        }
    }
}