"use strict";

$(window).scroll(function () {
    var top = $(document).scrollTop();
    var height = 300;

    if (top > height) {
        jQuery('.navbar-fixed-top').addClass('menu-scroll');
    } else {
        jQuery('.navbar-fixed-top').removeClass('menu-scroll');
    }
});
