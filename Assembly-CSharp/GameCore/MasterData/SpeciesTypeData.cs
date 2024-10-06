// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SpeciesTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F23")]
  [Serializable]
  public sealed class SpeciesTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4004BA7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004BA8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004BA9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string displayName;

    [Token(Token = "0x17000D51")]
    public int Key
    {
      [Token(Token = "0x60059A0"), Address(RVA = "0x3C33450", Offset = "0x3C33450", VA = "0x3C33450", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60059A1")]
    [Address(RVA = "0x3C33458", Offset = "0x3C33458", VA = "0x3C33458", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60059A2")]
    [Address(RVA = "0x3C335C4", Offset = "0x3C335C4", VA = "0x3C335C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60059A3")]
    [Address(RVA = "0x3C33660", Offset = "0x3C33660", VA = "0x3C33660")]
    public SpeciesTypeData()
    {
    }
  }
}
