// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryHumanParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012E5")]
  [Serializable]
  public sealed class StoryHumanParameterData : IMasterDataEntity
  {
    [Token(Token = "0x400599A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400599B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400599C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x400599D")]
    public const string TEXT_AB = "text_masterdata_story";

    [Token(Token = "0x1700102A")]
    public int Key
    {
      [Token(Token = "0x6006AF4"), Address(RVA = "0x48DDE20", Offset = "0x48DDE20", VA = "0x48DDE20", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006AF5")]
    [Address(RVA = "0x48DDE28", Offset = "0x48DDE28", VA = "0x48DDE28", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006AF6")]
    [Address(RVA = "0x48DDF94", Offset = "0x48DDF94", VA = "0x48DDF94", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x1700102B")]
    public string Text
    {
      [Token(Token = "0x6006AF7"), Address(RVA = "0x48DE02C", Offset = "0x48DE02C", VA = "0x48DE02C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006AF8")]
    [Address(RVA = "0x48DE108", Offset = "0x48DE108", VA = "0x48DE108")]
    public StoryHumanParameterData()
    {
    }
  }
}
