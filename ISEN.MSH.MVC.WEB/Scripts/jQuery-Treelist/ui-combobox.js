/*
* jQuery widget to create themable dropdownlists
* 
* http://www.jordivila.net/jquery-dropdownlist-widget-json-to-combo-box.html
*
*/

(function($) {

    $.widget("jv.combobox", {
        options: {
            list: null,
            listWidth: null,
            listHeight: null
        }
        , _create: function() {

            var w = this;
            var $el = $(this.element);
            var o = w.options;

            var inHtml = '<ul class="ui-widget ui-combobox"><li class="ui-state-default"><a href="javascript:void(0);" class="ui-combobox-toggleText"></a><span class="ui-icon ui-icon-triangle-1-s"></span><ul class="ui-combobox-list ui-widget-content">';
            for (var i = 0; i < o.list.length; i++) {
                inHtml += "<li class=' " + (o.list[i].selected == true ? "ui-state-highlight" : "") + "' valueAlt='" + o.list[i].value + "'><span>" + o.list[i].text + "</span></li>";
            }
            inHtml += '</ul></li></ul>';

            $el
                .append(inHtml)
                .find("ul.ui-combobox li")
                    .click(function() {
                        $el.find('ul.ui-combobox-list:first').slideDown('fast').show();
                    })
                    .hover(
                        function() { },
                        function() {
                            $(this).parent().find("ul.ui-combobox-list").slideUp('slow');
                        })
                .find('ul.ui-combobox-list')
                    .css('width', parseInt(o.listWidth == null ? $el.find('ul.ui-combobox').outerWidth(true) : o.listWidth))
                    .css('height', parseInt(o.listHeight == null ? $el.find('ul.ui-combobox-list').outerHeight(true) : o.listHeight))
                    .css('top', parseInt($el.find('li:first').outerHeight(true)-2))
                    .css('z-index', isNaN($el.find('li:first').css('z-index')) == true ? 9999 : $el.find('li:first').css('z-index') + 1)
                    .find('li')
                        .hover(
                            function() { $(this).addClass('ui-state-hover'); },
                            function() { $(this).removeClass('ui-state-hover'); })
                        .click(function(e) {
                            var $sel = $el.find('ul.ui-combobox-list li.ui-state-highlight');
                            $el.find('a.ui-combobox-toggleText').html($(this).text());
                            $(this).parents('ul.ui-combobox-list:first').slideUp('slow');

                            if (($sel.length == 0) || ($sel.attr('valueAlt') != $(this).attr('valueAlt'))) {
                                $sel.removeClass('ui-state-highlight');
                                $(this).addClass('ui-state-highlight');
                                w._trigger('changed', null, { value: $(this).attr('valueAlt') });
                            }
                            e.stopPropagation();
                        });


                        $el.find('a.ui-combobox-toggleText').html($el.find('li.ui-state-highlight:first').length == 0 ? $el.find('ul.ui-combobox-list li:first').text() : $el.find('li.ui-state-highlight:first').text());

        },
        destroy: function() {
            $(this.element).find('*').remove();
            $.Widget.prototype.destroy.call(this);
        }
    });

})(jQuery);
