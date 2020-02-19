/* SearchKit (https://github.com/hirov-anton/search-kit)
See LICENSE file in the solution root for full license information
Copyright (c) Anton Hirov */

function buildSections(section) {
    /* TODO!!! */
    var sectionsContainer = $("#sk-search-sections-container");
    buildSection(section, sectionsContainer);

    var subsectionsContainer = $("#sk-search-subsections-container");
    var children = section.children;
    for (var c in children) {
        buildSection(children[c], subsectionsContainer);
    }

    var itemsContainer = $("#sk-search-items-container");
    var items = section.items;
    for (var i in items) {
        buildSection(items[i], itemsContainer);
    }
}

function buildSection(section, container) {
    var title = $("<p></p>").append(section.name);
    $("<div></div>").attr("data-id", section.id)
                    .append(title)
                    .appendTo(container);
}