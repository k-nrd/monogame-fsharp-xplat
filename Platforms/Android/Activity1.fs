module Activity

open Game
open Android.App
open Android.Content.PM
open Android.OS
open Android.Views
open Microsoft.Xna.Framework

[<Activity(Label = "@string/app_name",
           MainLauncher = true,
           Icon = "@drawable/icon",
           AlwaysRetainTaskState = true,
           LaunchMode = LaunchMode.SingleInstance,
           ScreenOrientation = ScreenOrientation.FullUser)>]
type Activity1() =
    inherit AndroidGameActivity()

    override this.OnCreate(bundle) =
        base.OnCreate bundle

        let _game = new Game1()
        let _view = _game.Services.GetService(typedefof<View>) :?> View

        base.SetContentView _view
        _game.Run()
