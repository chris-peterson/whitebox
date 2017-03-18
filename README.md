## How to profile an Autofac application
1. Clone this repo
1. In _your application_, add a project reference to `Whitebox.Containers.Autofac` and add this to your Autofac registration `builder.RegisterModule<WhiteboxProfilingModule>();`
1. Open the `Whitebox.sln`, press F5
1. Start your profiled application

Good luck!
