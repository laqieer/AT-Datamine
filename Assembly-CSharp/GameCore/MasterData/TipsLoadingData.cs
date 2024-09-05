// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TipsLoadingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA5")]
  [Serializable]
  public sealed class TipsLoadingData : IMasterDataEntity
  {
    [Token(Token = "0x40046B9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046BA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int tipsCategory;
    [Token(Token = "0x40046BB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40046BC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x40046BD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int playerRank;
    [Token(Token = "0x40046BE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int sequenceId;
    [Token(Token = "0x40046BF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string tipsId;

    [Token(Token = "0x17000D3D")]
    public int Key
    {
      [Token(Token = "0x6005909"), Address(RVA = "0x3C2F828", Offset = "0x3C2F828", VA = "0x3C2F828", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600590A")]
    [Address(RVA = "0x3C2F830", Offset = "0x3C2F830", VA = "0x3C2F830", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600590B")]
    [Address(RVA = "0x3C2FB1C", Offset = "0x3C2FB1C", VA = "0x3C2FB1C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600590C")]
    [Address(RVA = "0x3C2FC4C", Offset = "0x3C2FC4C", VA = "0x3C2FC4C")]
    public TipsLoadingData()
    {
    }
  }
}
