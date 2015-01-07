using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;
using NancyHighcharts_sample.Models;

namespace NancyHighcharts_sample.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "hello world";


            Get["/json"] = _ =>
            {
                var webpage = new WebPageModel() { Title = "さつまいも編", H1 = "さつまいもグラフ", CurrentDatetime = DateTime.Now.ToString() };
                return View["json", webpage];
            };


            Get["/jsonp"] = _ =>
            {
                var webpage = new WebPageModel() { Title = "りんご編", H1 = "りんごグラフ", CurrentDatetime = DateTime.Now.ToString() };
                return View["jsonp", webpage];
            };


            Get["/api/json"] = _ =>
            {
                var potato = new PotatoModel[]
                {
                    new PotatoModel(){ Name = "紅はるか", Amount = 20, Color = "Pink"},
                    new PotatoModel(){ Name = "ベニアズマ", Amount = 10, Color = "DarkViolet"},
                    new PotatoModel(){ Name = "金時いも", Amount = 5, Color = "MistyRose"},
                };
                return Response.AsJson(potato);
            };
        }
    }
}
