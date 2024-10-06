// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B5")]
  [Serializable]
  public sealed class StyleGroupDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005BC1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BC2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleGroup;
    [Token(Token = "0x4005BC3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public StyleGroupTypeEnum styleGroupType;

    [Token(Token = "0x1700109A")]
    public int Key
    {
      [Token(Token = "0x6006EB2"), Address(RVA = "0x47090C4", Offset = "0x47090C4", VA = "0x47090C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006EB3")]
    [Address(RVA = "0x47090CC", Offset = "0x47090CC", VA = "0x47090CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006EB4")]
    [Address(RVA = "0x4709238", Offset = "0x4709238", VA = "0x4709238", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006EB5")]
    [Address(RVA = "0x47092CC", Offset = "0x47092CC", VA = "0x47092CC")]
    public StyleGroupDescriptionData()
    {
    }
  }
}
