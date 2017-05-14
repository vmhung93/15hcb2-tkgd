$(function () {
    if (Cookies.get('isAuthenticated')) {
        $('.anonymous').css('display', 'none');
        $('.authorize').css('display', 'block');
    }
    else {
        $('.anonymous').css('display', 'block');
        $('.authorize').css('display', 'none');
    }

    $("#btn-signIn").click(function () {
        // Check current user is authenticated
        if (Cookies.get('isAuthenticated') == 'true') {
            alert("Bạn đã đăng nhập.");
            return;
        }

        var email = ($("#email").val() == '' || $("#email").val() == null) ? "user@gmail.com" : $("#email").val();
        var remember = $("#remember-me").is(':checked');

        if (remember) {
            Cookies.set('isAuthenticated', true, { expires: 7 });
        }
        else {
            Cookies.set('isAuthenticated', true);
        }

        Cookies.set('email', email);

        // Redirect to homepage
        window.location.href = '/courses';
    })

    $("#btn-logout").click(function () {
        // Clear cookie
        Cookies.remove('isAuthenticated');
        Cookies.remove('email');

        // Redirect to homepage
        window.location.href = '/';
    })
})