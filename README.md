# Scalpel

Xamarin.Android Bindings for [JakeWharton/scalpel](https://github.com/JakeWharton/scalpel) v1.1.2

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

*Note: There are known text rendering issues prior to Android 4.4 that cannot be fixed. Sorry.*

Download
--------

// TODO


---
&copy; 2017 Yauheni Pakala | MIT License
