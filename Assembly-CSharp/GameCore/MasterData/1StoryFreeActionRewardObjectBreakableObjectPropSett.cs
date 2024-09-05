// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionRewardObjectBreakableObjectPropSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001274")]
  [Serializable]
  public sealed class StoryFreeActionRewardObjectBreakableObjectPropSettingData : IMasterDataEntity
  {
    [Token(Token = "0x400582E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400582F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int propID;
    [Token(Token = "0x4005830")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string breakSE;
    [Token(Token = "0x4005831")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int iconType;
    [Token(Token = "0x4005832")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public bool isBreakStage;

    [Token(Token = "0x17000FE2")]
    public int Key
    {
      [Token(Token = "0x60068E8"), Address(RVA = "0x48CA7A4", Offset = "0x48CA7A4", VA = "0x48CA7A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068E9")]
    [Address(RVA = "0x48CA7AC", Offset = "0x48CA7AC", VA = "0x48CA7AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068EA")]
    [Address(RVA = "0x48CA9DC", Offset = "0x48CA9DC", VA = "0x48CA9DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60068EB")]
    [Address(RVA = "0x48CAA94", Offset = "0x48CAA94", VA = "0x48CAA94")]
    public StoryFreeActionRewardObjectBreakableObjectPropSettingData()
    {
    }
  }
}
