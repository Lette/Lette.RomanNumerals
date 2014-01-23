namespace RomanNumerals

open Xunit
open Xunit.Extensions
open RomanNumerals.FSharp.Converter

module ConverterTests =

    type PropertyDataType =
        System.Object [] list

    let (testCases : PropertyDataType) =
        [
            [| 1; "I" |]
            [| 2; "II" |]
            [| 3; "III" |]
            [| 4; "IV" |]
            [| 5; "V" |]
            [| 6; "VI" |]
            [| 7; "VII" |]
            [| 8; "VIII" |]
            [| 9; "IX" |]
            [| 10; "X" |]
            [| 11; "XI" |]
            [| 18; "XVIII" |]
            [| 19; "XIX" |]
            [| 49; "XLIX" |]
            [| 99; "XCIX" |]
            [| 100; "C" |]
            [| 101; "CI" |]
            [| 499; "CDXCIX" |]
            [| 500; "D" |]
            [| 501; "DI" |]
            [| 899; "DCCCXCIX" |]
            [| 900; "CM" |]
            [| 901; "CMI" |]
            [| 999; "CMXCIX" |]
            [| 1000; "M" |]
            [| 1001; "MI" |]
            [| 4000; "MMMM" |]
            [| 9894; "MMMMMMMMMDCCCXCIV" |]
            [| 10000; "MMMMMMMMMM" |]
            [| 100000; "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" |]
        ]

    [<Theory>]
    [<PropertyData("testCases")>]
    let Converts_number_to_roman (number : int, expected : string) =
        let inRoman = ToRoman number
        Assert.Equal<string> (expected, inRoman)
