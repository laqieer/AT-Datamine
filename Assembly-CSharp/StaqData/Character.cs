// Decompiled with JetBrains decompiler
// Type: StaqData.Character
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020FB")]
  public class Character
  {
    [Token(Token = "0x4008BA9")]
    private const float CriticalRateMin = 1.5f;
    [Token(Token = "0x4008BAA")]
    private const float CriticalRateMax = 3.5f;
    [Token(Token = "0x4008BAB")]
    private const float CriticalRateControl = 100f;

    [Token(Token = "0x17002B41")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600C82E"), Address(RVA = "0x1CE1A78", Offset = "0x1CE1A78", VA = "0x1CE1A78")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600C82F"), Address(RVA = "0x1CE1A80", Offset = "0x1CE1A80", VA = "0x1CE1A80")] private set
      {
      }
    }

    [Token(Token = "0x17002B42")]
    public DateTime CreateAt
    {
      [Token(Token = "0x600C830"), Address(RVA = "0x1CE1A88", Offset = "0x1CE1A88", VA = "0x1CE1A88")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600C831"), Address(RVA = "0x1CE1A90", Offset = "0x1CE1A90", VA = "0x1CE1A90")] private set
      {
      }
    }

    [Token(Token = "0x17002B43")]
    public int MasterId
    {
      [Token(Token = "0x600C832"), Address(RVA = "0x1CE1A98", Offset = "0x1CE1A98", VA = "0x1CE1A98")] get
      {
        return new int();
      }
      [Token(Token = "0x600C833"), Address(RVA = "0x1CE1AA0", Offset = "0x1CE1AA0", VA = "0x1CE1AA0")] private set
      {
      }
    }

    [Token(Token = "0x17002B44")]
    public int IntimateLevel
    {
      [Token(Token = "0x600C834"), Address(RVA = "0x1CE1AA8", Offset = "0x1CE1AA8", VA = "0x1CE1AA8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C835"), Address(RVA = "0x1CE1AB0", Offset = "0x1CE1AB0", VA = "0x1CE1AB0")] private set
      {
      }
    }

    [Token(Token = "0x17002B45")]
    public int IntimateExp
    {
      [Token(Token = "0x600C836"), Address(RVA = "0x1CE1AB8", Offset = "0x1CE1AB8", VA = "0x1CE1AB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C837"), Address(RVA = "0x1CE1AC0", Offset = "0x1CE1AC0", VA = "0x1CE1AC0")] private set
      {
      }
    }

    [Token(Token = "0x17002B46")]
    public string[] PlayerUnitSupportIds
    {
      [Token(Token = "0x600C838"), Address(RVA = "0x1CE1AC8", Offset = "0x1CE1AC8", VA = "0x1CE1AC8")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x600C839"), Address(RVA = "0x1CE1AD0", Offset = "0x1CE1AD0", VA = "0x1CE1AD0")] private set
      {
      }
    }

    [Token(Token = "0x17002B47")]
    public string ExpeditionPlayerUnitId
    {
      [Token(Token = "0x600C83A"), Address(RVA = "0x1CE1AD8", Offset = "0x1CE1AD8", VA = "0x1CE1AD8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C83B"), Address(RVA = "0x1CE1AE0", Offset = "0x1CE1AE0", VA = "0x1CE1AE0")] private set
      {
      }
    }

    [Token(Token = "0x17002B48")]
    public int ReleaseState
    {
      [Token(Token = "0x600C83C"), Address(RVA = "0x1CE1AE8", Offset = "0x1CE1AE8", VA = "0x1CE1AE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C83D"), Address(RVA = "0x1CE1AF0", Offset = "0x1CE1AF0", VA = "0x1CE1AF0")] private set
      {
      }
    }

    [Token(Token = "0x17002B49")]
    public CharacterLimitReleaseDetailData LimitReleaseDetail
    {
      [Token(Token = "0x600C83E"), Address(RVA = "0x1CE1AF8", Offset = "0x1CE1AF8", VA = "0x1CE1AF8")] get
      {
        return (CharacterLimitReleaseDetailData) null;
      }
      [Token(Token = "0x600C83F"), Address(RVA = "0x1CE1B00", Offset = "0x1CE1B00", VA = "0x1CE1B00")] private set
      {
      }
    }

    [Token(Token = "0x17002B4A")]
    public int InfluenceRate
    {
      [Token(Token = "0x600C840"), Address(RVA = "0x1CE1B08", Offset = "0x1CE1B08", VA = "0x1CE1B08")] get
      {
        return new int();
      }
      [Token(Token = "0x600C841"), Address(RVA = "0x1CE1B10", Offset = "0x1CE1B10", VA = "0x1CE1B10")] private set
      {
      }
    }

    [Token(Token = "0x17002B4B")]
    public CharacterData CharacterData
    {
      [Token(Token = "0x600C842"), Address(RVA = "0x1CE1B18", Offset = "0x1CE1B18", VA = "0x1CE1B18")] get
      {
        return (CharacterData) null;
      }
      [Token(Token = "0x600C843"), Address(RVA = "0x1CE1B20", Offset = "0x1CE1B20", VA = "0x1CE1B20")] private set
      {
      }
    }

    [Token(Token = "0x17002B4C")]
    public List<PlayerUnitCharacterWeaponProficiencyType> WeaponProficiencies
    {
      [Token(Token = "0x600C844"), Address(RVA = "0x1CE1B28", Offset = "0x1CE1B28", VA = "0x1CE1B28")] get
      {
        return (List<PlayerUnitCharacterWeaponProficiencyType>) null;
      }
      [Token(Token = "0x600C845"), Address(RVA = "0x1CE1B30", Offset = "0x1CE1B30", VA = "0x1CE1B30")] private set
      {
      }
    }

    [Token(Token = "0x17002B4D")]
    public int PararaLife
    {
      [Token(Token = "0x600C846"), Address(RVA = "0x1CE1B38", Offset = "0x1CE1B38", VA = "0x1CE1B38")] get
      {
        return new int();
      }
      [Token(Token = "0x600C847"), Address(RVA = "0x1CE1B40", Offset = "0x1CE1B40", VA = "0x1CE1B40")] private set
      {
      }
    }

    [Token(Token = "0x17002B4E")]
    public int PararaStrength
    {
      [Token(Token = "0x600C848"), Address(RVA = "0x1CE1B48", Offset = "0x1CE1B48", VA = "0x1CE1B48")] get
      {
        return new int();
      }
      [Token(Token = "0x600C849"), Address(RVA = "0x1CE1B50", Offset = "0x1CE1B50", VA = "0x1CE1B50")] private set
      {
      }
    }

    [Token(Token = "0x17002B4F")]
    public int PararaIntelligence
    {
      [Token(Token = "0x600C84A"), Address(RVA = "0x1CE1B58", Offset = "0x1CE1B58", VA = "0x1CE1B58")] get
      {
        return new int();
      }
      [Token(Token = "0x600C84B"), Address(RVA = "0x1CE1B60", Offset = "0x1CE1B60", VA = "0x1CE1B60")] private set
      {
      }
    }

    [Token(Token = "0x17002B50")]
    public int PararaVitality
    {
      [Token(Token = "0x600C84C"), Address(RVA = "0x1CE1B68", Offset = "0x1CE1B68", VA = "0x1CE1B68")] get
      {
        return new int();
      }
      [Token(Token = "0x600C84D"), Address(RVA = "0x1CE1B70", Offset = "0x1CE1B70", VA = "0x1CE1B70")] private set
      {
      }
    }

    [Token(Token = "0x17002B51")]
    public int PararaMind
    {
      [Token(Token = "0x600C84E"), Address(RVA = "0x1CE1B78", Offset = "0x1CE1B78", VA = "0x1CE1B78")] get
      {
        return new int();
      }
      [Token(Token = "0x600C84F"), Address(RVA = "0x1CE1B80", Offset = "0x1CE1B80", VA = "0x1CE1B80")] private set
      {
      }
    }

    [Token(Token = "0x17002B52")]
    public int PararaAgility
    {
      [Token(Token = "0x600C850"), Address(RVA = "0x1CE1B88", Offset = "0x1CE1B88", VA = "0x1CE1B88")] get
      {
        return new int();
      }
      [Token(Token = "0x600C851"), Address(RVA = "0x1CE1B90", Offset = "0x1CE1B90", VA = "0x1CE1B90")] private set
      {
      }
    }

    [Token(Token = "0x17002B53")]
    public int PararaDexterity
    {
      [Token(Token = "0x600C852"), Address(RVA = "0x1CE1B98", Offset = "0x1CE1B98", VA = "0x1CE1B98")] get
      {
        return new int();
      }
      [Token(Token = "0x600C853"), Address(RVA = "0x1CE1BA0", Offset = "0x1CE1BA0", VA = "0x1CE1BA0")] private set
      {
      }
    }

    [Token(Token = "0x17002B54")]
    public int PararaLucky
    {
      [Token(Token = "0x600C854"), Address(RVA = "0x1CE1BA8", Offset = "0x1CE1BA8", VA = "0x1CE1BA8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C855"), Address(RVA = "0x1CE1BB0", Offset = "0x1CE1BB0", VA = "0x1CE1BB0")] private set
      {
      }
    }

    [Token(Token = "0x17002B55")]
    public int Lp
    {
      [Token(Token = "0x600C856"), Address(RVA = "0x1CE1BB8", Offset = "0x1CE1BB8", VA = "0x1CE1BB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C857"), Address(RVA = "0x1CE1BC0", Offset = "0x1CE1BC0", VA = "0x1CE1BC0")] private set
      {
      }
    }

    [Token(Token = "0x17002B56")]
    public string LastLostAt
    {
      [Token(Token = "0x600C858"), Address(RVA = "0x1CE1BC8", Offset = "0x1CE1BC8", VA = "0x1CE1BC8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C859"), Address(RVA = "0x1CE1BD0", Offset = "0x1CE1BD0", VA = "0x1CE1BD0")] private set
      {
      }
    }

    [Token(Token = "0x600C85A")]
    [Address(RVA = "0x1CE1BD8", Offset = "0x1CE1BD8", VA = "0x1CE1BD8")]
    private Character()
    {
    }

    [Token(Token = "0x600C85B")]
    [Address(RVA = "0x1CE1BE0", Offset = "0x1CE1BE0", VA = "0x1CE1BE0")]
    public Style GetExpeditionStyle() => (Style) null;

    [Token(Token = "0x600C85C")]
    [Address(RVA = "0x1CE1C74", Offset = "0x1CE1C74", VA = "0x1CE1C74")]
    public bool IsOrganization() => new bool();

    [Token(Token = "0x600C85D")]
    [Address(RVA = "0x1CE203C", Offset = "0x1CE203C", VA = "0x1CE203C")]
    public bool IsLost() => new bool();

    [Token(Token = "0x600C85E")]
    [Address(RVA = "0x1CE204C", Offset = "0x1CE204C", VA = "0x1CE204C")]
    public void Apply(PlayerUnitCharacterType entity)
    {
    }

    [Token(Token = "0x600C85F")]
    [Address(RVA = "0x1CE2304", Offset = "0x1CE2304", VA = "0x1CE2304")]
    private void Reset()
    {
    }

    [Token(Token = "0x600C860")]
    [Address(RVA = "0x1CE2338", Offset = "0x1CE2338", VA = "0x1CE2338")]
    public static Character CreateByServerData(PlayerUnitCharacterType entity) => (Character) null;

    [Token(Token = "0x600C861")]
    [Address(RVA = "0x1CE2574", Offset = "0x1CE2574", VA = "0x1CE2574")]
    public bool CheckPararaLimit(ExpeditionBossDescriptionData bossDescriptionData) => new bool();
  }
}
