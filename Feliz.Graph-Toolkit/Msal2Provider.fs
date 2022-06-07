namespace Feliz.Graph_Toolkit.Providers

open Fable.Core
open Fable.Core.JsInterop

[<StringEnum>]
type Msal2LoginType =
    | Redirect
    | Popup

type Msal2ProviderProperties =
    | ClientId of string
    | [<CompiledName("login-type")>] LoginType of Msal2LoginType
    | Scopes of string list

type Msal2Provider() =
    [<Import("Msal2Provider", from = "@microsoft/mgt-msal2-provider")>]
    [<Emit("new $0($1)")>]
    static member private createInternal(props) : IProvider = jsNative

    static member create(props: Msal2ProviderProperties list) : IProvider =
        Msal2Provider.createInternal (keyValueList CaseRules.LowerFirst props)