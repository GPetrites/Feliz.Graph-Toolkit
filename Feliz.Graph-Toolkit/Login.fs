namespace Feliz.Graph_Toolkit

open Feliz
open Fable.Core

[<Erase>]
type login =
    static member inline loginInitiated(handler: Browser.Types.Event -> unit) =
        Interop.mkLoginAttr "loginInitiated" handler

    static member inline loginInitiated(handler: unit -> unit) =
        Interop.mkLoginAttr "loginInitiated" handler

    static member inline loginCompleted(handler: Browser.Types.Event -> unit) =
        Interop.mkLoginAttr "loginCompleted" handler

    static member inline loginCompleted(handler: unit -> unit) =
        Interop.mkLoginAttr "loginCompleted" handler

    static member inline loginFailed(handler: Browser.Types.Event -> unit) =
        Interop.mkLoginAttr "loginFailed" handler

    static member inline loginFailed(handler: unit -> unit) =
        Interop.mkLoginAttr "loginFailed" handler

    static member inline logoutInitiated(handler: Browser.Types.Event -> unit) =
        Interop.mkLoginAttr "logoutInitiated" handler

    static member inline logoutInitiated(handler: unit -> unit) =
        Interop.mkLoginAttr "logoutInitiated" handler

    static member inline logoutCompleted(handler: Browser.Types.Event -> unit) =
        Interop.mkLoginAttr "logoutCompleted" handler

    static member inline logoutCompleted(handler: unit -> unit) =
        Interop.mkLoginAttr "logoutCompleted" handler