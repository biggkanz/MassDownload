namespace MassDownload

module Log =
    
    open System
    open System.Threading
    
    /// Print a colored log message
    let message =
        let lockObj = obj()
        fun (color : ConsoleColor) (message : string ) ->
            lock lockObj (fun () ->
                Console.ForegroundColor <- color
                printfn "%s (thread ID: %i)"
                    message Thread.CurrentThread.ManagedThreadId
                Console.ResetColor())
    
    /// Print a red log message.
    let red = message ConsoleColor.Red
    let green = message ConsoleColor.Green
    let yellow = message ConsoleColor.Yellow
    let cyan  = message ConsoleColor.Cyan
    
        
    
