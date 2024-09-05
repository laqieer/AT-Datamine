// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuidelineData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E95")]
  [Serializable]
  public sealed class GuidelineData : IMasterDataEntity
  {
    [Token(Token = "0x400468C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400468D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string version;

    [Token(Token = "0x17000D2D")]
    public int Key
    {
      [Token(Token = "0x60058B1"), Address(RVA = "0x3C2CE9C", Offset = "0x3C2CE9C", VA = "0x3C2CE9C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058B2")]
    [Address(RVA = "0x3C2CEA4", Offset = "0x3C2CEA4", VA = "0x3C2CEA4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058B3")]
    [Address(RVA = "0x3C2CFB0", Offset = "0x3C2CFB0", VA = "0x3C2CFB0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058B4")]
    [Address(RVA = "0x3C2D038", Offset = "0x3C2D038", VA = "0x3C2D038")]
    public GuidelineData()
    {
    }
  }
}
