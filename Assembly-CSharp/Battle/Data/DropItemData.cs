// Decompiled with JetBrains decompiler
// Type: Battle.Data.DropItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026FD")]
  public sealed class DropItemData
  {
    [Token(Token = "0x17003331")]
    public RewardTypeEnum RewardType
    {
      [Token(Token = "0x600F18A"), Address(RVA = "0x41AF3A0", Offset = "0x41AF3A0", VA = "0x41AF3A0")] get
      {
        return new RewardTypeEnum();
      }
      [Token(Token = "0x600F18B"), Address(RVA = "0x41AF3A8", Offset = "0x41AF3A8", VA = "0x41AF3A8")] private set
      {
      }
    }

    [Token(Token = "0x17003332")]
    public int Id
    {
      [Token(Token = "0x600F18C"), Address(RVA = "0x41AF3B0", Offset = "0x41AF3B0", VA = "0x41AF3B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F18D"), Address(RVA = "0x41AF3B8", Offset = "0x41AF3B8", VA = "0x41AF3B8")] private set
      {
      }
    }

    [Token(Token = "0x17003333")]
    public int Amount
    {
      [Token(Token = "0x600F18E"), Address(RVA = "0x41AF3C0", Offset = "0x41AF3C0", VA = "0x41AF3C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F18F"), Address(RVA = "0x41AF3C8", Offset = "0x41AF3C8", VA = "0x41AF3C8")] private set
      {
      }
    }

    [Token(Token = "0x17003334")]
    public bool IsFirstTime
    {
      [Token(Token = "0x600F190"), Address(RVA = "0x41AF3D0", Offset = "0x41AF3D0", VA = "0x41AF3D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F191"), Address(RVA = "0x41AF3D8", Offset = "0x41AF3D8", VA = "0x41AF3D8")] private set
      {
      }
    }

    [Token(Token = "0x600F192")]
    [Address(RVA = "0x41AF3E4", Offset = "0x41AF3E4", VA = "0x41AF3E4")]
    public DropItemData(BattleDropDescriptionData entity)
    {
    }

    [Token(Token = "0x600F193")]
    [Address(RVA = "0x41AF420", Offset = "0x41AF420", VA = "0x41AF420")]
    public DropItemData(RewardTypeEnum rewardType, int id, int amount)
    {
    }
  }
}
