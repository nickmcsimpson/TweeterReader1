	jQuery(document).ready(function() { 
		jQuery("#rev-slider").revolution({
			sliderType:"standard",
			sliderLayout:"auto",
			delay:9000,
			navigation: {
				keyboardNavigation: "on",
				keyboard_direction: "horizontal",
				mouseScrollNavigation: "off",
				onHoverStop: "off",
				touch: {
					touchenabled: "on",
					swipe_threshold: 75,
					swipe_min_touches: 1,
					swipe_direction: "horizontal",
					drag_block_vertical: false
				},
				arrows: {
					style: "hermes",
					enable: true,
					hide_onmobile: true,
					hide_onleave: false,
					tmp: '',
					left: {
						h_align: "right",
						v_align: "bottom",
						h_offset: 30,
						v_offset: 30
					},
					right: {
						h_align: "right",
						v_align: "bottom",
						h_offset: 5,
						v_offset: 30
					}
				},
				bullets: {
					enable: true,
					hide_onmobile: true,
					style: "hermes",
					hide_onleave: false,
					direction: "vertical",
					h_align: "left",
					v_align: "bottom",
					h_offset: 55,
					v_offset: 30,
					space: 5,
					tmp: ''
				}
			}, 
		  gridwidth:1920,
		  gridheight:800 
		}); 
	}); 