// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleLevelUpValueData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013BA")]
  [Serializable]
  public sealed class StyleLevelUpValueData : IMasterDataEntity
  {
    [Token(Token = "0x4005BC7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BC8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public StyleLevelUpValueTypeEnum styleLevelUpValueType;
    [Token(Token = "0x4005BC9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public float value;

    [Token(Token = "0x1700109C")]
    public int Key
    {
      [Token(Token = "0x6006EC5"), Address(RVA = "0x4709860", Offset = "0x4709860", VA = "0x4709860", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006EC6")]
    [Address(RVA = "0x4709868", Offset = "0x4709868", VA = "0x4709868", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006EC7")]
    [Address(RVA = "0x47099D4", Offset = "0x47099D4", VA = "0x47099D4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006EC8")]
    [Address(RVA = "0x4709A68", Offset = "0x4709A68", VA = "0x4709A68")]
    public StyleLevelUpValueData()
    {
    }
  }
}
