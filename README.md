# MAUI Shell tab switching produces a grey flash on black pages

## Summary
A brief grey/light flash occurs when switching between Shell tabs whose pages and content grids have black backgrounds. The reporter reproduced the flash in a minimal sample on a physical iPhone and an iOS simulator. This package contains the uploaded classic-appearance sample with personal signing settings and Visual Studio state removed. Application source and layout are unchanged.

## Reproduction
1. Open MauiTabFlashRepro.sln in Visual Studio with .NET 10 MAUI/iOS support
2. Pair to a Mac with a compatible Xcode installation
3. Select an iOS simulator, or select a physical iPhone and configure your own development signing account/profile
4. Build and run the application
5. Tap Home, Draws, Investments and Holders repeatedly, at both normal and faster speeds
6. Observe the brief grey/light flash during tab transitions

Expected: the page background remains black throughout each transition.
Actual: a brief grey/light flash is visible while switching tabs.

## Sample details
- Target framework: net10.0-ios
- Minimum supported iOS version: 18.2 (not the tested device OS version)
- Namespace and application ID: com.rkmresearch.dummy
- Four Shell tabs; each page contains only a black grid and white label
- Shell and tab-bar colours are explicitly configured
- Info.plist retains UIDesignRequiresCompatibility=true from the tested sample
- No custom handlers, WebViews, database or third-party UI packages
- Microsoft.Maui.Controls uses $(MauiVersion), resolved from the build environment

## Test environment / complete before submitting
- Physical device: iPhone XS, as reported by the tester
- Physical iOS version: 18.7.10, extracted from the uploaded project user settings; confirm on device
- Simulator: reproduced as reported by the tester; exact model/runtime and variant need confirmation
- Visual Studio: 2026 Community, version 18.11.3, Stable channel, October 2026 Feature Update (confirmed from screenshot)
- .NET SDK version: TO ADD
- Resolved Microsoft.Maui.Controls version: 10.0.110 (confirmed in NuGet screenshot; 10.0.120 shown as available but not tested)
- Xcode version: 26.6 (17F113), confirmed from screenshot
- Build configuration: Debug shown in Visual Studio screenshot
- Regression / last working version: not established
- Screen recording: Evidence/tab-switch-flash.mp4 (original uploaded bytes, approximately 8.67 seconds)

The earlier modern-appearance sample was reported to reproduce on the simulator. The uploaded classic sample was subsequently confirmed on the physical iPhone. This is evidence of the behaviour, not a determination of its underlying cause.

## Submission
Use this README as the issue description and attach this ZIP plus the screen recording. Complete the environment fields first. No issue has been submitted by preparing this package.

## Package validation
The ZIP and project XML were checked, and retained source files were compared byte-for-byte against the upload, except the signing removal in the project file. This cleaned copy has not been compiled or run by the assistant. The tester previously built and ran the original sample.

Excluded: .vs directory and .csproj.user file. Removed: CodesignKey and CodesignProvision project properties. No build outputs are included. Keep your original working project for device testing; this is a separate submission copy.

## Recording observations
Frame inspection confirms the page changes from black to grey during multiple tab switches, while the bottom tab bar remains black. Examples occur at approximately 1.8, 2.9, 3.9, 5.0, 6.1 and 7.0 seconds. Labels overlap briefly during some transitions. The recording demonstrates the rendering behaviour; it does not establish the underlying cause.
