// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkADVEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001284")]
  [Serializable]
  public sealed class StoryFreeActionTalkADVEventData : IMasterDataEntity
  {
    [Token(Token = "0x400587B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400587C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int TalkADVLabel;
    [Token(Token = "0x400587D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ObjectName;
    [Token(Token = "0x400587E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public PlayAdvPatternEnum PlayADVPattern;
    [Token(Token = "0x400587F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int CameraMovePosition;
    [Token(Token = "0x4005880")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int PlayerMovePosition;
    [Token(Token = "0x4005881")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public EventNpcActEnum BeginNpcAct;
    [Token(Token = "0x4005882")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float IconPositionX;
    [Token(Token = "0x4005883")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public float IconPositionY;
    [Token(Token = "0x4005884")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float IconPositionZ;

    [Token(Token = "0x17000FED")]
    public int Key
    {
      [Token(Token = "0x6006941"), Address(RVA = "0x48CE5CC", Offset = "0x48CE5CC", VA = "0x48CE5CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006942")]
    [Address(RVA = "0x48CE5D4", Offset = "0x48CE5D4", VA = "0x48CE5D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006943")]
    [Address(RVA = "0x48CE9E0", Offset = "0x48CE9E0", VA = "0x48CE9E0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006944")]
    [Address(RVA = "0x48CEAE4", Offset = "0x48CEAE4", VA = "0x48CEAE4")]
    public StoryFreeActionTalkADVEventData()
    {
    }
  }
}
