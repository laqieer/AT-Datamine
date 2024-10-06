// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SupportSkillActivateRateData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011C3")]
  [Serializable]
  public sealed class SupportSkillActivateRateData : IMasterDataEntity
  {
    [Token(Token = "0x4005578")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005579")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400557A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rate;

    [Token(Token = "0x17000F57")]
    public int Key
    {
      [Token(Token = "0x60065AE"), Address(RVA = "0x4D1E0A0", Offset = "0x4D1E0A0", VA = "0x4D1E0A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065AF")]
    [Address(RVA = "0x4D1E0A8", Offset = "0x4D1E0A8", VA = "0x4D1E0A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065B0")]
    [Address(RVA = "0x4D1E214", Offset = "0x4D1E214", VA = "0x4D1E214", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60065B1")]
    [Address(RVA = "0x4D1E2AC", Offset = "0x4D1E2AC", VA = "0x4D1E2AC")]
    public SupportSkillActivateRateData()
    {
    }
  }
}
