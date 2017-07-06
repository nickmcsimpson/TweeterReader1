(function ($) {
    "use strict";
	$("#recent-full").owlCarousel({
		autoPlay: 6000,
		items : 4,
		navigation : false,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 3],
	});
	
	$("#recent-column4").owlCarousel({
		autoPlay: 3000,
		items : 4,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 3],
	});
	
	$("#full-column4").owlCarousel({
		autoPlay: 8000,
		items : 4,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 3],
	});
	
	$("#recent-column3").owlCarousel({
		autoPlay: 3000,
		items : 3,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 1],
	});
	
	$("#owl-services").owlCarousel({
		autoPlay: false,
		items : 3,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 1],
	});
	
	$("#team").owlCarousel({
		autoPlay: false,
		items : 4,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,2],
		itemsTablet : [768, 2],
	});
    
    $("#recent-products").owlCarousel({
		autoPlay: false,
		items : 4,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [768, 3],
	});
    
    $("#popular-place").owlCarousel({
		autoPlay: false,
		items : 3,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,3],
		itemsTablet : [920,3],
		itemsTabletSmall : [767,2],
	});
	
    //altered this to try and make it not act funky.
    $("#testimoni").owlCarousel({
		autoPlay: false,
		singleItem : true,
		navigation : true,
		pagination : true,
	});

	$("#testimoni-column3").owlCarousel({
		autoPlay: 3000,
		items : 3,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,3],
        itemsDesktopSmall : [979,2],
		itemsTablet : [768, 1],
	});
	
	$("#clients").owlCarousel({
		autoPlay: false,
		items : 6,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,5],
        itemsDesktopSmall : [979,5],
		itemsTablet : [920,4],
		itemsTabletSmall : [767,3],
	});
    
    $("#clients2").owlCarousel({
		autoPlay: 10000,
		items : 3,
		navigation : false,
		pagination : false,
		itemsDesktop : [1199,4],
        itemsDesktopSmall : [1024,3],
		itemsTablet : [768,3],
		itemsMobile : [480,1]
	});
    
    $("#team-fullwidth").owlCarousel({
		autoPlay: 8000,
		items : 1,
		navigation : true,
		pagination : false,
		itemsDesktop : [1199,1],
        itemsDesktopSmall : [979,1],
		itemsTablet : [768,1],
	});
	
	$("#recent-comments").owlCarousel({
		autoPlay: 5000,
		singleItem : true,
		navigation : true,
		pagination : false,
	});
    
    $("#slider-app").owlCarousel({
        navigation : false,
        pagination : false,
        slideSpeed : 300,
        paginationSpeed : 400,
        singleItem:true,
        autoPlay : 3000
    });
})(jQuery);