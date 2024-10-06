// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleVoiceCombiData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E2B")]
  [Serializable]
  public sealed class BattleVoiceCombiData : IMasterDataEntity
  {
    [Token(Token = "0x400439E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400439F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string voicePackName;
    [Token(Token = "0x40043A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public BattleVoiceTimingEnum timing;
    [Token(Token = "0x40043A1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string targetVoicePackName;
    [Token(Token = "0x40043A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string voiceNo;

    [Token(Token = "0x17000C6D")]
    public int Key
    {
      [Token(Token = "0x6005652"), Address(RVA = "0x3E34E5C", Offset = "0x3E34E5C", VA = "0x3E34E5C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005653")]
    [Address(RVA = "0x3E34E64", Offset = "0x3E34E64", VA = "0x3E34E64", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005654")]
    [Address(RVA = "0x3E35090", Offset = "0x3E35090", VA = "0x3E35090", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005655")]
    [Address(RVA = "0x3E35150", Offset = "0x3E35150", VA = "0x3E35150")]
    public BattleVoiceCombiData()
    {
    }
  }
}
