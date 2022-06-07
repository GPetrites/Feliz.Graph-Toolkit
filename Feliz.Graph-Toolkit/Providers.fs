namespace Feliz.Graph_Toolkit.Providers

open Fable.Core
open Fable.Core.JS

type IProvider() =
    [<Emit("$0.login = $1")>]
    member _.setLogin(v: unit -> Promise<unit>) : unit = jsNative

    [<Emit("$0.logout = $1")>]
    member _.setLogout(v: unit -> Promise<unit>) : unit = jsNative

[<Import("Providers", from = "@microsoft/mgt-element")>]
type Providers() =
    static member globalProvider
        with get (): IProvider = jsNative
        and set (v: IProvider): unit = jsNative