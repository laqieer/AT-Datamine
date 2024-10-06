// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusExpDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010CF")]
  [Serializable]
  public sealed class StyleMasterBonusExpDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005277")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005278")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleMasterExp;
    [Token(Token = "0x4005279")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400527A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int from;
    [Token(Token = "0x400527B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int to;

    [Token(Token = "0x17000E7B")]
    public int Key
    {
      [Token(Token = "0x6006128"), Address(RVA = "0x28DE620", Offset = "0x28DE620", VA = "0x28DE620", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006129")]
    [Address(RVA = "0x28DE628", Offset = "0x28DE628", VA = "0x28DE628", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600612A")]
    [Address(RVA = "0x28DE854", Offset = "0x28DE854", VA = "0x28DE854", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600612B")]
    [Address(RVA = "0x28DE908", Offset = "0x28DE908", VA = "0x28DE908")]
    public StyleMasterBonusExpDescriptionData()
    {
    }
  }
}
