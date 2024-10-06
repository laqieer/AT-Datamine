// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EA1")]
  [Serializable]
  public sealed class SpeciesDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40046B4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046B5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int species;
    [Token(Token = "0x40046B6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public SpeciesTypeEnum speciesType;

    [Token(Token = "0x17000D3B")]
    public int Key
    {
      [Token(Token = "0x60058F9"), Address(RVA = "0x3C2F264", Offset = "0x3C2F264", VA = "0x3C2F264", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058FA")]
    [Address(RVA = "0x3C2F26C", Offset = "0x3C2F26C", VA = "0x3C2F26C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058FB")]
    [Address(RVA = "0x3C2F3D8", Offset = "0x3C2F3D8", VA = "0x3C2F3D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058FC")]
    [Address(RVA = "0x3C2F46C", Offset = "0x3C2F46C", VA = "0x3C2F46C")]
    public SpeciesDescriptionData()
    {
    }
  }
}
