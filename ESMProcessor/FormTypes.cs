using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMProcessor
{
    public enum FormType : byte
    {
        [EnumDescription("None", 0x00, "NONE")]
        SIG_NONE = 0x00,
        [EnumDescription("Header", 0x01, "TES4")]
        SIG_TES4 = 0x01,
        [EnumDescription("Group", 0x02, "GRUP")]
        SIG_GRUP = 0x02,
        [EnumDescription("Game Setting", 0x03, "GMST")]
        SIG_GMST = 0x03,
        [EnumDescription("Keyword", 0x04, "KYWD")]
        SIG_KYWD = 0x04,
        [EnumDescription("Entitlement", 0x05, "ENTM")]
        SIG_ENTM = 0x05,
        [EnumDescription("Consumable Entitlement", 0x06, "COEN")]
        SIG_COEN = 0x06,
        [EnumDescription("Crate Service Entitlement", 0x07, "CSEN")]
        SIG_CSEN = 0x07,
        [EnumDescription("Emote Category", 0x08, "ECAT")]
        SIG_ECAT = 0x08,
        [EnumDescription("Emote", 0x09, "EMOT")]
        SIG_EMOT = 0x09,
        [EnumDescription("Avatar", 0x0A, "AVTR")]
        SIG_AVTR = 0x0A,
        [EnumDescription("Challenge Pass Reward Data", 0x0B, "CPRD")]
        SIG_CPRD = 0x0B,
        [EnumDescription("Location Reference Type", 0x0C, "LCRT")]
        SIG_LCRT = 0x0C,
        [EnumDescription("Action", 0x0D, "AACT")]
        SIG_AACT = 0x0D,
        [EnumDescription("Transform", 0x0E, "TRNS")]
        SIG_TRNS = 0x0E,
        [EnumDescription("Component", 0x0F, "CMPO")]
        SIG_CMPO = 0x0F,
        [EnumDescription("Texture Set", 0x10, "TXST")]
        SIG_TXST = 0x10,
        [EnumDescription("Menu Icon", 0x11, "MICN")]
        SIG_MICN = 0x11,
        [EnumDescription("Global", 0x12, "GLOB")]
        SIG_GLOB = 0x12,
        [EnumDescription("Damage Type", 0x13, "DMGT")]
        SIG_DMGT = 0x13,
        [EnumDescription("Class", 0x14, "CLAS")]
        SIG_CLAS = 0x14,
        [EnumDescription("Faction", 0x15, "FACT")]
        SIG_FACT = 0x15,
        [EnumDescription("Head Part", 0x16, "HDPT")]
        SIG_HDPT = 0x16,
        [EnumDescription("Eyes", 0x17, "EYES")]
        SIG_EYES = 0x17,
        [EnumDescription("Race", 0x18, "RACE")]
        SIG_RACE = 0x18,
        [EnumDescription("Sound Marker", 0x19, "SOUN")]
        SIG_SOUN = 0x19,
        [EnumDescription("Sound Echo Marker", 0x1A, "SECH")]
        SIG_SECH = 0x1A,
        [EnumDescription("Acoustic Space", 0x1B, "ASPC")]
        SIG_ASPC = 0x1B,
        [EnumDescription("Resource", 0x1C, "RESO")]
        SIG_RESO = 0x1C,
        [EnumDescription("Magic Effect", 0x1D, "MGEF")]
        SIG_MGEF = 0x1D,
        [EnumDescription("Script", 0x1E, "SCPT")]
        SIG_SCPT = 0x1E,
        [EnumDescription("Landscape Texture", 0x1F, "LTEX")]
        SIG_LTEX = 0x1F,
        [EnumDescription("Enchantment", 0x20, "ENCH")]
        SIG_ENCH = 0x20,
        [EnumDescription("Spell", 0x21, "SPEL")]
        SIG_SPEL = 0x21,
        [EnumDescription("Scroll", 0x22, "SCRL")]
        SIG_SCRL = 0x22,
        [EnumDescription("Activator", 0x23, "ACTI")]
        SIG_ACTI = 0x23,
        [EnumDescription("Talking Activator", 0x24, "TACT")]
        SIG_TACT = 0x24,
        [EnumDescription("Curve Table", 0x25, "CURV")]
        SIG_CURV = 0x25,
        [EnumDescription("Armor", 0x26, "ARMO")]
        SIG_ARMO = 0x26,
        [EnumDescription("Book", 0x27, "BOOK")]
        SIG_BOOK = 0x27,
        [EnumDescription("Container", 0x28, "CONT")]
        SIG_CONT = 0x28,
        [EnumDescription("Door", 0x29, "DOOR")]
        SIG_DOOR = 0x29,
        [EnumDescription("Ingredient", 0x2A, "INGR")]
        SIG_INGR = 0x2A,
        [EnumDescription("Light", 0x2B, "LIGH")]
        SIG_LIGH = 0x2B,
        [EnumDescription("Misc Item", 0x2C, "MISC")]
        SIG_MISC = 0x2C,
        [EnumDescription("Misc Item Spawner", 0x2D, "MSCS")]
        SIG_MSCS = 0x2D,
        [EnumDescription("Misc Item Spawner Instance", 0x2E, "MISI")]
        SIG_MISI = 0x2E,
        [EnumDescription("Currency", 0x2F, "CNCY")]
        SIG_CNCY = 0x2F,
        [EnumDescription("Static", 0x30, "STAT")]
        SIG_STAT = 0x30,
        [EnumDescription("Static Collection", 0x31, "SCOL")]
        SIG_SCOL = 0x31,
        [EnumDescription("Movable Static", 0x32, "MSTT")]
        SIG_MSTT = 0x32,
        [EnumDescription("Grass", 0x33, "GRAS")]
        SIG_GRAS = 0x33,
        [EnumDescription("Tree", 0x34, "TREE")]
        SIG_TREE = 0x34,
        [EnumDescription("Flora", 0x35, "FLOR")]
        SIG_FLOR = 0x35,
        [EnumDescription("Furniture", 0x36, "FURN")]
        SIG_FURN = 0x36,
        [EnumDescription("Weapon", 0x37, "WEAP")]
        SIG_WEAP = 0x37,
        [EnumDescription("Ammunition", 0x38, "AMMO")]
        SIG_AMMO = 0x38,
        [EnumDescription("Non-Player Character (Actor)", 0x39, "NPC_")]
        SIG_NPC_ = 0x39,
        [EnumDescription("Leveled NPC", 0x3A, "LVLN")]
        SIG_LVLN = 0x3A,
        [EnumDescription("Leveled Pack In", 0x3B, "LVLP")]
        SIG_LVLP = 0x3B,
        [EnumDescription("Key", 0x3C, "KEYM")]
        SIG_KEYM = 0x3C,
        [EnumDescription("Ingestible", 0x3D, "ALCH")]
        SIG_ALCH = 0x3D,
        [EnumDescription("Utility", 0x3E, "UTIL")]
        SIG_UTIL = 0x3E,
        [EnumDescription("Idle Marker", 0x3F, "IDLM")]
        SIG_IDLM = 0x3F,
        [EnumDescription("Holotape", 0x40, "NOTE")]
        SIG_NOTE = 0x40,
        [EnumDescription("Projectile", 0x41, "PROJ")]
        SIG_PROJ = 0x41,
        [EnumDescription("Hazard", 0x42, "HAZD")]
        SIG_HAZD = 0x42,
        [EnumDescription("Bendable Spline", 0x43, "BNDS")]
        SIG_BNDS = 0x43,
        [EnumDescription("Soul Gem", 0x44, "SLGM")]
        SIG_SLGM = 0x44,
        [EnumDescription("Terminal", 0x45, "TERM")]
        SIG_TERM = 0x45,
        [EnumDescription("Perk Card Pack", 0x46, "PPAK")]
        SIG_PPAK = 0x46,
        [EnumDescription("Power Armor Chasis", 0x47, "PACH")]
        SIG_PACH = 0x47,
        [EnumDescription("Leveled Item", 0x48, "LVLI")]
        SIG_LVLI = 0x48,
        [EnumDescription("Weather", 0x49, "WTHR")]
        SIG_WTHR = 0x49,
        [EnumDescription("Climate", 0x4A, "CLMT")]
        SIG_CLMT = 0x4A,
        [EnumDescription("Shader Particle Geometry", 0x4B, "SPGD")]
        SIG_SPGD = 0x4B,
        [EnumDescription("Visual Effect", 0x4C, "RFCT")]
        SIG_RFCT = 0x4C,
        [EnumDescription("Region", 0x4D, "REGN")]
        SIG_REGN = 0x4D,
        [EnumDescription("Navigation Mesh Info Map", 0x4E, "NAVI")]
        SIG_NAVI = 0x4E,
        [EnumDescription("Cell", 0x4F, "CELL")]
        SIG_CELL = 0x4F,
        [EnumDescription("Reference", 0x50, "REFR")]
        SIG_REFR = 0x50,
        [EnumDescription("Placed NPC", 0x51, "ACHR")]
        SIG_ACHR = 0x51,
        [EnumDescription("Projectile Missile", 0x52, "PMIS")]
        SIG_PMIS = 0x52,
        [EnumDescription("Projectile Arrow", 0x53, "PARW")]
        SIG_PARW = 0x53,
        [EnumDescription("Projectile Projectile", 0x54, "PGRE")]
        SIG_PGRE = 0x54,
        [EnumDescription("Projectile Beam", 0x55, "PBEA")]
        SIG_PBEA = 0x55,
        [EnumDescription("Projectile Flame", 0x56, "PFLA")]
        SIG_PFLA = 0x56,
        [EnumDescription("Projectile Cone/Voice", 0x57, "PCON")]
        SIG_PCON = 0x57,
        [EnumDescription("Projectile Barrier", 0x58, "PBAR")]
        SIG_PBAR = 0x58,
        [EnumDescription("Projectile Hazard", 0x59, "PHZD")]
        SIG_PHZD = 0x59,
        [EnumDescription("Worldspace", 0x5A, "WRLD")]
        SIG_WRLD = 0x5A,
        [EnumDescription("Landscape", 0x5B, "LAND")]
        SIG_LAND = 0x5B,
        [EnumDescription("Navigation Mesh", 0x5C, "NAVM")]
        SIG_NAVM = 0x5C,
        [EnumDescription("Unknown - TLOD", 0x5D, "TLOD")]
        SIG_TLOD = 0x5D,
        [EnumDescription("Dialog Topic", 0x5E, "DIAL")]
        SIG_DIAL = 0x5E,
        [EnumDescription("Dialog Response", 0x5F, "INFO")]
        SIG_INFO = 0x5F,
        [EnumDescription("Quest", 0x60, "QUST")]
        SIG_QUST = 0x60,
        [EnumDescription("Idle Animation", 0x61, "IDLE")]
        SIG_IDLE = 0x61,
        [EnumDescription("Package", 0x62, "PACK")]
        SIG_PACK = 0x62,
        [EnumDescription("Combat Style", 0x63, "CSTY")]
        SIG_CSTY = 0x63,
        [EnumDescription("Load Screen", 0x64, "LSCR")]
        SIG_LSCR = 0x64,
        [EnumDescription("Leveled Spell", 0x65, "LVSP")]
        SIG_LVSP = 0x65,
        [EnumDescription("Animated Object", 0x66, "ANIO")]
        SIG_ANIO = 0x66,
        [EnumDescription("Water", 0x67, "WATR")]
        SIG_WATR = 0x67,
        [EnumDescription("Effect Shader", 0x68, "EFSH")]
        SIG_EFSH = 0x68,
        [EnumDescription("Unknown - TOFT", 0x69, "TOFT")]
        SIG_TOFT = 0x69,
        [EnumDescription("Explosion", 0x6A, "EXPL")]
        SIG_EXPL = 0x6A,
        [EnumDescription("Debris", 0x6B, "DEBR")]
        SIG_DEBR = 0x6B,
        [EnumDescription("Image Space", 0x6C, "IMGS")]
        SIG_IMGS = 0x6C,
        [EnumDescription("Image Space Adapter", 0x6D, "IMAD")]
        SIG_IMAD = 0x6D,
        [EnumDescription("FormID List", 0x6E, "FLST")]
        SIG_FLST = 0x6E,
        [EnumDescription("Perk", 0x6F, "PERK")]
        SIG_PERK = 0x6F,
        [EnumDescription("Perk Card", 0x70, "PCRD")]
        SIG_PCRD = 0x70,
        [EnumDescription("Leveled Perk Card", 0x71, "LVPC")]
        SIG_LVPC = 0x71,
        [EnumDescription("Body Part Data", 0x72, "BPTD")]
        SIG_BPTD = 0x72,
        [EnumDescription("Addon Node", 0x73, "ADDN")]
        SIG_ADDN = 0x73,
        [EnumDescription("Actor Value Info", 0x74, "AVIF")]
        SIG_AVIF = 0x74,
        [EnumDescription("Camera Shot", 0x75, "CAMS")]
        SIG_CAMS = 0x75,
        [EnumDescription("Camera Path", 0x76, "CPTH")]
        SIG_CPTH = 0x76,
        [EnumDescription("Voice Type", 0x77, "VTYP")]
        SIG_VTYP = 0x77,
        [EnumDescription("Material Type", 0x78, "MATT")]
        SIG_MATT = 0x78,
        [EnumDescription("Impact", 0x79, "IPCT")]
        SIG_IPCT = 0x79,
        [EnumDescription("Impact Data Set", 0x7A, "IPDS")]
        SIG_IPDS = 0x7A,
        [EnumDescription("Armor Addon", 0x7B, "ARMA")]
        SIG_ARMA = 0x7B,
        [EnumDescription("Location", 0x7C, "LCTN")]
        SIG_LCTN = 0x7C,
        [EnumDescription("Message", 0x7D, "MESG")]
        SIG_MESG = 0x7D,
        [EnumDescription("Ragdoll", 0x7E, "RGDL")]
        SIG_RGDL = 0x7E,
        [EnumDescription("Default Object Manager", 0x7F, "DOBJ")]
        SIG_DOBJ = 0x7F,
        [EnumDescription("Default Object", 0x80, "DFOB")]
        SIG_DFOB = 0x80,
        [EnumDescription("Lighting Template", 0x81, "LGTM")]
        SIG_LGTM = 0x81,
        [EnumDescription("Music Type", 0x82, "MUSC")]
        SIG_MUSC = 0x82,
        [EnumDescription("Footstep", 0x83, "FSTP")]
        SIG_FSTP = 0x83,
        [EnumDescription("Footstep Set", 0x84, "FSTS")]
        SIG_FSTS = 0x84,
        [EnumDescription("Story Manager Branch Node", 0x85, "SMBN")]
        SIG_SMBN = 0x85,
        [EnumDescription("Story Manager Quest Node", 0x86, "SMQN")]
        SIG_SMQN = 0x86,
        [EnumDescription("Story Manager Event Node", 0x87, "SMEN")]
        SIG_SMEN = 0x87,
        [EnumDescription("Dialog Branch", 0x88, "DLBR")]
        SIG_DLBR = 0x88,
        [EnumDescription("Music Track", 0x89, "MUST")]
        SIG_MUST = 0x89,
        [EnumDescription("Dialog View", 0x8A, "DLVW")]
        SIG_DLVW = 0x8A,
        [EnumDescription("Word of Power", 0x8B, "WOOP")]
        SIG_WOOP = 0x8B,
        [EnumDescription("Shout", 0x8C, "SHOU")]
        SIG_SHOU = 0x8C,
        [EnumDescription("Equip Type", 0x8D, "EQUP")]
        SIG_EQUP = 0x8D,
        [EnumDescription("Relationship", 0x8E, "RELA")]
        SIG_RELA = 0x8E,
        [EnumDescription("Scene", 0x8F, "SCEN")]
        SIG_SCEN = 0x8F,
        [EnumDescription("Association Type", 0x90, "ASTP")]
        SIG_ASTP = 0x90,
        [EnumDescription("Outfit", 0x91, "OTFT")]
        SIG_OTFT = 0x91,
        [EnumDescription("Art Object", 0x92, "ARTO")]
        SIG_ARTO = 0x92,
        [EnumDescription("Material Object", 0x93, "MATO")]
        SIG_MATO = 0x93,
        [EnumDescription("Movement Type", 0x94, "MOVT")]
        SIG_MOVT = 0x94,
        [EnumDescription("Sound Descriptor", 0x95, "SNDR")]
        SIG_SNDR = 0x95,
        [EnumDescription("Dual Cast Data", 0x96, "DUAL")]
        SIG_DUAL = 0x96,
        [EnumDescription("Sound Category", 0x97, "SNCT")]
        SIG_SNCT = 0x97,
        [EnumDescription("Sound Output Model", 0x98, "SOPM")]
        SIG_SOPM = 0x98,
        [EnumDescription("Collision Layer", 0x99, "COLL")]
        SIG_COLL = 0x99,
        [EnumDescription("Color", 0x9A, "CLFM")]
        SIG_CLFM = 0x9A,
        [EnumDescription("Reverb Parameters", 0x9B, "REVB")]
        SIG_REVB = 0x9B,
        [EnumDescription("Pack-In", 0x9C, "PKIN")]
        SIG_PKIN = 0x9C,
        [EnumDescription("Reference Group", 0x9D, "RFGP")]
        SIG_RFGP = 0x9D,
        [EnumDescription("Aim Model", 0x9E, "AMDL")]
        SIG_AMDL = 0x9E,
        [EnumDescription("Aim Assist Model", 0x9F, "AAMD")]
        SIG_AAMD = 0x9F,
        [EnumDescription("Layer", 0xA0, "LAYR")]
        SIG_LAYR = 0xA0,
        [EnumDescription("Constructible Object", 0xA1, "COBJ")]
        SIG_COBJ = 0xA1,
        [EnumDescription("Object Modification", 0xA2, "OMOD")]
        SIG_OMOD = 0xA2,
        [EnumDescription("Material Swap", 0xA3, "MSWP")]
        SIG_MSWP = 0xA3,
        [EnumDescription("Model Swap", 0xA4, "MDSP")]
        SIG_MDSP = 0xA4,
        [EnumDescription("Zoom", 0xA5, "ZOOM")]
        SIG_ZOOM = 0xA5,
        [EnumDescription("Instance Naming Rules", 0xA6, "INNR")]
        SIG_INNR = 0xA6,
        [EnumDescription("Sound Keyword Mapping", 0xA7, "KSSM")]
        SIG_KSSM = 0xA7,
        [EnumDescription("Audio Effect Chain", 0xA8, "AECH")]
        SIG_AECH = 0xA8,
        [EnumDescription("Scene Collection", 0xA9, "SCCO")]
        SIG_SCCO = 0xA9,
        [EnumDescription("Attraction Rule", 0xAA, "AORU")]
        SIG_AORU = 0xAA,
        [EnumDescription("Sound Category Snapshot", 0xAB, "SCSN")]
        SIG_SCSN = 0xAB,
        [EnumDescription("Animation Sound Tag Set", 0xAC, "STAG")]
        SIG_STAG = 0xAC,
        [EnumDescription("Navigation Mesh Obstacle Manager", 0xAD, "NOCM")]
        SIG_NOCM = 0xAD,
        [EnumDescription("Lens Flare", 0xAE, "LENS")]
        SIG_LENS = 0xAE,
        [EnumDescription("Unknown - LSPR", 0xAF, "LSPR")]
        SIG_LSPR = 0xAF,
        [EnumDescription("Object Visibility Manager", 0xB0, "OVIS")]
        SIG_OVIS = 0xB0,
        [EnumDescription("Unknown - DLYR", 0xB1, "DLYR")]
        SIG_DLYR = 0xB1,
        [EnumDescription("Snap Template Node", 0xB2, "STND")]
        SIG_STND = 0xB2,
        [EnumDescription("Snap Template", 0xB3, "STMP")]
        SIG_STMP = 0xB3,
        [EnumDescription("Ground Cover", 0xB4, "GCVR")]
        SIG_GCVR = 0xB4,
        [EnumDescription("Player Reference", 0xB5, "PLYR")]
        SIG_PLYR = 0xB5,
        [EnumDescription("Spell Threshold Data", 0xB6, "STHD")]
        SIG_STHD = 0xB6,
        [EnumDescription("Volumetric Lighting", 0xB7, "VOLI")]
        SIG_VOLI = 0xB7,
        [EnumDescription("Workshop Permissions", 0xB8, "WSPR")]
        SIG_WSPR = 0xB8,
        [EnumDescription("Wave Encounter", 0xB9, "WAVE")]
        SIG_WAVE = 0xB9,
        [EnumDescription("Aim Assist Pose Data", 0xBA, "AAPD")]
        SIG_AAPD = 0xBA,
        [EnumDescription("Photo Mode Feature", 0xBB, "PMFT")]
        SIG_PMFT = 0xBB,
        [EnumDescription("Challenge", 0xBC, "CHAL")]
        SIG_CHAL = 0xBC,
        [EnumDescription("Condition Form", 0xBD, "CNDF")]
        SIG_CNDF = 0xBD,
        [EnumDescription("Unknown - AUVF", 0xBE, "AUVF")]
        SIG_AUVF = 0xBE,
        [EnumDescription("Legendary Item", 0xBF, "LGDI")]
        SIG_LGDI = 0xBF,
        [EnumDescription("Event Quest Widget", 0xC0, "EQWG")]
        SIG_EQWG = 0xC0,
    }
}
