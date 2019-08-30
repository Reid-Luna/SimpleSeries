using System.Collections.Generic;

namespace SimpleWeather
{
  public class Areas
  {
    public static Dictionary<string, string> Zones = new Dictionary<string, string>
    {
      { "AIRP", "AIRP" },
      { "ALAMO", "ALAMO" },
      { "ALTA", "ALTA" },
      { "ARMYB", "ARMYB" },
      { "BANHAMC", "BANHAMC" },
      { "BANNING", "BANNING" },
      { "BEACH", "BEACH" },
      { "BHAMCA", "BHAMCA" },
      { "BRADP", "BRADP" },
      { "BRADT", "BRADT" },
      { "BURTON", "BURTON" },
      { "CALAFB", "CALAFB" },
      { "CANNY", "CANNY" },
      { "CCREAK", "CCREAK" },
      { "CHAMH", "CHAMH" },
      { "CHIL", "CHIL" },
      { "CHU", "CHU" },
      { "CMSW", "CMSW" },
      { "CYPRE", "CYPRE" },
      { "DAVIS", "DAVIS" },
      { "DELBE", "DELBE" },
      { "DELPE", "DELPE" },
      { "DELSOL", "DELSOL" },
      { "DESRT", "DESRT" },
      { "DOWNT", "DOWNT" },
      { "DTVINE", "DTVINE" },
      { "EAST_V", "EAST_V" },
      { "EBURO", "EBURO" },
      { "ELGORL", "ELGORL" },
      { "ELYSIAN", "ELYSIAN" },
      { "GALFISH", "GALFISH" },
      { "GOLF", "GOLF" },
      { "GRAPES", "GRAPES" },
      { "GREATC", "GREATC" },
      { "HARMO", "HARMO" },
      { "HAWICK", "HAWICK" },
      { "HORS", "HORS" },
      { "HUMLAB", "HUMLAB" },
      { "JAIL", "JAIL" },
      { "KOREAT", "KOREAT" },
      { "LACT", "LACT" },
      { "LAGO", "LAGO" },
      { "LDAM", "LDAM" },
      { "LEGSQU", "LEGSQU" },
      { "LMESA", "LMESA" },
      { "LOSPUER", "LOSPUER" },
      { "MIRR", "MIRR" },
      { "MORN", "MORN" },
      { "MOVIE", "MOVIE" },
      { "MTCHIL", "MTCHIL" },
      { "MTGORDO", "MTGORDO" },
      { "MTJOSE", "MTJOSE" },
      { "MURRI", "MURRI" },
      { "NCHU", "NCHU" },
      { "NOOSE", "NOOSE" },
      { "OCEANA", "OCEANA" },
      { "PALCOV", "PALCOV" },
      { "PALETO", "PALETO" },
      { "PALFOR", "PALFOR" },
      { "PALHIGH", "PALHIGH" },
      { "PALMPOW", "PALMPOW" },
      { "PBLUFF", "PBLUFF" },
      { "PBOX", "PBOX" },
      { "PROCOB", "PROCOB" },
      { "RANCHO", "RANCHO" },
      { "RGLEN", "RGLEN" },
      { "RICHM", "RICHM" },
      { "ROCKF", "ROCKF" },
      { "RTRAK", "RTRAK" },
      { "SANAND", "SANAND" },
      { "SANCHIA", "SANCHIA" },
      { "SANDY", "SANDY" },
      { "SKID", "SKID" },
      { "SLAB", "SLAB" },
      { "STAD", "STAD" },
      { "STRAW", "STRAW" },
      { "TATAMO", "TATAMO" },
      { "TERMINA", "TERMINA" },
      { "TEXTI", "TEXTI" },
      { "TONGVAH", "TONGVAH" },
      { "TONGVAV", "TONGVAV" },
      { "VCANA", "VCANA" },
      { "VESP", "VESP" },
      { "VINE", "VINE" },
      { "WINDF", "WINDF" },
      { "WVINE", "WVINE" },
      { "ZANCUDO", "ZANCUDO" },
      { "ZP_ORT", "ZP_ORT" },
      { "ZQ_UAR", "ZQ_UAR" }
    };

    public static Dictionary<string, string[]> Neighborhoods = new Dictionary<string, string[]>
    {
      { "Paleto", new string[] {"CMSW","PALCOV","OCEANA","PALFOR","PALETO","PROCOB"} },
      { "Northern Mountains", new string[] {"MTGORDO","ELGORL","BRADP","BRADT","MTCHIL","GALFISH"} },
      { "Zancudo", new string[] {"LAGO","ARMYB","NCHU","CANNY","MTJOSE"} },
      { "Grand Senora Desert", new string[] {"PALMPOW","WINDF","RTRACK","JAIL","HARMO","DESRT","SANDY","ZQ_UAR","HUMLAB","SANCHIA","GRAPES","ALAMO","SLAB","CALAFAB"} },
      { "Coastal Beaches", new string[] {"BANHAMC","BANHAMCA","CHU","TONGVAH"} },
      { "North LS Hills", new string[] {"CHIL","GREATC","RGLEN","TONGVAV"} },
      { "LS Beaches", new string[] {"BEACH","VESP","VCANA","DELBE","PBLUFF"} },
      { "North LS", new string[] {"MIRR","EAST_V","DTVINE","ALTA","HAWICK","BURTON","ROCKF","MOVIE","DELPE","MORN","RICHM","GOLF","WVINE","DTVINE","HORS","LACT","LDAM"} },
      { "Eastern Valley", new string[] {"EBURO","PALHIGH","NOOSE","TATAMO"} },
      { "Central LS", new string[] {"MURRI","LMESA","SKID","LEGSQU","TEXTI","PBOX","KOREAT"} },
      { "South LS", new string[] {"TERMINA","ELYSIAN","AIRP","BANNING","DELSOL","RANCHO","STRAW","CYPRE","SANAND"} }
    };

    public static Dictionary<string, string[]> Regions = new Dictionary<string, string[]>
    {
      { "North", new string[] { "CMSW", "PALCOV", "OCEANA", "PALFOR", "PALETO", "PROCOB", "MTGORDO", "ELGORL", "BRADP", "BRADT", "MTCHIL", "GALFISH", "LAGO", "ARMYB", "NCHU", "CANNY", "MTJOSE", "PALMPOW", "WINDF", "RTRACK", "JAIL", "HARMO", "DESRT", "SANDY", "ZQ_UAR", "HUMLAB", "SANCHIA", "GRAPES", "ALAMO", "SLAB", "CALAFAB", "BANHAMC", "BANHAMCA", "CHU", "TONGVAH", "CHIL", "GREATC", "RGLEN", "TONGVAV" } },
      { "South", new string[] { "BEACH", "VESP", "VCANA", "DELBE", "PBLUFF", "MIRR", "EAST_V", "DTVINE", "ALTA", "HAWICK", "BURTON", "ROCKF", "MOVIE", "DELPE", "MORN", "RICHM", "GOLF", "WVINE", "DTVINE", "HORS", "LACT", "LDAM", "EBURO", "PALHIGH", "NOOSE", "TATAMO", "MURRI", "LMESA", "SKID", "LEGSQU", "TEXTI", "PBOX", "KOREAT", "TERMINA", "ELYSIAN", "AIRP", "BANNING", "DELSOL", "RANCHO", "STRAW", "CYPRE", "SANAND" } }
    };

    public static string[] All = new string[] { "CMSW", "PALCOV", "OCEANA", "PALFOR", "PALETO", "PROCOB", "MTGORDO", "ELGORL", "BRADP", "BRADT", "MTCHIL", "GALFISH", "LAGO", "ARMYB", "NCHU", "CANNY", "MTJOSE", "PALMPOW", "WINDF", "RTRACK", "JAIL", "HARMO", "DESRT", "SANDY", "ZQ_UAR", "HUMLAB", "SANCHIA", "GRAPES", "ALAMO", "SLAB", "CALAFAB", "BANHAMC", "BANHAMCA", "CHU", "TONGVAH", "CHIL", "GREATC", "RGLEN", "TONGVAV", "BEACH", "VESP", "VCANA", "DELBE", "PBLUFF", "MIRR", "EAST_V", "DTVINE", "ALTA", "HAWICK", "BURTON", "ROCKF", "MOVIE", "DELPE", "MORN", "RICHM", "GOLF", "WVINE", "DTVINE", "HORS", "LACT", "LDAM", "EBURO", "PALHIGH", "NOOSE", "TATAMO", "MURRI", "LMESA", "SKID", "LEGSQU", "TEXTI", "PBOX", "KOREAT", "TERMINA", "ELYSIAN", "AIRP", "BANNING", "DELSOL", "RANCHO", "STRAW", "CYPRE", "SANAND" };
  }
}
