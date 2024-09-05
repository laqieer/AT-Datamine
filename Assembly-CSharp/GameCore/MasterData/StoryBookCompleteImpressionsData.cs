// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryBookCompleteImpressionsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012D4")]
  [Serializable]
  public sealed class StoryBookCompleteImpressionsData : IMasterDataEntity
  {
    [Token(Token = "0x4005966")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005967")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bookID;
    [Token(Token = "0x4005968")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int number;
    [Token(Token = "0x4005969")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public TextBoxTypeEnum boxtype;
    [Token(Token = "0x400596A")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x1700101A")]
    public int Key
    {
      [Token(Token = "0x6006AA5"), Address(RVA = "0x48DAF00", Offset = "0x48DAF00", VA = "0x48DAF00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AA6")]
    [Address(RVA = "0x48DAF08", Offset = "0x48DAF08", VA = "0x48DAF08", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006AA7")]
    [Address(RVA = "0x48DB0D4", Offset = "0x48DB0D4", VA = "0x48DB0D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700101B")]
    public string Text
    {
      [Token(Token = "0x6006AA8"), Address(RVA = "0x48DB178", Offset = "0x48DB178", VA = "0x48DB178")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006AA9")]
    [Address(RVA = "0x48DB254", Offset = "0x48DB254", VA = "0x48DB254")]
    public StoryBookCompleteImpressionsData()
    {
    }
  }
}
