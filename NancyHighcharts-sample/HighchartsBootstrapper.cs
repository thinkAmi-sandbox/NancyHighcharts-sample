using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nancy;

namespace NancyHighcharts_sample
{
    public class HighchartsBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(Nancy.Conventions.NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            // Scriptsディレクトリ以下のファイルを静的コンテンツとして扱うようにする。
            nancyConventions.StaticContentsConventions.Add(
                Nancy.Conventions.StaticContentConventionBuilder.AddDirectory("Scripts")
            );
        }
    }
}
