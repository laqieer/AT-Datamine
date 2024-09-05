// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionAreaFastTravelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200123B")]
  [Serializable]
  public sealed class StoryFreeActionAreaFastTravelData : IMasterDataEntity
  {
    [Token(Token = "0x4005746")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005747")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int label;
    [Token(Token = "0x4005748")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int area;
    [Token(Token = "0x4005749")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string anchor;

    [Token(Token = "0x17000F99")]
    public int Key
    {
      [Token(Token = "0x60067A7"), Address(RVA = "0x4D3145C", Offset = "0x4D3145C", VA = "0x4D3145C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60067A8")]
    [Address(RVA = "0x4D31464", Offset = "0x4D31464", VA = "0x4D31464", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60067A9")]
    [Address(RVA = "0x4D31630", Offset = "0x4D31630", VA = "0x4D31630", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F9A")]
    public string Text
    {
      [Token(Token = "0x60067AA"), Address(RVA = "0x4D316D8", Offset = "0x4D316D8", VA = "0x4D316D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60067AB")]
    [Address(RVA = "0x4D317B4", Offset = "0x4D317B4", VA = "0x4D317B4")]
    public StoryFreeActionAreaFastTravelData()
    {
    }
  }
}
