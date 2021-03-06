using System.Collections.Generic;
using System.Linq;

namespace Celeste.Mod.SpeedrunTool.TeleportRoom {
    public static class LevelDataReorderUtils {
        private static Dictionary<string, List<string>> ReorderLevelNames = new Dictionary<string, List<string>> {
            {
                "Celeste/0-IntroNormal",
                new List<string> {
                    "-1",
                    "0",
                    "0b",
                    "1",
                    "2",
                    "3",
                    "x1",
                }
            }, {
                "Celeste/1-ForsakenCityNormal",
                new List<string> {
                    "1",
                    "2",
                    "3",
                    "4",
                    "3b",
                    "5",
                    "5z",
                    "5a",
                    "6",
                    "6z",
                    "7zb",
                    "6zb",
                    "6a",
                    "6b",
                    "s0",
                    "s1",
                    "6c",
                    "7z",
                    "8z",
                    "8zb",
                    "7",
                    "8",
                    "7a",
                    "9z",
                    "8b",
                    "9",
                    "9b",
                    "9c",
                    "10",
                    "10z",
                    "10zb",
                    "11",
                    "11z",
                    "10a",
                    "12",
                    "12z",
                    "12a",
                    "end",
                }
            }, {
                "Celeste/1-ForsakenCityBSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                    "02b",
                    "03",
                    "04",
                    "05",
                    "05b",
                    "06",
                    "07",
                    "08",
                    "08b",
                    "09",
                    "10",
                    "11",
                    "end",
                }
            }, {
                "Celeste/1-ForsakenCityCSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/2-OldSiteNormal",
                new List<string> {
                    "start",
                    "s0",
                    "s1",
                    "s2",
                    "0",
                    "1",
                    "d0",
                    "d7",
                    "d8",
                    "d3",
                    "d2",
                    "d9",
                    "d6",
                    "d1",
                    "d4",
                    "d5",
                    "3x",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "9b",
                    "10",
                    "2",
                    "11",
                    "12b",
                    "12c",
                    "12d",
                    "12",
                    "13",
                    "end_0",
                    "end_s0",
                    "end_s1",
                    "end_1",
                    "end_2",
                    "end_3",
                    "end_4",
                    "end_3b",
                    "end_3cb",
                    "end_3c",
                    "end_5",
                    "end_6",
                }
            }, {
                "Celeste/2-OldSiteBSide",
                new List<string> {
                    "start",
                    "00",
                    "01",
                    "01b",
                    "02b",
                    "02",
                    "03",
                    "04",
                    "05",
                    "06",
                    "07",
                    "08b",
                    "08",
                    "09",
                    "10",
                    "11",
                    "end",
                }
            }, {
                "Celeste/2-OldSiteCSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/3-CelestialResortNormal",
                new List<string> {
                    "s0",
                    "s1",
                    "s2",
                    "s3",
                    "0x-a",
                    "00-a",
                    "02-a",
                    "02-b",
                    "01-b",
                    "00-b",
                    "00-c",
                    "0x-b",
                    "03-a",
                    "04-b",
                    "05-a",
                    "06-a",
                    "07-a",
                    "07-b",
                    "06-b",
                    "06-c",
                    "05-c",
                    "08-c",
                    "08-b",
                    "08-a",
                    "09-b",
                    "11-x",
                    "11-y",
                    "12-y",
                    "11-z",
                    "10-z",
                    "10-y",
                    "10-x",
                    "08-x",
                    "11-b",
                    "12-b",
                    "13-b",
                    "13-a",
                    "13-x",
                    "12-x",
                    "11-a",
                    "10-c",
                    "11-c",
                    "12-c",
                    "12-d",
                    "11-d",
                    "10-d",
                    "09-d",
                    "08-d",
                    "06-d",
                    "04-d",
                    "04-c",
                    "02-c",
                    "03-b",
                    "01-c",
                    "02-d",
                    "00-d",
                    "roof00",
                    "roof01",
                    "roof02",
                    "roof03",
                    "roof04",
                    "roof05",
                    "roof06b",
                    "roof06",
                    "roof07",
                }
            }, {
                "Celeste/3-CelestialResortBSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                    "03",
                    "04",
                    "05",
                    "06",
                    "07",
                    "08",
                    "09",
                    "10",
                    "11",
                    "13",
                    "14",
                    "15",
                    "12",
                    "16",
                    "17",
                    "18",
                    "19",
                    "21",
                    "20",
                    "end",
                }
            }, {
                "Celeste/3-CelestialResortCSide",
                new List<string> {
                    "00",
                    "01",
                    "02-dummy",
                    "02",
                }
            }, {
                "Celeste/4-GoldenRidgeNormal",
                new List<string> {
                    "a-00",
                    "a-01",
                    "a-01x",
                    "a-02",
                    "a-03",
                    "a-04",
                    "a-05",
                    "a-05x",
                    "a-06",
                    "a-07",
                    "a-08",
                    "a-10",
                    "a-11",
                    "a-09",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-05",
                    "b-04",
                    "b-06",
                    "b-07",
                    "b-03",
                    "b-sec",
                    "b-secb",
                    "b-08b",
                    "b-08",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-04",
                    "c-05",
                    "c-06",
                    "c-06b",
                    "c-09",
                    "c-07",
                    "c-08",
                    "c-10",
                    "d-00",
                    "d-00b",
                    "d-01",
                    "d-02",
                    "d-03",
                    "d-04",
                    "d-05",
                    "d-06",
                    "d-07",
                    "d-08",
                    "d-09",
                    "d-10",
                }
            }, {
                "Celeste/4-GoldenRidgeBSide",
                new List<string> {
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "a-04",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "b-04",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-04",
                    "d-00",
                    "d-01",
                    "d-02",
                    "d-03",
                    "end",
                }
            }, {
                "Celeste/4-GoldenRidgeCSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/5-MirrorTempleNormal",
                new List<string> {
                    "a-00b",
                    "a-00x",
                    "a-00d",
                    "a-00c",
                    "a-00",
                    "a-01",
                    "a-04",
                    "a-03",
                    "a-05",
                    "a-06",
                    "a-07",
                    "a-02",
                    "a-08",
                    "a-10",
                    "a-09",
                    "a-11",
                    "a-14",
                    "a-12",
                    "a-15",
                    "a-13",
                    "b-00",
                    "b-18",
                    "b-01",
                    "b-01c",
                    "b-20",
                    "b-21",
                    "b-01b",
                    "b-02",
                    "b-11",
                    "b-13",
                    "b-17",
                    "b-22",
                    "b-12",
                    "b-10",
                    "b-03",
                    "b-05",
                    "b-04",
                    "b-07",
                    "b-08",
                    "b-09",
                    "b-06",
                    "b-19",
                    "b-14",
                    "b-15",
                    "b-16",
                    "void",
                    "c-00",
                    "c-01",
                    "c-01b",
                    "c-01c",
                    "c-08b",
                    "c-08",
                    "c-10",
                    "c-12",
                    "c-07",
                    "c-11",
                    "c-09",
                    "c-13",
                    "d-00",
                    "d-01",
                    "d-15",
                    "d-13",
                    "d-04",
                    "d-09",
                    "d-07",
                    "d-05",
                    "d-06",
                    "d-02",
                    "d-03",
                    "d-19b",
                    "d-19",
                    "d-10",
                    "d-20",
                    "e-00",
                    "e-01",
                    "e-02",
                    "e-03",
                    "e-04",
                    "e-06",
                    "e-05",
                    "e-07",
                    "e-08",
                    "e-09",
                    "e-10",
                    "e-11",
                }
            }, {
                "Celeste/5-MirrorTempleBSide",
                new List<string> {
                    "start",
                    "a-00",
                    "a-01",
                    "a-02",
                    "b-00",
                    "b-01",
                    "b-04",
                    "b-02",
                    "b-05",
                    "b-06",
                    "b-07",
                    "b-03",
                    "b-08",
                    "b-09",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-04",
                    "d-00",
                    "d-01",
                    "d-02",
                    "d-03",
                    "d-04",
                    "d-05",
                }
            }, {
                "Celeste/5-MirrorTempleCSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/6-ReflectionNormal",
                new List<string> {
                    "start",
                    "00",
                    "01",
                    "02",
                    "03",
                    "02b",
                    "04",
                    "04b",
                    "04c",
                    "04e",
                    "04d",
                    "05",
                    "06",
                    "07",
                    "08b",
                    "08a",
                    "09",
                    "10b",
                    "10a",
                    "11",
                    "12b",
                    "12a",
                    "13",
                    "14b",
                    "14a",
                    "15",
                    "16b",
                    "16a",
                    "17",
                    "18b",
                    "18a",
                    "19",
                    "20",
                    "b-00",
                    "b-00b",
                    "b-00c",
                    "b-01",
                    "b-02",
                    "b-02b",
                    "b-03",
                    "boss-00",
                    "boss-01",
                    "boss-02",
                    "boss-03",
                    "boss-04",
                    "boss-05",
                    "boss-06",
                    "boss-07",
                    "boss-08",
                    "boss-09",
                    "boss-10",
                    "boss-11",
                    "boss-12",
                    "boss-13",
                    "boss-14",
                    "boss-15",
                    "boss-16",
                    "boss-17",
                    "boss-18",
                    "boss-19",
                    "boss-20",
                    "after-00",
                    "after-01",
                    "after-02",
                }
            }, {
                "Celeste/6-ReflectionBSide",
                new List<string> {
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "a-04",
                    "a-05",
                    "a-06",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "b-04",
                    "b-05",
                    "b-06",
                    "b-07",
                    "b-08",
                    "b-10",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-04",
                    "d-00",
                    "d-01",
                    "d-02",
                    "d-03",
                    "d-04",
                    "d-05",
                }
            }, {
                "Celeste/6-ReflectionCSide",
                new List<string> {
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/7-SummitNormal",
                new List<string> {
                    "a-00-intro",
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-02b",
                    "a-03",
                    "a-04",
                    "a-04b",
                    "a-05",
                    "a-06",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-02b",
                    "b-02e",
                    "b-02c",
                    "b-02d",
                    "b-03",
                    "b-04",
                    "b-05",
                    "b-06",
                    "b-07",
                    "b-08",
                    "b-09",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-03b",
                    "c-04",
                    "c-05",
                    "c-06",
                    "c-06b",
                    "c-06c",
                    "c-07",
                    "c-07b",
                    "c-08",
                    "c-09",
                    "d-00",
                    "d-01",
                    "d-01b",
                    "d-01c",
                    "d-01d",
                    "d-02",
                    "d-03",
                    "d-03b",
                    "d-04",
                    "d-05",
                    "d-05b",
                    "d-05x",
                    "d-06",
                    "d-07",
                    "d-08",
                    "d-09",
                    "d-10",
                    "d-10b",
                    "d-11",
                    "e-00b",
                    "e-00",
                    "e-01",
                    "e-01b",
                    "e-01c",
                    "e-03",
                    "e-02",
                    "e-04",
                    "e-05",
                    "e-06",
                    "e-07",
                    "e-08",
                    "e-09",
                    "e-11",
                    "e-12",
                    "e-10",
                    "e-10b",
                    "e-13",
                    "f-00",
                    "f-01",
                    "f-02",
                    "f-02b",
                    "f-04",
                    "f-03",
                    "f-05",
                    "f-06",
                    "f-07",
                    "f-08",
                    "f-08b",
                    "f-08d",
                    "f-08c",
                    "f-09",
                    "f-10",
                    "f-10b",
                    "f-11",
                    "g-00",
                    "g-00b",
                    "g-01",
                    "g-02",
                    "g-03",
                    "credits-city",
                    "credits-clouds",
                    "credits-dashes",
                    "credits-payphone",
                    "credits-prologue",
                    "credits-resort",
                    "credits-summit",
                    "credits-tree",
                    "credits-walking",
                    "credits-wallslide",
                }
            }, {
                "Celeste/7-SummitBSide",
                new List<string> {
                    "a-00-intro",
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "c-00",
                    "c-01",
                    "c-02",
                    "c-03",
                    "d-00",
                    "d-01",
                    "d-02",
                    "d-03",
                    "e-00",
                    "e-01",
                    "e-02",
                    "e-03",
                    "f-00",
                    "f-01",
                    "f-02",
                    "f-03",
                    "g-00",
                    "g-01",
                    "g-02",
                    "g-03",
                }
            }, {
                "Celeste/7-SummitCSide",
                new List<string> {
                    "01",
                    "02",
                    "03",
                }
            }, {
                "Celeste/8-EpilogueNormal",
                new List<string> {
                    "outside",
                    "bridge",
                    "secret",
                    "inside",
                }
            }, {
                "Celeste/9-CoreNormal",
                new List<string> {
                    "00",
                    "0x",
                    "01",
                    "02",
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "b-04",
                    "b-05",
                    "b-06",
                    "b-07b",
                    "b-07",
                    "c-00",
                    "c-00b",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-03b",
                    "c-04",
                    "d-00",
                    "d-01",
                    "d-02",
                    "d-03",
                    "d-04",
                    "d-05",
                    "d-06",
                    "d-07",
                    "d-08",
                    "d-09",
                    "d-10",
                    "d-10b",
                    "d-10c",
                    "d-11",
                    "space",
                }
            }, {
                "Celeste/9-CoreBSide",
                new List<string> {
                    "00",
                    "01",
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "a-04",
                    "a-05",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "b-04",
                    "b-05",
                    "c-01",
                    "c-02",
                    "c-03",
                    "c-04",
                    "c-05",
                    "c-06",
                    "c-08",
                    "c-07",
                    "space",
                }
            }, {
                "Celeste/9-CoreCSide",
                new List<string> {
                    "intro",
                    "00",
                    "01",
                    "02",
                }
            }, {
                "Celeste/LostLevelsNormal",
                new List<string> {
                    "intro-00-past",
                    "intro-01-future",
                    "intro-02-launch",
                    "intro-03-space",
                    "a-00",
                    "a-01",
                    "a-02",
                    "a-03",
                    "a-04",
                    "a-05",
                    "b-00",
                    "b-01",
                    "b-02",
                    "b-03",
                    "b-04",
                    "b-05",
                    "b-06",
                    "b-07",
                    "c-00",
                    "c-00b",
                    "c-01",
                    "c-02",
                    "c-alt-00",
                    "c-alt-01",
                    "c-03",
                    "d-00",
                    "d-02",
                    "d-01",
                    "d-03",
                    "d-04",
                    "d-05",
                    "e-00y",
                    "e-00yb",
                    "e-00z",
                    "e-00",
                    "e-00b",
                    "e-01",
                    "e-02",
                    "e-03-dummy",
                    "e-03",
                    "e-04",
                    "e-05",
                    "e-05b-dummy",
                    "e-05b",
                    "e-05c",
                    "e-06",
                    "e-07",
                    "e-08",
                    "f-door",
                    "f-00",
                    "f-01",
                    "f-02",
                    "f-03",
                    "f-04",
                    "f-05",
                    "f-06",
                    "f-07",
                    "f-08",
                    "f-09",
                    "g-00",
                    "g-01",
                    "g-03",
                    "g-02",
                    "g-04",
                    "g-05",
                    "g-06",
                    "h-00b",
                    "h-00",
                    "h-01",
                    "h-02",
                    "h-03",
                    "h-03b",
                    "h-04",
                    "h-04b",
                    "h-05",
                    "h-06",
                    "h-06b",
                    "h-07",
                    "h-08",
                    "h-09",
                    "h-10",
                    "i-00",
                    "i-00b",
                    "i-01",
                    "i-02",
                    "i-03",
                    "i-04",
                    "i-05",
                    "j-00",
                    "j-00b",
                    "j-01",
                    "j-02",
                    "j-03",
                    "j-04",
                    "j-05",
                    "j-06",
                    "j-07",
                    "j-08",
                    "j-09",
                    "j-10",
                    "j-11",
                    "j-12",
                    "j-13",
                    "j-14",
                    "j-14b",
                    "j-15",
                    "j-16",
                    "j-17",
                    "j-18",
                    "j-19",
                    "end-golden",
                    "end-cinematic",
                    "end-granny",
                }
            }, {
                "BeefyUncleTorre/map/1Normal",
                new List<string> {
                    "crane-01",
                    "memory-00",
                    "ch1-peace-00",
                    "peace-28",
                    "peace-000",
                    "peace-0000",
                    "peace-01",
                    "peace-29",
                    "peace-02",
                    "peace-03",
                    "peace-04",
                    "peace-05",
                    "peace-06",
                    "peace-07",
                    "peace-08",
                    "peace-26",
                    "peace-10",
                    "peace-09",
                    "peace-11",
                    "ch2-peace-12",
                    "heat-00",
                    "heat-01",
                    "heat-00-01",
                    "heat-00-02",
                    "heat-00-03",
                    "heat-00-04",
                    "heat-00-07",
                    "heat-00-08",
                    "heat-00-05",
                    "heat-00-06",
                    "heat-02",
                    "peace-14",
                    "heat-04",
                    "peace-16",
                    // "heat-03",
                    // "heat-05",
                    // "heat-07",
                    // "peace-17",
                    "heat-06",
                    "peace-18",
                    "ch3-heat-08",
                    "memory-01",
                    "memory-01-b",
                    "cold-14",
                    "cold-00",
                    "heat-09",
                    "heat-10",
                    "heat-11", 
                    "peace-27",
                    "cold-000",
                    "cold-01",
                    "cold-02",
                    "cold-03",
                    "cold-04",
                    "cold-10",
                    "cold-11",
                    "cold-16", 
                    "cold-12",
                    "cold-05",
                    "cold-06",
                    "cold-07",
                    "cold-08",
                    "ch4-cold-09",
                    "cold-15",
                    // "peace-13",
                    // "peace-13sec",
                    // "peace-14b",
                    // "peace-15",
                    // "peace-19",
                    // "peace-20",
                    // "peace-21",
                    // "peace-22",
                    // "peace-23",
                    // "peace-24",
                    // "peace-25",
                    "fall-00",
                    "fall-000",
                    "fall-0000",
                    "fall-00000",
                    "fall-01a",
                    "fall-02a",
                    "fall-03a",
                    "fall-04a",
                    "fall-05a",
                    "fall-06",
                    "fall-07",
                    "fall-17",
                    "fall-08a",
                    "fall-13",
                    "fall-14",
                    "fall-15",
                    "fall-16",
                    "fall-09a",
                    "fall-10a",
                    "fall-11a",
                    "fall-18",
                    // "fall-01b",
                    // "fall-02b",
                    // "fall-03b",
                    // "fall-04b",
                    // "fall-05b",
                    // "fall-08b",
                    // "fall-09b",
                    // "fall-10b",
                    // "fall-11b",
                    "ch5-fall-12",
                    "memory-02b",
                    "memory-02c",
                    "memory-17",
                    "memory-02",
                    "memory-03",
                    "memory-18",
                    "memory-04",
                    "memory-05a",
                    "memory-19a",
                    "memory-05b",
                    "memory-06a",
                    "memory-07a",
                    "memory-14",
                    "memory-15",
                    "memory-16a", 
                    "memory-08a",
                    "memory-09a",
                    "memory-10a",
                    "memory-11a",
                    // "memory-06b",
                    // "memory-08b",
                    // "memory-09b",
                    // "memory-10b",
                    // "memory-11b",
                    "ch6-memory-12",
                    "memory-13",
                    // "memory-16b",
                    // "memory-title",
                    // "memory-title2",
                    "crane-02",
                    "crane-03",
                    "crane-04",
                    "crane-blue-01",
                    "crane-blue-02",
                    "crane-blue-03",
                    "crane-blue-04",
                    "crane-gold-01",
                    "crane-gold-02",
                    "crane-gold-03",
                    "crane-pink-01",
                    "crane-pink-02",
                    "crane-pink-03",
                    "crane-red-01",
                    "crane-red-02",
                    "crane-red-03",
                    "solace-00",
                    "solace-01",
                    "solace-02",
                    "solace-03",
                    "solace-04",
                    "solace-05",
                    "solace-06",
                    "solace-07",
                }
            },
        };

        private static readonly Dictionary<AreaKey, List<LevelData>> ReorderLevelDatas =
            new Dictionary<AreaKey, List<LevelData>>();

        public static List<LevelData> GetReorderLevelDatas(Level level) {
            AreaKey areaKey = level.Session.Area;
            List<LevelData> levelDatas = level.Session?.MapData?.Levels;
            if (ReorderLevelDatas.ContainsKey(areaKey)) {
                return ReorderLevelDatas[areaKey];
            }

            List<LevelData> datas = new List<LevelData>();
            if (ReorderLevelNames.ContainsKey(areaKey.SID + areaKey.Mode)) {
                var levelNames = ReorderLevelNames[areaKey.SID + areaKey.Mode];
                foreach (string levelName in levelNames) {
                    LevelData levelData = levelDatas?.FirstOrDefault(data => data.Name == levelName);
                    if (levelData != null) {
                        datas.Add(levelData);
                    }
                }
            }

            if (datas.Count > 0) {
                ReorderLevelDatas[areaKey] = datas;
                return datas;
            }

            return levelDatas;
        }
    }
}