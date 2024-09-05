// Decompiled with JetBrains decompiler
// Type: DuelMarker.UpdateCharacterStatusMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021ED")]
  public class UpdateCharacterStatusMarker : Marker, INotification, INotificationOptionProvider
  {
    [Token(Token = "0x4008F49")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool m_Retroactive;
    [Token(Token = "0x4008F4A")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool m_EmitOnce;
    [Token(Token = "0x4008F4C")]
    [FieldOffset(Offset = "0x30")]
    public DuelCharacterController.DuelCharacterRole targetCharacter;
    [Token(Token = "0x4008F4D")]
    [FieldOffset(Offset = "0x34")]
    public bool isAbnormalState;
    [Token(Token = "0x4008F4E")]
    [FieldOffset(Offset = "0x38")]
    public BattleBadStatusTypeEnum abnormalState;
    [Token(Token = "0x4008F4F")]
    [FieldOffset(Offset = "0x3C")]
    public bool shouldUpdateAbnormalState;
    [Token(Token = "0x4008F50")]
    [FieldOffset(Offset = "0x3D")]
    public bool isDualGuard;
    [Token(Token = "0x4008F51")]
    [FieldOffset(Offset = "0x3E")]
    public bool isCritical;
    [Token(Token = "0x4008F52")]
    [FieldOffset(Offset = "0x3F")]
    public bool isHit;
    [Token(Token = "0x4008F53")]
    [FieldOffset(Offset = "0x40")]
    public int oldHP;
    [Token(Token = "0x4008F54")]
    [FieldOffset(Offset = "0x44")]
    public int newHP;

    [Token(Token = "0x17002D17")]
    public PropertyName id
    {
      [Token(Token = "0x600CEC6"), Address(RVA = "0x4B65C28", Offset = "0x4B65C28", VA = "0x4B65C28", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x17002D18")]
    public bool retroactive
    {
      [Token(Token = "0x600CEC7"), Address(RVA = "0x4B65C30", Offset = "0x4B65C30", VA = "0x4B65C30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CEC8"), Address(RVA = "0x4B65C38", Offset = "0x4B65C38", VA = "0x4B65C38")] set
      {
      }
    }

    [Token(Token = "0x17002D19")]
    public bool emitOnce
    {
      [Token(Token = "0x600CEC9"), Address(RVA = "0x4B65C44", Offset = "0x4B65C44", VA = "0x4B65C44")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CECA"), Address(RVA = "0x4B65C4C", Offset = "0x4B65C4C", VA = "0x4B65C4C")] set
      {
      }
    }

    [Token(Token = "0x17002D1A")]
    private NotificationFlags UnityEngine\u002ETimeline\u002EINotificationOptionProvider\u002Eflags
    {
      [Token(Token = "0x600CECB"), Address(RVA = "0x4B65C58", Offset = "0x4B65C58", VA = "0x4B65C58", Slot = "10")] get
      {
        return new NotificationFlags();
      }
    }

    [Token(Token = "0x600CECC")]
    [Address(RVA = "0x4B65C74", Offset = "0x4B65C74", VA = "0x4B65C74")]
    public UpdateCharacterStatusMarker()
    {
    }
  }
}
