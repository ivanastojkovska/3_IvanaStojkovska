
        $(function(){
            $(".readButton").on("click", function() {
                $("#details").show();
                var $getRow = $(this).parent().parent().children();
                var $name = $($getRow[0]).text();
                $("#name").text($name);
                var $email = $($getRow[1]).text();
                $("#email").text($email);
                var $mobile = $($getRow[2]).text();
                $("#mobile").text($mobile);
            });
            $(".updateButton").on("click", function() {
                var $getRow = $(this).parent().parent();
                $getRow.prop("contentEditable", "true");
                $(this).removeClass("updateButton");
                $(this).addClass("save");
                $(this).text("Save");
            });
            $(".save").on("click", function() {
                var $getRow = $(this).parent().parent();
                $getRow.prop("contentEditable", "false");
                $(this).addClass("updateButton");
                $(this).removeClass("save");
                $(this).text("Update");
            });
            $(".deleteButton").on("click", function() {
                var $getRow = $(this).parent().parent();
                $getRow.hide();
            });
            //bonus
            $("#closeDetails").on("click", function() {
                var $getRow = $(this).parent().parent();
                $("#details").hide();
            });
        });
