// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulSpotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FAA")]
  [Serializable]
  public sealed class ExpeditionSoulSpotData : IMasterDataEntity
  {
    [Token(Token = "0x4004EE2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EE3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int soulType;
    [Token(Token = "0x4004EE4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004EE5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int production;
    [Token(Token = "0x4004EE6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int storage;

    [Token(Token = "0x17000D93")]
    public int Key
    {
      [Token(Token = "0x6005BF1"), Address(RVA = "0x2787764", Offset = "0x2787764", VA = "0x2787764", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BF2")]
    [Address(RVA = "0x278776C", Offset = "0x278776C", VA = "0x278776C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BF3")]
    [Address(RVA = "0x2787998", Offset = "0x2787998", VA = "0x2787998", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BF4")]
    [Address(RVA = "0x2787A4C", Offset = "0x2787A4C", VA = "0x2787A4C")]
    public ExpeditionSoulSpotData()
    {
    }
  }
}
