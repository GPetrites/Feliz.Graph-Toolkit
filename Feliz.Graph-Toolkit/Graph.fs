namespace Feliz.Graph_Toolkit

open Feliz
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type Graph =
    static member inline login(properties: ILoginProperty list) =
        Interop.reactApi.createElement (import "Login" "@microsoft/mgt-react", createObj !!properties)

    static member inline people(properties: IPeopleProperty list) =
        Interop.reactApi.createElement (import "People" "@microsoft/mgt-react", createObj !!properties)