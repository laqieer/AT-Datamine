// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkADVEventTextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001287")]
  [Serializable]
  public sealed class StoryFreeActionTalkADVEventTextData : IMasterDataEntity
  {
    [Token(Token = "0x4005888")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005889")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int talkAdvEventID;
    [Token(Token = "0x400588A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int advName;

    [Token(Token = "0x17000FEE")]
    public int Key
    {
      [Token(Token = "0x6006951"), Address(RVA = "0x48CF224", Offset = "0x48CF224", VA = "0x48CF224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006952")]
    [Address(RVA = "0x48CF22C", Offset = "0x48CF22C", VA = "0x48CF22C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006953")]
    [Address(RVA = "0x48CF398", Offset = "0x48CF398", VA = "0x48CF398", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006954")]
    [Address(RVA = "0x48CF42C", Offset = "0x48CF42C", VA = "0x48CF42C")]
    public StoryFreeActionTalkADVEventTextData()
    {
    }
  }
}
