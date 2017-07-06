(function($) {
	'use strict';	
	$('#bg-home').vegas({
        slides: [
            { src: "img/slider/slider-bg20.jpg" },
            { src: "img/slider/slider-bg20.jpg" },
            { src: "img/slider/slider-bg20.jpg" }
        ],
        animation: [ 'kenburnsLeft', 'kenburnsRight','kenburnsUp', 'kenburnsUpLeft', 'kenburnsUpRight','kenburnsDown', 'kenburnsDownLeft', 'kenburnsDownRight' ],
		transition: 'zoomOut2',
        transitionDuration:5000,
        delay:10000,
		valign: 'top',
    });
	
	var heightBg = function(){
		var getHeightHome = $(".home").outerHeight();
		$(".bg-home").height(getHeightHome);
	}
	$(window).on("load", heightBg);
	$(window).on("resize", heightBg);
})(jQuery);