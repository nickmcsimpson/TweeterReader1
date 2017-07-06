(function ($) {
	"use strict";
    
    /*
    Gallery Masonry
    =========================== */
    var masonryGrid = function(){
        var self = $("#gallery");
        self.masonry({
            isAnimated: true,
            columnWidth:".grid-sizer",
            itemSelector: ".grid-item"
        });
    }
    
    masonryGrid();
    $(window).on("load", function(){
        setTimeout(masonryGrid, 1000);
    });
})(jQuery);