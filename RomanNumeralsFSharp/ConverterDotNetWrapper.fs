namespace RomanNumerals

open RomanNumerals.FSharp.Converter

type Converter() =
    member this.ToRoman (number : int) =
        ToRoman number
