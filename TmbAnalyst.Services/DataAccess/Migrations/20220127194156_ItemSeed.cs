using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TmbAnalyst.Services.DataAccess.Migrations
{
    public partial class ItemSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemSourceCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "World Bosses" },
                    { 2, "Sunwell Plateau" },
                    { 3, "Zul'Aman" },
                    { 4, "Black Temple" },
                    { 5, "Hyjal Summit" },
                    { 6, "Tempest Keep" },
                    { 7, "Serpentshrine Cavern" },
                    { 8, "Magtheridon's Lair" },
                    { 9, "Gruul's Lair" },
                    { 10, "Karazhan" },
                    { 11, "Naxxramas" },
                    { 12, "Temple of Ahn'Qiraj" },
                    { 13, "Ruins of Ahn'Qiraj" },
                    { 14, "Zul'Gurub" },
                    { 15, "Blackwing Lair" },
                    { 16, "Onyxia's Lair" },
                    { 17, "Molten Core" }
                });

            migrationBuilder.InsertData(
                table: "ItemSources",
                columns: new[] { "Id", "ItemSourceCategoryId", "Name", "OrderNumber" },
                values: new object[,]
                {
                    { 1, 1, "Doom Lord Kazzak", 0 },
                    { 2, 1, "Doomwalker", 1 },
                    { 3, 1, "Azuregos", 2 },
                    { 4, 1, "Lord Kazzak", 3 },
                    { 5, 1, "Dragons Shared", 4 },
                    { 6, 1, "Emeriss", 5 },
                    { 7, 1, "Lethon", 6 },
                    { 8, 1, "Taerar", 7 },
                    { 9, 1, "Ysondre", 8 },
                    { 10, 2, "Trash", 0 },
                    { 11, 2, "Recipes", 1 },
                    { 12, 2, "Kalecgos", 2 },
                    { 13, 2, "Brutallus", 3 },
                    { 14, 2, "Felmyst", 4 },
                    { 15, 2, "Eredar Twins", 5 },
                    { 16, 2, "M'uru", 6 },
                    { 17, 2, "Kil'Jaeden", 7 },
                    { 18, 3, "Recipes", 0 },
                    { 19, 3, "Timed Event", 1 },
                    { 20, 3, "Nalorakk", 2 },
                    { 21, 3, "Jan'alai", 3 },
                    { 22, 3, "Akil'zon", 4 },
                    { 23, 3, "Halazzi", 5 },
                    { 24, 3, "Malacrass", 6 },
                    { 25, 3, "Zul'jin", 7 },
                    { 26, 4, "Trash", 0 },
                    { 27, 4, "Recipes", 1 },
                    { 28, 4, "Naj'entus", 2 },
                    { 29, 4, "Supremus", 3 },
                    { 30, 4, "Shade", 4 },
                    { 31, 4, "Gorefiend", 5 },
                    { 32, 4, "Gurtogg", 6 },
                    { 33, 4, "Reliquary", 7 },
                    { 34, 4, "Shahraz", 8 },
                    { 35, 4, "Council", 9 },
                    { 36, 4, "Illidan", 10 },
                    { 37, 5, "Trash", 0 },
                    { 38, 5, "Recipes", 1 },
                    { 39, 5, "Winterchill", 2 },
                    { 40, 5, "Anetheron", 3 },
                    { 41, 5, "Kaz'rogal", 4 },
                    { 42, 5, "Azgalor", 5 },
                    { 43, 5, "Archimonde", 6 },
                    { 44, 6, "Trash", 0 },
                    { 45, 6, "Recipes", 1 },
                    { 46, 6, "Al'ar", 2 },
                    { 47, 6, "Void Reaver", 3 },
                    { 48, 6, "Solarian", 4 },
                    { 49, 6, "Kael'thas", 5 },
                    { 50, 7, "Trash", 0 },
                    { 51, 7, "Recipes", 1 },
                    { 52, 7, "Hydross", 2 },
                    { 53, 7, "Lurker Below", 3 },
                    { 54, 7, "Leotheras", 4 },
                    { 55, 7, "Karathress", 5 },
                    { 56, 7, "Morogrim", 6 },
                    { 57, 7, "Lady Vashj", 7 },
                    { 58, 8, "Magtheridon", 0 },
                    { 59, 9, "Maulgar", 0 },
                    { 60, 9, "Gruul", 1 },
                    { 61, 10, "Trash", 0 },
                    { 62, 10, "Servants", 1 },
                    { 63, 10, "Attumen", 2 },
                    { 64, 10, "Moroes", 3 },
                    { 65, 10, "Maiden", 4 },
                    { 66, 10, "Opera Event", 5 },
                    { 67, 10, "The Curator", 6 },
                    { 68, 10, "Chess Event", 7 },
                    { 69, 10, "Illhoof", 8 },
                    { 70, 10, "Shade of Aran", 9 },
                    { 71, 10, "Netherspite", 10 },
                    { 72, 10, "Nightbane", 11 },
                    { 73, 10, "Malchezaar", 12 },
                    { 74, 11, "Tokens", 0 },
                    { 75, 11, "Trash", 1 },
                    { 76, 11, "Anub'Rekhan", 2 },
                    { 77, 11, "Faerlina", 3 },
                    { 78, 11, "Maexxna", 4 },
                    { 79, 11, "Noth", 5 },
                    { 80, 11, "Heigan", 6 },
                    { 81, 11, "Loatheb", 7 },
                    { 82, 11, "Razuvious", 8 },
                    { 83, 11, "Gothik", 9 },
                    { 84, 11, "Four Horsemen", 10 },
                    { 85, 11, "Patchwerk", 11 },
                    { 86, 11, "Grobbulus", 12 },
                    { 87, 11, "Gluth", 13 },
                    { 88, 11, "Thaddius", 14 },
                    { 89, 11, "Sapphiron", 15 },
                    { 90, 11, "Kel'Thuzad", 16 },
                    { 91, 12, "Mounts", 0 },
                    { 92, 12, "Enchants", 1 },
                    { 93, 12, "Tokens", 2 },
                    { 94, 12, "Trash", 3 },
                    { 95, 12, "Skeram", 4 },
                    { 96, 12, "Bug Trio", 5 },
                    { 97, 12, "Sartura", 6 },
                    { 98, 12, "Fankriss", 7 },
                    { 99, 12, "Viscidus", 8 },
                    { 100, 12, "Huhuran", 9 },
                    { 101, 12, "Twin Emperors", 10 },
                    { 102, 12, "Ouro", 11 },
                    { 103, 12, "C'Thun", 12 },
                    { 104, 13, "Enchants", 0 },
                    { 105, 13, "Tokens", 1 },
                    { 106, 13, "Trash", 2 },
                    { 107, 13, "Kurinnaxx", 3 },
                    { 108, 13, "General Rajaxx", 4 },
                    { 109, 13, "Moam", 5 },
                    { 110, 13, "Buru", 6 },
                    { 111, 13, "Ayamiss", 7 },
                    { 112, 13, "Ossirian", 8 },
                    { 113, 14, "Tokens", 0 },
                    { 114, 14, "Trash", 1 },
                    { 115, 14, "Shared", 2 },
                    { 116, 14, "Jeklik", 3 },
                    { 117, 14, "Venoxis", 4 },
                    { 118, 14, "Mar'li", 5 },
                    { 119, 14, "Bloodlord", 6 },
                    { 120, 14, "Edge of Madness", 7 },
                    { 121, 14, "Thekal", 8 },
                    { 122, 14, "Gahz'ranka", 9 },
                    { 123, 14, "Arlokk", 10 },
                    { 124, 14, "Jin'do", 11 },
                    { 125, 14, "Hakkar", 12 },
                    { 126, 15, "Trash", 0 },
                    { 127, 15, "Razorgore", 1 },
                    { 128, 15, "Vaelastrasz", 2 },
                    { 129, 15, "Broodlord", 3 },
                    { 130, 15, "Firemaw", 4 },
                    { 131, 15, "Ebonroc", 5 },
                    { 132, 15, "Flamegor", 6 },
                    { 133, 15, "Drake Shared Loot", 7 },
                    { 134, 15, "Chromaggus", 8 },
                    { 135, 15, "Nefarian", 9 },
                    { 136, 16, "Onyxia", 0 },
                    { 137, 17, "Recipes", 0 },
                    { 138, 17, "Trash", 1 },
                    { 139, 17, "Shared", 2 },
                    { 140, 17, "Lucifron", 3 },
                    { 141, 17, "Magmadar", 4 },
                    { 142, 17, "Gehennas", 5 },
                    { 143, 17, "Garr", 6 },
                    { 144, 17, "Shazzrah", 7 },
                    { 145, 17, "Baron Geddon", 8 },
                    { 146, 17, "Golemagg", 9 },
                    { 147, 17, "Sulfuron", 10 },
                    { 148, 17, "Majordomo", 11 },
                    { 149, 17, "Ragnaros", 12 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemSourceId", "Name" },
                values: new object[,]
                {
                    { 16665, 118, "Tome of Tranquilizing Shot" },
                    { 16795, 121, "Arcanist Crown" },
                    { 16796, 119, "Arcanist Leggings" },
                    { 16797, 123, "Arcanist Mantle" },
                    { 16798, 124, "Arcanist Robes" },
                    { 16799, 3, "Arcanist Bindings" },
                    { 16800, 118, "Arcanist Boots" },
                    { 16801, 122, "Arcanist Gloves" },
                    { 16802, 3, "Arcanist Belt" },
                    { 16803, 122, "Felheart Slippers" },
                    { 16804, 3, "Felheart Bracers" },
                    { 16805, 118, "Felheart Gloves" },
                    { 16806, 3, "Felheart Belt" },
                    { 16807, 123, "Felheart Shoulder Pads" },
                    { 16808, 121, "Felheart Horns" },
                    { 16809, 124, "Felheart Robes" },
                    { 16810, 119, "Felheart Pants" },
                    { 16811, 122, "Boots of Prophecy" },
                    { 16812, 120, "Gloves of Prophecy" },
                    { 16813, 121, "Circlet of Prophecy" },
                    { 16814, 119, "Pants of Prophecy" },
                    { 16815, 124, "Robes of Prophecy" },
                    { 16816, 125, "Mantle of Prophecy" },
                    { 16817, 3, "Girdle of Prophecy" },
                    { 16818, 109, "Netherwind Belt" },
                    { 16819, 3, "Vambraces of Prophecy" },
                    { 16820, 124, "Nightslayer Chestpiece" },
                    { 16821, 121, "Nightslayer Cover" },
                    { 16822, 119, "Nightslayer Pants" },
                    { 16823, 125, "Nightslayer Shoulder Pads" },
                    { 16824, 122, "Nightslayer Boots" },
                    { 16825, 3, "Nightslayer Bracelets" },
                    { 16826, 120, "Nightslayer Gloves" },
                    { 16827, 3, "Nightslayer Belt" },
                    { 16828, 3, "Cenarion Belt" },
                    { 16829, 118, "Cenarion Boots" },
                    { 16830, 3, "Cenarion Bracers" },
                    { 16831, 122, "Cenarion Gloves" },
                    { 16832, 115, "Bloodfang Spaulders" },
                    { 16833, 124, "Cenarion Vestments" },
                    { 16834, 121, "Cenarion Helm" },
                    { 16835, 119, "Cenarion Leggings" },
                    { 16836, 123, "Cenarion Spaulders" },
                    { 16837, 118, "Earthfury Boots" },
                    { 16838, 3, "Earthfury Belt" },
                    { 16839, 120, "Earthfury Gauntlets" },
                    { 16840, 3, "Earthfury Bracers" },
                    { 16841, 124, "Earthfury Vestments" },
                    { 16842, 121, "Earthfury Helmet" },
                    { 16843, 119, "Earthfury Legguards" },
                    { 16844, 123, "Earthfury Epaulets" },
                    { 16845, 124, "Giantstalker's Breastplate" },
                    { 16846, 121, "Giantstalker's Helmet" },
                    { 16847, 119, "Giantstalker's Leggings" },
                    { 16848, 125, "Giantstalker's Epaulets" },
                    { 16849, 120, "Giantstalker's Boots" },
                    { 16850, 3, "Giantstalker's Bracers" },
                    { 16851, 3, "Giantstalker's Belt" },
                    { 16852, 122, "Giantstalker's Gloves" },
                    { 16853, 124, "Lawbringer Chestguard" },
                    { 16854, 121, "Lawbringer Helm" },
                    { 16855, 119, "Lawbringer Legplates" },
                    { 16856, 123, "Lawbringer Spaulders" },
                    { 16857, 3, "Lawbringer Bracers" },
                    { 16858, 3, "Lawbringer Belt" },
                    { 16859, 118, "Lawbringer Boots" },
                    { 16860, 120, "Lawbringer Gauntlets" },
                    { 16861, 3, "Bracers of Might" },
                    { 16862, 120, "Sabatons of Might" },
                    { 16863, 118, "Gauntlets of Might" },
                    { 16864, 3, "Belt of Might" },
                    { 16865, 124, "Breastplate of Might" },
                    { 16866, 121, "Helm of Might" },
                    { 16867, 119, "Legplates of Might" },
                    { 16868, 125, "Pauldrons of Might" },
                    { 16897, 116, "Stormrage Chestguard" },
                    { 16898, 110, "Stormrage Boots" },
                    { 16899, 114, "Stormrage Handguards" },
                    { 16900, 117, "Stormrage Cover" },
                    { 16901, 127, "Stormrage Legguards" },
                    { 16902, 115, "Stormrage Pauldrons" },
                    { 16903, 109, "Stormrage Belt" },
                    { 16904, 108, "Stormrage Bracers" },
                    { 16905, 116, "Bloodfang Chestpiece" },
                    { 16906, 110, "Bloodfang Boots" },
                    { 16907, 114, "Bloodfang Gloves" },
                    { 16908, 117, "Bloodfang Hood" },
                    { 16909, 127, "Bloodfang Pants" },
                    { 16910, 109, "Bloodfang Belt" },
                    { 16911, 108, "Bloodfang Bracers" },
                    { 16912, 110, "Netherwind Boots" },
                    { 16913, 114, "Netherwind Gloves" },
                    { 16914, 117, "Netherwind Crown" },
                    { 16915, 127, "Netherwind Pants" },
                    { 16916, 116, "Netherwind Robes" },
                    { 16917, 115, "Netherwind Mantle" },
                    { 16918, 108, "Netherwind Bindings" },
                    { 16919, 110, "Boots of Transcendence" },
                    { 16920, 114, "Handguards of Transcendence" },
                    { 16921, 117, "Halo of Transcendence" },
                    { 16922, 127, "Leggings of Transcendence" },
                    { 16923, 116, "Robes of Transcendence" },
                    { 16924, 115, "Pauldrons of Transcendence" },
                    { 16925, 109, "Belt of Transcendence" },
                    { 16926, 108, "Bindings of Transcendence" },
                    { 16927, 110, "Nemesis Boots" },
                    { 16928, 114, "Nemesis Gloves" },
                    { 16929, 117, "Nemesis Skullcap" },
                    { 16930, 127, "Nemesis Leggings" },
                    { 16931, 116, "Nemesis Robes" },
                    { 16932, 115, "Nemesis Spaulders" },
                    { 16933, 109, "Nemesis Belt" },
                    { 16934, 108, "Nemesis Bracers" },
                    { 16935, 108, "Dragonstalker's Bracers" },
                    { 16936, 109, "Dragonstalker's Belt" },
                    { 16937, 115, "Dragonstalker's Spaulders" },
                    { 16938, 127, "Dragonstalker's Legguards" },
                    { 16939, 117, "Dragonstalker's Helm" },
                    { 16940, 114, "Dragonstalker's Gauntlets" },
                    { 16941, 110, "Dragonstalker's Greaves" },
                    { 16942, 116, "Dragonstalker's Breastplate" },
                    { 16943, 108, "Bracers of Ten Storms" },
                    { 16944, 109, "Belt of Ten Storms" },
                    { 16945, 115, "Epaulets of Ten Storms" },
                    { 16946, 127, "Legplates of Ten Storms" },
                    { 16947, 117, "Helmet of Ten Storms" },
                    { 16948, 114, "Gauntlets of Ten Storms" },
                    { 16949, 110, "Greaves of Ten Storms" },
                    { 16950, 116, "Breastplate of Ten Storms" },
                    { 16951, 108, "Judgement Bindings" },
                    { 16952, 109, "Judgement Belt" },
                    { 16953, 115, "Judgement Spaulders" },
                    { 16954, 127, "Judgement Legplates" },
                    { 16955, 117, "Judgement Crown" },
                    { 16956, 114, "Judgement Gauntlets" },
                    { 16957, 110, "Judgement Sabatons" },
                    { 16958, 116, "Judgement Breastplate" },
                    { 16959, 108, "Bracelets of Wrath" },
                    { 16960, 109, "Waistband of Wrath" },
                    { 16961, 115, "Pauldrons of Wrath" },
                    { 16962, 127, "Legplates of Wrath" },
                    { 16963, 117, "Helm of Wrath" },
                    { 16964, 114, "Gauntlets of Wrath" },
                    { 16965, 110, "Sabatons of Wrath" },
                    { 16966, 116, "Breastplate of Wrath" },
                    { 17063, 127, "Band of Accuria" },
                    { 17064, 117, "Shard of the Scale" },
                    { 17065, 119, "Medallion of Steadfast Might" },
                    { 17066, 121, "Drillborer Disk" },
                    { 17067, 117, "Ancient Cornerstone Grimoire" },
                    { 17068, 117, "Deathbringer" },
                    { 17069, 119, "Striker's Mark" },
                    { 17070, 57, "Fang of the Mystics" },
                    { 17071, 121, "Gutgore Ripper" },
                    { 17072, 124, "Blastershot Launcher" },
                    { 17073, 119, "Earthshaker" },
                    { 17074, 125, "Shadowstrike" },
                    { 17075, 117, "Vis'kag the Bloodletter" },
                    { 17076, 127, "Bonereaver's Edge" },
                    { 17077, 97, "Crimson Shocker" },
                    { 17078, 117, "Sapphiron Drape" },
                    { 17082, 127, "Shard of the Flame" },
                    { 17102, 127, "Cloak of the Shrouded Mists" },
                    { 17103, 124, "Azuresong Mageblade" },
                    { 17104, 127, "Spinal Reaper" },
                    { 17105, 121, "Aurastone Hammer" },
                    { 17106, 127, "Malistar's Defender" },
                    { 17107, 127, "Dragon's Blood Cape" },
                    { 17109, 118, "Choker of Enlightenment" },
                    { 17110, 123, "Seal of the Archmagus" },
                    { 17111, 58, "Blazefury Medallion" },
                    { 17112, 58, "Empyrean Demolisher" },
                    { 17113, 58, "Amberseal Keeper" },
                    { 17204, 127, "Eye of Sulfuras" },
                    { 17782, 123, "Talisman of Binding Shard" },
                    { 17966, 117, "Onyxia Hide Backpack" },
                    { 18202, 57, "Eskhandar's Left Claw" },
                    { 18203, 119, "Eskhandar's Right Claw" },
                    { 18204, 58, "Eskhandar's Pelt" },
                    { 18205, 117, "Eskhandar's Collar" },
                    { 18208, 57, "Drape of Benediction" },
                    { 18252, 4, "Pattern: Core Armor Kit" },
                    { 18257, 4, "Recipe: Major Rejuvenation Potion" },
                    { 18259, 4, "Formula: Enchant Weapon - Spell Power" },
                    { 18260, 4, "Formula: Enchant Weapon - Healing Power" },
                    { 18264, 4, "Plans: Elemental Sharpening Stone" },
                    { 18265, 4, "Pattern: Flarecore Wraps" },
                    { 18290, 4, "Schematic: Biznicks 247x128 Accurascope" },
                    { 18291, 4, "Schematic: Force Reactive Disk" },
                    { 18292, 4, "Schematic: Core Marksman Rifle" },
                    { 18422, 117, "Head of Onyxia" },
                    { 18541, 57, "Puissant Cape" },
                    { 18542, 57, "Typhoon" },
                    { 18543, 58, "Ring of Entropy" },
                    { 18544, 58, "Doomhide Gauntlets" },
                    { 18545, 57, "Leggings of Arcane Supremacy" },
                    { 18546, 58, "Infernal Headcage" },
                    { 18547, 57, "Unmelting Ice Girdle" },
                    { 18563, 123, "Bindings of the Windseeker" },
                    { 18564, 121, "Bindings of the Windseeker" },
                    { 18646, 126, "The Eye of Divinity" },
                    { 18665, 58, "The Eye of Shadow" },
                    { 18703, 126, "Ancient Petrified Leaf" },
                    { 18704, 57, "Mature Blue Dragon Sinew" },
                    { 18705, 117, "Mature Black Dragon Sinew" },
                    { 18803, 126, "Finkle's Lava Dredger" },
                    { 18805, 126, "Core Hound Tooth" },
                    { 18806, 126, "Core Forged Greaves" },
                    { 18808, 126, "Gloves of the Hypnotic Flame" },
                    { 18809, 126, "Sash of Whispered Secrets" },
                    { 18810, 126, "Wild Growth Spaulders" },
                    { 18811, 126, "Fireproof Cloak" },
                    { 18812, 126, "Wristguards of True Flight" },
                    { 18813, 117, "Ring of Binding" },
                    { 18814, 127, "Choker of the Fire Lord" },
                    { 18815, 127, "Essence of the Pure Flame" },
                    { 18816, 127, "Perdition's Blade" },
                    { 18817, 127, "Crown of Destruction" },
                    { 18820, 97, "Talisman of Ephemeral Power" },
                    { 18821, 97, "Quick Strike Ring" },
                    { 18822, 97, "Obsidian Edged Blade" },
                    { 18823, 97, "Aged Core Leather Gloves" },
                    { 18824, 97, "Magma Tempered Boots" },
                    { 18829, 97, "Deep Earth Spaulders" },
                    { 18832, 121, "Brutality Blade" },
                    { 18842, 124, "Staff of Dominance" },
                    { 18861, 97, "Flamewaker Legplates" },
                    { 18872, 97, "Manastorm Leggings" },
                    { 18875, 97, "Salamander Scale Pants" },
                    { 18878, 97, "Sorcerous Dagger" },
                    { 18879, 97, "Heavy Dark Iron Ring" },
                    { 19002, 116, "Head of Nefarian" },
                    { 19130, 57, "Cold Snap" },
                    { 19131, 57, "Snowblind Shoes" },
                    { 19132, 57, "Crystal Adorned Crown" },
                    { 19133, 58, "Fel Infused Leggings" },
                    { 19134, 58, "Flayed Doomguard Belt" },
                    { 19135, 58, "Blacklight Bracer" },
                    { 19136, 97, "Mana Igniting Cord" },
                    { 19137, 127, "Onslaught Girdle" },
                    { 19138, 127, "Band of Sulfuras" },
                    { 19139, 126, "Fireguard Shoulders" },
                    { 19140, 126, "Cauterizing Band" },
                    { 19142, 97, "Fire Runed Grimoire" },
                    { 19143, 97, "Flameguard Gauntlets" },
                    { 19144, 97, "Sabatons of the Flamewalker" },
                    { 19145, 97, "Robe of Volatile Power" },
                    { 19146, 97, "Wristguards of Stability" },
                    { 19147, 97, "Ring of Spell Power" },
                    { 19334, 108, "The Untamed Blade" },
                    { 19335, 108, "Spineshatter" },
                    { 19336, 108, "Arcane Infused Gem" },
                    { 19337, 108, "The Black Book" },
                    { 19339, 109, "Mind Quickening Gem" },
                    { 19340, 109, "Rune of Metamorphosis" },
                    { 19341, 110, "Lifegiving Gem" },
                    { 19342, 110, "Venomous Totem" },
                    { 19343, 111, "Scrolls of Blinding Light" },
                    { 19344, 111, "Natural Alignment Crystal" },
                    { 19345, 112, "Aegis of Preservation" },
                    { 19346, 109, "Dragonfang Blade" },
                    { 19347, 115, "Claw of Chromaggus" },
                    { 19348, 109, "Red Dragonscale Protector" },
                    { 19349, 115, "Elementium Reinforced Bulwark" },
                    { 19350, 110, "Heartstriker" },
                    { 19351, 110, "Maladath, Runed Blade of the Black Flight" },
                    { 19352, 115, "Chromatically Tempered Sword" },
                    { 19353, 114, "Drake Talon Cleaver" },
                    { 19354, 3, "Draconic Avenger" },
                    { 19355, 114, "Shadow Wing Focus Staff" },
                    { 19356, 116, "Staff of the Shadow Flame" },
                    { 19357, 113, "Herald of Woe" },
                    { 19358, 3, "Draconic Maul" },
                    { 19360, 116, "Lok'amir il Romathis" },
                    { 19361, 115, "Ashjre'thul, Crossbow of Smiting" },
                    { 19362, 3, "Doom's Edge" },
                    { 19363, 116, "Crul'shorukh, Edge of Chaos" },
                    { 19364, 116, "Ashkandi, Greatsword of the Brotherhood" },
                    { 19365, 111, "Claw of the Black Drake" },
                    { 19367, 113, "Dragon's Touch" },
                    { 19368, 112, "Dragonbreath Hand Cannon" },
                    { 19369, 108, "Gloves of Rapid Evolution" },
                    { 19370, 108, "Mantle of the Blackwing Cabal" },
                    { 19371, 109, "Pendant of the Fallen Dragon" },
                    { 19372, 109, "Helm of Endless Rage" },
                    { 19373, 110, "Black Brood Pauldrons" },
                    { 19374, 110, "Bracers of Arcane Accuracy" },
                    { 19375, 116, "Mish'undare, Circlet of the Mind Flayer" },
                    { 19376, 116, "Archimtiros' Ring of Reckoning" },
                    { 19377, 116, "Prestor's Talisman of Connivery" },
                    { 19378, 116, "Cloak of the Brood Lord" },
                    { 19379, 116, "Neltharion's Tear" },
                    { 19380, 116, "Therazane's Link" },
                    { 19381, 116, "Boots of the Shadow Flame" },
                    { 19382, 116, "Pure Elementium Band" },
                    { 19385, 115, "Empowered Leggings" },
                    { 19386, 115, "Elementium Threaded Cloak" },
                    { 19387, 115, "Chromatic Boots" },
                    { 19388, 115, "Angelista's Grasp" },
                    { 19389, 115, "Taut Dragonhide Shoulderpads" },
                    { 19390, 115, "Taut Dragonhide Gloves" },
                    { 19391, 115, "Shimmering Geta" },
                    { 19392, 115, "Girdle of the Fallen Crusader" },
                    { 19393, 115, "Primalist's Linked Waistguard" },
                    { 19394, 114, "Drake Talon Pauldrons" },
                    { 19395, 114, "Rejuvenating Gem" },
                    { 19396, 114, "Taut Dragonhide Belt" },
                    { 19397, 114, "Ring of Blackrock" },
                    { 19398, 111, "Cloak of Firemaw" },
                    { 19399, 111, "Black Ash Robe" },
                    { 19400, 111, "Firemaw's Clutch" },
                    { 19401, 111, "Primalist's Linked Legguards" },
                    { 19402, 111, "Legguards of the Fallen Crusader" },
                    { 19403, 112, "Band of Forced Concentration" },
                    { 19405, 112, "Malfurion's Blessed Bulwark" },
                    { 19406, 112, "Drake Fang Talisman" },
                    { 19407, 112, "Ebony Flame Gloves" },
                    { 19430, 113, "Shroud of Pure Thought" },
                    { 19431, 113, "Styleen's Impeding Scarab" },
                    { 19432, 113, "Circle of Applied Force" },
                    { 19433, 113, "Emberweave Leggings" },
                    { 19434, 3, "Band of Dark Dominion" },
                    { 19435, 3, "Essence Gatherer" },
                    { 19436, 3, "Cloak of Draconic Might" },
                    { 19437, 3, "Boots of Pure Thought" },
                    { 19438, 3, "Ringo's Blizzard Boots" },
                    { 19439, 3, "Interlaced Shadow Jerkin" },
                    { 19716, 64, "Primal Hakkari Bindings" },
                    { 19717, 64, "Primal Hakkari Armsplint" },
                    { 19718, 64, "Primal Hakkari Stanchion" },
                    { 19719, 64, "Primal Hakkari Girdle" },
                    { 19720, 64, "Primal Hakkari Sash" },
                    { 19721, 64, "Primal Hakkari Shawl" },
                    { 19722, 64, "Primal Hakkari Tabard" },
                    { 19723, 64, "Primal Hakkari Kossack" },
                    { 19724, 64, "Primal Hakkari Aegis" },
                    { 19802, 107, "Heart of Hakkar" },
                    { 19852, 107, "Ancient Hakkari Manslayer" },
                    { 19853, 107, "Gurubashi Dwarf Destroyer" },
                    { 19854, 107, "Zin'rokh, Destroyer of Worlds" },
                    { 19855, 107, "Bloodsoaked Legplates" },
                    { 19856, 107, "The Eye of Hakkar" },
                    { 19857, 107, "Cloak of Consumption" },
                    { 19859, 107, "Fang of the Faceless" },
                    { 19861, 107, "Touch of Chaos" },
                    { 19862, 107, "Aegis of the Blood God" },
                    { 19863, 101, "Primalist's Seal" },
                    { 19864, 107, "Bloodcaller" },
                    { 19865, 107, "Warblade of the Hakkari" },
                    { 19866, 101, "Warblade of the Hakkari" },
                    { 19867, 101, "Bloodlord's Defender" },
                    { 19869, 101, "Blooddrenched Grips" },
                    { 19870, 101, "Hakkari Loa Cloak" },
                    { 19871, 100, "Talisman of Protection" },
                    { 19872, 101, "Swift Razzashi Raptor" },
                    { 19873, 101, "Overlord's Crimson Band" },
                    { 19874, 101, "Halberd of Smiting" },
                    { 19875, 106, "Bloodstained Coif" },
                    { 19876, 107, "Soul Corrupter's Necklace" },
                    { 19877, 101, "Animist's Leggings" },
                    { 19878, 101, "Bloodsoaked Pauldrons" },
                    { 19884, 106, "Jin'do's Judgement" },
                    { 19885, 106, "Jin'do's Evil Eye" },
                    { 19886, 106, "The Hexxer's Cover" },
                    { 19887, 106, "Bloodstained Legplates" },
                    { 19888, 106, "Overlord's Embrace" },
                    { 19889, 106, "Blooddrenched Leggings" },
                    { 19890, 106, "Jin'do's Hexxer" },
                    { 19891, 106, "Jin'do's Bag of Whammies" },
                    { 19892, 106, "Animist's Boots" },
                    { 19893, 101, "Zanzil's Seal" },
                    { 19894, 106, "Bloodsoaked Gauntlets" },
                    { 19895, 101, "Bloodtinged Kilt" },
                    { 19896, 103, "Thekal's Grasp" },
                    { 19897, 103, "Betrayer's Boots" },
                    { 19898, 103, "Seal of Jin" },
                    { 19899, 103, "Ritualistic Legguards" },
                    { 19900, 99, "Zulian Stone Axe" },
                    { 19901, 103, "Zulian Slicer" },
                    { 19902, 103, "Swift Zulian Tiger" },
                    { 19903, 99, "Fang of Venoxis" },
                    { 19904, 99, "Runed Bloodstained Hauberk" },
                    { 19905, 99, "Zanzil's Band" },
                    { 19906, 99, "Blooddrenched Footpads" },
                    { 19907, 99, "Zulian Tigerhide Cloak" },
                    { 19908, 3, "Sceptre of Smiting" },
                    { 19909, 105, "Will of Arlokk" },
                    { 19910, 105, "Arlokk's Grasp" },
                    { 19912, 105, "Overlord's Onyx Band" },
                    { 19913, 105, "Bloodsoaked Greaves" },
                    { 19914, 105, "Panther Hide Sack" },
                    { 19915, 98, "Zulian Defender" },
                    { 19918, 98, "Jeklik's Crusher" },
                    { 19919, 100, "Bloodstained Greaves" },
                    { 19920, 98, "Primalist's Band" },
                    { 19921, 3, "Zulian Hacker" },
                    { 19922, 105, "Arlokk's Hoodoo Stick" },
                    { 19923, 98, "Jeklik's Opaline Talisman" },
                    { 19925, 100, "Band of Jin" },
                    { 19927, 100, "Mar'li's Touch" },
                    { 19928, 98, "Animist's Spaulders" },
                    { 19929, 106, "Bloodtinged Gloves" },
                    { 19930, 100, "Mar'li's Eye" },
                    { 19939, 102, "Gri'lek's Blood" },
                    { 19940, 102, "Renataki's Tooth" },
                    { 19941, 102, "Wushoolay's Mane" },
                    { 19942, 102, "Hazza'rah's Dream Thread" },
                    { 19944, 104, "Nat Pagle's Fish Terminator" },
                    { 19945, 104, "Foror's Eyepatch" },
                    { 19946, 104, "Tigule's Harpoon" },
                    { 19947, 104, "Nat Pagle's Broken Reel" },
                    { 19961, 102, "Gri'lek's Grinder" },
                    { 19962, 102, "Gri'lek's Carver" },
                    { 19963, 102, "Pitchfork of Madness" },
                    { 19964, 102, "Renataki's Soul Conduit" },
                    { 19965, 102, "Wushoolay's Poker" },
                    { 19967, 102, "Thoughtblighter" },
                    { 19968, 102, "Fiery Retributer" },
                    { 19993, 102, "Hoodoo Hunting Bow" },
                    { 20032, 100, "Flowing Ritual Robes" },
                    { 20038, 101, "Mandokir's Sting" },
                    { 20257, 107, "Seafury Gauntlets" },
                    { 20258, 3, "Zulian Ceremonial Staff" },
                    { 20259, 3, "Shadow Panther Hide Gloves" },
                    { 20260, 103, "Seafury Leggings" },
                    { 20261, 3, "Shadow Panther Hide Belt" },
                    { 20262, 98, "Seafury Boots" },
                    { 20263, 3, "Gurubashi Helm" },
                    { 20264, 107, "Peacekeeper Gauntlets" },
                    { 20265, 98, "Peacekeeper Boots" },
                    { 20266, 103, "Peacekeeper Leggings" },
                    { 20577, 62, "Nightmare Blade" },
                    { 20578, 63, "Emerald Dragonfang" },
                    { 20579, 59, "Green Dragonskin Cloak" },
                    { 20580, 59, "Hammer of Bestial Fury" },
                    { 20581, 59, "Staff of Rampant Growth" },
                    { 20582, 59, "Trance Stone" },
                    { 20599, 60, "Polished Ironwood Crossbow" },
                    { 20615, 59, "Dragonspur Wraps" },
                    { 20616, 59, "Dragonbone Wristguards" },
                    { 20617, 59, "Ancient Corroded Leggings" },
                    { 20618, 59, "Gloves of Delusional Power" },
                    { 20619, 59, "Acid Inscribed Greaves" },
                    { 20621, 60, "Boots of the Endless Moor" },
                    { 20622, 60, "Dragonheart Necklace" },
                    { 20623, 60, "Circlet of Restless Dreams" },
                    { 20624, 60, "Ring of the Unliving" },
                    { 20625, 61, "Belt of the Dark Bog" },
                    { 20626, 61, "Black Bark Wristbands" },
                    { 20627, 61, "Dark Heart Pants" },
                    { 20628, 61, "Deviate Growth Cap" },
                    { 20629, 61, "Malignant Footguards" },
                    { 20630, 61, "Gauntlets of the Shining Light" },
                    { 20631, 62, "Mendicant's Slippers" },
                    { 20632, 62, "Mindtear Band" },
                    { 20633, 62, "Unnatural Leather Spaulders" },
                    { 20634, 62, "Boots of Fright" },
                    { 20635, 63, "Jade Inlaid Vestments" },
                    { 20636, 63, "Hibernation Crystal" },
                    { 20637, 63, "Acid Inscribed Pauldrons" },
                    { 20638, 63, "Leggings of the Demented Mind" },
                    { 20639, 63, "Strangely Glyphed Legplates" },
                    { 20644, 59, "Nightmare Engulfed Object" },
                    { 20727, 81, "Formula: Enchant Gloves - Shadow Power" },
                    { 20728, 81, "Formula: Enchant Gloves - Frost Power" },
                    { 20729, 81, "Formula: Enchant Gloves - Fire Power" },
                    { 20730, 81, "Formula: Enchant Gloves - Healing Power" },
                    { 20731, 81, "Formula: Enchant Gloves - Superior Agility" },
                    { 20734, 81, "Formula: Enchant Cloak - Stealth" },
                    { 20736, 81, "Formula: Enchant Cloak - Dodge" },
                    { 20884, 64, "Qiraji Magisterial Ring" },
                    { 20885, 64, "Qiraji Martial Drape" },
                    { 20886, 64, "Qiraji Spiked Hilt" },
                    { 20888, 64, "Qiraji Ceremonial Ring" },
                    { 20889, 64, "Qiraji Regal Drape" },
                    { 20890, 64, "Qiraji Ornate Hilt" },
                    { 20926, 64, "Vek'nilash's Circlet" },
                    { 20927, 64, "Ouro's Intact Hide" },
                    { 20928, 64, "Qiraji Bindings of Command" },
                    { 20929, 64, "Carapace of the Old God" },
                    { 20930, 64, "Vek'lor's Diadem" },
                    { 20931, 64, "Skin of the Great Sandworm" },
                    { 20932, 64, "Qiraji Bindings of Dominance" },
                    { 20933, 64, "Husk of the Old God" },
                    { 21126, 90, "Death's Sting" },
                    { 21128, 82, "Staff of the Qiraji Prophets" },
                    { 21134, 90, "Dark Edge of Insanity" },
                    { 21218, 80, "Blue Qiraji Resonating Crystal" },
                    { 21220, 96, "Head of Ossirian the Unscarred" },
                    { 21221, 90, "Eye of C'Thun" },
                    { 21232, 64, "Imperial Qiraji Armaments" },
                    { 21237, 64, "Imperial Qiraji Regalia" },
                    { 21321, 80, "Red Qiraji Resonating Crystal" },
                    { 21323, 80, "Green Qiraji Resonating Crystal" },
                    { 21324, 80, "Yellow Qiraji Resonating Crystal" },
                    { 21371, 4, "Pattern: Core Felcloth Bag" },
                    { 21452, 96, "Staff of the Ruins" },
                    { 21453, 96, "Mantle of the Horusath" },
                    { 21454, 96, "Runic Stone Shoulders" },
                    { 21455, 93, "Southwind Helm" },
                    { 21456, 96, "Sandstorm Cloak" },
                    { 21457, 96, "Bracers of Brutality" },
                    { 21458, 96, "Gauntlets of New Life" },
                    { 21459, 96, "Crossbow of Imminent Doom" },
                    { 21460, 96, "Helm of Domination" },
                    { 21461, 96, "Leggings of the Black Blizzard" },
                    { 21462, 96, "Gloves of Dark Wisdom" },
                    { 21463, 96, "Ossirian's Binding" },
                    { 21464, 96, "Shackles of the Unscarred" },
                    { 21466, 95, "Stinger of Ayamiss" },
                    { 21467, 93, "Thick Silithid Chestguard" },
                    { 21468, 93, "Mantle of Maz'Nadir" },
                    { 21469, 93, "Gauntlets of Southwind" },
                    { 21470, 93, "Cloak of the Savior" },
                    { 21471, 93, "Talon of Furious Concentration" },
                    { 21472, 93, "Dustwind Turban" },
                    { 21473, 93, "Eye of Moam" },
                    { 21474, 93, "Chitinous Shoulderguards" },
                    { 21475, 93, "Legplates of the Destroyer" },
                    { 21476, 93, "Obsidian Scaled Leggings" },
                    { 21477, 93, "Ring of Fury" },
                    { 21478, 95, "Bow of Taut Sinew" },
                    { 21479, 93, "Gauntlets of the Immovable" },
                    { 21480, 95, "Scaled Silithid Gauntlets" },
                    { 21481, 95, "Boots of the Desert Protector" },
                    { 21482, 95, "Boots of the Fiery Sands" },
                    { 21483, 95, "Ring of the Desert Winds" },
                    { 21484, 95, "Helm of Regrowth" },
                    { 21485, 94, "Buru's Skull Fragment" },
                    { 21486, 94, "Gloves of the Swarm" },
                    { 21487, 94, "Slimy Scaled Gauntlets" },
                    { 21488, 94, "Fetish of Chitinous Spikes" },
                    { 21489, 94, "Quicksand Waders" },
                    { 21490, 94, "Slime Kickers" },
                    { 21491, 94, "Scaled Bracers of the Gorger" },
                    { 21492, 92, "Manslayer of the Qiraji" },
                    { 21493, 92, "Boots of the Vanguard" },
                    { 21494, 92, "Southwind's Grasp" },
                    { 21495, 92, "Legplates of the Qiraji Command" },
                    { 21496, 92, "Bracers of Qiraji Command" },
                    { 21497, 92, "Boots of the Qiraji General" },
                    { 21498, 91, "Qiraji Sacrificial Dagger" },
                    { 21499, 91, "Vestments of the Shifting Sands" },
                    { 21500, 91, "Belt of the Inquisition" },
                    { 21501, 91, "Toughened Silithid Hide Gloves" },
                    { 21502, 91, "Sand Reaver Wristguards" },
                    { 21503, 91, "Belt of the Sand Reaver" },
                    { 21579, 90, "Vanquished Tentacle of C'Thun" },
                    { 21581, 90, "Gauntlets of Annihilation" },
                    { 21582, 90, "Grasp of the Old God" },
                    { 21583, 90, "Cloak of Clarity" },
                    { 21585, 90, "Dark Storm Gauntlets" },
                    { 21586, 90, "Belt of Never-ending Agony" },
                    { 21596, 90, "Ring of the Godslayer" },
                    { 21597, 88, "Royal Scepter of Vek'lor" },
                    { 21598, 88, "Royal Qiraji Belt" },
                    { 21599, 88, "Vek'lor's Gloves of Devastation" },
                    { 21600, 88, "Boots of Epiphany" },
                    { 21601, 88, "Ring of Emperor Vek'lor" },
                    { 21602, 88, "Qiraji Execution Bracers" },
                    { 21603, 83, "Wand of Qiraji Nobility" },
                    { 21604, 88, "Bracelets of Royal Redemption" },
                    { 21605, 88, "Gloves of the Hidden Temple" },
                    { 21606, 88, "Belt of the Fallen Emperor" },
                    { 21607, 88, "Grasp of the Fallen Emperor" },
                    { 21608, 88, "Amulet of Vek'nilash" },
                    { 21609, 88, "Regenerating Belt of Vek'nilash" },
                    { 21610, 89, "Wormscale Blocker" },
                    { 21611, 89, "Burrower Bracers" },
                    { 21615, 89, "Don Rigoberto's Lost Hat" },
                    { 21616, 87, "Huhuran's Stinger" },
                    { 21617, 87, "Wasphide Gauntlets" },
                    { 21618, 87, "Hive Defiler Wristguards" },
                    { 21619, 87, "Gloves of the Messiah" },
                    { 21620, 87, "Ring of the Martyr" },
                    { 21621, 87, "Cloak of the Golden Hive" },
                    { 21622, 86, "Sharpened Silithid Femur" },
                    { 21623, 86, "Gauntlets of the Righteous Champion" },
                    { 21624, 86, "Gauntlets of Kalimdor" },
                    { 21625, 86, "Scarab Brooch" },
                    { 21626, 86, "Slime-coated Leggings" },
                    { 21627, 85, "Cloak of Untold Secrets" },
                    { 21635, 85, "Barb of the Sand Reaver" },
                    { 21639, 85, "Pauldrons of the Unrelenting" },
                    { 21645, 85, "Hive Tunneler's Boots" },
                    { 21647, 85, "Fetish of the Sand Reaver" },
                    { 21648, 84, "Recomposed Boots" },
                    { 21650, 85, "Ancient Qiraji Ripper" },
                    { 21651, 85, "Scaled Sand Reaver Leggings" },
                    { 21652, 85, "Silithid Carapace Chestguard" },
                    { 21663, 85, "Robes of the Guardian Saint" },
                    { 21664, 85, "Barbed Choker" },
                    { 21665, 85, "Mantle of Wicked Revenge" },
                    { 21666, 84, "Sartura's Might" },
                    { 21667, 84, "Legplates of Blazing Light" },
                    { 21668, 84, "Scaled Leggings of Qiraji Fury" },
                    { 21669, 84, "Creeping Vine Helm" },
                    { 21670, 84, "Badge of the Swarmguard" },
                    { 21671, 84, "Robes of the Battleguard" },
                    { 21672, 84, "Gloves of Enforcement" },
                    { 21673, 84, "Silithid Claw" },
                    { 21674, 84, "Gauntlets of Steadfast Determination" },
                    { 21675, 84, "Thick Qirajihide Belt" },
                    { 21676, 84, "Leggings of the Festering Swarm" },
                    { 21677, 86, "Ring of the Qiraji Fury" },
                    { 21678, 84, "Necklace of Purity" },
                    { 21679, 88, "Kalimdor's Revenge" },
                    { 21680, 83, "Vest of Swift Execution" },
                    { 21681, 83, "Ring of the Devoured" },
                    { 21682, 83, "Bile-Covered Gauntlets" },
                    { 21683, 83, "Mantle of the Desert Crusade" },
                    { 21684, 83, "Mantle of the Desert's Fury" },
                    { 21685, 83, "Petrified Scarab" },
                    { 21686, 83, "Mantle of Phrenic Power" },
                    { 21687, 83, "Ukko's Ring of Darkness" },
                    { 21688, 83, "Boots of the Fallen Hero" },
                    { 21689, 83, "Gloves of Ebru" },
                    { 21690, 83, "Angelista's Charm" },
                    { 21691, 83, "Ooze-ridden Gauntlets" },
                    { 21692, 83, "Triad Girdle" },
                    { 21693, 83, "Guise of the Devourer" },
                    { 21694, 83, "Ternary Mantle" },
                    { 21695, 83, "Angelista's Touch" },
                    { 21696, 83, "Robes of the Triumvirate" },
                    { 21697, 83, "Cape of the Trinity" },
                    { 21698, 82, "Leggings of Immersion" },
                    { 21699, 82, "Barrage Shoulders" },
                    { 21700, 82, "Pendant of the Qiraji Guardian" },
                    { 21701, 82, "Cloak of Concentrated Hatred" },
                    { 21702, 82, "Amulet of Foul Warding" },
                    { 21703, 82, "Hammer of Ji'zhi" },
                    { 21704, 82, "Boots of the Redeemed Prophecy" },
                    { 21705, 82, "Boots of the Fallen Prophet" },
                    { 21706, 82, "Boots of the Unwavering Will" },
                    { 21707, 82, "Ring of Swarming Thought" },
                    { 21708, 82, "Beetle Scaled Wristguards" },
                    { 21715, 96, "Sand Polished Hammer" },
                    { 21800, 3, "Silithid Husked Launcher" },
                    { 21801, 3, "Antenna of Invigoration" },
                    { 21802, 3, "The Lost Kris of Zedd" },
                    { 21803, 3, "Helm of the Holy Avenger" },
                    { 21804, 3, "Coif of Elemental Fury" },
                    { 21806, 3, "Gavel of Qiraji Authority" },
                    { 21809, 3, "Fury of the Forgotten Swarm" },
                    { 21810, 3, "Treads of the Wandering Nomad" },
                    { 21814, 82, "Breastplate of Annihilation" },
                    { 21836, 3, "Ritssyn's Ring of Chaos" },
                    { 21837, 3, "Anubisath Warhammer" },
                    { 21838, 3, "Garb of Royal Ascension" },
                    { 21839, 90, "Scepter of the False Prophet" },
                    { 21856, 3, "Neretzek, The Blood Drinker" },
                    { 21888, 3, "Gloves of the Immortal" },
                    { 21889, 3, "Gloves of the Redeemed Prophecy" },
                    { 21891, 3, "Shard of the Fallen Star" },
                    { 21903, 3, "Pattern: Soulcloth Shoulders" },
                    { 21904, 3, "Pattern: Soulcloth Vest" },
                    { 22220, 93, "Plans: Black Grasp of the Destroyer" },
                    { 22222, 82, "Plans: Thick Obsidian Breastplate" },
                    { 22349, 64, "Desecrated Breastplate" },
                    { 22350, 64, "Desecrated Tunic" },
                    { 22351, 64, "Desecrated Robe" },
                    { 22352, 64, "Desecrated Legplates" },
                    { 22353, 64, "Desecrated Helmet" },
                    { 22354, 64, "Desecrated Pauldrons" },
                    { 22355, 64, "Desecrated Bracers" },
                    { 22356, 64, "Desecrated Waistguard" },
                    { 22357, 64, "Desecrated Gauntlets" },
                    { 22358, 64, "Desecrated Sabatons" },
                    { 22359, 64, "Desecrated Legguards" },
                    { 22360, 64, "Desecrated Headpiece" },
                    { 22361, 64, "Desecrated Spaulders" },
                    { 22362, 64, "Desecrated Wristguards" },
                    { 22363, 64, "Desecrated Girdle" },
                    { 22364, 64, "Desecrated Handguards" },
                    { 22365, 64, "Desecrated Boots" },
                    { 22366, 64, "Desecrated Leggings" },
                    { 22367, 64, "Desecrated Circlet" },
                    { 22368, 64, "Desecrated Shoulderpads" },
                    { 22369, 64, "Desecrated Bindings" },
                    { 22370, 64, "Desecrated Belt" },
                    { 22371, 64, "Desecrated Gloves" },
                    { 22372, 64, "Desecrated Sandals" },
                    { 22373, 3, "Wartorn Leather Scrap" },
                    { 22374, 3, "Wartorn Chain Scrap" },
                    { 22375, 3, "Wartorn Plate Scrap" },
                    { 22376, 3, "Wartorn Cloth Scrap" },
                    { 22396, 85, "Totem of Life" },
                    { 22399, 86, "Idol of Health" },
                    { 22402, 85, "Libram of Grace" },
                    { 22520, 79, "The Phylactery of Kel'Thuzad" },
                    { 22545, 3, "Formula: Enchant Boots - Surefooted" },
                    { 22559, 47, "Formula: Enchant Weapon - Mongoose" },
                    { 22560, 53, "Formula: Enchant Weapon - Sunfire" },
                    { 22561, 52, "Formula: Enchant Weapon - Soulfrost" },
                    { 22637, 64, "Primal Hakkari Idol" },
                    { 22682, 64, "Frozen Rune" },
                    { 22691, 73, "Corrupted Ashbringer" },
                    { 22711, 97, "Cloak of the Hakkari Worshippers" },
                    { 22712, 97, "Might of the Tribe" },
                    { 22713, 97, "Zulian Scepter of Rites" },
                    { 22714, 97, "Sacrificial Gauntlets" },
                    { 22715, 97, "Gloves of the Tormented" },
                    { 22716, 97, "Belt of Untapped Power" },
                    { 22718, 97, "Blooddrenched Mask" },
                    { 22720, 97, "Zulian Headdress" },
                    { 22721, 97, "Band of Servitude" },
                    { 22722, 97, "Seal of the Gurubashi Berserker" },
                    { 22726, 64, "Splinter of Atiesh" },
                    { 22730, 90, "Eyestalk Waist Cord" },
                    { 22731, 90, "Cloak of the Devoured" },
                    { 22732, 90, "Mark of C'Thun" },
                    { 22739, 104, "Tome of Polymorph: Turtle" },
                    { 22798, 79, "Might of Menethil" },
                    { 22799, 79, "Soulseeker" },
                    { 22800, 70, "Brimstone Staff" },
                    { 22801, 77, "Spire of Twilight" },
                    { 22802, 79, "Kingsfall" },
                    { 22803, 75, "Midnight Haze" },
                    { 22804, 67, "Maexxna's Fang" },
                    { 22806, 66, "Widow's Remorse" },
                    { 22807, 67, "Wraith Blade" },
                    { 22808, 77, "The Castigator" },
                    { 22809, 73, "Maul of the Redeemed Crusader" },
                    { 22810, 75, "Toxin Injector" },
                    { 22811, 73, "Soulstring" },
                    { 22812, 79, "Nerubian Slavemaker" },
                    { 22813, 76, "Claymore of Unholy Might" },
                    { 22815, 74, "Severance" },
                    { 22816, 68, "Hatchet of Sundered Bone" },
                    { 22818, 74, "The Plague Bearer" },
                    { 22819, 79, "Shield of Condemnation" },
                    { 22820, 74, "Wand of Fates" },
                    { 22821, 79, "Doomfinger" },
                    { 22935, 65, "Touch of Frost" },
                    { 22936, 65, "Wristguards of Vengeance" },
                    { 22937, 65, "Gem of Nerubis" },
                    { 22938, 65, "Cryptfiend Silk Cloak" },
                    { 22939, 65, "Band of Unanswered Prayers" },
                    { 22940, 66, "Icebane Pauldrons" },
                    { 22941, 66, "Polar Shoulder Pads" },
                    { 22942, 66, "The Widow's Embrace" },
                    { 22943, 66, "Malice Stone Pendant" },
                    { 22947, 67, "Pendant of Forgotten Names" },
                    { 22954, 67, "Kiss of the Spider" },
                    { 22960, 74, "Cloak of Suturing" },
                    { 22961, 74, "Band of Reanimation" },
                    { 22967, 75, "Icy Scale Spaulders" },
                    { 22968, 75, "Glacial Mantle" },
                    { 22981, 76, "Gluth's Missing Collar" },
                    { 22983, 76, "Rime Covered Mantle" },
                    { 22988, 75, "The End of Dreams" },
                    { 22994, 76, "Digested Hand of Power" },
                    { 23000, 77, "Plated Abomination Ribcage" },
                    { 23001, 77, "Eye of Diminution" },
                    { 23004, 71, "Idol of Longevity" },
                    { 23005, 68, "Totem of Flowing Water" },
                    { 23006, 68, "Libram of Light" },
                    { 23009, 71, "Wand of the Whispering Dead" },
                    { 23014, 71, "Iblis, Blade of the Fallen Seraph" },
                    { 23017, 71, "Veil of Eclipse" },
                    { 23018, 71, "Signet of the Fallen Defender" },
                    { 23019, 69, "Icebane Helmet" },
                    { 23020, 72, "Polar Helmet" },
                    { 23021, 72, "The Soul Harvester's Bindings" },
                    { 23023, 72, "Sadist's Collar" },
                    { 23025, 73, "Seal of the Damned" },
                    { 23027, 73, "Warmth of Forgiveness" },
                    { 23028, 68, "Hailstone Band" },
                    { 23029, 68, "Noth's Frigid Heart" },
                    { 23030, 68, "Cloak of the Scourge" },
                    { 23031, 68, "Band of the Inevitable" },
                    { 23032, 72, "Glacial Headdress" },
                    { 23033, 69, "Icy Scale Coif" },
                    { 23035, 69, "Preceptor's Hat" },
                    { 23036, 69, "Necklace of Necropsy" },
                    { 23037, 70, "Ring of Spiritual Fervor" },
                    { 23038, 70, "Band of Unnatural Forces" },
                    { 23039, 70, "The Eye of Nerub" },
                    { 23040, 78, "Glyph of Deflection" },
                    { 23041, 78, "Slayer's Crest" },
                    { 23042, 70, "Loatheb's Reflection" },
                    { 23043, 78, "The Face of Death" },
                    { 23044, 3, "Harbinger of Doom" },
                    { 23045, 78, "Shroud of Dominion" },
                    { 23046, 78, "The Restrained Essence of Sapphiron" },
                    { 23047, 78, "Eye of the Dead" },
                    { 23048, 78, "Sapphiron's Right Eye" },
                    { 23049, 78, "Sapphiron's Left Eye" },
                    { 23050, 78, "Cloak of the Necropolis" },
                    { 23053, 79, "Stormrage's Talisman of Seething" },
                    { 23054, 79, "Gressil, Dawn of Ruin" },
                    { 23056, 79, "Hammer of the Twisting Nether" },
                    { 23057, 79, "Gem of Trapped Innocents" },
                    { 23059, 64, "Ring of the Dreadnaught" },
                    { 23060, 64, "Bonescythe Ring" },
                    { 23061, 64, "Ring of Faith" },
                    { 23062, 64, "Frostfire Ring" },
                    { 23063, 64, "Plagueheart Ring" },
                    { 23064, 64, "Ring of the Dreamwalker" },
                    { 23065, 64, "Ring of the Earthshatterer" },
                    { 23066, 64, "Ring of Redemption" },
                    { 23067, 64, "Ring of the Cryptstalker" },
                    { 23068, 69, "Legplates of Carnage" },
                    { 23069, 3, "Necro-Knight's Garb" },
                    { 23070, 77, "Leggings of Polarity" },
                    { 23071, 73, "Leggings of Apocalypse" },
                    { 23073, 72, "Boots of Displacement" },
                    { 23075, 76, "Death's Bargain" },
                    { 23219, 71, "Girdle of the Mentor" },
                    { 23220, 67, "Crystal Webbed Robe" },
                    { 23221, 3, "Misplaced Servo Arm" },
                    { 23226, 3, "Ghoul Skin Tunic" },
                    { 23237, 3, "Ring of the Eternal Flame" },
                    { 23238, 3, "Stygian Buckler" },
                    { 23242, 78, "Claw of the Frost Wyrm" },
                    { 23545, 78, "Power of the Scourge" },
                    { 23547, 78, "Resilience of the Scourge" },
                    { 23548, 78, "Might of the Scourge" },
                    { 23549, 78, "Fortitude of the Scourge" },
                    { 23557, 89, "Larvae of the Great Worm" },
                    { 23558, 89, "The Burrower's Shell" },
                    { 23570, 89, "Jom Gabbar" },
                    { 23577, 79, "The Hungering Cold" },
                    { 23631, 4, "Plans: Fel Edged Battleaxe" },
                    { 23663, 3, "Girdle of Elemental Fury" },
                    { 23664, 3, "Pauldrons of Elemental Fury" },
                    { 23665, 3, "Leggings of Elemental Fury" },
                    { 23666, 3, "Belt of the Grand Crusader" },
                    { 23667, 3, "Spaulders of the Grand Crusader" },
                    { 23668, 3, "Leggings of the Grand Crusader" },
                    { 28453, 46, "Bracers of the White Stag" },
                    { 28454, 46, "Stalker's War Bands" },
                    { 28477, 46, "Harbinger Bands" },
                    { 28502, 46, "Vambraces of Courage" },
                    { 28503, 46, "Whirlwind Bracers" },
                    { 28504, 46, "Steelhawk Crossbow" },
                    { 28505, 46, "Gauntlets of Renewed Hope" },
                    { 28506, 46, "Gloves of Dexterous Manipulation" },
                    { 28507, 46, "Handwraps of Flowing Thought" },
                    { 28508, 46, "Gloves of Saintly Blessings" },
                    { 28509, 46, "Worgen Claw Necklace" },
                    { 28510, 46, "Spectral Band of Innervation" },
                    { 28511, 48, "Bands of Indwelling" },
                    { 28512, 48, "Bracers of Justice" },
                    { 28514, 48, "Bracers of Maliciousness" },
                    { 28515, 48, "Bands of Nefarious Deeds" },
                    { 28516, 48, "Barbed Choker of Discipline" },
                    { 28517, 48, "Boots of Foretelling" },
                    { 28518, 48, "Iron Gauntlets of the Maiden" },
                    { 28519, 48, "Gloves of Quickening" },
                    { 28520, 48, "Gloves of Centering" },
                    { 28521, 48, "Mitts of the Treemender" },
                    { 28522, 48, "Shard of the Virtuous" },
                    { 28523, 48, "Totem of Healing Rains" },
                    { 28524, 47, "Emerald Ripper" },
                    { 28525, 47, "Signet of Unshakable Faith" },
                    { 28528, 47, "Moroes' Lucky Pocket Watch" },
                    { 28529, 47, "Royal Cloak of Arathi Kings" },
                    { 28530, 47, "Brooch of Unquenchable Fury" },
                    { 28545, 47, "Edgewalker Longboots" },
                    { 28565, 47, "Nethershard Girdle" },
                    { 28566, 47, "Crimson Girdle of the Indomitable" },
                    { 28567, 47, "Belt of Gale Force" },
                    { 28568, 47, "Idol of the Avian Heart" },
                    { 28569, 47, "Boots of Valiance" },
                    { 28570, 47, "Shadow-Cloak of Dalaran" },
                    { 28572, 49, "Blade of the Unrequited" },
                    { 28573, 49, "Despair" },
                    { 28578, 49, "Masquerade Gown" },
                    { 28579, 49, "Romulo's Poison Vial" },
                    { 28581, 49, "Wolfslayer Sniper Rifle" },
                    { 28582, 49, "Red Riding Hood's Cloak" },
                    { 28583, 49, "Big Bad Wolf's Head" },
                    { 28584, 49, "Big Bad Wolf's Paw" },
                    { 28585, 49, "Ruby Slippers" },
                    { 28586, 49, "Wicked Witch's Hat" },
                    { 28587, 49, "Legacy" },
                    { 28588, 49, "Blue Diamond Witchwand" },
                    { 28589, 49, "Beastmaw Pauldrons" },
                    { 28590, 49, "Ribbon of Sacrifice" },
                    { 28591, 49, "Earthsoul Leggings" },
                    { 28592, 49, "Libram of Souls Redeemed" },
                    { 28593, 49, "Eternium Greathelm" },
                    { 28594, 49, "Trial-Fire Trousers" },
                    { 28597, 55, "Panzar'Thar Breastplate" },
                    { 28599, 55, "Scaled Breastplate of Carnage" },
                    { 28600, 55, "Stonebough Jerkin" },
                    { 28601, 55, "Chestguard of the Conniver" },
                    { 28602, 55, "Robe of the Elder Scribes" },
                    { 28603, 55, "Talisman of Nightbane" },
                    { 28604, 55, "Nightstaff of the Everliving" },
                    { 28606, 55, "Shield of Impenetrable Darkness" },
                    { 28608, 55, "Ironstriders of Urgency" },
                    { 28609, 55, "Emberspur Talisman" },
                    { 28610, 55, "Ferocious Swift-Kickers" },
                    { 28611, 55, "Dragonheart Flameshield" },
                    { 28612, 50, "Pauldrons of the Solace-Giver" },
                    { 28621, 50, "Wrynn Dynasty Greaves" },
                    { 28631, 50, "Dragon-Quake Shoulderguards" },
                    { 28633, 50, "Staff of Infinite Mysteries" },
                    { 28647, 50, "Forest Wind Shoulderpads" },
                    { 28649, 50, "Garona's Signet Ring" },
                    { 28652, 52, "Cincture of Will" },
                    { 28653, 52, "Shadowvine Cloak of Infusion" },
                    { 28654, 52, "Malefic Girdle" },
                    { 28655, 52, "Cord of Nature's Sustenance" },
                    { 28656, 52, "Girdle of the Prowler" },
                    { 28657, 52, "Fool's Bane" },
                    { 28658, 52, "Terestian's Stranglestaff" },
                    { 28659, 52, "Xavian Stiletto" },
                    { 28660, 52, "Gilded Thorium Cloak" },
                    { 28661, 52, "Mender's Heart-Ring" },
                    { 28662, 52, "Breastplate of the Lightbinder" },
                    { 28663, 53, "Boots of the Incorrupt" },
                    { 28666, 53, "Pauldrons of the Justice-Seeker" },
                    { 28669, 53, "Rapscallion Boots" },
                    { 28670, 53, "Boots of the Infernal Coven" },
                    { 28671, 53, "Steelspine Faceguard" },
                    { 28672, 53, "Drape of the Dark Reavers" },
                    { 28673, 53, "Tirisfal Wand of Ascendancy" },
                    { 28674, 53, "Saberclaw Talisman" },
                    { 28675, 53, "Shermanar Great-Ring" },
                    { 28726, 53, "Mantle of the Mind Flayer" },
                    { 28727, 53, "Pendant of the Violet Eye" },
                    { 28728, 53, "Aran's Soothing Sapphire" },
                    { 28729, 54, "Spiteblade" },
                    { 28730, 54, "Mithril Band of the Unscarred" },
                    { 28731, 54, "Shining Chain of the Afterworld" },
                    { 28732, 54, "Cowl of Defiance" },
                    { 28733, 54, "Girdle of Truth" },
                    { 28734, 54, "Jewel of Infinite Possibilities" },
                    { 28735, 54, "Earthblood Chestguard" },
                    { 28740, 54, "Rip-Flayer Leggings" },
                    { 28741, 54, "Skulker's Greaves" },
                    { 28742, 54, "Pantaloons of Repentance" },
                    { 28743, 54, "Mantle of Abrahmis" },
                    { 28744, 54, "Uni-Mind Headdress" },
                    { 28745, 51, "Mithril Chain of Heroism" },
                    { 28746, 51, "Fiend Slayer Boots" },
                    { 28747, 51, "Battlescar Boots" },
                    { 28748, 51, "Legplates of the Innocent" },
                    { 28749, 51, "King's Defender" },
                    { 28750, 51, "Girdle of Treachery" },
                    { 28751, 51, "Heart-Flame Leggings" },
                    { 28752, 51, "Forestlord Striders" },
                    { 28753, 51, "Ring of Recurrence" },
                    { 28754, 51, "Triptych Shield of the Ancients" },
                    { 28755, 51, "Bladed Shoulderpads of the Merciless" },
                    { 28756, 51, "Headdress of the High Potentate" },
                    { 28757, 56, "Ring of a Thousand Marks" },
                    { 28762, 56, "Adornment of Stolen Souls" },
                    { 28763, 56, "Jade Ring of the Everliving" },
                    { 28764, 56, "Farstrider Wildercloak" },
                    { 28765, 56, "Stainless Cloak of the Pure Hearted" },
                    { 28766, 56, "Ruby Drape of the Mysticant" },
                    { 28767, 56, "The Decapitator" },
                    { 28768, 56, "Malchazeen" },
                    { 28770, 56, "Nathrezim Mindblade" },
                    { 28771, 56, "Light's Justice" },
                    { 28772, 56, "Sunfury Bow of the Phoenix" },
                    { 28773, 56, "Gorehowl" },
                    { 28774, 42, "Glaive of the Pit" },
                    { 28775, 42, "Thundering Greathelm" },
                    { 28776, 42, "Liar's Tongue Gloves" },
                    { 28777, 42, "Cloak of the Pit Stalker" },
                    { 28778, 42, "Terror Pit Girdle" },
                    { 28779, 42, "Girdle of the Endless Pit" },
                    { 28780, 42, "Soul-Eater's Handwraps" },
                    { 28781, 42, "Karaborian Talisman" },
                    { 28782, 42, "Crystalheart Pulse-Staff" },
                    { 28783, 42, "Eredar Wand of Obliteration" },
                    { 28785, 52, "The Lightning Capacitor" },
                    { 28789, 42, "Eye of Magtheridon" },
                    { 28794, 44, "Axe of the Gronn Lords" },
                    { 28795, 43, "Bladespire Warbands" },
                    { 28796, 43, "Malefic Mask of the Shadows" },
                    { 28797, 43, "Brute Cloak of the Ogre-Magi" },
                    { 28799, 43, "Belt of Divine Inspiration" },
                    { 28800, 43, "Hammer of the Naaru" },
                    { 28801, 43, "Maulgar's Warhelm" },
                    { 28802, 44, "Bloodmaw Magus-Blade" },
                    { 28803, 44, "Cowl of Nature's Breath" },
                    { 28804, 44, "Collar of Cho'gall" },
                    { 28810, 44, "Windshear Boots" },
                    { 28822, 44, "Teeth of Gruul" },
                    { 28823, 44, "Eye of Gruul" },
                    { 28824, 44, "Gauntlets of Martial Perfection" },
                    { 28825, 44, "Aldori Legacy Defender" },
                    { 28826, 44, "Shuriken of Negation" },
                    { 28827, 44, "Gauntlets of the Dragonslayer" },
                    { 28828, 44, "Gronn-Stitched Girdle" },
                    { 28830, 44, "Dragonspine Trophy" },
                    { 29458, 42, "Aegis of the Vindicator" },
                    { 29753, 42, "Chestguard of the Fallen Defender" },
                    { 29754, 42, "Chestguard of the Fallen Champion" },
                    { 29755, 42, "Chestguard of the Fallen Hero" },
                    { 29756, 50, "Gloves of the Fallen Hero" },
                    { 29757, 50, "Gloves of the Fallen Champion" },
                    { 29758, 50, "Gloves of the Fallen Defender" },
                    { 29759, 56, "Helm of the Fallen Hero" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemSourceId", "Name" },
                values: new object[,]
                {
                    { 29760, 56, "Helm of the Fallen Champion" },
                    { 29761, 56, "Helm of the Fallen Defender" },
                    { 29762, 43, "Pauldrons of the Fallen Hero" },
                    { 29763, 43, "Pauldrons of the Fallen Champion" },
                    { 29764, 43, "Pauldrons of the Fallen Defender" },
                    { 29765, 44, "Leggings of the Fallen Hero" },
                    { 29766, 44, "Leggings of the Fallen Champion" },
                    { 29767, 44, "Leggings of the Fallen Defender" },
                    { 29918, 32, "Mindstorm Wristbands" },
                    { 29920, 32, "Phoenix-Ring of Rebirth" },
                    { 29921, 32, "Fire Crest Breastplate" },
                    { 29922, 32, "Band of Al'ar" },
                    { 29923, 32, "Talisman of the Sun King" },
                    { 29924, 32, "Netherbane" },
                    { 29925, 32, "Phoenix-Wing Cloak" },
                    { 29947, 32, "Gloves of the Searing Grip" },
                    { 29948, 32, "Claw of the Phoenix" },
                    { 29949, 32, "Arcanite Steam-Pistol" },
                    { 29950, 34, "Greaves of the Bloodwarder" },
                    { 29951, 34, "Star-Strider Boots" },
                    { 29962, 34, "Heartrazor" },
                    { 29965, 34, "Girdle of the Righteous Path" },
                    { 29966, 34, "Vambraces of Ending" },
                    { 29972, 34, "Trousers of the Astromancer" },
                    { 29976, 34, "Worldstorm Gauntlets" },
                    { 29977, 34, "Star-Soul Breeches" },
                    { 29981, 34, "Ethereum Life-Staff" },
                    { 29982, 34, "Wand of the Forgotten Star" },
                    { 29983, 33, "Fel-Steel Warhelm" },
                    { 29984, 33, "Girdle of Zaetar" },
                    { 29985, 33, "Void Reaver Greaves" },
                    { 29986, 33, "Cowl of the Grand Engineer" },
                    { 29987, 35, "Gauntlets of the Sun King" },
                    { 29988, 35, "The Nexus Key" },
                    { 29989, 35, "Sunshower Light Cloak" },
                    { 29990, 35, "Crown of the Sun" },
                    { 29991, 35, "Sunhawk Leggings" },
                    { 29992, 35, "Royal Cloak of the Sunstriders" },
                    { 29993, 35, "Twinblade of the Phoenix" },
                    { 29994, 35, "Thalassian Wildercloak" },
                    { 29995, 35, "Leggings of Murderous Intent" },
                    { 29996, 35, "Rod of the Sun King" },
                    { 29997, 35, "Band of the Ranger-General" },
                    { 29998, 35, "Royal Gauntlets of Silvermoon" },
                    { 30008, 40, "Pendant of the Lost Ages" },
                    { 30020, 3, "Fire-Cord of the Magus" },
                    { 30021, 3, "Wildfury Greatstaff" },
                    { 30022, 3, "Pendant of the Perilous" },
                    { 30023, 3, "Totem of the Maelstrom" },
                    { 30024, 3, "Mantle of the Elven Kings" },
                    { 30025, 3, "Serpentshrine Shuriken" },
                    { 30026, 3, "Bands of the Celestial Archer" },
                    { 30027, 3, "Boots of Courage Unending" },
                    { 30028, 3, "Seventh Ring of the Tirisfalen" },
                    { 30029, 3, "Bark-Gloves of Ancient Wisdom" },
                    { 30030, 3, "Girdle of Fallen Stars" },
                    { 30047, 36, "Blackfathom Warbands" },
                    { 30048, 36, "Brighthelm of Justice" },
                    { 30049, 36, "Fathomstone" },
                    { 30050, 36, "Boots of the Shifting Nightmare" },
                    { 30051, 36, "Idol of the Crescent Goddess" },
                    { 30052, 36, "Ring of Lethality" },
                    { 30053, 36, "Pauldrons of the Wardancer" },
                    { 30054, 36, "Ranger-General's Chestguard" },
                    { 30055, 36, "Shoulderpads of the Stranger" },
                    { 30056, 36, "Robe of Hateful Echoes" },
                    { 30057, 37, "Bracers of Eradication" },
                    { 30058, 37, "Mallet of the Tides" },
                    { 30059, 37, "Choker of Animalistic Fury" },
                    { 30060, 37, "Boots of Effortless Striking" },
                    { 30061, 37, "Ancestral Ring of Conquest" },
                    { 30062, 37, "Grove-Bands of Remulos" },
                    { 30063, 37, "Libram of Absolute Truth" },
                    { 30064, 37, "Cord of Screaming Terrors" },
                    { 30065, 37, "Glowing Breastplate of Truth" },
                    { 30066, 37, "Tempest-Strider Boots" },
                    { 30067, 37, "Velvet Boots of the Guardian" },
                    { 30068, 40, "Girdle of the Tidal Call" },
                    { 30075, 40, "Gnarled Chestpiece of the Ancients" },
                    { 30079, 40, "Illidari Shoulderpads" },
                    { 30080, 40, "Luminescent Rod of the Naaru" },
                    { 30081, 40, "Warboots of Obliteration" },
                    { 30082, 40, "Talon of Azshara" },
                    { 30083, 40, "Ring of Sundered Souls" },
                    { 30084, 40, "Pauldrons of the Argent Sentinel" },
                    { 30085, 40, "Mantle of the Tireless Tracker" },
                    { 30090, 39, "World Breaker" },
                    { 30091, 38, "True-Aim Stalker Bands" },
                    { 30092, 38, "Orca-Hide Boots" },
                    { 30095, 38, "Fang of the Leviathan" },
                    { 30096, 38, "Girdle of the Invulnerable" },
                    { 30097, 38, "Coral-Barbed Shoulderpads" },
                    { 30098, 40, "Razor-Scale Battlecloak" },
                    { 30099, 39, "Frayed Tether of the Drowned" },
                    { 30100, 39, "Soul-Strider Boots" },
                    { 30101, 39, "Bloodsea Brigand's Vest" },
                    { 30102, 41, "Krakken-Heart Breastplate" },
                    { 30103, 41, "Fang of Vashj" },
                    { 30104, 41, "Cobra-Lash Boots" },
                    { 30105, 41, "Serpent Spine Longbow" },
                    { 30106, 41, "Belt of One-Hundred Deaths" },
                    { 30107, 41, "Vestments of the Sea-Witch" },
                    { 30108, 41, "Lightfathom Scepter" },
                    { 30109, 41, "Ring of Endless Coils" },
                    { 30110, 41, "Coral Band of the Revived" },
                    { 30111, 41, "Runetotem's Mantle" },
                    { 30112, 41, "Glorious Gauntlets of Crestfall" },
                    { 30183, 3, "Nether Vortex" },
                    { 30236, 35, "Chestguard of the Vanquished Champion" },
                    { 30237, 35, "Chestguard of the Vanquished Defender" },
                    { 30238, 35, "Chestguard of the Vanquished Hero" },
                    { 30239, 38, "Gloves of the Vanquished Champion" },
                    { 30240, 38, "Gloves of the Vanquished Defender" },
                    { 30241, 38, "Gloves of the Vanquished Hero" },
                    { 30242, 41, "Helm of the Vanquished Champion" },
                    { 30243, 41, "Helm of the Vanquished Defender" },
                    { 30244, 41, "Helm of the Vanquished Hero" },
                    { 30245, 39, "Leggings of the Vanquished Champion" },
                    { 30246, 39, "Leggings of the Vanquished Defender" },
                    { 30247, 39, "Leggings of the Vanquished Hero" },
                    { 30248, 33, "Pauldrons of the Vanquished Champion" },
                    { 30249, 33, "Pauldrons of the Vanquished Defender" },
                    { 30250, 33, "Pauldrons of the Vanquished Hero" },
                    { 30280, 4, "Pattern: Belt of Blasting" },
                    { 30281, 4, "Pattern: Belt of the Long Road" },
                    { 30282, 4, "Pattern: Boots of Blasting" },
                    { 30283, 4, "Pattern: Boots of the Long Road" },
                    { 30301, 4, "Pattern: Belt of Natural Power" },
                    { 30302, 4, "Pattern: Belt of Deep Shadow" },
                    { 30303, 4, "Pattern: Belt of the Black Eagle" },
                    { 30304, 4, "Pattern: Monsoon Belt" },
                    { 30305, 4, "Pattern: Boots of Natural Grace" },
                    { 30306, 4, "Pattern: Boots of Utter Darkness" },
                    { 30307, 4, "Pattern: Boots of the Crimson Hawk" },
                    { 30308, 4, "Pattern: Hurricane Boots" },
                    { 30321, 4, "Plans: Belt of the Guardian" },
                    { 30322, 4, "Plans: Red Belt of Battle" },
                    { 30323, 4, "Plans: Boots of the Protector" },
                    { 30324, 4, "Plans: Red Havoc Boots" },
                    { 30446, 34, "Solarian's Sapphire" },
                    { 30447, 32, "Tome of Fiery Redemption" },
                    { 30448, 32, "Talon of Al'ar" },
                    { 30449, 34, "Void Star Talisman" },
                    { 30450, 33, "Warp-Spring Coil" },
                    { 30480, 46, "Fiery Warhorse's Reins" },
                    { 30619, 33, "Fel Reaver's Piston" },
                    { 30620, 3, "Spyglass of the Hidden Fleet" },
                    { 30621, 41, "Prism of Inner Calm" },
                    { 30626, 39, "Sextant of Unstable Currents" },
                    { 30627, 38, "Tsunami Talisman" },
                    { 30629, 36, "Scarab of Displacement" },
                    { 30641, 3, "Boots of Elusion" },
                    { 30642, 3, "Drape of the Righteous" },
                    { 30643, 3, "Belt of the Tracker" },
                    { 30644, 3, "Grips of Deftness" },
                    { 30663, 39, "Fathom-Brooch of the Tidewalker" },
                    { 30664, 36, "Living Root of the Wildheart" },
                    { 30665, 37, "Earring of Soulful Meditation" },
                    { 30666, 3, "Ritssyn's Lost Pendant" },
                    { 30667, 3, "Ring of Unrelenting Storms" },
                    { 30668, 3, "Grasp of the Dead" },
                    { 30673, 3, "Inferno Waist Cord" },
                    { 30674, 3, "Zierhut's Lost Treads" },
                    { 30675, 45, "Lurker's Cord" },
                    { 30676, 45, "Lurker's Grasp" },
                    { 30677, 45, "Lurker's Belt" },
                    { 30678, 45, "Lurker's Girdle" },
                    { 30680, 45, "Glider's Foot-Wraps" },
                    { 30681, 45, "Glider's Boots" },
                    { 30682, 45, "Glider's Sabatons" },
                    { 30683, 45, "Glider's Greaves" },
                    { 30684, 45, "Ravager's Cuffs" },
                    { 30685, 45, "Ravager's Wrist-Wraps" },
                    { 30686, 45, "Ravager's Bands" },
                    { 30687, 45, "Ravager's Bracers" },
                    { 30720, 40, "Serpent-Coil Braid" },
                    { 30722, 2, "Ethereum Nexus-Reaver" },
                    { 30723, 2, "Talon of the Tempest" },
                    { 30724, 2, "Barrel-Blade Longrifle" },
                    { 30725, 2, "Anger-Spark Gloves" },
                    { 30726, 2, "Archaic Charm of Presence" },
                    { 30727, 2, "Gilded Trousers of Benediction" },
                    { 30728, 2, "Fathom-Helm of the Deeps" },
                    { 30729, 2, "Black-Iron Battlecloak" },
                    { 30730, 2, "Terrorweave Tunic" },
                    { 30731, 2, "Faceguard of the Endless Watch" },
                    { 30732, 1, "Exodar Life-Staff" },
                    { 30733, 1, "Hope Ender" },
                    { 30734, 1, "Leggings of the Seventh Circle" },
                    { 30735, 1, "Ancient Spellcloak of the Highborne" },
                    { 30736, 1, "Ring of Flowing Light" },
                    { 30737, 1, "Gold-Leaf Wildboots" },
                    { 30738, 1, "Ring of Reciprocity" },
                    { 30739, 1, "Scaled Greaves of the Marksman" },
                    { 30740, 1, "Ripfiend Shoulderplates" },
                    { 30741, 1, "Topaz-Studded Battlegrips" },
                    { 30861, 27, "Furious Shackles" },
                    { 30862, 27, "Blessed Adamantite Bracers" },
                    { 30863, 27, "Deadly Cuffs" },
                    { 30864, 27, "Bracers of the Pathfinder" },
                    { 30865, 27, "Tracker's Blade" },
                    { 30866, 27, "Blood-stained Pauldrons" },
                    { 30868, 27, "Rejuvenating Bracers" },
                    { 30869, 27, "Howling Wind Bracers" },
                    { 30870, 27, "Cuffs of Devastation" },
                    { 30871, 27, "Bracers of Martyrdom" },
                    { 30872, 27, "Chronicle of Dark Secrets" },
                    { 30873, 27, "Stillwater Boots" },
                    { 30874, 28, "The Unbreakable Will" },
                    { 30878, 28, "Glimmering Steel Mantle" },
                    { 30879, 28, "Don Alejandro's Money Belt" },
                    { 30880, 28, "Quickstrider Moccasins" },
                    { 30881, 28, "Blade of Infamy" },
                    { 30882, 28, "Bastion of Light" },
                    { 30883, 28, "Pillar of Ferocity" },
                    { 30884, 28, "Hatefury Mantle" },
                    { 30885, 28, "Archbishop's Slippers" },
                    { 30886, 28, "Enchanted Leather Sandals" },
                    { 30887, 28, "Golden Links of Restoration" },
                    { 30888, 28, "Anetheron's Noose" },
                    { 30889, 29, "Kaz'rogal's Hardened Heart" },
                    { 30891, 29, "Black Featherlight Boots" },
                    { 30892, 29, "Beast-tamer's Shoulders" },
                    { 30893, 29, "Sun-touched Chain Leggings" },
                    { 30894, 29, "Blue Suede Shoes" },
                    { 30895, 29, "Angelista's Sash" },
                    { 30896, 30, "Glory of the Defender" },
                    { 30897, 30, "Girdle of Hope" },
                    { 30898, 30, "Shady Dealer's Pantaloons" },
                    { 30899, 30, "Don Rodrigo's Poncho" },
                    { 30900, 30, "Bow-stitched Leggings" },
                    { 30901, 30, "Boundless Agony" },
                    { 30902, 31, "Cataclysm's Edge" },
                    { 30903, 31, "Legguards of Endless Rage" },
                    { 30904, 31, "Savior's Grasp" },
                    { 30905, 31, "Midnight Chestguard" },
                    { 30906, 31, "Bristleblitz Striker" },
                    { 30907, 31, "Mail of Fevered Pursuit" },
                    { 30908, 31, "Apostle of Argus" },
                    { 30909, 31, "Antonidas's Aegis of Rapt Concentration" },
                    { 30910, 31, "Tempest of Chaos" },
                    { 30911, 31, "Scepter of Purification" },
                    { 30912, 31, "Leggings of Eternity" },
                    { 30913, 31, "Robes of Rhonin" },
                    { 30914, 29, "Belt of the Crescent Moon" },
                    { 30915, 29, "Belt of Seething Fury" },
                    { 30916, 29, "Leggings of Channeled Elements" },
                    { 30917, 29, "Razorfury Mantle" },
                    { 30918, 29, "Hammer of Atonement" },
                    { 30919, 29, "Valestalker Girdle" },
                    { 31089, 26, "Chestguard of the Forgotten Conqueror" },
                    { 31090, 26, "Chestguard of the Forgotten Vanquisher" },
                    { 31091, 26, "Chestguard of the Forgotten Protector" },
                    { 31092, 30, "Gloves of the Forgotten Conqueror" },
                    { 31093, 30, "Gloves of the Forgotten Vanquisher" },
                    { 31094, 30, "Gloves of the Forgotten Protector" },
                    { 31095, 31, "Helm of the Forgotten Protector" },
                    { 31096, 31, "Helm of the Forgotten Vanquisher" },
                    { 31097, 31, "Helm of the Forgotten Conqueror" },
                    { 31098, 25, "Leggings of the Forgotten Conqueror" },
                    { 31099, 25, "Leggings of the Forgotten Vanquisher" },
                    { 31100, 25, "Leggings of the Forgotten Protector" },
                    { 31101, 24, "Pauldrons of the Forgotten Conqueror" },
                    { 31102, 24, "Pauldrons of the Forgotten Vanquisher" },
                    { 31103, 24, "Pauldrons of the Forgotten Protector" },
                    { 32232, 18, "Eternium Shell Bracers" },
                    { 32234, 18, "Fists of Mukoa" },
                    { 32235, 26, "Cursed Vision of Sargeras" },
                    { 32236, 18, "Rising Tide" },
                    { 32237, 18, "The Maelstrom's Fury" },
                    { 32238, 18, "Ring of Calming Waves" },
                    { 32239, 18, "Slippers of the Seacaller" },
                    { 32240, 18, "Guise of the Tidal Lurker" },
                    { 32241, 18, "Helm of Soothing Currents" },
                    { 32242, 18, "Boots of Oceanic Fury" },
                    { 32243, 18, "Pearl Inlaid Boots" },
                    { 32245, 18, "Tide-stomper's Greaves" },
                    { 32247, 18, "Ring of Captured Storms" },
                    { 32248, 18, "Halberd of Desolation" },
                    { 32250, 19, "Pauldrons of Abyssal Fury" },
                    { 32251, 19, "Wraps of Precise Flight" },
                    { 32252, 19, "Nether Shadow Tunic" },
                    { 32253, 19, "Legionkiller" },
                    { 32254, 19, "The Brutalizer" },
                    { 32255, 19, "Felstone Bulwark" },
                    { 32256, 19, "Waistwrap of Infinity" },
                    { 32257, 19, "Idol of the White Stag" },
                    { 32258, 19, "Naturalist's Preserving Cinch" },
                    { 32259, 19, "Bands of the Coming Storm" },
                    { 32260, 19, "Choker of Endless Nightmares" },
                    { 32261, 19, "Band of the Abyssal Lord" },
                    { 32262, 19, "Syphon of the Nathrezim" },
                    { 32263, 20, "Praetorian's Legguards" },
                    { 32264, 20, "Shoulders of the Hidden Predator" },
                    { 32265, 20, "Shadow-walker's Cord" },
                    { 32266, 20, "Ring of Deceitful Intent" },
                    { 32267, 34, "Boots of the Resilient" },
                    { 32268, 20, "Myrmidon's Treads" },
                    { 32269, 22, "Messenger of Fate" },
                    { 32270, 20, "Focused Mana Bindings" },
                    { 32271, 20, "Kilt of Immortal Nature" },
                    { 32273, 20, "Amice of Brilliant Light" },
                    { 32275, 20, "Spiritwalker Gauntlets" },
                    { 32276, 20, "Flashfire Girdle" },
                    { 32278, 20, "Grips of Silent Justice" },
                    { 32279, 20, "The Seeker's Wristguards" },
                    { 32280, 21, "Gauntlets of Enforcement" },
                    { 32285, 4, "Design: Flashing Crimson Spinel" },
                    { 32289, 4, "Design: Stormy Empyrean Sapphire" },
                    { 32295, 4, "Design: Mystic Lionseye" },
                    { 32296, 4, "Design: Great Lionseye" },
                    { 32297, 4, "Design: Sovereign Shadowsong Amethyst" },
                    { 32298, 4, "Design: Shifting Shadowsong Amethyst" },
                    { 32303, 4, "Design: Inscribed Pyrestone" },
                    { 32307, 4, "Design: Veiled Pyrestone" },
                    { 32323, 21, "Shadowmoon Destroyer's Drape" },
                    { 32324, 21, "Insidious Bands" },
                    { 32325, 21, "Rifle of the Stoic Guardian" },
                    { 32326, 21, "Twisted Blades of Zarak" },
                    { 32327, 21, "Robe of the Shadow Council" },
                    { 32328, 21, "Botanist's Gloves of Growth" },
                    { 32329, 21, "Cowl of Benevolence" },
                    { 32330, 21, "Totem of Ancestral Guidance" },
                    { 32331, 25, "Cloak of the Illidari Council" },
                    { 32332, 23, "Torch of the Damned" },
                    { 32333, 22, "Girdle of Stability" },
                    { 32334, 22, "Vest of Mounting Assault" },
                    { 32335, 22, "Unstoppable Aggressor's Ring" },
                    { 32336, 26, "Black Bow of the Betrayer" },
                    { 32337, 22, "Shroud of Forgiveness" },
                    { 32338, 22, "Blood-cursed Shoulderpads" },
                    { 32339, 22, "Belt of Primal Majesty" },
                    { 32340, 22, "Garments of Temperance" },
                    { 32341, 22, "Leggings of Divine Retribution" },
                    { 32342, 22, "Girdle of Mighty Resolve" },
                    { 32343, 22, "Wand of Prismatic Focus" },
                    { 32344, 22, "Staff of Immaculate Recovery" },
                    { 32345, 23, "Dreadboots of the Legion" },
                    { 32346, 23, "Boneweave Girdle" },
                    { 32347, 23, "Grips of Damnation" },
                    { 32348, 21, "Soul Cleaver" },
                    { 32349, 23, "Translucent Spellthread Necklace" },
                    { 32350, 23, "Touch of Inspiration" },
                    { 32351, 23, "Elunite Empowered Bracers" },
                    { 32352, 23, "Naturewarden's Treads" },
                    { 32353, 23, "Gloves of Unfailing Faith" },
                    { 32354, 23, "Crown of Empowered Fate" },
                    { 32361, 20, "Blind-Seers Icon" },
                    { 32362, 23, "Pendant of Titans" },
                    { 32363, 23, "Naaru-Blessed Life Rod" },
                    { 32365, 24, "Heartshatter Breastplate" },
                    { 32366, 24, "Shadowmaster's Boots" },
                    { 32367, 24, "Leggings of Devastation" },
                    { 32368, 24, "Tome of the Lightbringer" },
                    { 32369, 24, "Blade of Savagery" },
                    { 32370, 24, "Nadina's Pendant of Purity" },
                    { 32373, 25, "Helm of the Illidari Shatterer" },
                    { 32374, 26, "Zhar'doom, Greatstaff of the Devourer" },
                    { 32375, 26, "Bulwark of Azzinoth" },
                    { 32376, 25, "Forest Prowler's Helm" },
                    { 32377, 18, "Mantle of Darkness" },
                    { 32385, 42, "Magtheridon's Head" },
                    { 32405, 35, "Verdant Sphere" },
                    { 32458, 35, "Ashes of Al'ar" },
                    { 32471, 26, "Shard of Azzinoth" },
                    { 32483, 26, "The Skull of Gul'dan" },
                    { 32496, 26, "Memento of Tyrande" },
                    { 32497, 26, "Stormrage Signet Ring" },
                    { 32500, 26, "Crystal Spire of Karabor" },
                    { 32501, 22, "Shadowmoon Insignia" },
                    { 32505, 25, "Madness of the Betrayer" },
                    { 32510, 21, "Softstep Boots of Tracking" },
                    { 32512, 21, "Girdle of Lordaeron's Fallen" },
                    { 32513, 20, "Wristbands of Divine Influence" },
                    { 32515, 33, "Wristguards of Determination" },
                    { 32516, 36, "Wraps of Purification" },
                    { 32517, 23, "The Wavemender's Mantle" },
                    { 32518, 25, "Veil of Turning Leaves" },
                    { 32519, 25, "Belt of Divine Guidance" },
                    { 32521, 26, "Faceplate of the Impenetrable" },
                    { 32524, 26, "Shroud of the Highborne" },
                    { 32525, 26, "Cowl of the Illidari High Lord" },
                    { 32526, 3, "Band of Devastation" },
                    { 32527, 3, "Ring of Ancient Knowledge" },
                    { 32528, 3, "Blessed Band of Karabor" },
                    { 32589, 3, "Hellfire-Encased Pendant" },
                    { 32590, 3, "Nethervoid Cloak" },
                    { 32591, 3, "Choker of Serrated Blades" },
                    { 32592, 3, "Chestguard of Relentless Storms" },
                    { 32593, 3, "Treads of the Den Mother" },
                    { 32606, 3, "Girdle of the Lightbearer" },
                    { 32608, 3, "Pillager's Gauntlets" },
                    { 32609, 3, "Boots of the Divine Light" },
                    { 32736, 4, "Plans: Swiftsteel Bracers" },
                    { 32737, 4, "Plans: Swiftsteel Shoulders" },
                    { 32738, 4, "Plans: Dawnsteel Bracers" },
                    { 32739, 4, "Plans: Dawnsteel Shoulders" },
                    { 32744, 4, "Pattern: Bracers of Renewed Life" },
                    { 32745, 4, "Pattern: Shoulderpads of Renewed Life" },
                    { 32746, 4, "Pattern: Swiftstrike Bracers" },
                    { 32747, 4, "Pattern: Swiftstrike Shoulders" },
                    { 32748, 4, "Pattern: Bindings of Lightning Reflexes" },
                    { 32749, 4, "Pattern: Shoulders of Lightning Reflexes" },
                    { 32750, 4, "Pattern: Living Earth Bindings" },
                    { 32751, 4, "Pattern: Living Earth Shoulders" },
                    { 32752, 4, "Pattern: Swiftheal Wraps" },
                    { 32753, 4, "Pattern: Swiftheal Mantle" },
                    { 32754, 4, "Pattern: Bracers of Nimble Thought" },
                    { 32755, 4, "Pattern: Mantle of Nimble Thought" },
                    { 32837, 26, "Warglaive of Azzinoth (mainhand)" },
                    { 32838, 26, "Warglaive of Azzinoth (offhand)" },
                    { 32943, 3, "Swiftsteel Bludgeon" },
                    { 32944, 32, "Talon of the Phoenix" },
                    { 32945, 3, "Fist of Molten Fury" },
                    { 32946, 3, "Claw of Molten Fury" },
                    { 33054, 37, "The Seal of Danzalar" },
                    { 33055, 36, "Band of Vile Aggression" },
                    { 33058, 40, "Band of the Vigilant" },
                    { 33102, 17, "Blood of Zul'jin" },
                    { 33191, 12, "Jungle Stompers" },
                    { 33203, 12, "Robes of Heavenly Purpose" },
                    { 33206, 12, "Pauldrons of Primal Fury" },
                    { 33211, 12, "Bladeangel's Money Belt" },
                    { 33214, 14, "Akil'zon's Talonblade" },
                    { 33215, 14, "Bloodstained Elven Battlevest" },
                    { 33216, 14, "Chestguard of Hidden Purpose" },
                    { 33281, 14, "Brooch of Nature's Mercy" },
                    { 33283, 14, "Amani Punisher" },
                    { 33285, 12, "Fury of the Ursine" },
                    { 33286, 14, "Mojo-mender's Mask" },
                    { 33293, 14, "Signet of Ancient Magics" },
                    { 33297, 15, "The Savage's Choker" },
                    { 33298, 16, "Prowler's Strikeblade" },
                    { 33299, 15, "Spaulders of the Advocate" },
                    { 33300, 15, "Shoulderpads of Dancing Blades" },
                    { 33303, 15, "Skullshatter Warboots" },
                    { 33307, 4, "Formula: Enchant Weapon - Executioner" },
                    { 33317, 15, "Robe of Departed Spirits" },
                    { 33322, 15, "Shimmer-pelt Vest" },
                    { 33326, 13, "Bulwark of the Amani Empire" },
                    { 33327, 12, "Mask of Introspection" },
                    { 33328, 13, "Arrow-fall Chestguard" },
                    { 33329, 13, "Shadowtooth Trollskin Cuirass" },
                    { 33332, 13, "Enamelled Disc of Mojo" },
                    { 33354, 13, "Wub's Cursed Hexblade" },
                    { 33356, 13, "Helm of Natural Regeneration" },
                    { 33357, 13, "Footpads of Madness" },
                    { 33388, 16, "Heartless" },
                    { 33389, 16, "Dagger of Bad Mojo" },
                    { 33421, 16, "Battleworn Tuskguard" },
                    { 33432, 16, "Coif of the Jungle Stalker" },
                    { 33446, 16, "Girdle of Stromgarde's Hope" },
                    { 33453, 16, "Hood of Hexing" },
                    { 33463, 16, "Hood of the Third Eye" },
                    { 33464, 16, "Hex Lord's Voodoo Pauldrons" },
                    { 33465, 16, "Staff of Primal Fury" },
                    { 33466, 17, "Loop of Cursed Bones" },
                    { 33467, 17, "Blade of Twisted Visions" },
                    { 33468, 17, "Dark Blessing" },
                    { 33469, 17, "Hauberk of the Empire's Champion" },
                    { 33471, 17, "Two-toed Sandals" },
                    { 33473, 17, "Chestguard of the Warlord" },
                    { 33474, 17, "Ancient Amani Longbow" },
                    { 33476, 17, "Cleaver of the Unforgiving" },
                    { 33478, 17, "Jin'rohk, The Great Apocalypse" },
                    { 33479, 17, "Grimgrin Faceguard" },
                    { 33480, 11, "Cord of Braided Troll Hair" },
                    { 33481, 11, "Pauldrons of Stone Resolve" },
                    { 33483, 11, "Life-step Belt" },
                    { 33489, 11, "Mantle of Ill Intent" },
                    { 33490, 11, "Staff of Dark Mending" },
                    { 33491, 11, "Tuskbreaker" },
                    { 33492, 11, "Trollbane" },
                    { 33493, 11, "Umbral Shiv" },
                    { 33494, 11, "Amani Divining Staff" },
                    { 33495, 11, "Rage" },
                    { 33496, 11, "Signet of Primal Wrath" },
                    { 33497, 11, "Mana Attuned Band" },
                    { 33498, 11, "Signet of the Quiet Forest" },
                    { 33499, 11, "Signet of the Last Defender" },
                    { 33500, 11, "Signet of Eternal Life" },
                    { 33533, 15, "Avalanche Leggings" },
                    { 33590, 11, "Cloak of Fiends" },
                    { 33591, 11, "Shadowcaster's Drape" },
                    { 33592, 16, "Cloak of Ancient Rituals" },
                    { 33640, 12, "Fury" },
                    { 33805, 11, "Shadowhunter's Treads" },
                    { 33809, 11, "Amani War Bear" },
                    { 33828, 16, "Tome of Diabolic Remedy" },
                    { 33829, 16, "Hex Shrunken Head" },
                    { 33830, 17, "Ancient Aqir Artifact" },
                    { 33831, 17, "Berserker's Call" },
                    { 33971, 11, "Elunite Imbued Leggings" },
                    { 34009, 3, "Hammer of Judgement" },
                    { 34010, 3, "Pepe's Shroud of Pacification" },
                    { 34011, 3, "Illidari Runeshield" },
                    { 34012, 3, "Shroud of the Final Stand" },
                    { 34029, 16, "Tiny Voodoo Mask" },
                    { 34164, 5, "Dragonscale-Encrusted Longblade" },
                    { 34165, 5, "Fang of Kalecgos" },
                    { 34166, 5, "Band of Lucent Beams" },
                    { 34167, 5, "Legplates of the Holy Juggernaut" },
                    { 34168, 5, "Starstalker Legguards" },
                    { 34169, 5, "Breeches of Natural Aggression" },
                    { 34170, 5, "Pantaloons of Calming Strife" },
                    { 34176, 6, "Reign of Misery" },
                    { 34177, 6, "Clutch of Demise" },
                    { 34178, 6, "Collar of the Pit Lord" },
                    { 34179, 6, "Heart of the Pit" },
                    { 34180, 6, "Felfury Legplates" },
                    { 34181, 6, "Leggings of Calamity" },
                    { 34182, 7, "Grand Magister's Staff of Torrents" },
                    { 34183, 3, "Shivering Felspine" },
                    { 34184, 7, "Brooch of the Highborne" },
                    { 34185, 7, "Sword Breaker's Bulwark" },
                    { 34186, 7, "Chain Links of the Tumultuous Storm" },
                    { 34188, 7, "Leggings of the Immortal Night" },
                    { 34189, 8, "Band of Ruinous Delight" },
                    { 34190, 8, "Crimson Paragon's Cover" },
                    { 34192, 8, "Pauldrons of Perseverance" },
                    { 34193, 8, "Spaulders of the Thalassian Savior" },
                    { 34194, 8, "Mantle of the Golden Forest" },
                    { 34195, 8, "Shoulderpads of Vehemence" },
                    { 34196, 8, "Golden Bow of Quel'Thalas" },
                    { 34197, 8, "Shiv of Exsanguination" },
                    { 34198, 8, "Stanchion of Primal Instinct" },
                    { 34199, 8, "Archon's Gavel" },
                    { 34202, 8, "Shawl of Wonderment" },
                    { 34203, 8, "Grip of Mannoroth" },
                    { 34204, 8, "Amulet of Unfettered Magics" },
                    { 34205, 8, "Shroud of Redeemed Souls" },
                    { 34206, 8, "Book of Highborne Hymns" },
                    { 34208, 8, "Equilibrium Epaulets" },
                    { 34209, 8, "Spaulders of Reclamation" },
                    { 34210, 8, "Amice of the Convoker" },
                    { 34211, 9, "Harness of Carnal Instinct" },
                    { 34212, 9, "Sunglow Vest" },
                    { 34213, 9, "Ring of Hardened Resolve" },
                    { 34214, 9, "Muramasa" },
                    { 34215, 9, "Warharness of Reckless Fury" },
                    { 34216, 9, "Heroic Judicator's Chestguard" },
                    { 34228, 9, "Vicious Hawkstrider Hauberk" },
                    { 34229, 9, "Garments of Serene Shores" },
                    { 34230, 9, "Ring of Omnipotence" },
                    { 34231, 9, "Aegis of Angelic Fortune" },
                    { 34232, 9, "Fel Conquerer Raiments" },
                    { 34233, 9, "Robes of Faltered Light" },
                    { 34234, 9, "Shadowed Gauntlets of Paroxysm" },
                    { 34240, 9, "Gauntlets of the Soothed Soul" },
                    { 34241, 10, "Cloak of Unforgivable Sin" },
                    { 34242, 10, "Tattered Cape of Antonidas" },
                    { 34243, 10, "Helm of Burning Righteousness" },
                    { 34244, 10, "Duplicitous Guise" },
                    { 34245, 10, "Cover of Ursol the Wise" },
                    { 34247, 10, "Apolyon, the Soul-Render" },
                    { 34329, 10, "Crux of the Apocalypse" },
                    { 34331, 10, "Hand of the Deceiver" },
                    { 34332, 10, "Cowl of Gul'dan" },
                    { 34333, 10, "Coif of Alleria" },
                    { 34334, 10, "Thori'dal, the Stars' Fury" },
                    { 34335, 10, "Hammer of Sanctification" },
                    { 34336, 10, "Sunflare" },
                    { 34337, 10, "Golden Staff of the Sin'dorei" },
                    { 34339, 10, "Cowl of Light's Purity" },
                    { 34340, 10, "Dark Conjuror's Collar" },
                    { 34341, 10, "Borderland Paingrips" },
                    { 34342, 10, "Handguards of the Dawn" },
                    { 34343, 10, "Thalassian Ranger Gauntlets" },
                    { 34344, 10, "Handguards of Defiled Worlds" },
                    { 34345, 10, "Crown of Anasterian" },
                    { 34346, 3, "Mounting Vengeance" },
                    { 34347, 3, "Wand of the Demonsoul" },
                    { 34348, 3, "Wand of Cleansing Light" },
                    { 34349, 3, "Blade of Life's Inevitability" },
                    { 34350, 3, "Gauntlets of the Ancient Shadowmoon" },
                    { 34351, 3, "Tranquil Majesty Wraps" },
                    { 34352, 7, "Borderland Fortress Grips" },
                    { 34427, 9, "Blackened Naaru Sliver" },
                    { 34428, 9, "Steely Naaru Sliver" },
                    { 34429, 9, "Shifting Naaru Sliver" },
                    { 34430, 9, "Glimmering Naaru Sliver" },
                    { 34845, 42, "Pit Lord's Satchel" },
                    { 34848, 5, "Bracers of the Forgotten Conqueror" },
                    { 34851, 5, "Bracers of the Forgotten Protector" },
                    { 34852, 5, "Bracers of the Forgotten Vanquisher" },
                    { 34853, 6, "Belt of the Forgotten Conqueror" },
                    { 34854, 6, "Belt of the Forgotten Protector" },
                    { 34855, 6, "Belt of the Forgotten Vanquisher" },
                    { 34856, 7, "Boots of the Forgotten Conqueror" },
                    { 34857, 7, "Boots of the Forgotten Protector" },
                    { 34858, 7, "Boots of the Forgotten Vanquisher" },
                    { 35186, 4, "Schematic: Annihilator Holo-Gogs" },
                    { 35189, 4, "Schematic: Powerheal 9000 Lens" },
                    { 35190, 4, "Schematic: Hyper-Magnified Moon Specs" },
                    { 35192, 4, "Schematic: Primal-Attuned Goggles" },
                    { 35193, 4, "Schematic: Lightning Etched Specs" },
                    { 35194, 4, "Schematic: Surestrike Goggles v3.0" },
                    { 35195, 4, "Schematic: Mayhem Projection Goggles" },
                    { 35196, 4, "Schematic: Hard Khorium Goggles" },
                    { 35198, 4, "Design: Loop of Forged Power" },
                    { 35199, 4, "Design: Ring of Flowing Life" },
                    { 35200, 4, "Design: Hard Khorium Band" },
                    { 35201, 4, "Design: Pendant of Sunfire" },
                    { 35202, 4, "Design: Amulet of Flowing Life" },
                    { 35203, 4, "Design: Hard Khorium Choker" },
                    { 35204, 4, "Pattern: Sunfire Handwraps" },
                    { 35205, 4, "Pattern: Hands of Eternal Light" },
                    { 35206, 4, "Pattern: Sunfire Robe" },
                    { 35207, 4, "Pattern: Robe of Eternal Light" },
                    { 35208, 4, "Plans: Sunblessed Gauntlets" },
                    { 35209, 4, "Plans: Hard Khorium Battlefists" },
                    { 35210, 4, "Plans: Sunblessed Breastplate" },
                    { 35211, 4, "Plans: Hard Khorium Battleplate" },
                    { 35212, 4, "Pattern: Leather Gauntlets of the Sun" },
                    { 35213, 4, "Pattern: Fletcher's Gloves of the Phoenix" },
                    { 35214, 4, "Pattern: Gloves of Immortal Dusk" },
                    { 35215, 4, "Pattern: Sun-Drenched Scale Gloves" },
                    { 35216, 4, "Pattern: Leather Chestguard of the Sun" },
                    { 35217, 4, "Pattern: Embrace of the Phoenix" },
                    { 35218, 4, "Pattern: Carapace of Sun and Shadow" },
                    { 35219, 4, "Pattern: Sun-Drenched Scale Chestguard" },
                    { 35282, 9, "Sin'dorei Band of Dominance" },
                    { 35283, 9, "Sin'dorei Band of Salvation" },
                    { 35284, 9, "Sin'dorei Band of Triumph" },
                    { 35290, 8, "Sin'dorei Pendant of Conquest" },
                    { 35291, 8, "Sin'dorei Pendant of Salvation" },
                    { 35292, 8, "Sin'dorei Pendant of Triumph" },
                    { 35733, 3, "Ring of Harmonic Beauty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16665);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16795);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16796);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16797);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16798);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16799);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16800);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16801);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16802);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16803);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16804);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16805);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16806);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16807);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16808);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16809);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16810);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16811);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16812);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16813);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16814);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16815);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16816);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16817);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16818);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16819);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16820);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16821);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16822);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16823);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16824);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16825);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16826);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16827);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16828);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16829);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16830);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16831);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16832);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16833);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16834);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16835);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16836);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16837);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16838);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16839);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16840);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16841);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16842);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16843);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16844);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16845);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16846);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16847);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16848);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16849);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16850);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16851);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16852);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16853);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16854);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16855);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16856);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16857);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16858);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16859);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16860);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16861);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16862);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16863);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16864);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16865);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16866);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16867);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16868);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16897);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16898);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16899);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16900);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16901);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16902);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16903);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16904);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16905);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16906);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16907);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16908);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16909);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16910);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16911);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16912);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16913);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16914);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16915);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16916);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16917);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16918);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16919);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16920);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16921);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16922);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16923);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16924);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16925);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16926);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16927);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16928);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16929);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16930);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16931);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16932);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16933);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16934);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16935);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16936);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16937);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16938);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16939);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16940);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16941);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16942);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16943);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16944);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16945);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16946);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16947);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16948);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16949);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16950);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16951);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16952);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16953);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16954);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16955);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16956);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16957);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16958);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16959);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16960);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16961);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16962);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16963);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16964);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16965);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16966);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17063);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17064);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17065);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17066);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17067);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17068);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17069);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17070);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17071);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17072);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17073);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17074);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17075);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17076);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17077);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17078);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17082);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17113);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17782);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17966);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18202);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18205);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18208);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18252);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18257);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18259);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18260);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18264);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18265);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18290);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18291);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18292);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18422);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18541);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18542);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18543);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18544);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18545);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18546);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18547);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18563);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18564);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18646);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18665);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18703);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18704);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18705);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18803);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18805);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18806);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18808);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18809);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18810);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18811);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18812);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18813);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18814);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18815);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18816);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18817);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18820);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18821);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18822);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18823);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18824);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18829);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18832);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18842);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18861);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18872);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18875);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18878);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18879);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19002);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19130);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19131);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19132);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19133);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19134);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19135);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19136);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19137);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19138);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19139);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19140);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19142);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19143);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19144);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19145);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19146);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19147);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19334);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19335);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19336);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19337);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19339);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19340);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19341);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19342);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19343);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19344);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19345);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19346);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19347);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19348);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19349);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19350);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19351);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19352);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19353);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19354);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19355);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19356);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19357);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19358);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19360);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19361);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19362);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19363);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19364);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19365);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19367);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19368);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19369);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19370);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19371);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19372);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19373);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19374);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19375);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19376);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19377);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19378);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19379);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19380);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19381);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19382);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19385);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19386);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19387);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19388);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19389);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19390);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19391);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19392);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19393);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19394);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19395);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19396);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19397);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19398);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19399);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19400);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19401);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19402);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19403);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19405);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19406);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19407);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19430);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19431);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19432);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19433);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19434);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19435);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19436);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19437);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19438);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19439);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19716);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19717);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19718);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19719);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19720);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19721);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19722);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19723);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19724);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19802);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19852);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19853);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19854);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19855);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19856);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19857);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19859);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19861);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19862);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19863);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19864);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19865);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19866);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19867);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19869);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19870);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19871);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19872);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19873);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19874);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19875);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19876);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19877);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19878);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19884);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19885);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19886);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19887);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19888);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19889);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19890);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19891);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19892);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19893);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19894);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19895);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19896);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19897);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19898);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19899);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19900);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19901);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19902);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19903);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19904);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19905);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19906);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19907);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19908);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19909);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19910);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19912);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19913);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19914);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19915);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19918);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19919);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19920);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19921);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19922);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19923);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19925);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19927);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19928);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19929);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19930);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19939);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19940);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19941);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19942);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19944);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19945);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19946);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19947);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19961);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19962);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19963);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19964);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19965);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19967);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19968);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19993);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20032);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20038);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20257);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20258);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20259);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20260);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20261);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20262);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20263);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20264);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20265);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20266);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20577);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20578);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20579);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20580);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20581);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20582);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20599);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20615);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20616);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20617);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20618);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20619);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20621);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20622);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20623);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20624);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20625);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20626);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20627);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20628);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20629);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20630);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20631);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20632);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20633);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20634);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20635);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20636);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20637);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20638);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20639);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20644);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20727);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20728);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20729);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20730);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20731);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20734);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20736);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20884);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20885);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20886);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20888);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20889);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20890);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20926);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20927);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20928);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20929);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20930);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20931);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20932);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20933);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21126);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21128);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21134);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21218);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21220);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21221);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21232);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21237);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21321);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21323);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21324);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21371);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21452);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21453);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21454);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21455);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21456);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21457);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21458);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21459);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21460);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21461);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21462);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21463);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21464);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21466);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21467);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21468);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21469);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21470);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21471);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21472);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21473);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21474);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21475);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21476);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21477);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21478);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21479);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21480);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21481);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21482);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21483);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21484);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21485);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21486);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21487);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21488);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21489);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21490);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21491);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21492);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21493);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21494);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21495);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21496);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21497);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21498);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21499);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21500);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21501);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21502);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21503);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21579);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21581);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21582);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21583);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21585);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21586);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21596);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21597);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21598);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21599);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21600);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21601);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21602);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21603);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21604);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21605);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21606);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21607);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21608);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21609);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21610);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21611);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21615);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21616);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21617);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21618);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21619);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21620);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21621);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21622);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21623);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21624);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21625);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21626);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21627);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21635);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21639);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21645);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21647);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21648);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21650);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21651);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21652);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21663);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21664);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21665);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21666);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21667);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21668);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21669);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21670);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21671);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21672);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21673);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21674);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21675);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21676);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21677);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21678);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21679);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21680);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21681);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21682);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21683);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21684);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21685);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21686);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21687);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21688);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21689);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21690);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21691);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21692);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21693);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21694);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21695);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21696);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21697);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21698);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21699);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21700);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21701);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21702);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21703);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21704);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21705);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21706);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21707);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21708);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21715);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21800);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21801);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21802);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21803);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21804);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21806);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21809);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21810);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21814);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21836);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21837);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21838);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21839);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21856);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21888);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21889);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21891);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21903);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21904);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22220);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22222);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22349);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22350);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22351);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22352);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22353);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22354);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22355);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22356);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22357);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22358);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22359);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22360);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22361);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22362);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22363);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22364);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22365);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22366);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22367);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22368);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22369);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22370);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22371);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22372);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22373);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22374);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22375);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22376);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22396);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22399);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22402);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22520);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22545);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22559);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22560);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22561);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22637);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22682);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22691);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22711);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22712);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22713);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22714);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22715);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22716);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22718);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22720);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22721);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22722);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22726);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22730);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22731);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22732);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22739);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22798);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22799);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22800);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22801);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22802);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22803);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22804);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22806);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22807);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22808);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22809);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22810);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22811);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22812);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22813);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22815);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22816);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22818);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22819);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22820);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22821);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22935);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22936);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22937);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22938);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22939);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22940);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22941);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22942);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22943);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22947);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22954);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22960);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22961);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22967);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22968);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22981);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22983);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22988);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22994);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23000);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23001);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23004);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23005);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23006);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23009);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23014);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23017);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23018);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23019);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23020);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23021);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23023);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23025);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23027);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23028);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23029);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23030);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23031);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23032);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23033);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23035);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23036);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23037);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23038);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23039);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23040);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23041);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23042);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23043);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23044);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23045);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23046);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23047);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23048);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23049);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23050);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23053);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23054);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23056);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23057);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23059);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23060);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23061);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23062);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23063);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23064);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23065);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23066);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23067);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23068);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23069);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23070);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23071);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23073);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23075);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23219);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23220);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23221);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23226);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23237);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23238);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23242);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23545);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23547);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23548);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23549);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23557);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23558);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23570);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23577);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23631);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23663);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23664);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23665);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23666);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23667);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23668);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28453);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28454);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28477);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28502);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28503);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28504);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28505);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28506);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28507);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28508);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28509);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28510);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28511);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28512);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28514);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28515);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28516);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28517);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28518);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28519);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28520);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28521);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28522);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28523);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28524);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28525);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28528);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28529);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28530);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28545);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28565);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28566);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28567);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28568);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28569);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28570);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28572);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28573);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28578);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28579);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28581);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28582);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28583);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28584);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28585);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28586);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28587);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28588);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28589);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28590);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28591);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28592);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28593);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28594);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28597);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28599);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28600);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28601);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28602);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28603);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28604);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28606);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28608);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28609);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28610);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28611);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28612);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28621);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28631);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28633);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28647);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28649);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28652);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28653);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28654);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28655);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28656);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28657);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28658);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28659);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28660);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28661);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28662);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28663);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28666);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28669);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28670);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28671);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28672);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28673);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28674);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28675);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28726);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28727);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28728);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28729);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28730);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28731);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28732);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28733);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28734);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28735);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28740);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28741);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28742);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28743);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28744);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28745);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28746);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28747);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28748);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28749);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28750);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28751);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28752);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28753);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28754);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28755);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28756);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28757);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28762);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28763);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28764);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28765);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28766);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28767);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28768);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28770);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28771);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28772);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28773);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28774);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28775);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28776);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28777);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28778);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28779);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28780);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28781);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28782);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28783);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28785);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28789);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28794);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28795);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28796);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28797);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28799);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28800);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28801);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28802);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28803);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28804);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28810);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28822);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28823);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28824);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28825);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28826);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28827);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28828);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28830);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29458);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29753);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29754);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29755);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29756);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29757);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29758);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29759);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29760);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29761);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29762);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29763);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29764);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29765);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29766);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29767);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29918);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29920);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29921);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29922);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29923);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29924);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29925);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29947);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29948);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29949);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29950);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29951);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29962);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29965);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29966);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29972);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29976);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29977);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29981);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29982);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29983);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29984);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29985);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29986);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29987);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29988);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29989);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29990);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29991);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29992);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29993);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29994);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29995);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29996);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29997);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29998);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30008);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30020);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30021);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30022);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30023);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30024);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30025);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30026);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30027);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30028);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30029);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30030);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30047);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30048);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30049);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30050);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30051);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30052);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30053);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30054);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30055);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30056);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30057);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30058);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30059);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30060);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30061);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30062);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30063);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30064);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30065);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30066);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30067);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30068);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30075);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30079);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30080);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30081);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30082);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30083);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30084);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30085);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30090);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30091);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30092);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30095);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30096);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30097);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30098);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30099);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30104);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30105);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30106);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30107);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30108);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30109);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30110);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30111);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30112);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30183);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30236);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30237);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30238);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30239);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30240);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30241);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30242);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30243);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30244);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30245);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30246);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30247);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30248);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30249);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30250);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30280);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30281);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30282);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30283);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30301);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30302);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30303);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30304);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30305);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30306);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30307);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30308);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30321);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30322);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30323);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30324);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30446);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30447);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30448);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30449);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30450);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30480);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30619);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30620);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30621);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30626);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30627);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30629);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30641);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30642);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30643);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30644);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30663);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30664);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30665);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30666);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30667);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30668);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30673);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30674);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30675);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30676);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30677);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30678);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30680);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30681);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30682);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30683);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30684);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30685);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30686);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30687);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30720);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30722);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30723);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30724);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30725);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30726);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30727);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30728);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30729);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30730);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30731);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30732);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30733);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30734);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30735);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30736);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30737);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30738);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30739);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30740);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30741);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30861);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30862);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30863);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30864);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30865);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30866);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30868);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30869);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30870);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30871);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30872);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30873);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30874);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30878);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30879);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30880);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30881);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30882);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30883);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30884);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30885);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30886);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30887);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30888);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30889);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30891);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30892);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30893);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30894);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30895);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30896);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30897);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30898);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30899);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30900);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30901);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30902);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30903);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30904);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30905);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30906);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30907);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30908);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30909);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30910);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30911);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30912);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30913);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30914);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30915);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30916);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30917);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30918);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30919);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31089);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31090);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31091);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31092);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31093);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31094);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31095);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31096);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31097);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31098);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31099);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31100);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31101);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31103);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32232);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32234);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32235);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32236);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32237);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32238);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32239);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32240);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32241);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32242);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32243);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32245);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32247);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32248);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32250);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32251);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32252);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32253);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32254);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32255);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32256);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32257);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32258);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32259);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32260);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32261);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32262);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32263);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32264);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32265);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32266);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32267);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32268);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32269);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32270);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32271);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32273);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32275);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32276);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32278);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32279);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32280);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32285);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32289);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32295);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32296);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32297);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32298);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32303);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32307);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32323);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32324);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32325);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32326);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32327);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32328);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32329);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32330);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32331);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32332);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32333);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32334);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32335);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32336);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32337);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32338);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32339);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32340);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32341);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32342);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32343);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32344);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32345);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32346);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32347);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32348);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32349);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32350);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32351);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32352);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32353);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32354);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32361);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32362);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32363);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32365);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32366);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32367);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32368);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32369);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32370);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32373);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32374);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32375);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32376);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32377);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32385);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32405);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32458);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32471);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32483);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32496);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32497);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32500);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32501);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32505);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32510);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32512);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32513);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32515);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32516);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32517);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32518);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32519);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32521);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32524);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32525);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32526);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32527);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32528);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32589);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32590);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32591);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32592);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32593);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32606);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32608);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32609);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32736);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32737);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32738);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32739);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32744);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32745);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32746);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32747);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32748);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32749);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32750);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32751);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32752);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32753);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32754);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32755);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32837);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32838);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32943);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32944);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32945);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32946);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33054);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33055);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33058);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33102);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33191);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33206);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33211);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33214);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33215);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33216);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33281);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33283);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33285);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33286);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33293);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33297);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33298);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33299);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33300);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33303);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33307);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33317);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33322);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33326);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33327);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33328);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33329);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33332);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33354);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33356);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33357);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33388);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33389);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33421);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33432);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33446);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33453);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33463);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33464);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33465);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33466);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33467);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33468);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33469);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33471);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33473);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33474);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33476);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33478);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33479);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33480);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33481);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33483);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33489);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33490);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33491);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33492);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33493);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33494);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33495);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33496);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33497);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33498);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33499);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33500);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33533);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33590);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33591);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33592);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33640);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33805);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33809);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33828);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33829);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33830);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33831);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33971);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34009);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34010);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34011);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34012);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34029);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34164);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34165);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34166);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34167);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34168);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34169);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34170);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34176);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34177);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34178);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34179);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34180);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34181);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34182);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34183);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34184);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34185);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34186);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34188);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34189);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34190);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34192);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34193);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34194);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34195);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34196);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34197);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34198);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34199);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34202);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34205);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34206);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34208);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34209);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34210);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34211);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34212);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34213);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34214);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34215);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34216);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34228);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34229);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34230);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34231);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34232);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34233);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34234);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34240);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34241);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34242);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34243);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34244);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34245);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34247);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34329);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34331);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34332);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34333);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34334);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34335);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34336);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34337);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34339);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34340);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34341);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34342);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34343);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34344);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34345);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34346);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34347);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34348);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34349);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34350);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34351);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34352);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34427);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34428);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34429);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34430);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34845);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34848);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34851);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34852);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34853);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34854);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34855);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34856);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34857);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34858);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35186);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35189);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35190);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35192);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35193);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35194);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35195);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35196);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35198);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35199);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35200);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35201);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35202);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35203);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35204);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35205);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35206);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35207);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35208);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35209);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35210);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35211);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35212);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35213);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35214);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35215);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35216);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35217);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35218);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35219);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35282);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35283);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35284);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35290);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35291);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35292);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35733);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ItemSources",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ItemSourceCategories",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
