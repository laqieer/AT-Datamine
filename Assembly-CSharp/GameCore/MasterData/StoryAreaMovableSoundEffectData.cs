// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryAreaMovableSoundEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011D1")]
  [Serializable]
  public sealed class StoryAreaMovableSoundEffectData : IMasterDataEntity
  {
    [Token(Token = "0x40055A8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40055A9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int soundGroupLabel;
    [Token(Token = "0x40055AA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int groupPattern;
    [Token(Token = "0x40055AB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int soundObject;

    [Token(Token = "0x17000F61")]
    public int Key
    {
      [Token(Token = "0x60065F0"), Address(RVA = "0x4D20A04", Offset = "0x4D20A04", VA = "0x4D20A04", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60065F1")]
    [Address(RVA = "0x4D20A0C", Offset = "0x4D20A0C", VA = "0x4D20A0C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60065F2")]
    [Address(RVA = "0x4D20BD8", Offset = "0x4D20BD8", VA = "0x4D20BD8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60065F3")]
    [Address(RVA = "0x4D20C7C", Offset = "0x4D20C7C", VA = "0x4D20C7C")]
    public StoryAreaMovableSoundEffectData()
    {
    }
  }
}
