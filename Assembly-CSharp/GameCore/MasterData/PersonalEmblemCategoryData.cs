// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PersonalEmblemCategoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001063")]
  [Serializable]
  public sealed class PersonalEmblemCategoryData : IMasterDataEntity
  {
    [Token(Token = "0x4005121")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005122")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005123")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public EmblemTypeEnum emblemType;

    [Token(Token = "0x17000E1A")]
    public int Key
    {
      [Token(Token = "0x6005F1E"), Address(RVA = "0x28CAF00", Offset = "0x28CAF00", VA = "0x28CAF00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F1F")]
    [Address(RVA = "0x28CAF08", Offset = "0x28CAF08", VA = "0x28CAF08", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F20")]
    [Address(RVA = "0x28CB074", Offset = "0x28CB074", VA = "0x28CB074", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005F21")]
    [Address(RVA = "0x28CB10C", Offset = "0x28CB10C", VA = "0x28CB10C")]
    public PersonalEmblemCategoryData()
    {
    }
  }
}
