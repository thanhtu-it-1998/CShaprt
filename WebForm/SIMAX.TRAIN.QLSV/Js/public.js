
$.fn.smDialog = function (options) {
    var defaults = {
        autoOpen: true,
        width: 900,
        local: options.local,
        show: { effect: "blink", duration: 1000 },
        hide: { effect: "explode", duration: 1000 },
    }
    if (options) { $.extend(defaults, options); }
    $(defaults.local).dialog({
        width: defaults.width,
        show: defaults.show,
        hide: defaults.hide,
        resizable: false,
        modal: true,
        dialogClass: 'fixedPosition presav-chatPanel',
        open: function (event, ui) {
            var panel = $('.presav-chatPanel');
            if (panel.hasClass('presav-minimize')) {
                panel.removeClass('presav-minimize').attr('style', panelStyleMaximized);
                $('.presav-chatPanel .ui-dialog-titlebar-minimize span').removeClass('ui-icon-plusthick').addClass('ui-icon-minusthick');
            }
            if (!$('.presav-chatPanel .ui-dialog-titlebar .ui-dialog-titlebar-minimize').length) {
                $('.ui-dialog-titlebar').append('<a href="#"  id="btnSize" class="ui-dialog-titlebar-minimize ui-corner-all" role="button">' +
                    '<span class="ui-icon ui-button-icon ui-icon-plusthick">minimize</span></a>');
                $('.presav-chatPanel .ui-dialog-titlebar .ui-dialog-titlebar-minimize').on('click', function () {
                    var panel = $('.presav-chatPanel');
                    var style = panel.attr('style');
                    if (panel.hasClass('presav-minimize')) {
                        panel.removeClass('presav-minimize').attr('style', panelStyleMaximized);
                        $('.presav-chatPanel .ui-dialog-titlebar-minimize span').removeClass('ui-icon-minusthick').addClass('ui-icon-plusthick');

                    } else {
                        panelStyleMaximized = style;
                        panel.addClass('presav-minimize').attr('style', 'width: 1460px; z-index: 1015; bottom: 0px; right: 0; top: 0; left: 0;');
                        $('.presav-chatPanel .ui-dialog-titlebar-minimize span').removeClass('ui-icon-plusthick').addClass('ui-icon-minusthick');

                    }
                    return false;
                });
            }
        }

    })
};
