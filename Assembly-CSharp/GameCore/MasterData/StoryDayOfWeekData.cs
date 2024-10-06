// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryDayOfWeekData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012DD")]
  [Serializable]
  public sealed class StoryDayOfWeekData : IMasterDataEntity
  {
    [Token(Token = "0x4005989")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400598A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400598B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int index;
    [Token(Token = "0x400598C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string shortyEN;
    [Token(Token = "0x400598D")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17001025")]
    public int Key
    {
      [Token(Token = "0x6006AD2"), Address(RVA = "0x48DCBA8", Offset = "0x48DCBA8", VA = "0x48DCBA8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AD3")]
    [Address(RVA = "0x48DCBB0", Offset = "0x48DCBB0", VA = "0x48DCBB0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006AD4")]
    [Address(RVA = "0x48DCD7C", Offset = "0x48DCD7C", VA = "0x48DCD7C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001026")]
    public string TextShortyEN
    {
      [Token(Token = "0x6006AD5"), Address(RVA = "0x48DCE28", Offset = "0x48DCE28", VA = "0x48DCE28")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001027")]
    public string Text
    {
      [Token(Token = "0x6006AD6"), Address(RVA = "0x48DCF04", Offset = "0x48DCF04", VA = "0x48DCF04")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006AD7")]
    [Address(RVA = "0x48DCFE0", Offset = "0x48DCFE0", VA = "0x48DCFE0")]
    public StoryDayOfWeekData()
    {
    }
  }
}
