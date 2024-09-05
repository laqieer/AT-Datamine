// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BloodTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000ED2")]
  [Serializable]
  public sealed class BloodTypeData : IMasterDataEntity
  {
    [Token(Token = "0x40048BB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40048BC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000D43")]
    public int Key
    {
      [Token(Token = "0x600593D"), Address(RVA = "0x3C30FF4", Offset = "0x3C30FF4", VA = "0x3C30FF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600593E")]
    [Address(RVA = "0x3C30FFC", Offset = "0x3C30FFC", VA = "0x3C30FFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600593F")]
    [Address(RVA = "0x3C31108", Offset = "0x3C31108", VA = "0x3C31108", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005940")]
    [Address(RVA = "0x3C31190", Offset = "0x3C31190", VA = "0x3C31190")]
    public BloodTypeData()
    {
    }
  }
}
