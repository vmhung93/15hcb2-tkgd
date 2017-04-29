"use strict";

$(window).scroll(function () {
    var top = $(document).scrollTop();
    var height = 750;

    if (top > height) {
        $("#fixed-menu").removeClass("cs-fixed-header");
        $("#fixed-menu").addClass("cs-header");

        // Change logo
        $("#cs-logo").attr("src", "/images/logo.png");
    } else {
        $("#fixed-menu").removeClass("cs-header");
        $("#fixed-menu").addClass("cs-fixed-header");

        // Change logo
        $("#cs-logo").attr("src", "/images/logo-white.png");
    }
});
