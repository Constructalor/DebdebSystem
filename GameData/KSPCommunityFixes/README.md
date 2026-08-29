# KSP Community Fixes

This plugin is a collection of code patches for fixing bugs and performance issues in the KSP codebase, and adding small QoL improvements. Entirely new features (especially those already covered by other mods) are out of scope, as well as patches that might alter the stock behaviors to minimize potential mod compatibility issues.

This mod is meant as community project, so feel free to propose additional patch ideas by opening an issue, or to contribute with a pull request.

### Download and installation

Compatible with **KSP 1.8.0** to **1.12.5** - Available on the [CKAN] mod manager

**Required** and **must be downloaded separately** : 

- **HarmonyKSP** : **[Download](https://github.com/KSPModdingLibs/HarmonyKSP/releases)** - [Homepage](https://github.com/KSPModdingLibs/HarmonyKSP/) - Available on [CKAN]
- **ModuleManager** : **[Download](https://ksp.sarbian.com/jenkins/job/ModuleManager/lastSuccessfulBuild/artifact/)** - [Forum post](https://forum.kerbalspaceprogram.com/index.php?/topic/50533-18x-110x-module-manager-414-july-7th-2020-locked-inside-edition/) - Available on [CKAN]

[CKAN]: https://github.com/KSP-CKAN/CKAN/releases

**Installation**

Installation with [CKAN] is recommended.  Otherwise:

- Go to the **[GitHub release page](https://github.com/KSPModdingLibs/KSPCommunityFixes/releases)** and download the file named `KSPCommunityFixes_x.x.x.zip`
- Open the downloaded *.zip archive
- Open the `GameData` folder of your KSP installation
- Delete any existing `KSPCommunityFixes` folder in your `GameData` folder
- Copy the `KSPCommunityFixes` folder found in the archive into your `GameData` folder

### Features

Individual patches can be enabled or disabled by editing the `Settings.cfg` file. To make sure your changes persist when the mod is updated, it is recommended to make them in a ModuleManager patch. Open the `Extras\KSPCF_UserSettings.cfg.extra` file in a text editor for further instructions.

While all KSP versions from 1.8.0 to 1.12.5 are supported, using the latest one (1.12.5) is highly recommended, as many patches only apply to the most recent KSP versions. When a bug fix patch doesn't apply to an older KSP version, this **doesn't** mean those bugs don't exist there.

User options are available from the "ESC" in-game settings menu :<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/settings.gif"/>

#### Major bugfixes

- **RefundingOnRecovery** [KSP 1.11.0 - 1.12.5]<br/>Vessel recovery funds properly account for modules implementing IPartCostModifier. This bug affect stock fairings, cargo parts and many modules from various mods (part switchers and procedural parts mods, USI, Kerbalism, Tweakscale, etc).
- **KerbalInventoryPersistence** [KSP 1.12.2 - 1.12.5]<br/>Fix the whole kerbal inventory persistence system being inactive in KSP 1.12.2+. This cause multiple issues, like being able to bypass kerbal inventories mass/volume limits, and various cargo part duplication / disappearance issues when EVAing / boarding.
- **[RoboticsDrift](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/13)** [KSP 1.12.0 - 1.12.5]<br/>Prevent unrecoverable part position drift of Breaking Grounds DLC robotic parts and their children parts.
- **DockingPortRotationDriftAndFixes** [KSP 1.12.5]<br/>Make the stock docking port rotation feature actually useable :
  - Completely prevent unrecoverable position drift of children parts of docking ports.
  - Fix joint failure and phantom forces when a docking port pair is set to opposite extreme angles.
  - Allow tweaking the rotation in the editor and while not docked in flight.
  - Rotation can now be properly used in a robotic controller.
  - Remove the -86°/86° hardcoded limitation of `hardMinMaxLimits`, it is now -180°/180°.
  - Fix many issues and state inconsistencies.
  - An optional `DockingPortExtendedRotation.cfg.extra` MM patch extending rotation range to 360° is available in the `Extras` folder. Copy it to your `GameData` folder and remove the `.extra` extension to use it.
- **[AutoStrutDrift](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/21)** [KSP 1.8.0 - 1.12.5]<br/>Improves the overall physics stability when using autostruts and prevent autostrut induced deformations following vessel modification events (decoupling, docking/undocking, fairing separation...).
- [**ModuleIndexingMismatch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/264) [KSP 1.8.0 - 1.12.5]<br/>Prevent modules persisted state from being lost in existing saves/ships following a mod installation/uninstallation/update. Note that this won't handle all cases, but it massively reduce occurrences of that issue.
- **PackedPartsRotation** [KSP 1.8.0 - 1.12.5]<br/>Fix part rotations not being reset to their pristine value when a non-landed vessel is packed, resulting in permanent part rotation drift when docking and other minor/cosmetic issues.
- **[PartStartStability](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/9)** [KSP 1.8.0 - 1.12.5]<br/>Fix vessel deformation and kraken events on flight scene load, also prevent some kraken issues when placing parts with EVA construction.

#### Minor bugfixes
- **PAWGroupMemory** [KSP 1.8.0 - 1.12.5]<br/>Fix the expanded/retracted state of Part Action Window groups being reset when the PAW is closed or internally rebuilt (especially frequent in the editor).
- **PAWItemsOrder** [KSP 1.8.0 - 1.12.5]<br/>Fix PAW items position randomly changing and flickering.
- **KerbalTooltipMaxSustainedG** [KSP 1.8.0 - 1.12.5]<br/>Fix the kerbals tooltip giving wrong "Max sustainable G" information.
- **ROCValidationOOR** [KSP 1.8.0 - 1.12.5]<br/>Fix ROCManager crashing during loading with Kopernicus modified systems.
- **ReactionWheelsPotentialTorque** [KSP 1.8.0 - 1.12.5]<br/>Fix reaction wheels reporting incorrect available torque when "Wheel Authority" is set below 100%. Fix stock SAS (and possibly other attitude controllers) instability issues.
- **StockAlarmCustomFormatterDate** [KSP 1.12.0 - 1.12.5]<br/>Make the stock alarm respect the day/year length defined by mods like Kronometer. Fix the underlying AppUIMemberDateTime UI widget API to use the mod-provided IDateTimeFormatter if present.
- **[StockAlarmDescPreserveLineBreak](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/19)** [KSP 1.12.0 - 1.12.5]<br/>Stock alarm preserve line breaks (and tabs) in the description field.
- **ExtendedDeployableParts** [KSP 1.12.0 - 1.12.5]<br/>Fix deployable parts (antennas, solar panels, radiators...) always starting in the extended state when the model isn't exported in the retracted state. This bug affect parts from various mods (ex : Ven's stock revamp solar panels).
- **[DeltaVHideWhenDisabled](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/31)** [KSP 1.12.0 - 1.12.5]<br/>Hide the stock stage delta-v UI elements and navball extended burn info when `DELTAV_CALCULATIONS_ENABLED` and `DELTAV_APP_ENABLED` are disabled by another mod or in the KSP `settings.cfg` file.
- **AsteroidSpawnerUniqueFlightId** [KSP 1.8.0 - 1.12.5]<br/>Fix the asteroid/comet spawner generating non-unique `Part.flightId` identifiers. This has a few minor side effects in stock (mainly incorrect science bonuses), but this field is heavily relied upon by various mods and this can cause major issues for them.
- **PartListTooltipIconSpin** [KSP 1.8.0 - 1.12.5]<br/> Fix editor tooltip part icons not spinning anymore after hovering on a greyed out surface attachable only part while the editor is empty.
- **[ScatterDistribution](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/41)** [KSP 1.8.0 - 1.12.5]<br/>Fix incorrect terrain scatter distribution when a partial longitude range is defined in the PQSLandControl definition.
- **[LostSoundAfterSceneSwitch](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/42)** [KSP 1.12.0 - 1.12.5]<br/> Fix audio source not being centered/aligned with the current vessel after scene switches, causing loss of vessel effects audio and random volume or left/right channel weirdness.
- **[EVAKerbalRecovery](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/43)** [KSP 1.11.0 - 1.12.5]<br/> Fix recovery of EVAing kerbals either causing their inventory to be recovered twice or the science data they carry not being recovered, depending on the EVA kerbal variant/suit.
- **[StickySplashedFixer](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/44)** [KSP 1.8.0 - 1.12.5]<br/> Fix vessel never leaving the splashed state if it starts out splashed, and decouples from its only splashed parts. This also fixes an issue where Splashed overrides Prelaunch as a situation.
- **[RescaledRoboticParts](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/48)** [KSP 1.8.0 - 1.12.5]<br/> Fix rescaled robotics parts propagating their scale to childrens after actuating the servo in the editor
- **[EnginePlateAirstreamShieldedTopPart](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/52)** [KSP 1.11.0 - 1.12.5]<br/>Fix engine plates causing the part attached above them to be incorrectly shielded from airstream.
- **[AsteroidInfiniteMining](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/51)** [KSP 1.10.0 - 1.12.5]<br/>Fix asteroid/comet mass being restored to 100% when reloading after having mined it down to 0%.
- **[CometMiningNotRemovingMass](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/66)** [KSP 1.12.2 - 1.12.5]<br/>Fix mass of comets not actually reducing when mining them, despite the PAW saying so.
- **[DoubleCurvePreserveTangents](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/68)** [KSP 1.8.0 - 1.12.5]<br/>Fix DoubleCurve flattening the tangents of the first keyframe regardless of whether tangents are supplied.
- **[StrategyDuration](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/70)** [KSP 1.8.0 - 1.12.5]<br/>Fix Strategies not using Duration settings.
- **[UpgradeBugs](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/63)** [KSP 1.12.0 - 1.12.5]<br/>Fix various bugs with upgrades, like the part stats upgrade module breaking, upgrades not properly applying in the editor, upgrade cost not being applied to part cost, and various issues int the public API.
- **[MapSOCorrectWrapping](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/83)** [KSP 1.10.0 - 1.12.5]<br/>Fixes issues with biomes crossing the poles (South pole biome at north pole and vice versa). Fixes "polar spikes" in the terrain for 8-bit heightmaps.
- **[ChutePhantomSymmetry](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/107)** [KSP 1.10.0 - 1.12.5]<br/>Fix spread angle still being applied after decoupling symmetry-placed parachutes.
- **[CorrectDragForFlags](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/126)** [KSP 1.12.3 - 1.12.5]<br/>Fix the "panel" variants of the flag parts using a single drag cube, causing excessive drag for the smaller options.
- **LadderToggleableLight** [KSP 1.8.0 - 1.12.5]<br/>Fix for the stock "Kelus-LV Bay Mobility Enhancer" light being always active even when the ladder is retracted, and implements manual control of the light.
- [**ReRootPreserveSurfaceAttach**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/142) [KSP 1.8.0 - 1.12.5]<br/>Disable the stock behavior of altering surface attachment nodes on re-rooting, a questionable QoL feature that doesn't work correctly, leading to permanently borked attachement nodes.
- [**ThumbnailSpotlight**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/149) [KSP 1.12.0 - 1.12.5], fix rogue spotlight staying in the scene when a part thumbnail fails to be generated.
- [**FixGetUnivseralTime**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/155) [KSP 1.8.0 - 1.12.5]<br/>Fix Planetarium.GetUniversalTime returning bad values in the editor.
- [**DockingPortConserveMomentum**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/160) [KSP 1.12.3 - 1.12.5]<br/>Make docking ports conserve momentum by averaging the acquire force between the two ports. Notably, docking port Kraken drives will no longer work.
- [**PropellantFlowDescription**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/165) [KSP 1.8.0 - KSP 1.12.5]<br/>Fix printing the resource's base flow mode instead of the (potentially overridden) propellant's flow mode when printing propellants in an engine's info panel in the Part Tooltip.
- [**ModuleAnimateGenericCrewModSpawnIVA**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/169) [KSP 1.8.0 - 1.12.5]<br/>Fix IVA & crew portrait not spawning/despawning when ModuleAnimateGeneric is used to change the part crew capacity. Notably affect the stock inflatable airlock.
- [**TimeWarpOrbitShift**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/170) [KSP 1.8.0 - 1.12.5]<br/>Fix active vessel orbit moving randomly when engaging timewarp while under heavy CPU load.
- [**InventoryPartMass**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/182) [KSP 1.12.0 - 1.12.5]<br/>Fixes bugs where parts stored in inventories would not have the correct mass or volume when their resource levels were modified or variants changed.
- [**EVAConstructionMass**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/185) [KSP 1.12.3 - 1.12.5]<br/>Fixes a bug where picking up a part in EVA construction would set its mass to the wrong value when mass modifiers are involved (e.g. part variants).
- [**RespawnDeadKerbals**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/104) [KSP 1.12.3 - 1.12.5]<br/>When respawning is enabled, starts the respawn timer for any dead kerbals (changing their state to "missing") when loading a save.  This addresses stock bugs where kerbals could be set to dead even when respawning is enabled.
- [**ZeroCostTechNode**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/180) [KSP 1.12.3 - 1.12.5]<br/>Fixes a bug where parts in tech nodes that have 0 science cost would become unusable.
- [**ModulePartVariantsNodePersistence**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/179) [KSP 1.12.3 - 1.12.5]<br/>Fixes an issue with ModulePartVariants where attachnodes would use their default state when resuming flight on a vessel from a saved game.  This would lead to different behavior in part joints and flexibility between initial launch and loading a save.
- [**PartBoundsIgnoreDisabledTransforms**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/208) [KSP 1.12.3 - 1.12.5]<br/>Fix disabled renderers by mesh switchers (B9PartSwitch...) still being considered for part bounds evaluation, resulting in various issues like parts not being occluded from drag in cargo bays, wrong vessel size being reported, etc...
- [**DragCubeLoadException**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/232) [KSP 1.8.0 - 1.12.5]<br/>Fix loading of drag cubes without a name failing with an IndexOutOfRangeException
- [**TimeWarpBodyCollision**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/259) [KSP 1.12.0 - 1.12.5]<br/>Fix timewarp rate not always being limited on SOI transistions, sometimes resulting in failure to detect an encounter/collision with the body in the next SOI.
- [**ModuleActiveRadiatorNoParentException**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/249) [KSP 1.12.3 - 1.12.5]<br/>Fix exception spam when a radiator set to `parentCoolingOnly` is detached from the vessel
- [**FastAndFixedEnumExtensions**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/322) [KSP 1.12.3 - 1.12.5]<br/>Fix exceptions when calling the `EnumExtensions.*Description()` methods with a non-defined enum value, and implement a cache for faster and less allocating execution of those methods.
- [**DebugConsoleDontStealInput**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/329) [KSP 1.12.3 - 1.12.5]<br/>Fix the Alt+F12 console input field stealing input when a console entry is added
- [**WheelIntertialLimit**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/341) Reduces the minimum inertia limit for wheels from 0.01 to 0.00001. Several small wheels had inertia values below this limit, so this makes them behave more correctly.

#### Quality of Life tweaks 

- **PAWCollapsedInventories** [KSP 1.11.0 - 1.12.5]<br/>Part Action Window inventory UI widgets in a collapsed group by default, group title show volume and mass usage. Applied to part and kerbal inventories.<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/PAWCollapsedInventories.gif" width="300"/>
- **AltimeterHorizontalPosition** [KSP 1.8.0 - 1.12.5]<br/>Altimeter widget horizontal position is now tweakable in the pause menu settings.<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/AltimeterHorizontalPosition.gif" width="500"/>
- **PAWStockGroups** [KSP 1.10.1 - 1.12.5]<br/>Part Action Window groups for a selection of stock items/modules<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/PAWGroups.png" width="500"/>
- **[TweakableWheelsAutostrut](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/16)** [KSP 1.8.0 - 1.12.5]<br/>Allow tweaking the autostrut mode of wheels/landing legs. Still default to "Heaviest part".<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/TweakableWheelsAutostrut.gif"/>
- **AutostrutActions** [KSP 1.8.0 - 1.12.5]<br/>Allow autostrut mode to be toggled with action groups (requires advanced tweakables to be enabled).
- **UIFloatEditNumericInput** [KSP 1.8.0 - 1.12.5]<br/>Allow numeric input ("#" button) in "float edit" PAW items<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/UIFloatEditNumericInput.gif"/>
- **DisableManeuverTool** [KSP 1.12.0 - 1.12.5]<br/>Allow disabling the KSP 1.12 maneuver/trip planner tool in the KSPCF in-game settings menu. It can cause stutters and freezes on scene load, when changing SOI or when editing maneuver nodes, especially with Kopernicus modified systems.
- **FairingMouseOverPersistence** [KSP 1.10.0 - 1.12.5]<br/>Make the "Fairing Expansion" state persistent when reloading a craft in the editor.
- [**AutoSavedCraftNameAtLaunch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/30) [KSP 1.8.0 - 1.12.5]<br/>Append `[Auto-Saved Ship]` when relevant in the Launchpad / Runway UI.<br/><img src="https://github.com/KSPModdingLibs/KSPCommunityFixes/raw/master/Screenshots/AutoSavedCraftNameAtLaunch.png" width="200"/>
- [**ShowContractFinishDates**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/36) [KSP 1.12.0 - 1.12.5]<br/>For archived contracts, show accepted/finished dates.
- **NoIVA** [KSP 1.8.0 - 1.12.5]<br/>Allow to disable IVA functionality and prevent related assets from being loaded, reducing RAM/VRAM usage and slightly increasing performance in some cases. Has a "use placeholder IVA" option allowing to keep crew portraits. This patch is disabled by default and must be enabled from the KSP "ESC" settings menu. It has no entry in the `Settings.cfg` file and require a restart to take effect. Do not use this option alongside IVA mods like RPM or MAS.
- **DisableNewGameIntro** [KSP 1.8.0 - 1.12.5]<br/>Disable the "intro" popups appearing in the space center, VAB/SPH and tracking station upon creating a new career game. Disabled by default.
- [**ToolbarShowHide**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/53) [KSP 1.8.0 - 1.12.5]<br/>Add a button for hiding/showing the stock toolbar. Also allow accessing the toolbar while in the space center facilities windows (mission control, admin building, R&D...).
- **ResourceLockActions** [KSP 1.8.0 - 1.12.5]<br/>Add part actions for locking/unlocking resources flow state.
- [**BetterEditorUndoRedo**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/172) [KSP 1.12.3 - 1.12.5]<br/>Invert the editor undo state capturing logic so part tweaks aren't lost when undoing.  NOTE: this patch is disabled when TweakScale/L is installed.
- [**OptionalMakingHistoryDLCFeatures**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/218) [KSP 1.12.3 - 1.12.5]<br/>Allow to disable the Making History DLC mission editor and additional launch sites features to decrease memory usage and increase loading speed. The Making History parts will still be available. Can be toggled from the KSPCF in-game settings (requires a restart), or from a MM patch (see `Settings.cfg`).
- **TargetParentBody** [KSP 1.8.0 - 1.12.5]<br/>Allow targeting the parent body of the current craft, or any body in the parent hierarchy.

#### Performance tweaks 

- **SceneLoadSpeedBoost** [KSP 1.8.0 - 1.12.5]<br/>Reduce scene switches loading time with large/modded saves by caching the current save in memory instead of loading it from disk.
- [**ForceSyncSceneSwitch**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/250) [KSP 1.12.0 - 1.12.5]<br/>Forces all scene transitions to happen synchronously. Mainly benefits highly modded installs by reducing asset cleanup run count from 3 to 1. 
- **OnDemandPartBuoyancy** [KSP 1.8.0 - 1.12.5]<br/>Prevent the part buoyancy integrator from running when not needed. Improves performance for large part count vessels while in the SOI of a body that has an ocean (Kerbin, Eve, Laythe...)
- [**FastLoader**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/108) [KSP 1.12.3 - 1.12.5]<br/>Complete rewrite of the KSP asset/part loader : prevent GPU framerate limits from affecting loading speed, implement multithreaded asset loading (20% to 40% speedup depending on CPU & storage specs), provides an opt-in mechanism for caching PNG textures in the DXT5 format, also implements loading of additional DDS formats (see **BetterDDSSupport** patch in the API/modding tools section).
- **PQSUpdateNoMemoryAlloc** [KSP 1.11.0 - 1.12.5]<br/> Prevent huge memory allocations and resulting occasional stutter on PQS creation happening when moving around near a body surface.
- [**PQSCoroutineLeak**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/85) [KSP 1.8.0 - 1.12.5]<br/>Prevent KSP from spawning multiple PQS update coroutines for the same PQS after scene switches and on other occasions, causing large performance degradation over time.
- [**PQSOnlyStartOnce**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/350) [KSP 1.12.0 - 1.12.5]</br>Prevent KSP from restarting PQS spheres multiple times when launching a vessel from the VAB or SPH.
- [**MemoryLeaks**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/49) [KSP 1.12.0 - 1.12.5]<br/>Fix a bunch of managed memory leaks, mainly by proactively removing `GameEvents` delegates originating from destroyed `UnityEngine.Object` instances on scene switches. Will log detected leaks and memory usage. Also see`Settings.cfg` to enable advanced logging options that can be useful to hunt down memory leaks in mods.
- [**ProgressTrackingSpeedBoost**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/57) [KSP 1.12.0 - 1.12.5]<br/>Remove unused ProgressTracking update handlers. Provides a very noticeable performance uplift in career games having a large amount of celestial bodies and/or vessels.
- [**DisableMapUpdateInFlight**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/59) [KSP 1.8.0 - 1.12.5]<br/>Disable the update of orbit lines and markers in flight when the map view isn't shown. Provides decent performance gains in games having a large amount of celestial bodies and/or vessels.
- [**CommNetThrottling**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/299) [KSP 1.12.0 - 1.12.5]<br/>Implement a throttling mechanism preventing CommNet network updates from happening every frame. When this patch is enabled, network updates will only happen at a set interval of in-game seconds (default is 2.5s, configurable in `Settings.cfg`). This patch will cause events such as line of sight loss or acquisition, or comm link changes to happen with a slight delay, but provide a significant performance uplift in games having a large amount of celestial bodies and/or vessels.
- [**AsteroidAndCometDrillCache**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/67) [KSP 1.12.5]<br/>Reduce constant overhead of ModuleAsteroidDrill and ModuleCometDrill by using the cached asteroid/comet part lookup results from ModuleResourceHarvester. Improves performance with large part count vessels having at least one drill part.
- [**FewerSaves**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/80) [KSP 1.8.0 - KSP 1.12.5]<br/>Disables saving on exiting Space Center minor buildings (Mission Control etc) and when deleting vessels in Tracking Station. Disabled by default.
- [**ConfigNodePerf**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/88) [see also](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/90) [KSP 1.8.0 - KSP 1.12.5]<br/>Speeds up many ConfigNode methods, especially reading and writing ConfigNodes.
- [**RestoreMaxPhysicsDT**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/95) [KSP 1.8.0 - 1.12.5]<br/>When using physics warp, Unity will set the max physics dt to be at least as high as the scaled physics dt. But KSP will never restore it back to the normal value from the settings. This can degrade performance as it allows more FixedUpdates to run per frame.
- [**ContractProgressEnumCache**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/100) [KSP 1.8.0 - 1.12.5]<br/>Prevent performance drops when there are in-progress comet sample or rover construction contracts
- [**DragCubeGeneration**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/139) [KSP 1.12.0 - 1.12.5]<br/> Faster and more reliable implementation of drag cube generation. Improves overall loading times (both game load and scene/vessel/ship load times), prevent occasional lag spikes (in the editor mostly) and fix some issues causing incorrect drag cubes to be generated (notable examples are the stock inflatable heat shield, the 1.25m and 2.5m nose cones and the Mainsail shroud). Note that by design, this patch results in a small deviation from the stock behavior for buyoancy, aerodynamics and thermodynamics, as the generated drag cubes will be slightly different.
- **LocalizerPerf** [KSP 1.8.0 - 1.12.5]<br/>Faster and minimal-allocation replacements for the `Localizer.Format()` methods, can provide significant speedup for GUI-heavy mods using localized strings.
- [**DisableHiddenPortraits**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/84) [KSP 1.8.0 - 1.12.5]<br/>Prevent non-visible crew portraits from being rendered after a switch back from the map view (and other cases), causing a significant perf hit when there are many kerbals in the vessel.
- **IMGUIOptimization** [KSP 1.8.0 - 1.12.5]<br/>Eliminate structural GC allocations and reduce performance overhead of OnGUI() methods. Can provide significant performance gains when having many mods using IMGUI heavily.
- [**CollisionManagerFastUpdate**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/174) [KSP 1.11.0 - 1.12.5]<br/>3-4 times faster update of parts inter-collision state, significantly reduce stutter on docking, undocking, decoupling and joint failure events.
- [**LowerMinPhysicsDTPerFrame**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/175) [KSP 1.12.3 - 1.12.5]<br/>Allow a min value of 0.02 instead of 0.03 for the "Max Physics Delta-Time Per Frame" main menu setting.  This allows for higher and smoother framerate at the expense of the game lagging behind real time.
- [**OptimizedModuleRaycasts**](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/216) [KSP 1.12.3 - 1.12.5]<br/>Improve engine exhaust damage and solar panel line of sight raycasts performance by avoiding extra physics state synchronization and caching solar panels scaled space raycasts results. Also prevent useless constant overhead and raycasts in `ModuleSurfaceFX.Update()` (see [PR](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/303/)).
- [**ModuleDockingNodeFindOtherNodesFaster**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) [KSP 1.12.3 - 1.12.5]<br/>Faster lookup of other docking nodes.
- [**CollisionEnhancerFastUpdate**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) [KSP 1.12.3 - 1.12.5]<br/>Optimization of the `CollisionEnhancer` component (responsible for part to terrain collision detection).
- [**PartSystemsFastUpdate**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) [KSP 1.12.3 - 1.12.5]<br/>Optimization of various flight scene auxiliary subsystems : temperature gauges, highlighter, strut position tracking...
- [**MinorPerfTweaks**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) [KSP 1.12.3 - 1.12.5]<br/>Various small performance patches (volume normalizer, eva module checks, faster `FlightGlobals.fetch` accessor)
- [**FloatingOriginPerf**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/257) [KSP 1.12.3 - 1.12.5]<br/>General micro-optimization of floating origin shifts. Main benefit is in large particle count situations (ie, launches with many engines) but this helps a bit in other cases as well.
- [**FasterPartFindTransform**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/255) [KSP 1.12.3 - 1.12.5]<br/>Faster, and minimal GC alloc relacements for the Part FindModelTransform* and FindHeirarchyTransform* methods.
- [**CraftBrowserOptimisations**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/284) [KSP 1.12.0 - 1.12.5]<br/>Significantly reduces the time it takes to open the craft browser and to search by name. Most noticeable with lots of craft.
- [**OptimisedVectorLines**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/281) [KSP 1.12.0 - 1.12.5]<br/>Improve performance in the Map View when a large number of vessels and bodies are visible via faster drawing of orbit lines and CommNet lines.
- [**GameDatabasePerf**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/269) [KSP 1.12.3 - 1.12.5]<br/>Faster dictionary backed version of the stock `GameDatabase.GetModel*` / `GameDatabase.GetTexture*` methods. This patch is always enabled and has no entry in `Settings.cfg`.
- [**PartParsingPerf**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/269) [KSP 1.8.0 - 1.12.5]<br/>Faster part icon generation and `Part` fields parsing.
- [**ModuleColorChangerOptimization**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/304) [KSP 1.12.3 - 1.12.5]<br/>Reduce the constant overhead from ModuleColorChanger
- [**FasterEditorPartList**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/326) [KSP 1.12.3 - 1.12.5]<br/>Improve the responsiveness of the part list when switching between categories, sorting and searching by tag.
- [**ExpansionBundlePreload**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/345) [KSP 1.12.3 - 1.12.5]<br/>Load expansion bundles in the background while part compilation is happening.

#### API and modding tools
- **MultipleModuleInPartAPI** [KSP 1.8.0 - 1.12.5]<br/>This API allow other plugins to implement PartModules that can exist in multiple occurrence in a single part and won't suffer "module indexing mismatch" persistent data losses following part configuration changes. [See documentation on the wiki](https://github.com/KSPModdingLibs/KSPCommunityFixes/wiki/MultipleModuleInPartAPI).
- **DockingPortLockedEvents** [KSP 1.12.2 - 1.12.5]<br/>Disabled by default, you can enable it with a MM patch. Fire GameEvents onRoboticPartLockChanging/onRoboticPartLockChanged respectively before/after calls to ModuleDockingNode.ModifyLocked(), following a modification of the ModuleDockingNode.nodeIsLocked field.
- **OnSymmetryFieldChanged** [KSP 1.8.0 - 1.12.5]<br/> Disabled by default, you can enable it with a MM patch. Change the `UI_Control.onSymmetryFieldChanged` callback to behave identically to the `UI_Control.onFieldChanged` callback :
  - The callback will only be called when the field value has actually been modified.
  - The "object" argument will contain the previous field value (instead of the new value).
- **PersistentIConfigNode** [KSP 1.8.0 - 1.12.5]<br/>Implement `IConfigNode` members marked as `[Persistent]` serialization support when using the `CreateObjectFromConfig()`, `LoadObjectFromConfig()` and `CreateConfigFromObject()` methods. Also implements `Guid` serialization support for those methods. Includes a complete rewrite of underlying ConfigNode code (in line with ConfigNodePerf) for performance, lower GC impact, and to fix some stock bugs.
- **ReflectionTypeLoadExceptionHandler** [KSP 1.8.0 - 1.12.5]<br/>Patch the BCL `Assembly.GetTypes()` method to always handle (gracefully) an eventual `ReflectionTypeLoadException`. Since having an assembly failing to load is a quite common scenario, this ensure such a situation won't cause issues with other plugins. Those exceptions are logged (but not re-thrown), and detailed information about offending plugins is shown on screen during loading so users are aware there is an issue with their install. This patch is always enabled and has no entry in `Settings.cfg`.
- **[DepartmentHeadImage](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/47)** [KSP 1.8.0 - 1.12.5]<br/> Fix administration building custom departement head image not being used when added by a mod.
- **[ModUpgradePipeline](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/91)** [KSP 1.8.0 - 1.12.5]<br/>This will save mod versions in sfs and craft files, and use those versions for mods' SaveUpgradePipeline scripts so that mods can handle their own upgrade versioning using native KSP tools instead of having to always run their upgrade scripts.
- **BetterDDSSupport** [KSP 1.12.3 - 1.12.5]<br/>Implement compatibility with the DXT10/DXGI specification, and support of loading additional texture formats :
  - `BC4` : single channel (R) compressed 4 bpp 
  - `BC5` : 2 channels (RG) compressed 8 bpp
  - `BC6H` : 3 channels (RGB) compressed 8 bpp with HDR color range (**Not available on MacOS**)
  - `BC7` : 4 channels (RGBA) compressed 8 bpp (**Not available on MacOS**)
  - `R16G16B16A16` : 4 channels (RGBA) uncompressed 64 bpp
  - `R16_FLOAT` / `R32_FLOAT` : single channel (R) uncompressed 16/32 bpp 
  - `R16G16_FLOAT` / `R32G32_FLOAT` : 2 channels (RG) uncompressed 32/64 bpp
  - `R16G16B16A16_FLOAT` / `R32G32B32A32_FLOAT` : 4 channels (RGBA) uncompressed 64/128 bpp
- [**KSPFieldEnumDesc**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/243) [KSP 1.12.2 - 1.12.5]<br/>Disabled by default, you can enable it with a MM patch. Adds display name and localization support for enum KSPFields. To use add `Description` attribute to the field.
- [**BaseFieldListUseFieldHost**](https://github.com/KSPModdingLibs/KSPCommunityFixes/pull/278) [KSP 1.12.3 - 1.12.5]<br/>Allow `BaseField` and associated features (PAW controls, persistence, etc) to work when a custom `BaseField` is added to a `BaseFieldList` (ie, a `Part` or `PartModule`) with a `host` instance other than the `BaseFieldList` owner. See the linked PR and code for use cases and example usage.

#### Stock configs tweaks
- **[ManufacturerFixes](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/62)**<br/>Fix a bunch of stock parts not having manufacturers, add icons for the stock "Stratus Corporation" and "LightYear Tire Company" and two new agents, "FreeFall Parachutes" and "Clamp-O-Tron".
- **[LandingGearLights](https://github.com/KSPModdingLibs/KSPCommunityFixes/issues/122)**<br/>Fix the lights on the "LY-10" and "LY-35" landing gears not automatically turning on/off when extending/retracting the landing gear.

### Performance improvement figures

- CPU profiling results, KSPCF 1.37.0 vs stock, fresh sandbox save.
- 452 parts stock+DLCs craft (https://kerbalx.com/Zacspace/Exoloper-+-Delivery-System)
- 720P resolution, all graphics settings to the min to avoid being GPU-limited.
- 3 situations : idling on the launchpad, during launch at 3000m, idling in low kerbin orbit (LKO).
- AVG = average FPS | 1% = worst percentile ("1% lows") | IMP = Improvement over stock

#### Pentium N5030 4C/4T | 8 GB DDR4@2400Mhz | UHD 605 IGP @720P | Results over 200 frames

|              | AVG - Stock | AVG - KSPCF | AVG - IMP | 1% - Stock | 1% - KSPCF | 1% - IMP |
|--------------|:-----------:|:-----------:|:---------:|:----------:|:----------:|:--------:|
| Launchpad    |     10,0    |     15,8    |    58%    |     8,0    |    13,4    |    68%   |
| Launch@3000m |      8,4    |     12,1    |    44%    |     7,2    |    10,0    |    39%   |
| LKO          |     11,1    |     14,7    |    32%    |     9,3    |    12,8    |    38%   |

#### Ryzen 5800X3D | 32 GB DDR4@3600Mhz | Radeon RX 7600XT @ 720p | Results over 500 frames

|              | AVG - Stock | AVG - KSPCF | AVG - IMP | 1% - Stock | 1% - KSPCF | 1% - IMP |
|--------------|:-----------:|:-----------:|:---------:|:----------:|:----------:|:--------:|
| Launchpad    |     46,4    |     69,4    |    50%    |    39,2    |    59,2    |    51%   |
| Launch@3000m |     37,0    |     56,3    |    52%    |    31,4    |    44,2    |    41%   |
| LKO          |     49,5    |     92,0    |    86%    |    41,0    |    70,4    |    72%   |

### License

MIT

### Localization

This mod supports localization. If you wish to contribute a localization file, you can have the mod generate or update a language template by editing the `Settings.cfg` (see instructions near the end of the file).

### Building

After loading the solution in your IDE, add a `ReferencePath` pointing to the root of your KSP install :

For Visual Studio, right-click on the `KSPCommunityFixes` project > `Properties` > `Reference Paths`, add the path to your KSP install and save the changes. Closing and re-opening the solution might be needed for the changes to propagate.

Alternatively, you can do that manually by creating a `KSPCommunityFixes.csproj.user` file next to the `KSPCommunityFixes.csproj` file, with the following content :
```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <ReferencePath>Absolute\Path\To\Your\KSP\Install\Folder</ReferencePath>
  </PropertyGroup>
</Project>
```
Then close / re-open the solution.

Building in the `Debug` configuration will update the `GameData` folder in your KSP install, building in the `Release` configuration will additionally create a zipped release in the `Releases` repository root folder.

For incrementing the version, edit the `KSPCommunityFixes.version` KSP-AVC file, changes will be propagated to `AssemblyInfo.cs` when building in the `Release` configuration.

The `Start` action of the IDE will trigger a build, update the `GameData` files in the KSP install and launch KSP.
If doing so in the `Debug` configuration and if your KSP install is modified to be debuggable, you will be able to debug the code from within your IDE (if your IDE provides Unity debugging support).
