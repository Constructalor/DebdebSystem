### Changelog

##### 1.40.1
**Bug Fixes**
- **PQSOnlyStartOnce** : This patch is now disabled by default as it appears to cause
  issues with PQS terrain generation under certain conditions.

##### 1.40.0
**New/Improved patches**
- New KSP bugfix : [**WheelIntertiaLimit**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/341) Reduces the lower inertia limit for wheels from 0.01 to 0.00001. Thanks to @MajorNr01 for contributing it.
- New performance patch : [**ExpansionBundlePreload**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/345) Starts loading expansion bundles in the background while part compilation is happening. This should have a significant reduction in load times if you have the expansions installed.
- New performance patch : [**PQSOnlyStartOnce**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/350) Avoid a second unnecessary restart of all PQS spheres in game when launching from the VAB or SPH. This should be a small improvement to scene switch times, possibly larger if you have parallax continued installed.
- Improved the **FastLoader** patch to load early asset bundles in the background. Should result in a small improvement to load times.
- Improved the **MinorPerfTweaks** patch to optimize away a `FindObjectOfType` call. Should result in a small improvement to scene switch times.
- Improved the **MinorPerfTweaks** patch to optimize `MonoUtilities.RefreshContextWindows()` and `MonoUtilities.RefreshPartContextWindow()`. Should be a minor improvement to scene switch times under some conditions. 

**Other changes**
- Added descriptions and mentalities for: Clamp-O-Tron, FreeFall Parachutes, LightYear Tire Company, Stratus Corporation. Thanks to @munktron239 for contributing it.

##### 1.39.1
**Bug fixes**
- **FastAndFixedEnumExtensions** : fixed the caching mechanism erroring out on enums containing multiple members using the same underlying value. Was causing various issues in RO/RP1 due to such an enum being defind here.

##### 1.39.0
**New/improved patches**
- New performance patch : [**FasterEditorPartList**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/326) Improve the responsiveness of the part list when switching between categories, sorting and searching by tag. Adress [issue #242](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/242) reported by @Rodg88.
- New KSP bugfix : [**DebugConsoleDontStealInput**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/329), fix the Alt+F12 console input field stealing input when a console entry is added. Thanks to @Clayell for reminding me of that especially annoying issue.
- New KSP bugfix & performance patch : [**FastAndFixedEnumExtensions**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/322), fix exceptions when calling the `EnumExtensions.*Description()` methods with a non-defined enum value, and implement a cache for faster and less allocating execution of those methods. Adress [issue #321](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/321), thanks to @k1suuu for reporting it.

**Other changes**
- Fixed `Override` patches not properly handling `switch` statement.
- Changed the logging level from `Error` to `Warning` when KSPCF detects a duplicate value in configs used to load a `[Persistent]` field.

##### 1.38.1
**Bug fixes**
- **ModuleColorChangerOptimization** : Fixed externally controlled ModuleColorChanger modules state being wrongly reset on startup, notably causing the stock heat shield to start in the charred / black state in the editor.

##### 1.38.0
**New/improved patches**
- New performance patch : [**ModuleColorChangerOptimization**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/304/) : Mostly eliminate the constant overhead from `ModuleColorChanger.Update()` by avoiding re-setting the shader property when the state hasn't changed.
- Improved **OptimizedModuleRaycasts** patch by removing useless constant overhead from the `ModuleSurfaceFX.Update()` method, see [PR #303](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/303/).

**Bug fixes**
- **OptimisedVectorLines** : Fixed [issue #306](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/306), fuel overlay not showing in the editor due to incorrect camera matrix math used in the optimization. Thanks to @Halbann for taking care of that one.

##### 1.37.3
**Bug fixes**
- **ModuleIndexingMismatch** : Fixed [issue #307](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/307) that would functionally disable this patch when multiple mods contain PartModules with the same name.

##### 1.37.2
**Bug fixes**
- **PersistentIConfigNode** : Reverted the `DataType` and `FieldData` types to being public instead of internal as those are part of the public API for this patch, and in active use by ROLib and SEP.

##### 1.37.1
**Bug fixes**
- **PartParsingPerf** : Fixed [issue #305](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/305), incorrect parsing of `dragModelType` part config values resulting in various parts such as wings to generate additional drag.

##### 1.37.0
**New / improved patches**
- New performance patch : [**CraftBrowserOptimisations**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/284), significantly reduces the time it takes to open the craft browser and to search by name. Most noticeable with lots of craft. Thanks to @Halbann for this contribution.
- New performance patch : [**OptimisedVectorLines**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/281), improve performance in the Map View and tracking station when a large number of vessels and bodies are visible via faster drawing of orbit lines and CommNet lines. Thanks to @Halbann and @CharleRoger for this contribution.
- New QoL patch : [**TargetParentBody**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/285), allow targeting the parent body of the current craft, or any body in the parent hierarchy. Thanks to @jamespglaze for this contribution.
- Improved **PartSystemsFastUpdate** performance patch with a [complete reimplementation of `TemperatureGaugeSystem`](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/270), also see [issue #194](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/194). Mostly eliminate the background processing of (hidden and visible) temperature gauges, and massively reduce the overhead of instantiating them, reducing scene load time and stutter on part count change events such as decoupling, docking, undocking, crashes, etc.
- Various initial **loading performance optimizations**, see [PR #269](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/269):
  - Added performance metrics logging upon reaching the main menu
  - Added (almost) entirely custom MU model parser, roughly 3 times the throughput of the stock parser (~300 MB/s on my machine). Will only really benefit to people having fast NVME drives with good random read performance.
  - New patch, **GameDatabasePerf** : KSPCF now maintains dictionaries of loaded models and texture assets by their url/name, and patch the stock `GameDatabase.GetModel*` / `GameDatabase.GetTexture*` method to use them instead of doing a linear search. This was especially bad with models, as the method would compare the requested string to the `GameObject.name` property for every model in the database.
  - As a part of the **MinorPerfTweaks** patch, patched the `FlightGlobals.fetch` property to not fallback to a `FindObjectOfType()` call when the `FlightGlobals._fetch` field is null, which is always the case during loading. In a stock + BDB test case, this alone was about 10% of the total loading time, 7+ seconds.
  - New patch, **PartParsingPerf**, featuring slightly faster part icon generation and faster `Part` fields parsing by creating a dictionary of IL-emitted parser delegates.
- Improved [**CommNetThrottling**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/299) performance patch. The patch now implement a custom rate limiting logic for CommNet updates, with a more balanced take between performance improvements and simulation precision. As a result, the patch is now enabled by default. Thanks to @JonnyOThan for insisting on that one.
- Improved [**ModuleIndexingMismatch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/264) patch. Will now restore persisted data following a config change (mod updated/added/removed) when the module now present on a part is a base or derived module. Notably allow action group customizations to be kept when sharing craft files between Waterfall / non-Waterfall installs. Thanks to @BrettRyland for detailed reporting.
- New modding API patch : [**BaseFieldListUseFieldHost**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/278). Allow `BaseField` and associated features (PAW controls, persistence, etc) to work when a custom `BaseField` is added to a `BaseFieldList` (ie, a `Part` or `PartModule`) with a `host` instance other than the `BaseFieldList` owner. Potential use cases for this are having a part or module-level PAW item associated to and sharing the state of a common field, for example a field in a `KSPAddon`, or extending external (typically stock) modules with additional PAW UI controls and/or persisted fields.

**Bug fixes**
- **CollisionEnhancerFastUpdate** : Fixed [issue #282](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/282), fixed exception spam when launching fireworks and possibly in other situations with non-part physical objects such as fairing / shroud debris. Thanks to @JonnyOThan for reporting.
- **PersistentIConfigNode** : Fixed [issue #297](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/297), incorrect return value from the `LoadObjectFromConfig()` KSP API method, notably resulting in the PAPI Lights mod failing to load. Thanks to @svm420 for reporting.

**Internal changes**
- Added a `[ManualPatch]` attribute. When applied to a class derived from `BasePatch`, the patch won't be automatically applied by the default patching infrastructure. To apply the patch, call `BasePatch.Patch()` manually. 

##### 1.36.1
Hotfix release for [issue #273](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/273) : [**ForceSyncSceneSwitch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/250) patch incompatibility with [Universal Storage 2](https://github.com/linuxgurugamer/universal-storage-2/). The patch will now be disabled when US2 is installed. 

Note that this patch [might be causing other issues](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/260), but so far we haven't been able to confirm them.

##### 1.36.0
**User facing changes**
- New KSP performance patch : [**FasterPartFindTransform**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/255) [KSP 1.12.3 - 1.12.5] : Faster, and minimal GC alloc relacements for the Part FindModelTransform* and FindHeirarchyTransform* methods.
- New KSP performance patch : [**ForceSyncSceneSwitch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/250) [KSP 1.12.0 - 1.12.5] : Forces all scene transitions to happen synchronously. Benefits scene transition time by reducing asset cleanup run count from 3 to 1 (contributed by @siimav).
- New KSP performance patches : this update introduce a collection of patches intended to fix various performance bottlenecks mainly relevant in high part count situations. See [PR #257](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) and [PR #256](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/256) :
  - **ModuleDockingNodeFindOtherNodesFaster** : Faster lookup of other docking nodes.
  - **CollisionEnhancerFastUpdate** : Optimization of the `CollisionEnhancer` component (responsible for part to terrain collision detection).
  - **PartSystemsFastUpdate** : Optimization of various flight scene auxiliary subsystems : temperature gauges, highlighter, strut position tracking...
  - **MinorPerfTweaks** : Various small performance patches (volume normalizer, eva module checks)
  - **FloatingOriginPerf** : General micro-optimization of floating origin shifts. Main benefit is in large particle count situations (ie, launches with many engines) but this helps a bit in other cases as well.
- New KSP bufix : [**DragCubeLoadException**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/232) [KSP 1.8.0 - 1.12.5] : Fix loading of drag cubes without a name failing with an IndexOutOfRangeException (contributed by @Nazfib).
- New KSP bufix : [**TimeWarpBodyCollision**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/259) [KSP 1.12.0 - 1.12.5] : Fix timewarp rate not always being limited on SOI transistions, sometimes resulting in failure to detect an encounter/collision with the body in the next SOI (contributed by @JonnyOThan).
- New modding API improvement : [**KSPFieldEnumDesc**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/243) [KSP 1.12.2 - 1.12.5] : Disabled by default, you can enable it with a MM patch. Adds display name and localization support for enum KSPFields. To use add `Description` attribute to the field (contributed by @siimav).
- New KSP bugfix : [**ModuleActiveRadiatorNoParentException**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/249) [KSP 1.12.3 - 1.12.5] : Fix exception spam when a radiator set to `parentCoolingOnly` is detached from the vessel (reported by @BrettRyland).
- **PAWStockGroups** : [Added PAW groups for generators](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/235), making the UI less confusing when multiple generators are present (contributed by @yalov).
- **ModuleIndexingMismatch** : [Improved patch](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/236), now will still load a module data when the mismatched module is of a known base or derived type. Notably prevent engine state such as action groups configuration from being lost when installing/uninstalling Waterfall, or when exchanging craft files between stock and Waterfall installs.

**Internal changes**
- Patching now always run as the first ModuleManagerPostLoad callback, ensuring other callbacks can benefit from the patches (contributed by @al2me6).
- Small internal refactor of the patching infrastructure for less verbose patch declaration.
- Introduced a new "override" patch type, basically an automatic transpiler allowing to replace a method body with another. This has a little less overhead than a prefix doing the same thing, and allow for other patches (including non-KSPCF ones) to prefix the patched method as usual.

##### 1.35.2
- **FastLoader** : Fixed a regression introduced in 1.35.1, causing PNG normal maps to be generated with empty mipmaps.

##### 1.35.1
- **FastLoader** : fixed the PNG loader behavior not being similiar as in stock. It was wrongly generating mipmaps, notably resulting in NPOT textures not showing when texture quality wasn't set to full resolution ([see issue #224](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/224)).
- **FastLoader** : fixed cached PNG textures loading not using the data loaded by the threaded reader, but instead reading the file again synchronously (!). Unsurprisingly, fixing that is massively improving texture loading time.

##### 1.35.0
- New KSP performance patch : [**OptimizedModuleRaycasts**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/216) [KSP 1.12.3 - 1.12.5] : Improve engine exhaust damage and solar panel line of sight raycasts performance by avoiding extra physics state synchronization and caching solar panels scaled space raycasts results.
- New KSP QoL/performance patch : [**OptionalMakingHistoryDLCFeatures**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/218) [KSP 1.12.3 - 1.12.5] : Allow to disable the Making History DLC mission editor and additional launch sites features to decrease memory usage and increase loading speed. The Making History parts will still be available. Can be toggled from the KSPCF in-game settings (requires a restart), or from a MM patch (see `Settings.cfg`)
- New KSP bugfix : [**PartBoundsIgnoreDisabledTransforms**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/208) [KSP 1.12.3 - 1.12.5] : Fix disabled renderers by mesh switchers (B9PartSwitch...) still being considered for part bounds evaluation, resulting in various issues like parts not being occluded from drag in cargo bays, wrong vessel size being reported, etc...
- **BetterUndoRedo** : Fixed "too much undoing" when undoing offset/rotate editor actions, and other incoherent behavior (see [related issue](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/206))
- **FastLoader** : Improved DDS loading performance by avoiding an extra copy of the DDS data
- **MemoryLeaks** : More stock memory leaks fixed, and additional reporting of leaked handlers

##### 1.34.1
- Disable BetterEditorUndoRedo when TweakScale/L is installed due to introducing a bug with part attachments in the editor.

##### 1.34.0
- New KSP QoL/performance patch : [**LowerMinPhysicsDTPerFrame**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/175) : Allow a min value of 0.02 instead of 0.03 for the "Max Physics Delta-Time Per Frame" main menu setting. This allows for higher and smoother framerate at the expense of the game lagging behind real time.  This was already possible by manually editing the `settings.cfg` file, but changes would revert when going into the settings screen.
- New KSP QoL patch : [**BetterEditorUndoRedo**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/172) : Invert the editor undo state capturing logic so part tweaks aren't lost when undoing.
- New KSP bugfix: [**InventoryPartMass**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/182) : Fixes bugs where parts stored in inventories would not have the correct mass or volume when their resource levels were modified or variants changed.
- New KSP bugfix: [**EVAConstructionMass**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/185) : Fixes a bug where picking up a part in EVA construction would set its mass to the wrong value when mass modifiers are involved (e.g. part variants).
- New KSP bugfix: [**RespawnDeadKerbals**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/104) : When respawning is enabled, starts the respawn timer for any dead kerbals (changing their state to "missing") when loading a save.  This addresses stock bugs where kerbals could be set to dead even when respawning is enabled.
- New KSP bugfix: [**ZeroCostTechNode**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/180) : Fixes a bug where parts in tech nodes that have 0 science cost would become unusable.
- New KSP bugfix: [**ModulePartVariantsNodePersistence**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/179) : Fixes an issue with ModulePartVariants where attachnodes would use their default state when resuming flight on a vessel from a saved game.  This would lead to different behavior in part joints and flexibility between initial launch and loading a save.
- Changed patch behavior: PAWGroupMemory now tracks group state globally instead of per-window.
- Added zh-cn localization for ManufacturerFixes.cfg (thanks @zhangyuesai)

##### 1.33.0
- New KSP performance patch : [**CollisionManagerFastUpdate**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/174) : 3-4 times faster update of parts inter-collision state, significantly reduce stutter on docking, undocking, decoupling and joint failure events.

##### 1.32.1
- **IMGUIOptimization** : fixed issue where the patch was breaking some mods UIs due to not resetting some internal state correctly.

##### 1.32.0
- New KSP bugfix : [**TimeWarpOrbitShift**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/170) [KSP 1.8.0 - 1.12.5], fix active vessel orbit moving randomly when engaging timewarp while under heavy CPU load.
- New KSP bugfix : [**ModuleAnimateGenericCrewModSpawnIVA**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/169) [KSP 1.8.0 - 1.12.5], fix IVA & crew portrait not spawning/despawning when ModuleAnimateGeneric is used to change the part crew capacity. Notably affect the stock inflatable airlock.
- New KSP bugfix : [**PropellantFlowDescription**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/165) [KSP 1.8.0 - KSP 1.12.5], fix printing the resource's base flow mode instead of the (potentially overridden) propellant's flow mode when printing propellants in an engine's info panel in the Part Tooltip.
- Fix KSP [issue #153](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/153), prevent flight related events to be registered from ModuleScienceExperiment on the prefabs and in other scenes. This was added to the **MemoryLeaks** patch, since that patch already handle a bunch of GameEvents related issues/leaks.
- New KSP performance patch : **IMGUIOptimization** [KSP 1.8.0 - 1.12.5], eliminate structural GC allocations and reduce performance overhead of OnGUI() methods. Can provide significant performance gains when having many mods using IMGUI heavily.
- **ConfigNodePerf** : fixed [issue #167](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/167), incorrect parsing of config files using `cr` only (old Mac style) line endings.

##### 1.31.1
- **DragCubeGeneration** : Actually enable patch by default, I somehow failed to push that change in the last release (Thanks @dok_377 for reporting)
- **ReflectionTypeLoadExceptionHandler** : Fixed the exception handler itself throwing an exception in a corner case situation where a dynamic assembly is loaded, causing a call to `Assembly.Location` to throw (Thanks @Lisias for reporting).

##### 1.31.0
- New KSP bugfix : [**DockingPortConserveMomentum**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/160) [KSP 1.12.3 - 1.12.5], make docking ports conserve momentum by averaging the acquire forces between the two ports.
- **DragCubeGeneration** : fixed [issue #154](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/154), fix broken map view (and various other issues) when a drag cube is generated on a root part having multiple drag cubes.
- **DragCubeGeneration** : fixed [issue #162](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/162), fix incorrect drag cubes generated for stock procedural fairings (and potentially mods doing procedural mesh generation).
- **DragCubeGeneration** : patch enabled by default, hopefully all bugs fixed :)
- **PersistentIConfigNode** : adress [issue #159](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/159), add some logging when an enum parsing error happens instead of swallowing it silently.

##### 1.30.0
- **DragCubeGeneration** : disabled by default since it continues to cause issues with fairings and some other parts. Will be reenabled by default when issues are fixed.
- New KSP bugfix : [**FixGetUnivseralTime**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/155) [KSP 1.8.0 - 1.12.5], fix Planetarium.GetUniversalTime returning bad values in the editor.

##### 1.29.2
- **ModUpgradePipeline** : fixed [issue #156](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/156), fix to correctly load mod versions on reading sfs/craft file and to correctly sanity-check UpgradeScripts vs current mod version not loaded version.

##### 1.29.1
- **ConfigNodePerf** : fixed [issue #152](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/152), fix CopyTo in overwrite mode not allowing subnodes with duplicate values.

##### 1.29.0
- **DragCubeGeneration** : fixed [issue #150](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/150), fix for in-editor detached parts can cause incorrect drag cubes with modded shaders, notably fix incorrect drag for parachutes and solar panels when the Shaddy + TU mods are installed.
- New KSP bugfix : [**ThumbnailSpotlight**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/149) [KSP 1.12.0 - 1.12.5], fix rogue spotlight staying in the scene when a part thumbnail fails to be generated. Contributed by @JonnyOThan.


##### 1.28.1
- **DragCubeGeneration** : fixed [issue #146](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/146), cache concurrency issues causing `InvalidOperation` exceptions and more generally incorrect drag cubes on dynamic editor/flight drag cube generation.

##### 1.28.0
- New KSP bugfix : [**ReRootPreserveSurfaceAttach**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/142) [KSP 1.8.0 - 1.12.5], disable the stock behavior of altering surface attachment nodes on re-rooting, a questionable QoL feature that doesn't work correctly, leading to permanently borked attachement nodes.
- New API/modding patch : **BetterDDSSupport** [KSP 1.12.3 - 1.12.5] (actually part of the **FastLoader** patch), implement support of loading additional DDS formats.
- New performance patch : [**DisableHiddenPortraits**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/84) [KSP 1.8.0 - 1.12.5], prevent non-visible crew portraits from being rendered after a switch back from the map view (and other cases), causing a significant perf hit when there are many kerbals in the vessel.
- New performance/bugfix patch : [**DragCubeGeneration**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/139) [KSP 1.12.0 - 1.12.5], faster and more reliable implementation of drag cube generation. Improves overall loading times (both game load and scene/vessel/ship load times), prevent occasional lag spikes (in the editor mostly) and fix some issues causing incorrect drag cubes to be generated (notable examples are the stock inflatable heat shield, the 1.25m and 2.5m nose cones and the Mainsail shroud). Note that by design, this patch results in a small deviation from the stock behavior for buyoancy, aerodynamics and thermodynamics, as the generated drag cubes will be slightly different.
- **DisableManeuverTool** : added MM-patcheable flags to set the default enabled state of the maneuver tool or to forcefully disable it, see `Settings.cfg`.

##### 1.27.0
- New performance patch : **LocalizerPerf** [KSP 1.8.0 - 1.12.5] Faster and minimal-allocation replacements for the Localizer.Format() methods, can provide significant speedup for GUI-heavy mods using localized strings.
- **FastLoader** : Faster implementation of the stock `translateLoadedNodes` method, can reduce loading time by up to 30 seconds in a heavily modded install (thanks to @siimav for spotting this).
- **LandingGearLights** : fixed the patch not applying to the smaller LY-10 landing gear (Thanks to @JonnyOThan).
- Fixed [issue #98](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/98) : **ConfigNodePerf** patch ignoring the last key/value pair when parsing a node-less, values only input. Notably fix a compatibility issue with the SimpleConstruction mod causing missing vessel construction costs.

##### 1.26.0
- New stock configs fix, **[LandingGearLights](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/122)** : fix the lights on the "LY-10" and "LY-35" landing gears not automatically turning on/off when extending/retracting the landing gear (Thanks to @JonnyOThan for reporting)
- New KSP bugfix/QoL patch, **LadderToggleableLight** : fix for the stock "Kelus-LV Bay Mobility Enhancer" light being always active even when the ladder is retracted, and implements manual control of the light.

##### 1.25.5
- Fixed [issue #134](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/133) : fix for [issue #133](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/133) was overly conservative, causing loading to stop on exceptions that don't cause a fatal error in stock.

##### 1.25.4
- Fixed [issue #133](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/133) : FastLoader allow the game to launch even when unrecoverable errors happen during loading.

##### 1.25.3
- Fixed [issue #128](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/128) : Fairing Expansion disable not retained after revert to hangar from launch
- Fixed [issue #125](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/125) : Altimeter position was accounting for the AppLauncher width when using the settings slider, but didn't anymore after a scene reload, resulting in a slightly offset position.

##### 1.25.2
- Fixed [issue #96](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/96) : the AutoStrutDrift patch now correctly ignore autostruts originating from a servo part.

##### 1.25.1
- CorrectDragForFlags : fixed flags in landscape mode using the same drag cube as for portrait mode.

##### 1.25.0
- New KSP bugfix patch : [CorrectDragForFlags](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/126), fix the "panel" variants of the flag parts using a single drag cube, causing excessive drag for the smaller options.
- Fixed [issue #124](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/124) : avoid disabling the KSP-Recall "refunding" hack when the user has disabled the KSPCF "RefundingOnRecovery" patch, thus making our friend Lisias happy again.

##### 1.24.6
- Fixed [issue #121](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/121) : MapSOCorrectWrapping patch cause the Mohole to disappear

##### 1.24.5
- Fixed [issue #113](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/117) : FastLoader patch now requires KSP version >= 1.12.3 due to PartLoader implementation differences in previous 1.12 patch versions

##### 1.24.4
- Fixed [issue #117](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/117) : FastLoader getting stuck on duplicated audio asset

##### 1.24.3
- Fixed [issue #115](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/115) : PNG texture cache isn't always invalidated when a PNG texture is modified
- Updated Krafs.Publicizer dependency to v2.2.0

##### 1.24.2
- Fixed [issue #114](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/114) : Drag cubes are incorrectly calculated on modules using `IMultipleDragCube.AssumeDragCubePosition()` due to FastLoader patch not skipping a frame to let the part animation(s) play

##### 1.24.1
- Fixed [issue #112](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/112) : Cannot dismiss or disable FastLoader opt-in popup on KSP < 1.12.0

##### 1.24.0
- Updated for KSP 1.12.5
- New KSP bugfix patch : [ChutePhantomSymmetry](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/107), fix parachutes in symmetry keeping their spread angle after decoupling.
- New performance patch : [ContractProgressEnumCache](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/100) (thanks to @abrenneke)
- New performance patch : [FastLoader](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/108),Complete rewrite of the KSP asset/part loader : prevent GPU framerate limits from affecting loading speed, implement multithreaded asset loading (20% to 40% speedup depending on CPU & storage specs), provides an opt-in mechanism for caching PNG textures in the DXT5 format. 
- The FastLoader patch also include a fix for [issue #69](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/69), KSP bug causing loading hangs when an invalid `*.png` file is being loaded.
- TextureLoaderOptimizations : the patch has been depreciated, equivalent functionality has been integrated in the more general FastLoader patch.
- ConfigNodePerf : Fixed the `Game.Updated()` patch not being applied due to an AmbiguousMatchException when finding the target method.
- StockAlarmCustomFormatterDate : issue was fixed in stock so the patch doesn't apply to KSP 1.12.4+
- RoboticsDrift : the patch now only apply to KSP 1.12+, as prior KSP versions have minor differences in the robotics code ultimately causing various bugs when the patch is applied, see [issue #72](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/72).

##### 1.23.0
- New performance / KSP bugfix patch : [RestoreMaxPhysicsDT](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/95) (contributed by @JonnyOThan).
- Fix typo in Strategy's SendStateMessage where bold was not disabled after title (as part of StrategyDuration fix, since that is the only place it would be used in stock KSP).
- Fix bug in ConfigNodePerf where it did not properly early-out of parsing if the cfg file had an extraneous } (stock parser aborts in that case).
- Added Chinese localization (contributed by @tinygrox).

##### 1.22.2
- Fix stock bug in SaveUpgradePipeline exposed by ModUpgradePipeline: the stock SaveUpgradePipeline blows up if an UpgradeScript does not apply to both sfs and craft contexts.

##### 1.22.1
- Add KSPAssembly attribute to MultipleModulePartAPI as well, and add the KSPAssemblyDependency to KSPCommunityFixes just in case.
- Set AssemblyVersion to 1.0 and only increment AssemblyFileVersion and KSPAssembly
- Refactor FieldData.WriteValue for ease in use by other mods.

##### 1.22.0
- New modding patch : [ModUpgradePipeline](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/91) (@NathanKell)
- Further improve ConfigNode performance. The tunable settings blocks have been removed since base performance is high enough now. They've been replaced by a single setting that enables not indenting save games and craft files on save, which offers a slight performance boost reading and writing and a fair amount of savings on disk. See https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/90 for full details. Note that some of this rewrite is done via PersistentIConfigNode. (@NathanKell)
- Add a KSPAssembly attribute to the dll.

##### 1.21.0
- New performance / KSP bugfix patch : [PQSCoroutineLeak](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/85) (issue discovered by @Gameslinx)
- Fixed the ToolbarShowHide patch partially failing due to an ambigious match exception when searching the no args `ApplicationLauncher.ShouldItHide()` method overload.
- PersistentIConfigNode patch : added support for nested Persistent IConfigNode, see associated [PR](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/86) (@NathanKell).
- New performance patch : [ConfigNodePerf](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/88) (@NathanKell)

##### 1.20.4
- Restrict UpgradeBugs to KSP 1.12+ since it is compiled against the new combined editor class.
- New KSP bufix : [MapSOCorrectWrapping](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/83) (contributed by @RCrockford)

##### 1.20.3
- New performance patch : [FewerSaves](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/80) (contributed by @siimav)
- StrategyDuration had an incorrect transpiler linkage.

##### 1.20.2
- Fix an issue with the DoubleCurve transpiler (contributed by @NathanKell, bug also contributed by @NathanKell)

##### 1.20.1
- Fix an issue with the DoubleCurve patch : [fix to DoubleCurvePreserveTangents](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/73) (contributed by @NathanKell)
- Fix a stock issue where PartModules added via code would have a null upgrades List : [extension to UpgradeBugs](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/74) (contributed by @NathanKell)

##### 1.20.0
- New KSP bugfix : [UpgradeBugs](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/63) (contributed by @NathanKell)
- New KSP bugfix : [DoubleCurvePreserveTangents](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/68) (contributed by @NathanKell)
- New KSP bugfix : [StrategyDuration](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/70) (contributed by @NathanKell)
- PersistentIConfigNode patch : fixed incorrect serialization in some corner cases(contributed by @NathanKell)
- New KSP bugfix : [CometMiningNotRemovingMass](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/66)
- New performance patch : [AsteroidAndCometDrillCache](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/67) (contributed by @JonnyOThan)
- OnSymmetryFieldChanged : fixed mistakenly inverted "changed" condition resulting in the patch not actually preventing symmetry events to be fired when the value hasn't changed.
- Added russian localization (contributed by @sunnypunny)
- New stock configs tweak : [ManufacturerFixes](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/64) (contributed by @sunnypunny)

##### 1.19.1
- DisableMapUpdateInFlight : fixed phantom map markers on flight scene load

##### 1.19.0
- New performance patch : [CommNetThrottling](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/56) (contributed by @JonnyOThan)
- New performance patch : [DisableMapOrbitsInFlight](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/59) (contributed by @JonnyOThan)
- New performance patch : [ProgressTrackingSpeedBoost](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/57) (contributed by @JonnyOThan)
- New QoL patch : [ToolbarShowHide](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/53) (contributed by @NathanKell)
- New QoL patch : ResourceLockActions
- New KSP bugfix : [EnginePlateAirstreamShieldedTopPart](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/52) (Thanks to @yalov (flart) for reporting and to @Aelfhe1m for coming up with a clever solution).
- New KSP bugfix : [AsteroidInfiniteMining](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/51) (Thanks to @Rodg88 for reporting).

##### 1.18.3
- MemoryLeaks : Only remove GameEvent delegates owned by destroyed UnityEngine.Object instances if they are declared by the stock assembly, or a PartModule, or a VesselModule. Some mods are relying on a singleton pattern by instantiating a KSPAddon once, registering GameEvents there and relying on those being called on the dead instance to manipulate static data (sigh...). Those cases will still be logged when the LogDestroyedUnityObjectGameEventsLeaks flag is set in settings.

##### 1.18.2
- Fixed MemoryLeaks patch causing KSC facilities upgrades being reverted after a scene change.

##### 1.18.1
- Fixed AutostrutActions patch causing nullrefs on part duplication and generally not working as intended.

##### 1.18.0
- New performance patch : [MemoryLeaks](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/49)
- New KSP bugfix : [RescaledRoboticParts](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/48) (thanks to @pap1723)
- New QoL patch : AutostrutActions (suggested by forum user @RealKerbal3x)

##### 1.17.0
- New KSP bugfix : [StickySplashedFixer](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/44) (thanks to @NathanKell)
- New modding bugfix : [DepartmentHeadImage](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/47) (thanks to @NathanKell)
- PersistentIConfigNode patch : added `Guid` serialization support to `CreateObjectFromConfig()`, `LoadObjectFromConfig()` and `CreateConfigFromObject()` methods (thanks to @NathanKell).

##### 1.16.1
- RoboticsDrift : fix "Servo info not found" log spam originating from servo parts for which the drift correction isn't enabled.

##### 1.16.0
- New KSP bugfix : [EVAKerbalRecovery](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/43) (thanks to @JonnyOThan for bug-reporting)
- FairingMouseOverPersistence : patch now only applies to KSP 1.10.0 and latter, as the field it relies on doesn't exists in prior versions, causing exceptions in OnLoad()/OnSave().
- Codebase cleaning pass, analyzers are now happy (or silenced).

##### 1.15.0
- New KSP bugfix : [ScatterDistribution](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/41) (thanks to @R-T-B)
- New KSP bugfix : [LostSoundAfterSceneSwitch](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/42) (thanks to @ensou04)
- Fixed KerbalInventoryPersistence patch not being applied on KSP 1.12.3

##### 1.14.1
- Fix KSPCF [issue #39](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/39) : AltimeterHorizontalPosition patch causes state inconsistencies with vessel filters.
- Fix KSPCF [issue #40](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/40) : UIFloatEditNumericInput patch breaking IR custom FloatEdit control. Don't alter the control prefab list, instead return our custom prefab on the fly in the KSP methods searching the prefab list.

##### 1.14.0
- New KSP bugfix : PartListTooltipIconSpin (investigation efforts by @StoneBlue).
- New KSP bugfix : AsteroidSpawnerUniqueFlightId
- New QoL patch : DisableNewGameIntro
- New performance patch : PQSUpdateNoMemoryAlloc (investigation and fix by @Linx).
- Updated Harmony to v2.2.1
- Fixed multiple RoboticsDrift patch issues: 
  - Improved general numerical stability by normalizing input/output Quaternions.
  - Fixed potential NRE spam happening after in-flight vessel hierarchy changes (ie, docking/undocking/decoupling...)
  - Fixed random child-parts-of-robotic-part displacement after timewarping/reloading (bug introduced with the changes made in 1.12.2)
  - Modded robotic parts whose `servoTransform` has a position offset relative to the part origin (either due to non-zero local position in the model hierarchy or a position offset in the part config `MODEL{}` node) are now unsupported. This mean drift correction won't be applied for them, and the stock behavior will apply. KSPCF will issue a log warning when unsupported parts are loaded in flight. Note that such a configuration isn't fully supported by stock either, and such parts will also have issues when manipulating their angle in the editor. And while I *might* find a way to fix this issue in the future, I strongly recommend mod authors to check/alter their models to ensure the `servoTransform` has a zero relative position/rotation from the model root. As of writing, this issue notably affect the BDB Skylab truss, the "More Servos" mod by @Angel-125 and possibly others. 

##### 1.13.2
- RoboticsDrift : fixed a rotation offset being wrongly applied to child parts of translation servos following the fix for issue #35 released in KSPCF 1.12.2 (see [report 1](https://forum.kerbalspaceprogram.com/index.php?/topic/204002-18-112-kspcommunityfixes-bugfixes-and-qol-tweaks/&do=findComment&comment=4132262), [report 2](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/13#issuecomment-1126797719))

##### 1.13.1
- Fixed NoIVA patch causing missing part textures when the part reuse/share IVA textures (ex : SXT). Note that this change negate the loading time gains of the original patch, and might even cause a small increase (a few seconds) if KSP isn't running from a SSD.

##### 1.13.0
- New modding patch : ReflectionTypeLoadExceptionHandler
- New QoL patch : ShowContractFinishDates, contributed by @NathanKell
- New QoL patch : NoIVA
- Added localization support
- Added tooltips to in-game settings

##### 1.12.2
- RoboticsDrift : fixed issue [#35](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/35), incorrect handling of non-stock servo parts having `MODEL{}` rotation/position offsets and/or a model hierarchy where the rotation transform has a position/rotation offset relative to the model root. Notably fixes incorrect behavior with the BDB [Hokulani OCO-RT90 Truss Structure](https://forum.kerbalspaceprogram.com/index.php?/topic/122020-1123-bluedog-design-bureau-stockalike-saturn-apollo-and-more-v1101-%D0%BB%D1%83%D0%BD%D0%B0-24apr2022/&do=findComment&comment=4128194).

##### 1.12.1
- HidePartUpgradeExtendedInfo : fixed wouldn't show extended info sometimes for regular parts. 

##### 1.12.0
- New QoL patch : [AutoSavedCraftNameAtLaunch](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/30)
- New KSP bugfix : [StockAlarmDescPreserveLineBreak](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/19)
- New KSP bugfix : [DeltaVHideWhenDisabled](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/31)

##### 1.11.2
- TextureLoaderOptimizations : restored compatibility with KSP 1.10 and 1.11
- DockingPortRotationDriftAndFixes : fixed autostruts crossing docking ports not being disabled if only one of the port pair is rotation-unlocked.

##### 1.11.1
- TextureLoaderOptimizations hotfix : was causing loading to hang on KSP 1.10 and 1.11 due to using an Unity method only available since KSP 1.12. Will restore compatbility latter, for now the patch is disabled for all versions below 1.12.
- AutoStrutDrift bugfix : fixed potential ArgumentOutOfRangeException.

##### 1.11.0
- New bugfix : ExtendedDeployableParts
- New performance tweak : TextureLoaderOptimizations
- new Qol tweak : HidePartUpgradeExtendedInfo, courtesy of @NathanKell (see [PR#29](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/29))

##### 1.10.1
DockingPortRotationDriftAndFixes refinements :
- Fixed the stock implementation being unable to handle a rotating docking ports when it is the root part (was throwing exceptions and generally wasn't working correctly)
- Fixed another stock bug : having a `rotationAxis` other than "Y" result in the docking port still rotating around the Y axis. This bug affect the 2 "inline" stock docking port parts.
- Fixed KSPCF bug : parent port not being able to rotate after re-docking
- Fixed KSPCF bug : things were not working as expected when using a rotating + non-rotating docking port pair
- Fixed KSPCF bug : prevent rotation being available when about to dock or after undocking when the other docking port is "acquired" but not docked.
- Various performance optimizations

##### 1.10.0
- New bugfix : DockingPortRotationDriftAndFixes. This patch contain several docking port fixes, and supersede the DockingPortLocking and DockingPortDrift patches, those patches have been removed.
- New bugfix : PackedPartsRotation. This patch is a generalization of a fix previously implemented in RoboticsDrift, and now cover all occurrences of that issue.
- New QoL patch : FairingMouseOverPersistence (suggested by forum user @dok_377)
- New mod API optional patch : OnSymmetryFieldChanged (thanks to @DRVeyl)
- New mod API optional patch : PersistentIConfigNode (thanks to @NathanKell)
- PartStartStability : fixed the patch causing an `ArgumentOutOfRangeException` on scene/vessel load in `FlightIntegrator.Update()`. As a side effect, this patch now make the FI first "valid" execution deterministic (will always be on the fourth `FixedUpdate()` cycle).
- RoboticsDrift : fixed incorrect handling when a robotic part is the vessel root part
- Prevent some patches failing with a `ReflectionTypeLoadException` when another plugin assembly fail to load (ex : the Sandcastle/EL integration assembly)

##### 1.9.1
- RoboticsDrift : fixed (harmless) `[RoboticsDrift] Servo info not found...` log spam when toggling the locked state of a robotic part in the editor

##### 1.9.0
- New bugfix : RoboticsDrift, see [issue #13](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/13).
- New mod API patch : DockingPortLockedEvents (added for KJR, see [related issue](https://github.com/KSP-RO/Kerbal-Joint-Reinforcement-Continued/issues/9))
- New bugfix : DockingPortLocking
- PAWCollapsedInventories : Fixed mass/volume info not updating correctly in the group title.
- Now using [Krafs.Publicizer](https://github.com/krafs/Publicizer) for cleaner/faster access to KSP internals. 

##### 1.8.0
- New bugfix : AutoStrutDrift, see [issue #21](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/21). Thanks to @Lisias for [investigation efforts](https://github.com/net-lisias-ksp/KSP-Recall/issues/27#issuecomment-1022167916).
- New bugfix : PartStartStability, see [issue #9](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/9).
- The FlightSceneLoadKraken patch is superseded by the PartStartStability patch, which is now disabled by default
- Fixed a silly mistake with the OnDemandPartBuoyancy patch where it would prevent part buoyancy from running if the vessel is already below water at scene load. Thanks to @DRVeyl for catching that.

##### 1.7.0
- New performance patch : OnDemandPartBuoyancy (thanks to @siimav)
- New bugfix : ROCValidationOOR (thanks to @R-T-B)

##### 1.6.1
- Fixed version file for 1.12.3

##### 1.6.0
- Updated for KSP 1.12.3
- DockingPortDrift bugfix doesn't apply in 1.12.3 (identical fix was ported to stock)
- Moved KSPCommunityFixes in-game settings to a dedicated category in the KSP settings menu
- New performance patch : SceneLoadSpeedBoost
- New QoL patch : DisableManeuverTool

##### 1.5.0
- New bugfix : KerbalTooltipMaxSustainedG
- Fixed (again...) some patches not being applied

##### 1.4.2
- Fixed ModuleIndexingMismatch patch causing issues with modules dynamically adding/removing resources. Specifically, the patch was causing part resources to be loaded before (instead of after in stock) the `PartModule.OnLoad()` call when loading a `ShipConstruct`. This notably fixes RealFuel resources being lost when reloading/launching a craft file, but that mistake likely had consequences for other fuel/resource switchers mods (B9PS, Firespitter...)

##### 1.4.1
- Fixed UIFloatEditNumericInput patch causing various errors and generally not working as intended.

##### 1.4.0
- New QoL patch : UIFloatEditNumericInput
- Fixed some patches not being applied in KSP versions below 1.12 : PAWItemsOrder, TweakableWheelsAutostrut, ModuleIndexingMismatch, FlightSceneLoadKraken.
- PAWStockGroups patch now applicable to KSP 1.10.1 (min version was 1.11.1 before)

##### 1.3.0
- New bugfix : PAWItemsOrder

##### 1.2.0
- New QoL patch : TweakableWheelsAutostrut, see [issue #16](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/16)
- Fix PluginData folder being created in the Plugins folder

##### 1.1.0
- New bugfix : ModuleIndexingMismatch, see [issue #14](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/14)
- New bugfix : FlightSceneLoadKraken, see [issue #9](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/9)
- New bugfix : StockAlarmCustomFormatterDate (thanks to @LGG)
- New bugfix : PAWGroupMemory
- New bugfix : KerbalInventoryPersistence, see [Squad bugtracker](https://bugs.kerbalspaceprogram.com/issues/28569)
- New QoL patch : PAWStockGroups, see [issue #1](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/1)
- New API : MultipleModuleInPartAPI
- Small tweaks to the patching engine

##### 1.0.4
- new bugfix : DockingPortDrift

##### 1.0.3
- Fix persisted altimeter position not being correctly reloaded
- Fix map filters transition coroutine errors by disabling the nested gameobject instead of the top one

##### 1.0.2
- New QoL patch : AltimeterHorizontalPosition

##### 1.0.1
- New QoL patch : PAWCollapsedInventories
- Base infrastructure for patch managment and conditional activation based on the KSP version
- Patches can be enabled/disabled in configs
- Support for KSP-Recall / Tweakscale

##### 1.0.0
- Initial release : RefundingOnRecovery bugfix

[CKAN]: https://forum.kerbalspaceprogram.com/index.php?/topic/197082-ckan-the-comprehensive-kerbal-archive-network-v1304-hubble/
