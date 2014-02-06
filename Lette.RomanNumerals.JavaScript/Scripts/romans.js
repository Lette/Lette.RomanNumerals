
'use strict';

var toRoman = function(number) {

    var numerals = [
        ['I', 'V'],
        ['X', 'L'],
        ['C', 'D'],
        ['M']
    ];

    var one = function(index) { return numerals[index][0]; };
    var five = function(index) { return numerals[index][1]; };
    var four = function(index) { return one(index) + five(index); };
    var nextOne = function(index) { return numerals[index + 1][0]; };
    var nine = function(index) { return one(index) + nextOne(index); };

    var hasMoreSymbols = function(index) { return numerals[index].length === 2; };

    var buildForSingleDigit = function(digit, index) {
        if (digit === 0)
            return '';

        if (hasMoreSymbols(index)) {

            if (digit === 4)
                return four(index);

            if (digit === 9)
                return nine(index);

            if (digit >= 5)
                return five(index) + buildForSingleDigit(digit - 5, index);
        }

        return one(index) + buildForSingleDigit(digit - 1, index);
    };

    var recurseBuildWith = function(head, tail, index) {
        return build(new Natural(tail), index + 1) + buildForSingleDigit(head, index);
    };

    var build = function(natural, index) {
        index = index || 0;

        if (natural.value() === 0)
            return '';

        if (hasMoreSymbols(index)) {
            return recurseBuildWith(natural.head(), natural.tail(), index);
        } else {
            return recurseBuildWith(natural.value(), 0, index);
        }
    };

    return build(new Natural(number));
};

var Natural = function(number) {

    var head = function() { return number % 10; };
    var tail = function() { return (number - head()) / 10; };
    var value = function() { return 10 * tail() + head(); };

    return {
        tail: tail,
        head: head,
        value: value
    };
};
