// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B2")]
  [Serializable]
  public sealed class StyleExpData : IMasterDataEntity
  {
    [Token(Token = "0x4005BBD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BBE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int initialRarityStar;

    [Token(Token = "0x17001099")]
    public int Key
    {
      [Token(Token = "0x6006EA1"), Address(RVA = "0x47087EC", Offset = "0x47087EC", VA = "0x47087EC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006EA2")]
    [Address(RVA = "0x47087F4", Offset = "0x47087F4", VA = "0x47087F4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006EA3")]
    [Address(RVA = "0x4708900", Offset = "0x4708900", VA = "0x4708900", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006EA4")]
    [Address(RVA = "0x4708984", Offset = "0x4708984", VA = "0x4708984")]
    public StyleExpDescriptionData GetExpDescriptionByExp(int exp)
    {
      return (StyleExpDescriptionData) null;
    }

    [Token(Token = "0x6006EA5")]
    [Address(RVA = "0x4708A18", Offset = "0x4708A18", VA = "0x4708A18")]
    public int CalcNextLevelExp(int exp) => new int();

    [Token(Token = "0x6006EA6")]
    [Address(RVA = "0x4708B04", Offset = "0x4708B04", VA = "0x4708B04")]
    public float CalcNextLevelExpRate(int exp) => new float();

    [Token(Token = "0x6006EA7")]
    [Address(RVA = "0x4708C10", Offset = "0x4708C10", VA = "0x4708C10")]
    public StyleExpData()
    {
    }
  }
}
