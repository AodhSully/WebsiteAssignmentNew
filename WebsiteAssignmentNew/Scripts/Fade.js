$(document).ready(function () {    
    $(window).show(function () {        
        $('.fade').each(function (i) {      

            $(this).animate({ 'opacity': '1' }, 1000);      

        });
    });
});