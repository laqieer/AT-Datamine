// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StockCounterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001392")]
  [Serializable]
  public sealed class StockCounterData : IMasterDataEntity
  {
    [Token(Token = "0x4005B6A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B6B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int max;

    [Token(Token = "0x1700108F")]
    public int Key
    {
      [Token(Token = "0x6006E04"), Address(RVA = "0x47016FC", Offset = "0x47016FC", VA = "0x47016FC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E05")]
    [Address(RVA = "0x4701704", Offset = "0x4701704", VA = "0x4701704", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E06")]
    [Address(RVA = "0x4701810", Offset = "0x4701810", VA = "0x4701810", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E07")]
    [Address(RVA = "0x4701894", Offset = "0x4701894", VA = "0x4701894")]
    public StockCounterData()
    {
    }
  }
}
