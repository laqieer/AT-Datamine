// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.OverrideResourceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001398")]
  [Serializable]
  public sealed class OverrideResourceData : IMasterDataEntity
  {
    [Token(Token = "0x4005B70")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string motion;
    [Token(Token = "0x4005B72")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int weaponPrefabId;
    [Token(Token = "0x4005B73")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string weaponBackDotName;
    [Token(Token = "0x4005B74")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string weaponFrontDotName;
    [Token(Token = "0x4005B75")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public string home3D;

    [Token(Token = "0x17001092")]
    public int Key
    {
      [Token(Token = "0x6006E1C"), Address(RVA = "0x4701EFC", Offset = "0x4701EFC", VA = "0x4701EFC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E1D")]
    [Address(RVA = "0x4701F04", Offset = "0x4701F04", VA = "0x4701F04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E1E")]
    [Address(RVA = "0x4702190", Offset = "0x4702190", VA = "0x4702190", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E1F")]
    [Address(RVA = "0x4702264", Offset = "0x4702264", VA = "0x4702264")]
    public OverrideResourceData()
    {
    }
  }
}
