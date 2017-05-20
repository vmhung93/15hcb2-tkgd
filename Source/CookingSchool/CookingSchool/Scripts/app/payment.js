$(function () {
    $('#credit-card-radio').on('click', function () {
        $(this).parent().find('a').trigger('click')
    })

    $('#paypal-radio').on('click', function () {
        $(this).parent().find('a').trigger('click')
    })

    $('#atm-radio').on('click', function () {
        $(this).parent().find('a').trigger('click')
    })
})