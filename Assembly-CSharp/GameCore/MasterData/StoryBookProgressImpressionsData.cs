// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookProgressImpressionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D8")]
  [Serializable]
  public sealed class StoryBookProgressImpressionsData : IMasterDataEntity
  {
    [Token(Token = "0x4005977")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005978")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bookID;
    [Token(Token = "0x4005979")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int count;
    [Token(Token = "0x400597A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int number;
    [Token(Token = "0x400597B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public TextBoxTypeEnum boxtype;
    [Token(Token = "0x400597C")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x17001020")]
    public int Key
    {
      [Token(Token = "0x6006AB9"), Address(RVA = "0x48DBC94", Offset = "0x48DBC94", VA = "0x48DBC94", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006ABA")]
    [Address(RVA = "0x48DBC9C", Offset = "0x48DBC9C", VA = "0x48DBC9C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006ABB")]
    [Address(RVA = "0x48DBEC8", Offset = "0x48DBEC8", VA = "0x48DBEC8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001021")]
    public string Text
    {
      [Token(Token = "0x6006ABC"), Address(RVA = "0x48DBF7C", Offset = "0x48DBF7C", VA = "0x48DBF7C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006ABD")]
    [Address(RVA = "0x48DC058", Offset = "0x48DC058", VA = "0x48DC058")]
    public StoryBookProgressImpressionsData()
    {
    }
  }
}
