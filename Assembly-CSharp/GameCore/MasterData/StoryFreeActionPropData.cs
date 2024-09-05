// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionPropData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001272")]
  [Serializable]
  public sealed class StoryFreeActionPropData : IMasterDataEntity
  {
    [Token(Token = "0x400582A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400582B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400582C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int propID;
    [Token(Token = "0x400582D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string ikObjectName;

    [Token(Token = "0x17000FE1")]
    public int Key
    {
      [Token(Token = "0x60068E0"), Address(RVA = "0x48CA414", Offset = "0x48CA414", VA = "0x48CA414", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068E1")]
    [Address(RVA = "0x48CA41C", Offset = "0x48CA41C", VA = "0x48CA41C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068E2")]
    [Address(RVA = "0x48CA5E8", Offset = "0x48CA5E8", VA = "0x48CA5E8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60068E3")]
    [Address(RVA = "0x48CA694", Offset = "0x48CA694", VA = "0x48CA694")]
    public StoryFreeActionPropData()
    {
    }
  }
}
