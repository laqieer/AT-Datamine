// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaEventQuestTaskTextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011E6")]
  [Serializable]
  public sealed class StoryAreaEventQuestTaskTextData : IMasterDataEntity
  {
    [Token(Token = "0x40055E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000F6E")]
    public int Key
    {
      [Token(Token = "0x600664C"), Address(RVA = "0x4D2436C", Offset = "0x4D2436C", VA = "0x4D2436C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600664D")]
    [Address(RVA = "0x4D24374", Offset = "0x4D24374", VA = "0x4D24374", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600664E")]
    [Address(RVA = "0x4D24480", Offset = "0x4D24480", VA = "0x4D24480", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F6F")]
    public string Text
    {
      [Token(Token = "0x600664F"), Address(RVA = "0x4D24508", Offset = "0x4D24508", VA = "0x4D24508")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006650")]
    [Address(RVA = "0x4D245E4", Offset = "0x4D245E4", VA = "0x4D245E4")]
    public StoryAreaEventQuestTaskTextData()
    {
    }
  }
}
