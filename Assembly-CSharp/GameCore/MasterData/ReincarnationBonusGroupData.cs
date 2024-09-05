// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ReincarnationBonusGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013A9")]
  [Serializable]
  public sealed class ReincarnationBonusGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005B9F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BA0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int reincarnationBonusGroupId;
    [Token(Token = "0x4005BA1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int reincarnationCount;
    [Token(Token = "0x4005BA2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public ReincarnationBonusTypeEnum reincarnationBonusTypeId;

    [Token(Token = "0x17001095")]
    public int Key
    {
      [Token(Token = "0x6006E6E"), Address(RVA = "0x4705720", Offset = "0x4705720", VA = "0x4705720", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E6F")]
    [Address(RVA = "0x4705728", Offset = "0x4705728", VA = "0x4705728", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E70")]
    [Address(RVA = "0x47058F4", Offset = "0x47058F4", VA = "0x47058F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E71")]
    [Address(RVA = "0x4705998", Offset = "0x4705998", VA = "0x4705998")]
    public ReincarnationBonusGroupData()
    {
    }
  }
}
