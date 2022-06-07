namespace Feliz.Graph_Toolkit

open Fable.Core

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkLoginAttr (key: string) (value: obj) : ILoginProperty = unbox (key, value)
    let inline mkPeopleAttr (key: string) (value: obj) : IPeopleProperty = unbox (key, value)