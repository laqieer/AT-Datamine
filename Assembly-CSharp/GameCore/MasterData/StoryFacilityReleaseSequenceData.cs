// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityReleaseSequenceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200122A")]
  [Serializable]
  public sealed class StoryFacilityReleaseSequenceData : IMasterDataEntity
  {
    [Token(Token = "0x40056DA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056DB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facility;
    [Token(Token = "0x40056DC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int sequence;

    [Token(Token = "0x17000F94")]
    public int Key
    {
      [Token(Token = "0x600677A"), Address(RVA = "0x4D2FEA0", Offset = "0x4D2FEA0", VA = "0x4D2FEA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600677B")]
    [Address(RVA = "0x4D2FEA8", Offset = "0x4D2FEA8", VA = "0x4D2FEA8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600677C")]
    [Address(RVA = "0x4D30014", Offset = "0x4D30014", VA = "0x4D30014", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600677D")]
    [Address(RVA = "0x4D300A8", Offset = "0x4D300A8", VA = "0x4D300A8")]
    public StoryFacilityReleaseSequenceData()
    {
    }
  }
}
