// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryNotifyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012EA")]
  [Serializable]
  public sealed class StoryNotifyData : IMasterDataEntity
  {
    [Token(Token = "0x40059A6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059A7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int priority;

    [Token(Token = "0x1700102D")]
    public int Key
    {
      [Token(Token = "0x6006B0E"), Address(RVA = "0x48DEAE4", Offset = "0x48DEAE4", VA = "0x48DEAE4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B0F")]
    [Address(RVA = "0x48DEAEC", Offset = "0x48DEAEC", VA = "0x48DEAEC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B10")]
    [Address(RVA = "0x48DEBF8", Offset = "0x48DEBF8", VA = "0x48DEBF8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700102E")]
    public string Text
    {
      [Token(Token = "0x6006B11"), Address(RVA = "0x48DEC7C", Offset = "0x48DEC7C", VA = "0x48DEC7C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700102F")]
    public string Title
    {
      [Token(Token = "0x6006B12"), Address(RVA = "0x48DED58", Offset = "0x48DED58", VA = "0x48DED58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006B13")]
    [Address(RVA = "0x48DEE34", Offset = "0x48DEE34", VA = "0x48DEE34")]
    public StoryNotifyData()
    {
    }
  }
}
