module App.Components

open Fable.Core
open Feliz
open Feliz.Graph_Toolkit
open Feliz.Graph_Toolkit.Providers
open Browser.Dom

let HelloWorld () =

    (*    Providers.globalProvider <- ProxyProvider.create "/account/Proxy"

    Providers.globalProvider.setLogin (fun () ->
        async { window.location.href <- "/account/SignIn" }
        |> Async.StartAsPromise)

    Providers.globalProvider.setLogout (fun () ->
        async { window.location.href <- "/account/SignOut" }
        |> Async.StartAsPromise)*)

    Providers.globalProvider <-
        Msal2Provider.create [
            ClientId "fbdf3eae-b546-4d94-86ca-49510934dd93"
            LoginType Popup
            Scopes [ "user.read"; "people.read" ]
        ]

    Html.div [
        Graph.login [
            login.loginCompleted (fun () -> console.log "Login complete")
        ]
        Graph.people [
            people.showMax 5
            people.showPresence true
            people.personCard Click
        ]
    ]