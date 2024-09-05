// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionTalkBalloonEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001289")]
  [Serializable]
  public sealed class StoryFreeActionTalkBalloonEventData : IMasterDataEntity
  {
    [Token(Token = "0x400588C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400588D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int TalkBalloonLabel;
    [Token(Token = "0x400588E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ObjectName;
    [Token(Token = "0x400588F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int BalloonText;
    [Token(Token = "0x4005890")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float IconPositionX;
    [Token(Token = "0x4005891")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float IconPositionY;
    [Token(Token = "0x4005892")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float IconPositionZ;

    [Token(Token = "0x17000FEF")]
    public int Key
    {
      [Token(Token = "0x600695C"), Address(RVA = "0x48CF838", Offset = "0x48CF838", VA = "0x48CF838", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600695D")]
    [Address(RVA = "0x48CF840", Offset = "0x48CF840", VA = "0x48CF840", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600695E")]
    [Address(RVA = "0x48CFB2C", Offset = "0x48CFB2C", VA = "0x48CFB2C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600695F")]
    [Address(RVA = "0x48CFC00", Offset = "0x48CFC00", VA = "0x48CFC00")]
    public StoryFreeActionTalkBalloonEventData()
    {
    }
  }
}
