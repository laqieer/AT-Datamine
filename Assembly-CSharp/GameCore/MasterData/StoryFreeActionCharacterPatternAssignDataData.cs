// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionCharacterPatternAssignDataData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200124D")]
  [Serializable]
  public sealed class StoryFreeActionCharacterPatternAssignDataData : IMasterDataEntity
  {
    [Token(Token = "0x4005794")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005795")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005796")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int charcterLookAssignTypeID;
    [Token(Token = "0x4005797")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string AnimationName;
    [Token(Token = "0x4005798")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float iconOffsetX;
    [Token(Token = "0x4005799")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float iconOffsetY;
    [Token(Token = "0x400579A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float iconOffsetZ;

    [Token(Token = "0x17000FB4")]
    public int Key
    {
      [Token(Token = "0x6006817"), Address(RVA = "0x4D35774", Offset = "0x4D35774", VA = "0x4D35774", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006818")]
    [Address(RVA = "0x4D3577C", Offset = "0x4D3577C", VA = "0x4D3577C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006819")]
    [Address(RVA = "0x4D35A68", Offset = "0x4D35A68", VA = "0x4D35A68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600681A")]
    [Address(RVA = "0x4D35B44", Offset = "0x4D35B44", VA = "0x4D35B44")]
    public StoryFreeActionCharacterPatternAssignDataData()
    {
    }
  }
}
