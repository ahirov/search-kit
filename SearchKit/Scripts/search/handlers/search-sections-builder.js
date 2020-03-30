/* SearchKit (https://github.com/hirov-anton/search-kit)
See LICENSE file in the solution root for full license information
Copyright (c) Anton Hirov */

function buildSections(section) {
    /* TODO!!! */
    var sectionsContainer = $("#sk-search-sections-container");
    buildSection(section, sectionsContainer, true);

    var subsectionsContainer = $("#sk-search-subsections-container");
    var children = section.children;
    for (var c in children) {
        buildSection(children[c], subsectionsContainer, false);
    }

    var itemsContainer = $("#sk-search-items-container");
    var items = section.items;
    for (var i in items) {
        buildItem(items[i], itemsContainer, false);
    }
}

function buildSection(section, container, isActive) {
    var button = $("<button></button>").data("id", section.$id)
                                       .attr("type", "button")
                                       .addClass("btn")
                                       .addClass("btn-sm")
                                       .addClass("btn-block")
                                       .css("text-align", "left")
                                       .append(section.name)
                                       .click(clickSearchButton);
    if (isActive) {
        button.addClass("btn-dark");
    } else {
        button.addClass("btn-outline-dark")
              .css("border", "none");
    }
    button.appendTo(container);
}

function buildItem(item, container) {
    var title = $("<p></p>").css("font-size", "14px")
                            .css("padding", "4px 8px")
                            .append(item.name);
    $("<div></div>").attr("data-id", item.id)
                    .append(title)
                    .appendTo(container);
}