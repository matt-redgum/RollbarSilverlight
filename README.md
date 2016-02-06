# RollbarSilverlight

This project is a near clone of [RollbarSharp](https://github.com/mroach/RollbarSharp) but with the required changes to make it run within a Silverlight application. These changes included mods to the Http POST method to rollbar.com, and some changes around accessing assembly info from within the Silverlight sandbox

The configuration loader was removed, and now needs to be provided as part of the RollbarClient constructor

## TODO

* There are no tests yet - it's on my list of things to do at some point

* Create a nuget package to make life a bit easier

