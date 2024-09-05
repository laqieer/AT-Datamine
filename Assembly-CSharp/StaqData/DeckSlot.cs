// Decompiled with JetBrains decompiler
// Type: StaqData.DeckSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FF4")]
  public class DeckSlot
  {
    [Token(Token = "0x17002769")]
    public UniqueID UnitUniqueId
    {
      [Token(Token = "0x600BE32"), Address(RVA = "0x1FFFDFC", Offset = "0x1FFFDFC", VA = "0x1FFFDFC")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE33"), Address(RVA = "0x1FFFE04", Offset = "0x1FFFE04", VA = "0x1FFFE04")] private set
      {
      }
    }

    [Token(Token = "0x1700276A")]
    public SortieType Type
    {
      [Token(Token = "0x600BE34"), Address(RVA = "0x1FFFE0C", Offset = "0x1FFFE0C", VA = "0x1FFFE0C")] get
      {
        return new SortieType();
      }
      [Token(Token = "0x600BE35"), Address(RVA = "0x1FFFE14", Offset = "0x1FFFE14", VA = "0x1FFFE14")] private set
      {
      }
    }

    [Token(Token = "0x1700276B")]
    public Style Style
    {
      [Token(Token = "0x600BE36"), Address(RVA = "0x1FFFE1C", Offset = "0x1FFFE1C", VA = "0x1FFFE1C")] get
      {
        return (Style) null;
      }
      [Token(Token = "0x600BE37"), Address(RVA = "0x1FFFE24", Offset = "0x1FFFE24", VA = "0x1FFFE24")] private set
      {
      }
    }

    [Token(Token = "0x1700276C")]
    public int PartyNumber
    {
      [Token(Token = "0x600BE38"), Address(RVA = "0x1FFFE2C", Offset = "0x1FFFE2C", VA = "0x1FFFE2C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE39"), Address(RVA = "0x1FFFE34", Offset = "0x1FFFE34", VA = "0x1FFFE34")] private set
      {
      }
    }

    [Token(Token = "0x1700276D")]
    public UniqueID MainWeaponUniqueId
    {
      [Token(Token = "0x600BE3A"), Address(RVA = "0x1FFFE3C", Offset = "0x1FFFE3C", VA = "0x1FFFE3C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE3B"), Address(RVA = "0x1FFFE44", Offset = "0x1FFFE44", VA = "0x1FFFE44")] private set
      {
      }
    }

    [Token(Token = "0x1700276E")]
    public UniqueID SubWeaponUnique1Id
    {
      [Token(Token = "0x600BE3C"), Address(RVA = "0x1FFFE4C", Offset = "0x1FFFE4C", VA = "0x1FFFE4C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE3D"), Address(RVA = "0x1FFFE54", Offset = "0x1FFFE54", VA = "0x1FFFE54")] private set
      {
      }
    }

    [Token(Token = "0x1700276F")]
    public UniqueID SubWeaponUnique2Id
    {
      [Token(Token = "0x600BE3E"), Address(RVA = "0x1FFFE5C", Offset = "0x1FFFE5C", VA = "0x1FFFE5C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE3F"), Address(RVA = "0x1FFFE64", Offset = "0x1FFFE64", VA = "0x1FFFE64")] private set
      {
      }
    }

    [Token(Token = "0x17002770")]
    public string[] WeaponIds
    {
      [Token(Token = "0x600BE40"), Address(RVA = "0x1FFD7B8", Offset = "0x1FFD7B8", VA = "0x1FFD7B8")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17002771")]
    public UniqueID AccessoryUniqueId
    {
      [Token(Token = "0x600BE41"), Address(RVA = "0x1FFFE6C", Offset = "0x1FFFE6C", VA = "0x1FFFE6C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE42"), Address(RVA = "0x1FFFE74", Offset = "0x1FFFE74", VA = "0x1FFFE74")] private set
      {
      }
    }

    [Token(Token = "0x17002772")]
    public UniqueID UnitTrustUniqueId
    {
      [Token(Token = "0x600BE43"), Address(RVA = "0x1FFFE7C", Offset = "0x1FFFE7C", VA = "0x1FFFE7C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE44"), Address(RVA = "0x1FFFE84", Offset = "0x1FFFE84", VA = "0x1FFFE84")] private set
      {
      }
    }

    [Token(Token = "0x17002773")]
    public UniqueID MindEquipmentUniqueId
    {
      [Token(Token = "0x600BE45"), Address(RVA = "0x1FFFE8C", Offset = "0x1FFFE8C", VA = "0x1FFFE8C")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600BE46"), Address(RVA = "0x1FFFE94", Offset = "0x1FFFE94", VA = "0x1FFFE94")] private set
      {
      }
    }

    [Token(Token = "0x17002774")]
    public UniqueID[] CustomSkillIds
    {
      [Token(Token = "0x600BE47"), Address(RVA = "0x1FFFE9C", Offset = "0x1FFFE9C", VA = "0x1FFFE9C")] get
      {
        return (UniqueID[]) null;
      }
      [Token(Token = "0x600BE48"), Address(RVA = "0x1FFFEA4", Offset = "0x1FFFEA4", VA = "0x1FFFEA4")] private set
      {
      }
    }

    [Token(Token = "0x17002775")]
    public Weapon MainWeapon
    {
      [Token(Token = "0x600BE49"), Address(RVA = "0x1FFFEAC", Offset = "0x1FFFEAC", VA = "0x1FFFEAC")] get
      {
        return (Weapon) null;
      }
      [Token(Token = "0x600BE4A"), Address(RVA = "0x1FFFEB4", Offset = "0x1FFFEB4", VA = "0x1FFFEB4")] private set
      {
      }
    }

    [Token(Token = "0x17002776")]
    public Weapon SubWeapons1
    {
      [Token(Token = "0x600BE4B"), Address(RVA = "0x1FFFEBC", Offset = "0x1FFFEBC", VA = "0x1FFFEBC")] get
      {
        return (Weapon) null;
      }
      [Token(Token = "0x600BE4C"), Address(RVA = "0x1FFFEC4", Offset = "0x1FFFEC4", VA = "0x1FFFEC4")] private set
      {
      }
    }

    [Token(Token = "0x17002777")]
    public Weapon SubWeapons2
    {
      [Token(Token = "0x600BE4D"), Address(RVA = "0x1FFFECC", Offset = "0x1FFFECC", VA = "0x1FFFECC")] get
      {
        return (Weapon) null;
      }
      [Token(Token = "0x600BE4E"), Address(RVA = "0x1FFFED4", Offset = "0x1FFFED4", VA = "0x1FFFED4")] private set
      {
      }
    }

    [Token(Token = "0x17002778")]
    public Equipment Accessory
    {
      [Token(Token = "0x600BE4F"), Address(RVA = "0x1FFFEDC", Offset = "0x1FFFEDC", VA = "0x1FFFEDC")] get
      {
        return (Equipment) null;
      }
      [Token(Token = "0x600BE50"), Address(RVA = "0x1FFFEE4", Offset = "0x1FFFEE4", VA = "0x1FFFEE4")] private set
      {
      }
    }

    [Token(Token = "0x17002779")]
    public Equipment MindEquipment
    {
      [Token(Token = "0x600BE51"), Address(RVA = "0x1FFFEEC", Offset = "0x1FFFEEC", VA = "0x1FFFEEC")] get
      {
        return (Equipment) null;
      }
      [Token(Token = "0x600BE52"), Address(RVA = "0x1FFFEF4", Offset = "0x1FFFEF4", VA = "0x1FFFEF4")] private set
      {
      }
    }

    [Token(Token = "0x1700277A")]
    public UnitTrust UnitTrust
    {
      [Token(Token = "0x600BE53"), Address(RVA = "0x1FFFEFC", Offset = "0x1FFFEFC", VA = "0x1FFFEFC")] get
      {
        return (UnitTrust) null;
      }
      [Token(Token = "0x600BE54"), Address(RVA = "0x1FFFF04", Offset = "0x1FFFF04", VA = "0x1FFFF04")] private set
      {
      }
    }

    [Token(Token = "0x1700277B")]
    public CustomSkill[] CustomSkills
    {
      [Token(Token = "0x600BE55"), Address(RVA = "0x1FFFF0C", Offset = "0x1FFFF0C", VA = "0x1FFFF0C")] get
      {
        return (CustomSkill[]) null;
      }
      [Token(Token = "0x600BE56"), Address(RVA = "0x1FFFF14", Offset = "0x1FFFF14", VA = "0x1FFFF14")] private set
      {
      }
    }

    [Token(Token = "0x1700277C")]
    public int PositionId
    {
      [Token(Token = "0x600BE57"), Address(RVA = "0x1FFFF1C", Offset = "0x1FFFF1C", VA = "0x1FFFF1C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE58"), Address(RVA = "0x1FFFF24", Offset = "0x1FFFF24", VA = "0x1FFFF24")] private set
      {
      }
    }

    [Token(Token = "0x1700277D")]
    public int Placement
    {
      [Token(Token = "0x600BE59"), Address(RVA = "0x1FFFF2C", Offset = "0x1FFFF2C", VA = "0x1FFFF2C")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE5A"), Address(RVA = "0x1FFFF34", Offset = "0x1FFFF34", VA = "0x1FFFF34")] private set
      {
      }
    }

    [Token(Token = "0x600BE5B")]
    [Address(RVA = "0x1FFFF3C", Offset = "0x1FFFF3C", VA = "0x1FFFF3C")]
    private DeckSlot(UniqueID uniqueId)
    {
    }

    [Token(Token = "0x600BE5C")]
    [Address(RVA = "0x20001D8", Offset = "0x20001D8", VA = "0x20001D8")]
    private DeckSlot(PlayerDeckSlotInfo entity, PlayerProfile playerProfile, int partyNumber)
    {
    }

    [Token(Token = "0x600BE5D")]
    [Address(RVA = "0x2000994", Offset = "0x2000994", VA = "0x2000994")]
    public bool IsSetEquipment(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600BE5E")]
    [Address(RVA = "0x1FFD4C0", Offset = "0x1FFD4C0", VA = "0x1FFD4C0")]
    public static DeckSlot CreateDebugData(string uniqueId) => (DeckSlot) null;

    [Token(Token = "0x600BE5F")]
    [Address(RVA = "0x1FFCEB4", Offset = "0x1FFCEB4", VA = "0x1FFCEB4")]
    public static DeckSlot CreateByServerData(PlayerDeckSlotInfo info, int partyNumber)
    {
      return (DeckSlot) null;
    }

    [Token(Token = "0x600BE60")]
    [Address(RVA = "0x1FFD740", Offset = "0x1FFD740", VA = "0x1FFD740")]
    public static DeckSlot CreateByServerData(
      PlayerDeckSlotInfo info,
      PlayerProfile playerProfile,
      int partyNumber)
    {
      return (DeckSlot) null;
    }
  }
}
