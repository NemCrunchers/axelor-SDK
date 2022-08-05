# Axelor C# SDK [![.NET](https://github.com/NemCrunchers/axelor-SDK/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/NemCrunchers/axelor-SDK/actions/workflows/dotnet.yml)

<a href='https://ko-fi.com/N4N5784YU' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

## Installation 
To install into a project simply add the [Nuget package](https://www.nuget.org/packages/Axelor.SDK/) into your project
> dotnet add package Axelor.SDK --version 0.0.10

## Usage
### Initialize
To use this library all you need to do is insert the following into your services object on start up. This will inject an AxelorClient object using dependency injection. 
```CSharp
builder.Services.AddSingleton(
    new AxelorClient(
        new HttpClient()
        {
            BaseAddress = new Uri(config["AxelorBaseUrl"]),
        }
    )
);
```
### Authenticate
In an interactive app you will want to prompt the user for a login and get the username and password that way, but for a non interactive this will suffice.
```CSharp
if (_axelorClient.isAuthenticated() == false)
{
    await _axelorClient.AuthorizeUser("admin", "admin");
}
```
### List Models
```CSharp
IEnumerable<Vehicle> vehicles = await _axelorClient.List<Vehicle>();
```
### Get Model
```CSharp
Vehicle vehicle = await _axelorClient.Get<Vehicle>(125);
```
### Delete Model
```CSharp
await _axelorClient.Delete<Vehicle>(125);
```
### Create Model
```CSharp
Vehicle newVehicle = new Vehicle(){
    Name = "Company Car" 
};
newVehicle = await _axelorClient.Çreate<Vehicle>(newVehicle);
```
### Update Model

```CSharp
Vehicle vehicle = await _axelorClient.Get<Vehicle>(125);
vehicle.Name = "new name";
vehicle = await _axelorClient.Update<Vehicle>(vehicle);
```