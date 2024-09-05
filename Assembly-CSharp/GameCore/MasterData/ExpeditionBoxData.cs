// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBoxData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F9C")]
  [Serializable]
  public sealed class ExpeditionBoxData : IMasterDataEntity
  {
    [Token(Token = "0x4004EC2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EC3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004EC4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int capacity;
    [Token(Token = "0x4004EC5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int coinRequiredAmount;

    [Token(Token = "0x17000D8C")]
    public int Key
    {
      [Token(Token = "0x6005BB5"), Address(RVA = "0x27859A4", Offset = "0x27859A4", VA = "0x27859A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BB6")]
    [Address(RVA = "0x27859AC", Offset = "0x27859AC", VA = "0x27859AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BB7")]
    [Address(RVA = "0x2785B78", Offset = "0x2785B78", VA = "0x2785B78", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BB8")]
    [Address(RVA = "0x2785C1C", Offset = "0x2785C1C", VA = "0x2785C1C")]
    public ExpeditionBoxData()
    {
    }
  }
}
