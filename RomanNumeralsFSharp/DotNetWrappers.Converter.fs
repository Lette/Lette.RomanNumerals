namespace Lette.RomanNumerals.FSharp.DotNetWrappers

open Lette.RomanNumerals.FSharp.Converter

type Converter() =
    member this.ToRoman (number : int) =
        ToRoman number
