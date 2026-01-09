![](https://i.imgur.com/74Iovs6.jpeg) 
![License](https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-green)
![Downloads](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2FKSP-CKAN%2FCKAN-meta%2Frefs%2Fheads%2Fmaster%2Fdownload_counts.json&query=PromisedWorldsCore&label=Downloads)
![Last commit](https://img.shields.io/github/last-commit/PromisedWorlds/PromisedWorlds/main.svg)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/PromisedWorlds/PromisedWorlds)
![KSP Version](https://img.shields.io/badge/KSP-1.12.x-blue.svg)
# 🌌 Promised Worlds

**Promised Worlds is a faithful revival of the solar systems Intercept Games planned to release for KSP 2. Want to brave the crater lakes of Gurdamma? Launch between the molten seas of Rask and Rusk? Our team of veteran KSP 1 modders is working around the globe to bring you those experiences—and more!**

So far, we have implemented the Debdeb System. The Tuun System is in the early stages of development, with a few planets implemented and released. The full Tuun System is in development currently. The Qeg System is being conceptualized (an uncertain feature).

All content for Promised Worlds is being designed in-house. We are not using any KSP 2 assets. 
 
Each world has been meticulously crafted to align with KSP 2 development screenshots and data mining discoveries. For celestial bodies lacking implementation details (e.g., Umod), we are applying creative liberties to attain what we feel were the KSP 2 developers' intentions.

Promised Worlds is currently in early access. Planets, moons, and other features are being added incrementally in updates. We're nearing a full release now with only a handful of features left to add. 

If you want to stay up to date with progress or contribute, join our Discord server! https://discord.gg/cuY2Hx2emM

## 🚀 Installation Guide

### 📦 CKAN (Recommended)
CKAN is the easiest and most reliable way to install **Promised Worlds** and its dependencies.

- Select **“Promised Worlds – Debdeb”** to install the Debdeb system  
- Select **“Promised Worlds – Tuun”** to install the Tuun system  

CKAN will automatically download all required dependencies for you.

---

### 🌌 SpaceDock
❌ **Not supported anymore**

Due to repeated issues with uploading large files, we no longer maintain Promised Worlds on SpaceDock.  
Please install via **CKAN** or **GitHub** instead.  
If you encounter any issues with the GitHub release, reach out to the dev team on the [Discord server](https://discord.gg/cuY2Hx2emM).

---

### 🧩 Manual Installation (GitHub)
If you prefer to install manually:

1. Download the latest release from the [GitHub Releases](https://github.com/Constructalor/PromisedWorlds/releases) page.  
   - You need the **Core** `.zip` file and the `.zip` file(s) for any system(s) you want.  
2. Extract the **Core** `.zip` and place its `GameData` contents into your KSP `GameData` directory.  
3. For each system (Debdeb, Tuun, etc.) you want to add:
   - Extract the system’s `.zip` and place its `GameData` contents into your KSP `GameData` directory (this adds a folder under `PromisedWorlds`).  
4. Install the required dependencies:
   - [Kopernicus](https://github.com/Kopernicus/Kopernicus/releases) (Read the Kopernicus install Guide, as Kopernicus requires it's own dependencies)
   - [ScaledDecorator](https://github.com/Sushutt/ScaledDecorator/releases) (Included with Promised Worlds)
   - [KSP Community Fixes](https://github.com/KSPModdingLibs/KSPCommunityFixes/releases)  
   - [Singularity](https://forum.kerbalspaceprogram.com/topic/193709-wip18x-112x-singularity-black-hole-shaders/) *(only required for wormholes)*  
5. Extract each dependency’s `.zip` and place its folders into your `GameData` directory.

💡 **Tip:** If you’re new to modding, CKAN handles dependencies automatically and avoids most manual errors

---

## ❌ **Known Issues**

- Donk occasionally appears black when eclipsing Gurdamma (No Known Fix)

---
## ❓Why are there no commits and no new updates?
- The Promised Worlds Dev Team is working on new updates for Promised Worlds, sadly updates take time and all of the commits go to our Dev repository first, those commits are bleeding edge.
- After we decide that the update can be released, we release them publicly.
- If you want to track progress of the developer repository for Promised Worlds you can join the discord and take a look at the channel called "github activity".
  
## ⚙️ Options

In the `PromisedWorlds` directory, there is a `PromisedWorldsSettings.cfg` file with configurable options:

| Option | Description |
|:--|:--|
| **Skybox** | Enables the Promised Worlds Skybox *(requires[Sigma Skybox Replacements](https://github.com/Sigma88/Sigma-Replacements/releases/tag/B_v0.5.1)* (Release 2.0.0 and above)) |
| **Wormholes** | Enables wormholes *(requires Singularity for shaders)* |
| **DistanceFactor** | Controls how far from Kerbol the systems will be |
| **Rescale** | Resizes the systems *(requires [Sigma Dimensions](https://github.com/Sigma88/Sigma-Dimensions))* |
| **RealisticStarSize** | Makes stars more realistically sized relative to planets |
| **RemoveStockScreens** | Removes stock loading screens and only shows PW's |

## 🔨 Contributors

We'd like to thank all the Promised Worlds contributors who dedicated their time to help with this project. Thank you ❤️

| Role           | Contributors |
|----------------|--------------|
| **Project Lead** | Emu (@Constructalor) |
| **Community Manager** | vision |
| **Developers** | Arekusu, averageksp, techo, levitato, NexusHelium, ProximaCentauri, Sushut, wpetula, YGTE |
| **Contributors** | kerbalcommander543, Lad-8008, Localz, Nerdy Boy, Omni-Man, Oprissmian, pilot |
| **Translators** | haumea/tankocat, Chitak, Datsk, lebobas, Leo, Omni-Man, oprissmian, tuna_army1444, undex, zhuzhu, zTallsTwo, Alphastar |

As of now, we have **27** people actively contributing.

## ⚖️ License

📜 **License**  
Licensed under [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/)

✅ You may share and adapt our work with **proper** credit  
🚫 No commercial use  
🔁 Changes must be shared under the same license   

More information can be found in the [License.md](https://github.com/PromisedWorlds/PromisedWorlds/blob/89733c44ae02f62c4e30d520e7299b15171ce894/LICENSE.md) file.

<img src="https://i.imgur.com/ULoCdoq.png" alt="LicenseImg" width="150">

## 📚 Wiki
More information about the Star Systems and anything other regarding Promised Worlds is up on our [Wiki](https://promisedworlds.github.io/PWiki/).
