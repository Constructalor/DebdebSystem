![](assets/Changelog.png) 

# Changelog

Older Promised Worlds Changelogs can be found here <https://github.com/PromisedWorlds/PromisedWorlds> 

## V2.0.5

NEW FEATURES / IMPROVEMENTS:
- Toolbar Icon does not appear in the editor anymore.
- Added Report a Bug, Links, Credits, Changelog to the plugin when you are not in the Main Menu

BUGFIXES:
- Plugin would try to search for a file that doesn't exist.

## V2.0.4
BUGFIXES:
- Fixed Wormholes so that they long longer should keep crafts in their SOI or fling them out at too high velocities

## V2.0.3
NEW FEATURES / IMPROVEMENTS:
- Upgraded the install checking plugin to help with more installation errors
- Plugin now checks for all Promised Worlds and Kopernicus dependencies
- Made the message for unsupported EVE version more clear to differentiate between EVE Redux and True Volumetric Clouds
- Some improvements to Simplified Chinese translation

BUGFIXES:
- Added a missing localization key for Gurdamma's Ashen Midlands
- Updated Axod's description to make more sense

## V2.0.2
BUGFIXES:
- Fix Umod's terrain having gaps in it
- Fix a typo in the skybox config file so the skybox actually works
- Fix the Promised Worlds menu icon not loading correctly on Linux/Mac
- Fix the edges of Puf's and Ovin's atmospheres displaying in front of the terrain

## V2.0.1

BUGFIXES:
- The skybox setting now works correctly with KSP DiRT. If using TextureReplacer, the skybox cannot be disabled.

## V2.0.0
This update has taken a long time and a lot of work. Thanks to some discoveries about KSP 2, major changes have been made across the entire mod. 
Due to the wide-reaching impact of this update, we recommend you start a new save, as prior saves will almost certainly be broken.
We appreciate the patience and support of the community and hope you enjoy what we've been preparing!

REVAMPS BASED ON NEW KSP 2 DISCOVERIES:
- Debdeb is now larger - we re-estimated its size.
- The protoplanetary disk has once again been changed to a more realisting thinner and darker appearance that aligns with KSP 2 footage.
- Dorau is now a gas giant (what we thought was Axod).
- Axod has been revamped to be a dwarf planet, with a brand-new Umod as its moon.
- Moved the Glumo system to Tuun as intended.
- Tilted Glumo for volumetric clouds users.
- Revamped Gup
- Revamped Noj
- Revamped Merbel to feature a new equatorial ocean.
- Revamped Charr
- Revamped Ovin
- Adjusted Gurdamma
- Revamped Lapat to be lifeless, as in KSP 2.
- Revamped Bis
- Added secret features that can be visited on Charr and Bis.
The following bodies and features were removed, as we have confirmed they were not present in KSP 2:
- Removed Diros
- Removed Jut
- Removed Kleid
- Removed Mesma
- Removed Omasa
- Removed Rosh
- Removed Shana
- Removed Puf's clouds
- Removed Merbel's clouds

NEW FEATURES / IMPROVEMENTS:

- Vastly improved visuals! You'll see custom scatter and ground improvements on all bodies with Parallax Continued installed.
- Stock Visuals are improved, and now replicate Scatterer atmospheres.
- Custom sunlares now added that reflect KSP 2 flares. Scatterer flares are no longer supported.
- Volumetrics V5 improvements all round. Cryovolcanoes have been added to Bis, as well as a minor correction to Gurdamma's Volcanic Winters.
- Added support for Volumetrics V3/V4 (V3 is now available without payment on Blackrack's Patreon).
- Added a skybox inspired by one seen in many of the KSP2 Feature Videos. You'll need: "Sigma Replacements: Skyboxes" to have this feature.
- Added PromisedWorlds.dll. The PW icon now appears in KSP's main menu, allowing you to change settings via graphical interface. It also provides installation checking and custom logging.
- PlanetShine and Distant Object Enhancement are now fully supported, including planetary flares.
- New resource configurations for SpaceDust, allowing extraction of resources to support colonies and exploration.
- Updates to Kerbalism configs.
- Adjusted TiltEm, Rational Resources, and Kerbalism configs for Debdeb and Tuun.
- Science Definitions have been updated for all bodies. Those for Tuun are not yet complete; more will be added in coming updates.
- New descriptions have been written for all bodies based on information from KSP 2.
- New loading screens reflect the planets' new appearances.
- New custom flags to show off your space program's interstellar ambitions.
- Removed the Random Main Menu Body feature - it did not work well and slowed down the game loading.

TECHNICAL IMPROVEMENTS:

- Converted some .png / .jpg textures to DDS for faster loading performance
- Adjusted some volumetric cloud options to improve performance
- Updated license to reflect the inclusion of cloud particle textures from EVE Redux.
- Removed cloud textures accidentally included from Kcalbeloh and replaced with our own.

BUGFIXES:

- Fix incorrect links in version files.
- Fix distance scale settings parameter not working.
- Fix starsize settings parameter not working.
- Update MM names in Debdeb's Kerbalism radiation configs to the current ones used by PW.
- Scaled Space no longer flattens bodies.

TRANSLATIONS:

- Added full translation for Simplified Chinese

## v1.2.1
BUGFIXES:

- Shrink the SOI of wormholes to make sure they don't steal ships from Dres orbit. 

## v1.2.0
NEW FEATURES / IMPROVEMENTS:

- Support for Blackrack's V5 volumetric clouds on most planets. V4 clouds are no longer supported.
- Added Tuun and its first three planets - Puf, Rask, and Rusk.
- Enhanced Umod's terrain and normal map
- Updated our title slide to reflect our new developers!

BUGFIXES:

- Fixed an error causing parts of Donk to turn red
- Fix a missing science def for Ovin's Valley of Despair

TECHNICAL IMPROVEMENTS:

- Move loading tips to localization so those can be translated.
- A few utility textures for EVE clouds have been added to Core

TRANSLATIONS:

Promised Worlds now has some translations for several languages, thanks to our hardworking translator teams!
- Added translations for body descriptions and biome names for Spanish and German
- Added translations for body descriptions for Russian

## v1.1.4
BUGFIXES:

- Added a config for KSP Community Fixes to automatically disable the stock maneuver tool, as this caused game crashes when changing SOIs. Thanks Matt Lowne for catching this!

## v1.1.3
NEW FEATURES / IMPROVEMENTS:

- Bis now has its atmosphere - Arekusu can finally rest.
- A new setting allows you to re-add stock loading screens if you want. Change RemoveStockScreens to False in PromisedWorldsSettings.cfg to have both stock screens and Promised Worlds'.

BUGFIXES:

- Bis's SOI has been shrunk so that it doesn't steal ships from Dorau at its periapsis.
- Dorau's atmosphere no longer has oxygen - it is not supposed to.

## v1.1.2
NEW FEATURES / IMPROVEMENTS:

- Improve Lapat and Ovin's ScaledSpace
- Random main menu bodies are now optional. Change RandomMainMenuBody to false in PromisedWorldsSettings.cfg to disable it and return to stock behavior.
- Glumo has a new orbit icon

BUGFIXES:

- Update Omasa's description to reflect the change in Mesma's orbit

TECHNICAL IMPROVEMENTS:

- Move all science definitions to localization. If you would like to help translate Promised Worlds, please ping @levitato5594 on our Discord server!
- Add dummy ModuleManager config to make it easier to detect installed systems. You can now do NEEDS[SystemDebdeb] to detect whether the Debdeb system is installed. This will be useful for mod developers wanting to be compatible with Promised Worlds.
- Planet debug settings are now a global toggle, under the debug section of PromisedWorldsSettings.cfg

## v1.1.1:
BUGFIXES:

- Remove planets with rings and atmospheres from being the random body on the loading screen, as they have issues.
- Remove stock loading screens from the rotation - only ours!

## v1.1.0:
NEW FEATURES / IMPROVEMENTS:

- Random planets will now be shown on the game main menu instead of Kerbin.
- Several custom flags have been added
- Debdeb's protoplanetary disk has been redesigned, featuring a more natural appearance.
- Wormholes are finally working. For real. Mostly. They even actually appear. Kevba's Anomaly goes from Dres to Gurdamma, if enabled in the settings file.
- There are now EVA report science definitions for the Debdeb system!
- Gurdamma now experiences volcanic winters with volumetric clouds - every few years, volcanic clouds cover the planet, plunging it into months of darkness.
- Axod and Glumo have had their volumetric clouds revamped! Dive deep into these gas giants' underworlds for mysterious alien views.
- Mesma and Omasa have been remade with 8K textures and new appearances! Mesma has been moved as well.
- New icons for the Debdeb system planets!
- Redo Debdeb's appearance, for those who look closely past the protoplanetary disk.
- Better Kerbalism and resource configs for the Debdeb system

BUGFIXES:

- Debdeb's heating no longer destroys crafts before they can get to Charr. Go forth and explore the molten world!
- Kleid now has a description! We're sorry for forgetting you, Kleid.
- Kleid's In Space Low / In Space High transition altitude has been raised to 100,000m. Kleid can't catch a break.
- Fixed the transition between Parallax Scaled and PQS terrain.
- Fixed Dorau's clouds appearing blocky and causing "missing texture" log spam.
- Adjusted the Scatterer settings for Rosh's atmosphere.
- Fix up Noj's biomes to work. We've very proud of them!
- Fix Jut to use the correct biome map.
- Fix PQS issues on Merbel

TECHNICAL IMPROVEMENTS:

- ScaledDecorator dependency updated to 1.2 - it will now warn if users do not have D3D11 (relevant for Mac and Linux)
- ScaledDecorator is now bundled with Promised Worlds - Core for ease of installation
- License information has been updated for clarity and compliance with licenses.
- The localization file is now shared between all systems, and has been moved to Promised Worlds - Core.
- EVE cloud textures have been moved to load on demand - that means about 500 MiB less data to load at game launch for the Debdeb system. It also means that these textures won't take up space in RAM when they're not needed, such as when you're at a different planet.
- Remove Donk volcano cloud configs and textures for now, as they're broken. They will be re-added when fixed
- Remove unused Dysto cloud texture. It was just taking up space.
- Do some cleanup of planet .cfg files for better readability
- Use Kopernicus On-Demand loading for all ScaledSpace textures - should save memory and loading time!
- Switch RealisticStarSize to false by default to be more stockalike.
- Remove unused settings.
- Add an SOI to Debdeb so that it doesn't extend forever

LICENSE CHANGE:

- Going forward, Promised Worlds will be released under the CC-BY-NC-SA license. This means that you will not be allowed to make derivatives for commercial purposes. Promised Worlds is of course still free to download and play, and can be freely modified for non-commercial uses as well, with attribution provided. This change was made to protect Promised Worlds' assets from being taken and used for commercial projects, and does not impact normal end users. 

## v1.0.3:
- (MAJOR bugfix) Fixed null refs which Gurdamma was causing because it couldn't find the VertexColorMap textures

## v1.0.2:
- (bugfix) Restored wormhole to the Debdeb system, if enabled. The Kerbol end is now around Dres. Finally, a purpose!
- (bugfix) Made Charr's Hot Craters and Molten Craters dangerous as designed
- (bugfix) Stopped a ModuleManager warning when loading the game
- (bugfix) Change a duplicate Dorau entry to Bis in TiltEm config
- (enhancement) Enabled the ability to toggle realistic star size
- (enhancement) Removed duplicate ScanSat.cfg and DistanceScale.cfg in Debdeb - Core has this config, so another is unnecessary.
- (technical) Ensure all bodies are loaded with FOR[PromisedWorlds]
- (technical) Ensure all Rational Resources configs have NEEDS[PromisedWorlds]
- (technical) Move all Debdeb planet names, descriptions, and biome names to localization
- (technical) Update the version of the bundled VertexColorMapEmissive to 1.1.0
- (documentation) Update README with information on CKAN and SpaceDock downloads
  
