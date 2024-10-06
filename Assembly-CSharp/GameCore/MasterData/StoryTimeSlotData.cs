// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryTimeSlotData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012FB")]
  [Serializable]
  public sealed class StoryTimeSlotData : IMasterDataEntity
  {
    [Token(Token = "0x40059D7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int index;

    [Token(Token = "0x17001037")]
    public int Key
    {
      [Token(Token = "0x6006B53"), Address(RVA = "0x48E1570", Offset = "0x48E1570", VA = "0x48E1570", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B54")]
    [Address(RVA = "0x48E1578", Offset = "0x48E1578", VA = "0x48E1578", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B55")]
    [Address(RVA = "0x48E16E4", Offset = "0x48E16E4", VA = "0x48E16E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B56")]
    [Address(RVA = "0x48E177C", Offset = "0x48E177C", VA = "0x48E177C")]
    public StoryTimeSlotData()
    {
    }
  }
}
