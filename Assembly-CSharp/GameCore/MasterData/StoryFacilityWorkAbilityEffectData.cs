// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityWorkAbilityEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001231")]
  [Serializable]
  public sealed class StoryFacilityWorkAbilityEffectData : IMasterDataEntity
  {
    [Token(Token = "0x40056EF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056F0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facilityAttachID;
    [Token(Token = "0x40056F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ability;
    [Token(Token = "0x40056F2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x40056F3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public bool canSelect;
    [Token(Token = "0x40056F4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardLabel;

    [Token(Token = "0x17000F96")]
    public int Key
    {
      [Token(Token = "0x6006793"), Address(RVA = "0x4D309EC", Offset = "0x4D309EC", VA = "0x4D309EC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006794")]
    [Address(RVA = "0x4D309F4", Offset = "0x4D309F4", VA = "0x4D309F4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006795")]
    [Address(RVA = "0x4D30C84", Offset = "0x4D30C84", VA = "0x4D30C84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006796")]
    [Address(RVA = "0x4D30D48", Offset = "0x4D30D48", VA = "0x4D30D48")]
    public StoryFacilityWorkAbilityEffectData()
    {
    }
  }
}
