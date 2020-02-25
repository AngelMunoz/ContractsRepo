// Learn more about F# at http://fsharp.org

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    async {
        let locator = new Windows.Devices.Geolocation.Geolocator()
        let! location = locator.GetGeopositionAsync() |> Async.AwaitTask
        let position = location.Coordinate.Point.Position
        let latlong = string.Format("lat:{0}, long:{1}", position.Latitude, position.Longitude)
        return printf "lat:%d, long: %d"  position.Latitude position.Longitude
    } |> Async.RunSynchronously
    0 // return an integer exit code
