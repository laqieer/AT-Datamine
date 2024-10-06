// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TutorialData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001323")]
  [Serializable]
  public sealed class TutorialData : IMasterDataEntity
  {
    [Token(Token = "0x4005A6C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A6D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x4005A6E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int categoryId;
    [Token(Token = "0x4005A6F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int[] tutorialPageIds;

    [Token(Token = "0x17001058")]
    public int Key
    {
      [Token(Token = "0x6006C0B"), Address(RVA = "0x48E7DF8", Offset = "0x48E7DF8", VA = "0x48E7DF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C0C")]
    [Address(RVA = "0x48E7E00", Offset = "0x48E7E00", VA = "0x48E7E00", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C0D")]
    [Address(RVA = "0x48E805C", Offset = "0x48E805C", VA = "0x48E805C")]
    public TutorialData()
    {
    }
  }
}
