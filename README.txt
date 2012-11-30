A good old fashioned Pong game made in Unity for Android devices.
(Testing and learning Unity and Android SDK)


Based on Martin's tutorial, with slight adjustments and using C# instead of Javascript.
URL: http://www.youtube.com/playlist?list=PLD47A8BE52CD8B4E5

Builds details:
* Builds\WebPlayer -- Web Builds Used for testing and in development stages
* Builds\Android -- apk packages for Android


My working environment:
* Windows 8 x64
* Unity Pro 3.5
* Visual Studio 2012 Professional

Known issues:
* From version 3.5, Unity will not auto-distroy the particles. Since I have no fix for now, the particles created at the collision are not disposed proprietly.
* [Fixed] The Paddle can move through the walls
