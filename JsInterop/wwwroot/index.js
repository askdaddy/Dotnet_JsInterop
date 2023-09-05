window.Logger = (msg) => {
    console.log(msg)
}

Blazor.start()
    .then(async () => {
        await DotNet.invokeMethodAsync("JsInterop","echo", "......")
    })
    .catch(e => {
        console.error(e.stack)
    })