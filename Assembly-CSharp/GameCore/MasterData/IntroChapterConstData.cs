// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IntroChapterConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200102D")]
  [Serializable]
  public sealed class IntroChapterConstData : IMasterDataEntity
  {
    [Token(Token = "0x400504D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400504E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int storyMainquestSequenceID;

    [Token(Token = "0x17000DE0")]
    public int Key
    {
      [Token(Token = "0x6005E18"), Address(RVA = "0x2799CAC", Offset = "0x2799CAC", VA = "0x2799CAC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E19")]
    [Address(RVA = "0x2799CB4", Offset = "0x2799CB4", VA = "0x2799CB4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E1A")]
    [Address(RVA = "0x2799DC0", Offset = "0x2799DC0", VA = "0x2799DC0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E1B")]
    [Address(RVA = "0x2799E44", Offset = "0x2799E44", VA = "0x2799E44")]
    public IntroChapterConstData()
    {
    }
  }
}
