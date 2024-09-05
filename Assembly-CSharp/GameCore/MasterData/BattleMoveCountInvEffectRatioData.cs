// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleMoveCountInvEffectRatioData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E21")]
  [Serializable]
  public sealed class BattleMoveCountInvEffectRatioData : 
    IMasterDataEntity,
    IBattleGroupEffectDataEntity
  {
    [Token(Token = "0x400434E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400434F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupID;
    [Token(Token = "0x4004350")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004351")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4004352")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float ratio;

    [Token(Token = "0x17000C58")]
    public int Key
    {
      [Token(Token = "0x6005614"), Address(RVA = "0x3E318E0", Offset = "0x3E318E0", VA = "0x3E318E0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005615")]
    [Address(RVA = "0x3E318E8", Offset = "0x3E318E8", VA = "0x3E318E8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005616")]
    [Address(RVA = "0x3E31B14", Offset = "0x3E31B14", VA = "0x3E31B14", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005617")]
    [Address(RVA = "0x3E31BC8", Offset = "0x3E31BC8", VA = "0x3E31BC8", Slot = "7")]
    public float GetRatio() => new float();

    [Token(Token = "0x6005618")]
    [Address(RVA = "0x3E31BD0", Offset = "0x3E31BD0", VA = "0x3E31BD0")]
    public BattleMoveCountInvEffectRatioData()
    {
    }
  }
}
