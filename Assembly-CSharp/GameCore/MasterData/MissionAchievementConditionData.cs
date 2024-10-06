// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionAchievementConditionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001098")]
  [Serializable]
  public sealed class MissionAchievementConditionData : IMasterDataEntity
  {
    [Token(Token = "0x40051E5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051E6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000E54")]
    public int Key
    {
      [Token(Token = "0x600601C"), Address(RVA = "0x28D4A28", Offset = "0x28D4A28", VA = "0x28D4A28", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600601D")]
    [Address(RVA = "0x28D4A30", Offset = "0x28D4A30", VA = "0x28D4A30", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600601E")]
    [Address(RVA = "0x28D4B3C", Offset = "0x28D4B3C", VA = "0x28D4B3C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600601F")]
    [Address(RVA = "0x28D4BC4", Offset = "0x28D4BC4", VA = "0x28D4BC4")]
    public MissionAchievementConditionData()
    {
    }
  }
}
