# Scalpel for Xamarin.Android

Binding library of [JakeWharton/scalpel](https://github.com/JakeWharton/scalpel) v1.1.2

	A surgical debugging tool to uncover the layers under your app.

![Scalpel](https://github.com/JakeWharton/scalpel/blob/master/images/sample.gif)

Usage
-----

Place a `ScalpelFrameLayout` at the root of your hierarchy.

 * `bool LayerInteractionEnabled` - Enable the 3D interaction.
 * `SetDrawViews(bool)` - Toggle wireframe display.
 * `SetDrawIds(bool)` - Toggle view ID display.
 * `int ChromeColor` and `int ChromeShadowColor` - Change the wireframe color.

When interaction is enabled the following gestures are supported:

 * Single touch: Controls the rotation of the model.
 * Two finger vertical pinch: Adjust zoom.
 * Two finger horizontal pinch: Adjust layer spacing.

If you are using the Gradle-based build system, you can wrap this view group around your activity layouts only in the debug builds.

*Note: There are known text rendering issues prior to Android 4.4 that cannot be fixed. Sorry.*

Download
--------

// TODO

License
--------

    Copyright 2014 Jake Wharton

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.