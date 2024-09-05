// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionOverrideSequeceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200126A")]
  [Serializable]
  public sealed class StoryFreeActionOverrideSequeceData : IMasterDataEntity
  {
    [Token(Token = "0x4005816")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005817")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int triggerSequence;
    [Token(Token = "0x4005818")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int characterSwitchPatternID;

    [Token(Token = "0x17000FD5")]
    public int Key
    {
      [Token(Token = "0x60068B0"), Address(RVA = "0x48C9054", Offset = "0x48C9054", VA = "0x48C9054", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60068B1")]
    [Address(RVA = "0x48C905C", Offset = "0x48C905C", VA = "0x48C905C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60068B2")]
    [Address(RVA = "0x48C91C8", Offset = "0x48C91C8", VA = "0x48C91C8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60068B3")]
    [Address(RVA = "0x48C925C", Offset = "0x48C925C", VA = "0x48C925C")]
    public StoryFreeActionOverrideSequeceData()
    {
    }
  }
}
