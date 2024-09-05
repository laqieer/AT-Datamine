// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookCompleteFirstImpressionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D2")]
  [Serializable]
  public sealed class StoryBookCompleteFirstImpressionsData : IMasterDataEntity
  {
    [Token(Token = "0x4005961")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005962")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bookID;
    [Token(Token = "0x4005963")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4005964")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public TextBoxTypeEnum boxtype;
    [Token(Token = "0x4005965")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17001018")]
    public int Key
    {
      [Token(Token = "0x6006A9C"), Address(RVA = "0x48DAA9C", Offset = "0x48DAA9C", VA = "0x48DAA9C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006A9D")]
    [Address(RVA = "0x48DAAA4", Offset = "0x48DAAA4", VA = "0x48DAAA4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006A9E")]
    [Address(RVA = "0x48DAC70", Offset = "0x48DAC70", VA = "0x48DAC70", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001019")]
    public string Text
    {
      [Token(Token = "0x6006A9F"), Address(RVA = "0x48DAD14", Offset = "0x48DAD14", VA = "0x48DAD14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006AA0")]
    [Address(RVA = "0x48DADF0", Offset = "0x48DADF0", VA = "0x48DADF0")]
    public StoryBookCompleteFirstImpressionsData()
    {
    }
  }
}
