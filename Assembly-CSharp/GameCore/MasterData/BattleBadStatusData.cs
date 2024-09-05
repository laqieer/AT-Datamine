// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleBadStatusData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E04")]
  [Serializable]
  public sealed class BattleBadStatusData : IMasterDataEntity, IBadStatusData
  {
    [Token(Token = "0x40042EB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40042EC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public BattleBadStatusTypeEnum type;
    [Token(Token = "0x40042ED")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public EffectiveRuleTypeEnum effectiveRule;
    [Token(Token = "0x40042EE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string description;
    [Token(Token = "0x40042EF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int iconPriority;
    [Token(Token = "0x40042F0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string iconName;
    [Token(Token = "0x40042F1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int effectPriority;
    [Token(Token = "0x40042F2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string initiationEffectName;
    [Token(Token = "0x40042F3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public string loopEffectName;
    [Token(Token = "0x40042F4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public string initiationEffectLocatorName;
    [Token(Token = "0x40042F5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public string loopEffectLocatorName;
    [Token(Token = "0x40042F6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public bool overrideColor;
    [Token(Token = "0x40042F7")]
    [FieldOffset(Offset = "0x61")]
    [SerializeField]
    public bool monochrome;
    [Token(Token = "0x40042F8")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public float hardlightBlend;
    [Token(Token = "0x40042F9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public string hardlightColorCode;

    [Token(Token = "0x17000C45")]
    public int Key
    {
      [Token(Token = "0x6005580"), Address(RVA = "0x3AB140C", Offset = "0x3AB140C", VA = "0x3AB140C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005581")]
    [Address(RVA = "0x3AB1414", Offset = "0x3AB1414", VA = "0x3AB1414", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005582")]
    [Address(RVA = "0x3AB1A08", Offset = "0x3AB1A08", VA = "0x3AB1A08", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000C46")]
    public BattleBadStatusTypeEnum Type
    {
      [Token(Token = "0x6005583"), Address(RVA = "0x3AB1B78", Offset = "0x3AB1B78", VA = "0x3AB1B78", Slot = "7")] get
      {
        return new BattleBadStatusTypeEnum();
      }
    }

    [Token(Token = "0x6005584")]
    [Address(RVA = "0x3AB1B80", Offset = "0x3AB1B80", VA = "0x3AB1B80")]
    public BattleBadStatusData()
    {
    }
  }
}
