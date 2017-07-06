using System.Web;
using System.Web.Optimization;

namespace TweeterReader.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/respond.js",
                      "~/Content/js/AnimatedHeader/EasePack.min.js", "~/Content/js/AnimatedHeader/rAF.js", "~/Content/js/AnimatedHeader/setting.js", "~/Content/js/AnimatedHeader/TweenLite.min.js",
                      "~/Content/js/autoheight/jquery.matchHeight.js", "~/Content/js/autoheight/setting.js",
                      "~/Content/js/countdown/jquery.countdown.min.js", "~/Content/js/countdown/lodash.min.js", "~/Content/js/countdown/setting.js",
                      "~/Content/js/crossslide/jquery.cross-slide.js", "~/Content/js/crossslide/setting.js",
                      "~/Content/js/cubeportfolio/fullwidth.js", "~/Content/js/cubeportfolio/jquery.cubeportfolio.min.js", "~/Content/js/cubeportfolio/masonry-3column.js", "~/Content/js/cubeportfolio/masonry-4column.js", "~/Content/js/cubeportfolio/masonry-nopadding.js", "~/Content/js/cubeportfolio/masonry-projects-2column.js", "~/Content/js/cubeportfolio/masonry-projects-3column.js", "~/Content/js/cubeportfolio/masonry-projects-4column.js", "~/Content/js/cubeportfolio/masonry-projects.js", "~/Content/js/cubeportfolio/masonry.js", "~/Content/js/cubeportfolio/mosaic.js",
                      "~/Content/js/custominput/custom-file-input.js", "~/Content/js/custominput/modernizr.js",
                      "~/Content/js/filmroll/jquery.film_roll.min.js", "~/Content/js/filmroll/setting.js",
                      "~/Content/js/flexslider/jquery.flexslider.min.js", "~/Content/js/flexslider/setting.js",
                      "~/Content/js/form/jcf.js", "~/Content/js/form/jcf.scrollable.js", "~/Content/js/form/jcf.select.js",
                      "~/Content/js/funnytext/jquery.funnyText.js", "~/Content/js/funnytext/setting.js",
                      "~/Content/js/google-code-prettify/lang-css.js",
                      "~/Content/js/google-code-prettify/prettify.js",
                      "~/Content/js/jplayer/jquery.jplayer.js",
                      "~/Content/js/jplayer/setting.js",
                      "~/Content/js/maps/setting.js",
                      "~/Content/js/masonry/masonry.min.js", "~/Content/js/masonry/setting.js",
                      "~/Content/js/offcanvas/classie.js", "~/Content/js/offcanvas/setting.js",
                      "~/Content/js/owlcarousel/owl.carousel.min.js", "~/Content/js/owlcarousel/setting.js",
                      "~/Content/js/parallax/jquery.parallax-1.1.3.js", "~/Content/js/parallax/setting.js",
                      "~/Content/js/rangeSlider/ion.rangeSlider.min.js", "~/Content/js/rangeSlider/setting.js",
                      "~/Content/js/raty/jquery.raty.min.js", "~/Content/js/masonry/raty/setting.js",
                      "~/Content/js/revolution/setting/agency-revolution-slider.js", "~/Content/js/revolution/setting/boxed-revolution-slider.js", "~/Content/js/revolution/setting/clean-revolution-slider.js", "~/Content/js/revolution/setting/corporate-revolution-slider.js", "~/Content/js/revolution/setting/creative-slide.js", "~/Content/js/revolution/setting/minimalist-revolution.js", "~/Content/js/revolution/setting/revolution-sidebar-nav.js",
                      "~/Content/js/revolution/jquery.themepunch.revolution.min.js", "~/Content/js/revolution/jquery.themepunch.tool.min.js", "~/Content/js/revolution/revolution.extension.actions.min.js", "~/Content/js/revolution/revolution.extension.carousel.min.js", "~/Content/js/revolution/revolution.extension.kenburn.min.js", "~/Content/js/revolution/revolution.extension.layeranimation.min.js", "~/Content/js/revolution/revolution.extension.migration.min.js", "~/Content/js/revolution/revolution.extension.navigation.min.js", "~/Content/js/revolution/revolution.extension.parallax.min.js", "~/Content/js/revolution/revolution.extension.slideanims.min.js", "~/Content/js/revolution/revolution.extension.video.min.js",
                      "~/Content/js/scrollbar/jquery.mCustomScrollbar.concat.min.js",
                      "~/Content/js/template-option/demosetting.js",
                      "~/Content/js/textillate/jquery.fittext.js", "~/Content/js/textillate/jquery.lettering.js", "~/Content/js/textillate/jquery.textillate.js", "~/Content/js/textillate/setting.js",
                      "~/Content/js/twitter/bower.json", "~/Content/js/twitter/setting.js", "~/Content/js/twitter/ticker.js", "~/Content/js/twitter/tweetie.jquery.json", "~/Content/js/twitter/tweetie.min.js",
                      "~/Content/js/typer/jquery-typer.js", "~/Content/js/typer/setting.js",
                      "~/Content/js/validation/jquery.validate.min.js", "~/Content/js/validation/setting.js",
                      "~/Content/js/vegas/setting.js", "~/Content/js/vegas/vegas.js",
                      "~/Content/js/widetext/jQuery.wideText.js", "~/Content/js/widetext/setting.js"
                      //"~/Content/js/google-code-prettify/lang-apollo.js", "~/Content/js/google-code-prettify/lang-clj.js", 
                      //"~/Content/js/google-code-prettify/lang-go.js", "~/Content/js/google-code-prettify/lang-hs.js", "~/Content/js/google-code-prettify/lang-lisp.js", "~/Content/js/google-code-prettify/lang-lua.js", "~/Content/js/google-code-prettify/lang-ml.js", "~/Content/js/google-code-prettify/lang-n.js", "~/Content/js/google-code-prettify/lang-proto.js", "~/Content/js/google-code-prettify/lang-scala.js", "~/Content/js/google-code-prettify/lang-sql.js", "~/Content/js/google-code-prettify/lang-tex.js", "~/Content/js/google-code-prettify/lang-vb.js", "~/Content/js/google-code-prettify/lang-vhdl.js", "~/Content/js/google-code-prettify/lang-wiki.js", "~/Content/js/google-code-prettify/lang-xq.js", "~/Content/js/google-code-prettify/lang-yaml.js", 
                      //"~/Content/js/checkator/fm.checkator.jquery.js", "~/Content/js/checkator/setting.js",
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/style.css",
                      "~/Content/animate.css",
                      "~/Content/bootsnav.css",
                      "~/Content/cubeportfolio.min.css",
                      "~/Content/custom-file-input.css",
                      "~/Content/flexslider.css",
                      "~/Content/ie10-viewport-bug-workaround.css",
                      "~/Content/ion.rangeSlider.css",
                      "~/Content/jquery.funnyText.css",
                      "~/Content/jquery.mCustomScrollbar.css",
                      "~/Content/masonry.css",
                      "~/Content/misty.css",
                      "~/Content/overwrite.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css",
                      "~/Content/owl.transitions.css",
                      "~/Content/prettify.css",
                      "~/Content/vegas.css",
                      "~/Content/revolution/layers.css",
                      "~/Content/revolution/navigation.css",
                      "~/Content/revolution/settings.css"));
        }
    }
}
