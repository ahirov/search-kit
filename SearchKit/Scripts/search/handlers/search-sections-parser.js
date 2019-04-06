/* SearchKit (https://github.com/hirov-anton/search-kit)
See LICENSE file in the solution root for full license information
Copyright (c) 2018 Anton Hirov */

function parseSections(data) {
    var ids = {};
    JSON.parse(data, initSectionIds);
    return JSON.parse(data, parseSection);

    function initSectionIds(key, value) {
        if (typeof value === objectLiteral
            && value !== null
            && value.$id) {
            ids[value.$id] = value;
        }
        return value;
    }

    function parseSection(key, value) {
        if (typeof value === objectLiteral
            && value !== null
            && value.$ref) {
            var ref = ids[value.$ref];
            return typeof ref !== undefinedLiteral
                ? ref
                : null;
        }
        return value;
    }
}