namespace Feliz.Graph_Toolkit.Providers

open Fable.Core

type ProxyProvider() =
    [<Import("ProxyProvider", from = "@microsoft/mgt-proxy-provider")>]
    [<Emit("new $0($1)")>]
    static member create(graphProxyUrl: string) : IProvider = jsNative