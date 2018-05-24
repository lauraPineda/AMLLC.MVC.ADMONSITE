
$(document).ready(function () {
    Common.LoadSpinner();
});

var Common = {
    
    SomeeClean: function () {
        $("#FinalDiv").next().css("display", "none");
        $("#FinalDiv").next().next().css("display", "none");
        $("#FinalDiv").next().next().next().css("display", "none");
        $("#FinalDiv").next().next().next().next().css("display", "none");
        $("#FinalDiv").next().next().next().next().next().css("display", "none");
    },

    LoadSpinner: function () {
        /*** EVENTOS CARGANDO LOADING... ***/
        $(document).on({
            ajaxStart: function () {
                var heightHidden = $("html").height() + "px";
                $("#jqxLoader").css("height", heightHidden);
                $("#jqxLoader").removeClass("hidden");
            },
            ajaxStop: function () {
                /*$('#jqxLoader').jqxLoader('close');*/
                $("#jqxLoader").addClass("hidden");
            }
        });

        $(document).on('submit', 'form', function () {
            var heightHidden = $("html").height() + "px";
            $("#jqxLoader").css("height", heightHidden);
            $("#jqxLoader").removeClass("hidden");
        })
    },

}