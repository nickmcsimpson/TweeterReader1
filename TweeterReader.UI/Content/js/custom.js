(function ($) {
	"use strict";
    var core = {
        initialize: function() {
            this.event();
        },
        event : function(){
			// ------------------------------------------------------------------------------ //
			// Change navbar class
			// ------------------------------------------------------------------------------ //
			$(window).scroll(function(){
				var scrollTop = $(window).scrollTop();
				if(scrollTop != 0){
					$(".navbar-fixed").addClass("fixsticky");
					return false;
				} else {
					$(".navbar-fixed").removeClass("fixsticky");
					return false;
				}
			});
			
			// ------------------------------------------------------------------------------ //
			// Accordions
			// ------------------------------------------------------------------------------ //
            $(".panel-collapse").each(function(){
                if( $(this).hasClass("in") ){
                    $(this).closest(".panel").addClass("on");
                }
                
                var getId = $(this).attr("id");
                $("#" + getId).on('shown.bs.collapse', function () {
                    $(this).closest(".panel").addClass("on");
                });	
                
                $("#" + getId).on('hidden.bs.collapse', function () {
                    $(this).closest(".panel").removeClass("on");
                });	
            });

            // ------------------------------------------------------------------------------ //
			// Modal
			// ------------------------------------------------------------------------------ //
            $('.modal').on('show.bs.modal', function() {
                $(this).show();
                core.setModalMaxHeight(this);
            });
            
            // ------------------------------------------------------------------------------ //
			// Tabs
			// ------------------------------------------------------------------------------ //
            $(".custom-tabs, .tabbable").each(function(){
                var getEffect = $(this).data("effect-in");
                $(".tab-content > .tab-pane", this).addClass("animated");
                
                $('a[data-toggle="tab"]', this).on('show.bs.tab', function (e) {
                    var target = $(e.target).attr("href"),
                        relatedTarget = $(e.relatedTarget).attr("href");
                    $(relatedTarget).removeClass(getEffect);
                    $(target).addClass(getEffect);
                    setTimeout(function(){
                    }, 500);
                });
            });
			
            // ------------------------------------------------------------------------------ //
            // Toggle Search
            // ------------------------------------------------------------------------------ //
            $(".fullwidth-top").each(function(){  
                $(".search-icon", this).on("click", function(e){
                    e.preventDefault();
                    $(".hidden-search").slideToggle();
                });
            });
            $(".search-close").on("click", function(){
                $(".hidden-search").slideUp();
            });
			
			// ------------------------------------------------------------------------------ //
			//Clients hover
			// ------------------------------------------------------------------------------ //
			$(".client-hover").css({'opacity':'0','filter':'alpha(opacity=0)'});
			$(".client-logo").each(function(){
				$(this).on("mouseenter", function() {
					$(this).find('.client-default').stop().fadeTo(900, 0);
					$(this).find('.client-hover').stop().fadeTo(900, 1);
					return false;
				});
				$(this).on("mouseleave", function() {
					$(this).find('.client-default').stop().fadeTo(900, 1);
					$(this).find('.client-hover').stop().fadeTo(900, 0);
					return false;
				});
			});
			
			// ------------------------------------------------------------------------------ //
			// Grid gallery
			// ------------------------------------------------------------------------------ //
			$(".grider-column-captionWrap").css({'opacity':'0','filter':'alpha(opacity=0)'});
			$(".grider-column").each(function(){
				$(this).on("mouseenter", function() {
					$(this).find('.grider-column-captionWrap').stop().fadeTo(600, 1);
					return false;
				});
				$(this).on("mouseleave", function() {
					$(this).find('.grider-column-captionWrap').stop().fadeTo(600, 0);
					return false;
				});
			});
			
			// ------------------------------------------------------------------------------ //
			// to top
			// ------------------------------------------------------------------------------ //
            $(window).scroll(function(){
                var scrollTop2 = $(window).scrollTop();
                if(scrollTop2 >= 100){
                    $(".scrollToTop").stop().fadeIn();
					return false;
                } else {
                    $(".scrollToTop").stop().fadeOut();
					return false;
                }
            });
            $(".scrollToTop").on("click", function(e){
                e.preventDefault();
                $('html,body').animate({
                    scrollTop: 0
                }, 1000);
				return false;
            });

            // ------------------------------------------------------------------------------ //
			// Team hover
			// ------------------------------------------------------------------------------ //
			$(".team-wrapp").each(function(){
				var capZoomIn = $(".capZoomIn", this);
					$(".team-caption").addClass("animated");
					capZoomIn.addClass("zoomOut");
				$(this).on("mouseenter", function() {
					capZoomIn.addClass("zoomIn");
					capZoomIn.removeClass("zoomOut");
					return false;
				});
				$(this).on("mouseleave", function() {
					capZoomIn.addClass("zoomOut");
					capZoomIn.removeClass("zoomIn");
					return false;
				});
			});	
			
            // ------------------------------------------------------------------------------ //
			// Product hover
			// ------------------------------------------------------------------------------ //
			$(".product-wrapper").each(function(){
				var capZoomIn = $(".capZoomIn", this);
					$(".product-caption").addClass("animated");
					capZoomIn.addClass("zoomOut");
				$(this).on("mouseenter", function() {
					capZoomIn.addClass("zoomIn");
					capZoomIn.removeClass("zoomOut");
					return false;
				});
				$(this).on("mouseleave", function() {
					capZoomIn.addClass("zoomOut");
					capZoomIn.removeClass("zoomIn");
					return false;
				});
			});	
			
            // ------------------------------------------------------------------------------ //
			// Counter
			// ------------------------------------------------------------------------------ //			
			if ( $( ".count" ).length ) {
				$(window).on("scroll.myCount", function(){	
					var h_window_1 = $(window).height() * 0.70,
						p_scroll = $('.count').offset().top,
						get_scroll = p_scroll - h_window_1;

					if( $(document).scrollTop() > get_scroll ){
						$(window).off("scroll.myCount");
						$('.count-value').each(function () {
							$(".start-count", this).text('0');
							var data_count = $(this).data("count");
							$(this).prop('Counter1',0).animate({
								Counter1: data_count
							}, {
								duration: 5000,
								easing: 'swing',
								step: function (now1) {
									$(".start-count", this).text(Math.ceil(now1));
								}
							});
						});
					}
				});
			}
			
            // ------------------------------------------------------------------------------ //
			// Progress Bar
			// ------------------------------------------------------------------------------ //
			$(".progress.type3").wrap("<div class='wrap-progress3'></div>");
			$(".progress.type3").append("<span class='circle'></span>");
            if( $(".wrap-progress").length ){
                $(window).on("scroll.myProgress", function(){
                    // Get position scroll
                    var p_progress = $( ".wrap-progress" ).offset().top, 
                        h_window = $(window).height() * 0.9, 
                        get_scroll_progress = p_progress - h_window;

                    if( $(document).scrollTop() > get_scroll_progress ){
                        $(window).off("scroll.myProgress");
                        $("div.progress").each(function(){

                            // Animation progress
                            var progress_bar = $(this).find(".progress-bar");
                            var val_progress = progress_bar.data("value-progress");
                            progress_bar.animate({
                                "width"  : val_progress + '%'
                            });
							
							// Set type2
							if($(this).hasClass("type2")){
								$(".value-progress",this).animate({
									"left"  : val_progress + '%'
								}, {
									duration: 1000
								});
							}
							
							// Set type3
							if($(this).hasClass("type3")){
								$(".circle",this).animate({
									"left"  : val_progress + '%'
								}, {
									duration: 1500
								});
							}

                            // Counter progress					
                            $(this).find(".value-progress").each(function () {
                                $(this).text('0');
                                $(this).prop("Counter",0).animate({
                                    Counter: val_progress
                                }, {
                                    duration: 3000,
                                    step: function (now) {
                                        $(this).text(Math.ceil(now));
                                    }
                                });
                            });

                        });
                    }	
                });
            }	
        },
		
        // ------------------------------------------------------------------------------ //
        // Modal Bootstrap
        // ------------------------------------------------------------------------------ //
        setModalMaxHeight : function(element){
            this.$element     = $(element);  
            this.$content     = this.$element.find('.modal-content');
            var borderWidth   = this.$content.outerHeight() - this.$content.innerHeight();
            var dialogMargin  = $(window).width() < 768 ? 20 : 60;
            var contentHeight = $(window).height() - (dialogMargin + borderWidth);
            var headerHeight  = this.$element.find('.modal-header').outerHeight() || 0;
            var footerHeight  = this.$element.find('.modal-footer').outerHeight() || 0;
            var maxHeight     = contentHeight - (headerHeight + footerHeight);

            this.$content.css({
                'overflow': 'hidden'
            });

            this.$element.find('.modal-body').css({
                'max-height': maxHeight,
                'overflow-y': 'auto'
            });
        }
    };
    
    $(window).on("load", function(){
        core.initialize();
		setTimeout(function(){
			$(".wrap-loading").addClass("slideOutUp").fadeOut();
		},500);
        
        //Form
        jcf.replaceAll();
        // Pretty Print shortcode
        window.prettyPrint && prettyPrint();
    });

    $(window).on("resize", function(){
        // Modals Bootstrap
        if ($('.modal.in').length != 0) {
            core.setModalMaxHeight($('.modal.in'));
        }
    });

}(jQuery));

