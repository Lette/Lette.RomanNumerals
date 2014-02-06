/// <reference path="jasmine/jasmine.js" />
/// <reference path="specHelper.js" />
/// <reference path="romans.js" />

'use strict';

describe("roman numerals", function() {

    var testData = [
        [1, 'I'],
        [2, 'II'],
        [3, 'III'],
        [4, 'IV'],
        [5, 'V'],
        [6, 'VI'],
        [7, 'VII'],
        [8, 'VIII'],
        [9, 'IX'],
        [10, 'X'],
        [11, 'XI'],
        [18, 'XVIII'],
        [19, 'XIX'],
        [49, 'XLIX'],
        [99, 'XCIX'],
        [100, 'C'],
        [101, 'CI'],
        [499, 'CDXCIX'],
        [500, 'D'],
        [501, 'DI'],
        [899, 'DCCCXCIX'],
        [900, 'CM'],
        [901, 'CMI'],
        [999, 'CMXCIX'],
        [1000, 'M'],
        [1001, 'MI'],
        [4000, 'MMMM'],
        [9894, 'MMMMMMMMMDCCCXCIV'],
        [10000, 'MMMMMMMMMM'],
        [100000, 'MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM']
    ];

    using("test data", testData, function (value, expected) {
        it("converts " + value + " to " + expected, function() {
            expect(toRoman(value)).toBe(expected);
        });
    });

    it("verifies the testdata", function() {
        for (var i = 0; i < testData.length; i++) {
            expect(toRoman(testData[i][0])).toBe(testData[i][1]);
        }
    });
});