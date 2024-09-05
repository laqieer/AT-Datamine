// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013B7")]
  [Serializable]
  public sealed class StyleGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005BC4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BC5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x1700109B")]
    public int Key
    {
      [Token(Token = "0x6006EBA"), Address(RVA = "0x47093DC", Offset = "0x47093DC", VA = "0x47093DC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006EBB")]
    [Address(RVA = "0x47093E4", Offset = "0x47093E4", VA = "0x47093E4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006EBC")]
    [Address(RVA = "0x47094F0", Offset = "0x47094F0", VA = "0x47094F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006EBD")]
    [Address(RVA = "0x4709578", Offset = "0x4709578", VA = "0x4709578")]
    public StyleGroupData()
    {
    }
  }
}
