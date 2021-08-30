# [air-quality-monitor](https://airqualitymonitor20210830195609.azurewebsites.net/)

This repository contains the code for a web-based application that allows users to retreive air quality measurements from any city in the world, where measurements are available. The application has been hosted with Azure at the link above.

## Prerequisites
The prerequisites for this project are simply:
- [ ] [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) 16.8 or later
- [ ] [.NET Core SDK](https://dotnet.microsoft.com/download/visual-studio-sdks) 

## To get the application running
Clone this repository and simply run from Visual Studio. In the event of a warning around the use of SSL at first start-up, you must trust the IIS Express SSL certificate and install it.

## Technologies used
The chosen framework for this application is ASP.NET Razor Pages. Razor Pages were chosen as the the preferred framework because of the simpler development experience and because it is more appropriate for a small- to medium-scale application. 

## Data source
Data has been sourced from [OpenAQ](https://docs.openaq.org/). 

OpenAQ is a non-profit organization empowering communities around the globe to clean their air by harmonizing, sharing, and using open air quality data.
