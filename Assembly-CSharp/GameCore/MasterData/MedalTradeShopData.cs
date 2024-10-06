// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200117F")]
  [Serializable]
  public sealed class MedalTradeShopData : IMasterDataEntity
  {
    [Token(Token = "0x400549B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400549C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400549D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string eventName;
    [Token(Token = "0x400549E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x400549F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x40054A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int resetSettingId;
    [Token(Token = "0x40054A1")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int showPriority;
    [Token(Token = "0x40054A2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int bannerImageID;

    [Token(Token = "0x17000F39")]
    public int Key
    {
      [Token(Token = "0x6006499"), Address(RVA = "0x4AF105C", Offset = "0x4AF105C", VA = "0x4AF105C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600649A")]
    [Address(RVA = "0x4AF1064", Offset = "0x4AF1064", VA = "0x4AF1064", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600649B")]
    [Address(RVA = "0x4AF13B0", Offset = "0x4AF13B0", VA = "0x4AF13B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F3A")]
    public string Name
    {
      [Token(Token = "0x600649C"), Address(RVA = "0x4AF14F0", Offset = "0x4AF14F0", VA = "0x4AF14F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F3B")]
    public string EventName
    {
      [Token(Token = "0x600649D"), Address(RVA = "0x4AF15CC", Offset = "0x4AF15CC", VA = "0x4AF15CC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600649E")]
    [Address(RVA = "0x4AF16A8", Offset = "0x4AF16A8", VA = "0x4AF16A8")]
    public bool HasBeenResetSetting() => new bool();

    [Token(Token = "0x600649F")]
    [Address(RVA = "0x4AF16B8", Offset = "0x4AF16B8", VA = "0x4AF16B8")]
    public MedalTradeShopData()
    {
    }
  }
}
