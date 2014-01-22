namespace RomanNumerals

module Converter =

    let numerals = ["I"; "V"; "X"; "L"; "C"; "D"; "M"]

    let one index = List.nth numerals (index * 2)
    let five index = List.nth numerals (index * 2 + 1)
    let four index = one index + five index
    let ten index = List.nth numerals (index *2 + 2)
    let nine index = one index + ten index

    let rec fillOnes number index =
        match number with
        | 0 -> ""
        | _ -> one index + fillOnes (number - 1) index

    let rec buildSingleDigit number index =
        match number with
        | 0 -> ""
        | 4 -> four index
        | 9 -> nine index
        | i when i >= 5 -> five index + (buildSingleDigit (number - 5) index)
        | _ -> fillOnes number index

    let isLastSymbol index =
        index * 2 + 1 = numerals.Length

    let rec build number index =
        if number = 0 then
            ""
        elif isLastSymbol index then
            fillOnes number index
        else
            build (number / 10) (index + 1) + buildSingleDigit (number % 10) index
    
    let ToRoman number =
        build number 0
