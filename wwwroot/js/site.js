﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function() {
    $('nav.navbar').find('a[href="' + location.pathname + '"]')
        .closest('li').addClass('active');
});
