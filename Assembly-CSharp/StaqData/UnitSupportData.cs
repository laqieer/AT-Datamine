// Decompiled with JetBrains decompiler
// Type: StaqData.UnitSupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200210C")]
  public class UnitSupportData
  {
    [Token(Token = "0x17002C02")]
    public UniqueID UniqueId
    {
      [Token(Token = "0x600CA17"), Address(RVA = "0x1BA0A84", Offset = "0x1BA0A84", VA = "0x1BA0A84")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600CA18"), Address(RVA = "0x1BA0A8C", Offset = "0x1BA0A8C", VA = "0x1BA0A8C")] private set
      {
      }
    }

    [Token(Token = "0x17002C03")]
    public int CharacterId1
    {
      [Token(Token = "0x600CA19"), Address(RVA = "0x1BA0A94", Offset = "0x1BA0A94", VA = "0x1BA0A94")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA1A"), Address(RVA = "0x1BA0A9C", Offset = "0x1BA0A9C", VA = "0x1BA0A9C")] private set
      {
      }
    }

    [Token(Token = "0x17002C04")]
    public int CharacterId2
    {
      [Token(Token = "0x600CA1B"), Address(RVA = "0x1BA0AA4", Offset = "0x1BA0AA4", VA = "0x1BA0AA4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA1C"), Address(RVA = "0x1BA0AAC", Offset = "0x1BA0AAC", VA = "0x1BA0AAC")] private set
      {
      }
    }

    [Token(Token = "0x17002C05")]
    public int Exp
    {
      [Token(Token = "0x600CA1D"), Address(RVA = "0x1BA0AB4", Offset = "0x1BA0AB4", VA = "0x1BA0AB4")] get
      {
        return new int();
      }
      [Token(Token = "0x600CA1E"), Address(RVA = "0x1BA0ABC", Offset = "0x1BA0ABC", VA = "0x1BA0ABC")] private set
      {
      }
    }

    [Token(Token = "0x17002C06")]
    public int NextLevelExp
    {
      [Token(Token = "0x600CA1F"), Address(RVA = "0x1BA0AC4", Offset = "0x1BA0AC4", VA = "0x1BA0AC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002C07")]
    public SupportRankTypeEnum SupportRank
    {
      [Token(Token = "0x600CA20"), Address(RVA = "0x1BA0B64", Offset = "0x1BA0B64", VA = "0x1BA0B64")] get
      {
        return new SupportRankTypeEnum();
      }
      [Token(Token = "0x600CA21"), Address(RVA = "0x1BA0B6C", Offset = "0x1BA0B6C", VA = "0x1BA0B6C")] private set
      {
      }
    }

    [Token(Token = "0x600CA22")]
    [Address(RVA = "0x1BA0B74", Offset = "0x1BA0B74", VA = "0x1BA0B74")]
    public UnitSupportData()
    {
    }

    [Token(Token = "0x600CA23")]
    [Address(RVA = "0x1BA0B7C", Offset = "0x1BA0B7C", VA = "0x1BA0B7C")]
    public UnitSupportData(int chara1id, int chara2id, int exp)
    {
    }

    [Token(Token = "0x600CA24")]
    [Address(RVA = "0x1BA0C48", Offset = "0x1BA0C48", VA = "0x1BA0C48")]
    public void Apply(PlayerUnitSupportType entity)
    {
    }

    [Token(Token = "0x600CA25")]
    [Address(RVA = "0x1BA0C70", Offset = "0x1BA0C70", VA = "0x1BA0C70")]
    public void UpdateExp(int exp)
    {
    }

    [Token(Token = "0x600CA26")]
    [Address(RVA = "0x1BA0D18", Offset = "0x1BA0D18", VA = "0x1BA0D18")]
    public bool IsSameCharaCombination(int charaId1, int charaId2) => new bool();
  }
}
