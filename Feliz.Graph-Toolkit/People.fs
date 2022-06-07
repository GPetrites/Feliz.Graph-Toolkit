namespace Feliz.Graph_Toolkit

open Feliz
open Fable.Core

[<StringEnum>]
type PersonCard =
    | Hover
    | Click
    | None

[<Erase>]
type people =
    static member inline personCard(prop: PersonCard) = Interop.mkPeopleAttr "personCard" prop
    static member inline showMax(prop: int) = Interop.mkPeopleAttr "showMax" prop

    static member inline showPresence(prop: bool) =
        Interop.mkPeopleAttr "showPresence" prop