// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTimeElapseLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200128D")]
  [Serializable]
  public sealed class StoryFreeActionTimeElapseLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x4005896")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005897")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int layoutLabelID;
    [Token(Token = "0x4005898")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x4005899")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x400589A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x400589B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float positionOffsetZ;
    [Token(Token = "0x400589C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int advID;

    [Token(Token = "0x17000FF1")]
    public int Key
    {
      [Token(Token = "0x600696D"), Address(RVA = "0x48D007C", Offset = "0x48D007C", VA = "0x48D007C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600696E")]
    [Address(RVA = "0x48D0084", Offset = "0x48D0084", VA = "0x48D0084", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600696F")]
    [Address(RVA = "0x48D0370", Offset = "0x48D0370", VA = "0x48D0370", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006970")]
    [Address(RVA = "0x48D0444", Offset = "0x48D0444", VA = "0x48D0444")]
    public StoryFreeActionTimeElapseLayoutData()
    {
    }
  }
}
