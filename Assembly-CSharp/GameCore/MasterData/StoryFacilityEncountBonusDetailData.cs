// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityEncountBonusDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001221")]
  [Serializable]
  public sealed class StoryFacilityEncountBonusDetailData : IMasterDataEntity
  {
    [Token(Token = "0x40056BC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056BD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facility;
    [Token(Token = "0x40056BE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int commuID;
    [Token(Token = "0x40056BF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int advID;

    [Token(Token = "0x17000F90")]
    public int Key
    {
      [Token(Token = "0x600674E"), Address(RVA = "0x4D2E1EC", Offset = "0x4D2E1EC", VA = "0x4D2E1EC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600674F")]
    [Address(RVA = "0x4D2E1F4", Offset = "0x4D2E1F4", VA = "0x4D2E1F4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006750")]
    [Address(RVA = "0x4D2E3C0", Offset = "0x4D2E3C0", VA = "0x4D2E3C0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006751")]
    [Address(RVA = "0x4D2E464", Offset = "0x4D2E464", VA = "0x4D2E464")]
    public StoryFacilityEncountBonusDetailData()
    {
    }
  }
}
