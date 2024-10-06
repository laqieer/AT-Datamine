// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleHpRatioEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E19")]
  [Serializable]
  public sealed class BattleHpRatioEffectRatioData : IMasterDataEntity, IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x4004327")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004328")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4004329")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400432A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x400432B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C53")]
    public int Key
    {
      [Token(Token = "0x60055E7"), Address(RVA = "0x3E2F938", Offset = "0x3E2F938", VA = "0x3E2F938", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60055E8")]
    [Address(RVA = "0x3E2F940", Offset = "0x3E2F940", VA = "0x3E2F940", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60055E9")]
    [Address(RVA = "0x3E2FB6C", Offset = "0x3E2FB6C", VA = "0x3E2FB6C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60055EA")]
    [Address(RVA = "0x3E2FC20", Offset = "0x3E2FC20", VA = "0x3E2FC20", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x60055EB")]
    [Address(RVA = "0x3E2FC28", Offset = "0x3E2FC28", VA = "0x3E2FC28")]
    public BattleHpRatioEffectRatioData()
    {
    }
  }
}
