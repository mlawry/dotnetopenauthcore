# dotnetopenauthcore #

A customised version of github.com/DotNetOpenAuth/DotNetOpenAuth that only supports OAuth 2.0 and targeting .NETCoreApp 1.1

Source code is based on the source tree of https://github.com/DotNetOpenAuth/DotNetOpenAuth branch master commit 7574924b2b5c810b7c00328f04f506f28da3f2ec on 16 Dec 2014.

Additional changes since include:

* Reduced solution to just the OAuth2 projects, and removed the OAuth (v1) and Test projects.
* Implemented assertion based extension grant. New message type AccessTokenAssertionRequest.cs added.
* Includes bug fix: https://github.com/DotNetOpenAuth/DotNetOpenAuth/issues/338

## NetCoreApp folder ##

A .NetCoreApp 1.1 solution that only supports client operation right now.
Normally there would be four projects:

* DotNetOpenAuth.Core
* DotNetOpenAuth.OAuth2
* DotNetOpenAuth.OAuth2.Client
* DotNetOpenAuth.OAuth2.ClientAuthorization

But these have been reduced into just two projects:

* DotNetOpenAuth.Core (DotNetOpenAuth.Core + DotNetOpenAuth.OAuth2)
* DotNetOpenAuth.OAuth2.Client (DotNetOpenAuth.OAuth2.Client + DotNetOpenAuth.OAuth2.ClientAuthorization)

## Get Started ##

For OAuth 2.0 clients, your starting point is normally the `DotNetOpenAuth.OAuth2.ClientBase` class in the `DotNetOpenAuth.OAuth2.Client` package.
Create an instance of `ClientBase` and then call one of its methods to get an OAuth 2.0 access token,
e.g. `ClientBase.GetClientAccessTokenAsync()` or `ClientBase.GetAssertionAccessTokenAsync()`.

