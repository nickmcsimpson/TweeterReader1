(function ($) {
	"use strict";
  $('#slider-fixed').crossSlide({
      fade: 3,
	}, [
	  {
		src:  'img/slider/slider-bg19.jpg',
		from: '50% 100% 1x',
		to:   '50% 0% 5.7x',
		time: 3
	  }, {
		src:  'img/slider/slider-bg19.jpg',
		from: '50% 0% 1.9x',
		to:   '50% 100% 1.1x',
		time: 3
	  }, {
		src:  'img/slider/slider-bg19.jpg',
		from: '100% 80% 1.9x',
		to:   '80% 0% 1.1x',
		time: 3
	  }, {
		src:  'img/slider/slider-bg19.jpg',
		from: '80% 80% 1.9x',
		to:   '100% 0% 1.1x',
		time: 2
	  }
	]);
}(jQuery));