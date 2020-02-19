/* SearchKit (https://github.com/hirov-anton/search-kit)
See LICENSE file in the solution root for full license information
Copyright (c) Anton Hirov */

$(document).ready(function() {
    $.ajax({
        type: "POST",
        url: getOriginUrl() + "/Search/GetData",
        headers: {
            //securityToken: TODO!!!
        },
        success: function (result) {
            var rootSection = parseSections(result.data);
            buildSections(rootSection);
        }
        //error: TODO!!!
    });
});