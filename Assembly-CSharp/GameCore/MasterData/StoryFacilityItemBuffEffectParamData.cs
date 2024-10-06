// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityItemBuffEffectParamData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001223")]
  [Serializable]
  public sealed class StoryFacilityItemBuffEffectParamData : IMasterDataEntity
  {
    [Token(Token = "0x40056C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056C2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int groupLabel;
    [Token(Token = "0x40056C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int humanParameterID;
    [Token(Token = "0x40056C4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int value;

    [Token(Token = "0x17000F91")]
    public int Key
    {
      [Token(Token = "0x600675A"), Address(RVA = "0x4D2E874", Offset = "0x4D2E874", VA = "0x4D2E874", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600675B")]
    [Address(RVA = "0x4D2E87C", Offset = "0x4D2E87C", VA = "0x4D2E87C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600675C")]
    [Address(RVA = "0x4D2EA48", Offset = "0x4D2EA48", VA = "0x4D2EA48", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600675D")]
    [Address(RVA = "0x4D2EAEC", Offset = "0x4D2EAEC", VA = "0x4D2EAEC")]
    public StoryFacilityItemBuffEffectParamData()
    {
    }
  }
}
