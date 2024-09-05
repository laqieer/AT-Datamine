// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityDifficultyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200121F")]
  [Serializable]
  public sealed class StoryFacilityDifficultyData : IMasterDataEntity
  {
    [Token(Token = "0x40056B6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056B7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facility;
    [Token(Token = "0x40056B8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x40056B9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int conditions;
    [Token(Token = "0x40056BA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int successRewards;
    [Token(Token = "0x40056BB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int failRewards;

    [Token(Token = "0x17000F8F")]
    public int Key
    {
      [Token(Token = "0x6006746"), Address(RVA = "0x4D2DD84", Offset = "0x4D2DD84", VA = "0x4D2DD84", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006747")]
    [Address(RVA = "0x4D2DD8C", Offset = "0x4D2DD8C", VA = "0x4D2DD8C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006748")]
    [Address(RVA = "0x4D2E018", Offset = "0x4D2E018", VA = "0x4D2E018", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006749")]
    [Address(RVA = "0x4D2E0DC", Offset = "0x4D2E0DC", VA = "0x4D2E0DC")]
    public StoryFacilityDifficultyData()
    {
    }
  }
}
