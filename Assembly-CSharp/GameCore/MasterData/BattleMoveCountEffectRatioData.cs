// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMoveCountEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E1F")]
  [Serializable]
  public sealed class BattleMoveCountEffectRatioData : 
    IMasterDataEntity,
    IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x4004348")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004349")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x400434A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400434B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x400434C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C57")]
    public int Key
    {
      [Token(Token = "0x6005609"), Address(RVA = "0x3E3117C", Offset = "0x3E3117C", VA = "0x3E3117C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600560A")]
    [Address(RVA = "0x3E31184", Offset = "0x3E31184", VA = "0x3E31184", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600560B")]
    [Address(RVA = "0x3E313B0", Offset = "0x3E313B0", VA = "0x3E313B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600560C")]
    [Address(RVA = "0x3E31464", Offset = "0x3E31464", VA = "0x3E31464", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x600560D")]
    [Address(RVA = "0x3E3146C", Offset = "0x3E3146C", VA = "0x3E3146C")]
    public BattleMoveCountEffectRatioData()
    {
    }
  }
}
