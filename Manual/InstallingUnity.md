 
 
|   **Property**|   |   **Function** |
|:---|:---|:---| 
|   **Fullscreen Mode**|   |   Choose the full-screen mode. This defines the default window mode at startup. |
|  |   *Fullscreen Window* |   Set your app window to the full-screen native resolution of the display. Unity renders app content at the resolution set by script (or by user selection when the built application launches), but scales it to fill the window. When scaling, Unity adds black bars to the rendered output to match the **aspect ratio**   chosen in the **Player** settings, so that the content isn’t stretched. This process is called [letterboxing](https://en.wikipedia.org/wiki/Letterboxing_(filming)). |
|  |   *Exclusive Fullscreen*(Windows only) |   Set your app to maintain sole full-screen use of a display. Unlike *Fullscreen Window*, this mode changes the OS resolution of the display to match the app’s chosen resolution. This option is only supported on Windows; on other platforms, the setting falls back to *Fullscreen Window*. |
|  |   *Maximized Window*(Mac only) |   Set the app window to the operating system’s definition of "maximized". On macOS, this means a full-screen window with an auto-hidden menu bar and dock. This option is only supported on macOS; on other platforms, the setting falls back to *Fullscreen Window*. |
|  |   *Windowed* |   Set your app to a standard, non-full-screen, movable window, the size of which is dependent on the app resolution. In this mode, the window is resizable by default. To disable this, disable the [Resizable Window](https://docs.unity3d.com/Manual/class-PlayerSettingsStandalone.html#resizable) setting. |
|   **Default Is Native Resolution**|   |   Enable this option to make the game use the default resolution used on the target machine. This optio |

 
