// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterSequenceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001039")]
  [Serializable]
  public sealed class IntroChapterSequenceData : IMasterDataEntity
  {
    [Token(Token = "0x400506F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005070")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int sequenceProgressValue;
    [Token(Token = "0x4005071")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int sequenceContentsType;
    [Token(Token = "0x4005072")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int sequenceContentsTypeParam;
    [Token(Token = "0x4005073")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool needMainDownload;

    [Token(Token = "0x17000DE5")]
    public int Key
    {
      [Token(Token = "0x6005E49"), Address(RVA = "0x28C1FF8", Offset = "0x28C1FF8", VA = "0x28C1FF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E4A")]
    [Address(RVA = "0x28C2000", Offset = "0x28C2000", VA = "0x28C2000", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E4B")]
    [Address(RVA = "0x28C2230", Offset = "0x28C2230", VA = "0x28C2230", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E4C")]
    [Address(RVA = "0x28C22E4", Offset = "0x28C22E4", VA = "0x28C22E4")]
    public IntroChapterSequenceData()
    {
    }
  }
}
