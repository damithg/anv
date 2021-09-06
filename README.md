# Simple UI integrated to read the aircraft data from a DLL

## Running the solution
- Noticed at last minute that the custom DLL is excluded in the .gitignore. Don't wanna commit bunch of other packages so adding the DLL as an artifacts.
- Add the custom DLL manually and build the project. That's pretty much all you have to do 

## TODO
- Refresh the screen at given time intervals is not been implemented.
- More tests would've been nice.
- Middleware to catch exceptions in global level would've been nice. At the moment we just using out of box - ILogger and that's in the basic level.
- Mapper to map between model and view models.

## See everything

![alt text](https://github.com/damithg/anv/blob/main/Anvil.WebUI/wwwroot/images/all.png)

## See KMs

![alt text](https://github.com/damithg/anv/blob/main/Anvil.WebUI/wwwroot/images/km.png)


## See Miles

![alt text](https://github.com/damithg/anv/blob/main/Anvil.WebUI/wwwroot/images/miles.png)


## See Unknowns

![alt text](https://github.com/damithg/anv/blob/main/Anvil.WebUI/wwwroot/images/unknown.png)
