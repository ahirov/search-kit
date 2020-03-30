/* SearchKit (https://github.com/hirov-anton/search-kit)
See LICENSE file in the solution root for full license information
Copyright (c) Anton Hirov */

function clickSearchButton(e) {
    $.ajax({
        type: "POST",
        url: getOriginUrl() + "/Search/GetSectionData",
        headers: {
            //securityToken: TODO!!!
        },
        data: { sectionId: $(e.target).data("id")},
        success: function (result) {

        }
        //error: TODO!!!
    });
}