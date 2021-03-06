const Zones = {
  AIRP: "AIRP",
  ALAMO: "ALAMO",
  ALTA: "ALTA",
  ARMYB: "ARMYB",
  BANHAMC: "BANHAMC",
  BANNING: "BANNING",
  BEACH: "BEACH",
  BHAMCA: "BHAMCA",
  BRADP: "BRADP",
  BRADT: "BRADT",
  BURTON: "BURTON",
  CALAFB: "CALAFB",
  CANNY: "CANNY",
  CCREAK: "CCREAK",
  CHAMH: "CHAMH",
  CHIL: "CHIL",
  CHU: "CHU",
  CMSW: "CMSW",
  CYPRE: "CYPRE",
  DAVIS: "DAVIS",
  DELBE: "DELBE",
  DELPE: "DELPE",
  DELSOL: "DELSOL",
  DESRT: "DESRT",
  DOWNT: "DOWNT",
  DTVINE: "DTVINE",
  EAST_V: "EAST_V",
  EBURO: "EBURO",
  ELGORL: "ELGORL",
  ELYSIAN: "ELYSIAN",
  GALFISH: "GALFISH",
  GOLF: "GOLF",
  GRAPES: "GRAPES",
  GREATC: "GREATC",
  HARMO: "HARMO",
  HAWICK: "HAWICK",
  HORS: "HORS",
  HUMLAB: "HUMLAB",
  JAIL: "JAIL",
  KOREAT: "KOREAT",
  LACT: "LACT",
  LAGO: "LAGO",
  LDAM: "LDAM",
  LEGSQU: "LEGSQU",
  LMESA: "LMESA",
  LOSPUER: "LOSPUER",
  MIRR: "MIRR",
  MORN: "MORN",
  MOVIE: "MOVIE",
  MTCHIL: "MTCHIL",
  MTGORDO: "MTGORDO",
  MTJOSE: "MTJOSE",
  MURRI: "MURRI",
  NCHU: "NCHU",
  NOOSE: "NOOSE",
  OCEANA: "OCEANA",
  PALCOV: "PALCOV",
  PALETO: "PALETO",
  PALFOR: "PALFOR",
  PALHIGH: "PALHIGH",
  PALMPOW: "PALMPOW",
  PBLUFF: "PBLUFF",
  PBOX: "PBOX",
  PROCOB: "PROCOB",
  RANCHO: "RANCHO",
  RGLEN: "RGLEN",
  RICHM: "RICHM",
  ROCKF: "ROCKF",
  RTRAK: "RTRAK",
  SANAND: "SANAND",
  SANCHIA: "SANCHIA",
  SANDY: "SANDY",
  SKID: "SKID",
  SLAB: "SLAB",
  STAD: "STAD",
  STRAW: "STRAW",
  TATAMO: "TATAMO",
  TERMINA: "TERMINA",
  TEXTI: "TEXTI",
  TONGVAH: "TONGVAH",
  TONGVAV: "TONGVAV",
  VCANA: "VCANA",
  VESP: "VESP",
  VINE: "VINE",
  WINDF: "WINDF",
  WVINE: "WVINE",
  ZANCUDO: "ZANCUDO",
  ZP_ORT: "ZP_ORT",
  ZQ_UAR: "ZQ_UAR"
};
const Neighborhoods = {
  Paleto: ["CMSW", "PALCOV", "OCEANA", "PALFOR", "PALETO", "PROCOB"],
  "Northern Mountains": [
    "MTGORDO",
    "ELGORL",
    "BRADP",
    "BRADT",
    "MTCHIL",
    "GALFISH"
  ],
  Zancudo: ["LAGO", "ARMYB", "NCHU", "CANNY", "MTJOSE"],
  "Grand Senora Desert": [
    "PALMPOW",
    "WINDF",
    "RTRACK",
    "JAIL",
    "HARMO",
    "DESRT",
    "SANDY",
    "ZQ_UAR",
    "HUMLAB",
    "SANCHIA",
    "GRAPES",
    "ALAMO",
    "SLAB",
    "CALAFAB"
  ],
  "Coastal Beaches": ["BANHAMC", "BANHAMCA", "CHU", "TONGVAH"],
  "North LS Hills": ["CHIL", "GREATC", "RGLEN", "TONGVAV"],
  "LS Beaches": ["BEACH", "VESP", "VCANA", "DELBE", "PBLUFF"],
  "North LS": [
    "MIRR",
    "EAST_V",
    "DTVINE",
    "ALTA",
    "HAWICK",
    "BURTON",
    "ROCKF",
    "MOVIE",
    "DELPE",
    "MORN",
    "RICHM",
    "GOLF",
    "WVINE",
    "DTVINE",
    "HORS",
    "LACT",
    "LDAM"
  ],
  "Eastern Valley": ["EBURO", "PALHIGH", "NOOSE", "TATAMO"],
  "Central LS": ["MURRI", "LMESA", "SKID", "LEGSQU", "TEXTI", "PBOX", "KOREAT"],
  "South LS": [
    "TERMINA",
    "ELYSIAN",
    "AIRP",
    "BANNING",
    "DELSOL",
    "RANCHO",
    "STRAW",
    "CYPRE",
    "SANAND"
  ]
};
const Regions = {
  North: [
    "CMSW",
    "PALCOV",
    "OCEANA",
    "PALFOR",
    "PALETO",
    "PROCOB",
    "MTGORDO",
    "ELGORL",
    "BRADP",
    "BRADT",
    "MTCHIL",
    "GALFISH",
    "LAGO",
    "ARMYB",
    "NCHU",
    "CANNY",
    "MTJOSE",
    "PALMPOW",
    "WINDF",
    "RTRACK",
    "JAIL",
    "HARMO",
    "DESRT",
    "SANDY",
    "ZQ_UAR",
    "HUMLAB",
    "SANCHIA",
    "GRAPES",
    "ALAMO",
    "SLAB",
    "CALAFAB",
    "BANHAMC",
    "BANHAMCA",
    "CHU",
    "TONGVAH",
    "CHIL",
    "GREATC",
    "RGLEN",
    "TONGVAV"
  ],
  South: [
    "BEACH",
    "VESP",
    "VCANA",
    "DELBE",
    "PBLUFF",
    "MIRR",
    "EAST_V",
    "DTVINE",
    "ALTA",
    "HAWICK",
    "BURTON",
    "ROCKF",
    "MOVIE",
    "DELPE",
    "MORN",
    "RICHM",
    "GOLF",
    "WVINE",
    "DTVINE",
    "HORS",
    "LACT",
    "LDAM",
    "EBURO",
    "PALHIGH",
    "NOOSE",
    "TATAMO",
    "MURRI",
    "LMESA",
    "SKID",
    "LEGSQU",
    "TEXTI",
    "PBOX",
    "KOREAT",
    "TERMINA",
    "ELYSIAN",
    "AIRP",
    "BANNING",
    "DELSOL",
    "RANCHO",
    "STRAW",
    "CYPRE",
    "SANAND"
  ]
};
const All = {
  All: [
    "CMSW",
    "PALCOV",
    "OCEANA",
    "PALFOR",
    "PALETO",
    "PROCOB",
    "MTGORDO",
    "ELGORL",
    "BRADP",
    "BRADT",
    "MTCHIL",
    "GALFISH",
    "LAGO",
    "ARMYB",
    "NCHU",
    "CANNY",
    "MTJOSE",
    "PALMPOW",
    "WINDF",
    "RTRACK",
    "JAIL",
    "HARMO",
    "DESRT",
    "SANDY",
    "ZQ_UAR",
    "HUMLAB",
    "SANCHIA",
    "GRAPES",
    "ALAMO",
    "SLAB",
    "CALAFAB",
    "BANHAMC",
    "BANHAMCA",
    "CHU",
    "TONGVAH",
    "CHIL",
    "GREATC",
    "RGLEN",
    "TONGVAV",
    "BEACH",
    "VESP",
    "VCANA",
    "DELBE",
    "PBLUFF",
    "MIRR",
    "EAST_V",
    "DTVINE",
    "ALTA",
    "HAWICK",
    "BURTON",
    "ROCKF",
    "MOVIE",
    "DELPE",
    "MORN",
    "RICHM",
    "GOLF",
    "WVINE",
    "DTVINE",
    "HORS",
    "LACT",
    "LDAM",
    "EBURO",
    "PALHIGH",
    "NOOSE",
    "TATAMO",
    "MURRI",
    "LMESA",
    "SKID",
    "LEGSQU",
    "TEXTI",
    "PBOX",
    "KOREAT",
    "TERMINA",
    "ELYSIAN",
    "AIRP",
    "BANNING",
    "DELSOL",
    "RANCHO",
    "STRAW",
    "CYPRE",
    "SANAND"
  ]
};

const Weather = [
  "CLEAR",
  "EXTRASUNNY",
  "CLOUDS",
  "OVERCAST",
  "RAIN",
  "CLEARING",
  "THUNDER",
  "SMOG",
  "FOGGY",
  "XMAS",
  "SNOWLIGHT",
  "BLIZZARD"
];
