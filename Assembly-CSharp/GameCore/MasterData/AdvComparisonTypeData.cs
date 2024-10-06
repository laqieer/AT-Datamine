// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AdvComparisonTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DA9")]
  [Serializable]
  public sealed class AdvComparisonTypeData : IMasterDataEntity
  {
    [Token(Token = "0x400417C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400417D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string Name;

    [Token(Token = "0x17000BF5")]
    public int Key
    {
      [Token(Token = "0x60053A3"), Address(RVA = "0x3A9BBA0", Offset = "0x3A9BBA0", VA = "0x3A9BBA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60053A4")]
    [Address(RVA = "0x3A9BBA8", Offset = "0x3A9BBA8", VA = "0x3A9BBA8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60053A5")]
    [Address(RVA = "0x3A9BCB4", Offset = "0x3A9BCB4", VA = "0x3A9BCB4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60053A6")]
    [Address(RVA = "0x3A9BD3C", Offset = "0x3A9BD3C", VA = "0x3A9BD3C")]
    public AdvComparisonTypeData()
    {
    }
  }
}
