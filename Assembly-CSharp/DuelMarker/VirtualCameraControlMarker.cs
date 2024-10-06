// Decompiled with JetBrains decompiler
// Type: DuelMarker.VirtualCameraControlMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace DuelMarker
{
  [Token(Token = "0x20021EE")]
  public class VirtualCameraControlMarker : Marker, INotification, INotificationOptionProvider
  {
    [Token(Token = "0x4008F55")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool m_Retroactive;
    [Token(Token = "0x4008F56")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool m_EmitOnce;
    [Token(Token = "0x4008F58")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    public bool isAimEnabled;
    [Token(Token = "0x4008F59")]
    [FieldOffset(Offset = "0x38")]
    [Space(10f)]
    public string lookAtObjectName;
    [Token(Token = "0x4008F5A")]
    [FieldOffset(Offset = "0x40")]
    public VirtualCameraControlMarker.LookAtTargetType lookAtTargetType;
    [Token(Token = "0x4008F5B")]
    [FieldOffset(Offset = "0x48")]
    public string lookAtBodyPartName;
    [Token(Token = "0x4008F5C")]
    [FieldOffset(Offset = "0x50")]
    public VirtualCameraControlMarker.LookAtBodyPartType lookAtBodyPartType;
    [Token(Token = "0x4008F5D")]
    [FieldOffset(Offset = "0x54")]
    public Vector3 trackedObjectOffset;
    [Token(Token = "0x4008F5E")]
    [FieldOffset(Offset = "0x60")]
    public float verticalDamping;
    [Token(Token = "0x4008F5F")]
    [FieldOffset(Offset = "0x64")]
    public float horizontalDamping;
    [Token(Token = "0x4008F60")]
    [FieldOffset(Offset = "0x68")]
    [Space(10f)]
    public bool resetTransformWhenDisabled;
    [Token(Token = "0x4008F61")]
    [FieldOffset(Offset = "0x6C")]
    public float resetDamping;

    [Token(Token = "0x17002D1B")]
    public PropertyName id
    {
      [Token(Token = "0x600CECD"), Address(RVA = "0x4B65C90", Offset = "0x4B65C90", VA = "0x4B65C90", Slot = "9")] get
      {
        return new PropertyName();
      }
    }

    [Token(Token = "0x17002D1C")]
    public bool retroactive
    {
      [Token(Token = "0x600CECE"), Address(RVA = "0x4B65C98", Offset = "0x4B65C98", VA = "0x4B65C98")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CECF"), Address(RVA = "0x4B65CA0", Offset = "0x4B65CA0", VA = "0x4B65CA0")] set
      {
      }
    }

    [Token(Token = "0x17002D1D")]
    public bool emitOnce
    {
      [Token(Token = "0x600CED0"), Address(RVA = "0x4B65CAC", Offset = "0x4B65CAC", VA = "0x4B65CAC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CED1"), Address(RVA = "0x4B65CB4", Offset = "0x4B65CB4", VA = "0x4B65CB4")] set
      {
      }
    }

    [Token(Token = "0x17002D1E")]
    private NotificationFlags UnityEngine\u002ETimeline\u002EINotificationOptionProvider\u002Eflags
    {
      [Token(Token = "0x600CED2"), Address(RVA = "0x4B65CC0", Offset = "0x4B65CC0", VA = "0x4B65CC0", Slot = "10")] get
      {
        return new NotificationFlags();
      }
    }

    [Token(Token = "0x600CED3")]
    [Address(RVA = "0x4B65CDC", Offset = "0x4B65CDC", VA = "0x4B65CDC")]
    public VirtualCameraControlMarker()
    {
    }

    [Token(Token = "0x20021EF")]
    public enum LookAtTargetType
    {
      [Token(Token = "0x4008F63")] Actor,
      [Token(Token = "0x4008F64")] Target,
      [Token(Token = "0x4008F65")] ActorAimObj,
      [Token(Token = "0x4008F66")] TargetAimObj,
      [Token(Token = "0x4008F67")] CenterAimObj,
      [Token(Token = "0x4008F68")] CustomObj,
    }

    [Token(Token = "0x20021F0")]
    public enum LookAtBodyPartType
    {
      [Token(Token = "0x4008F6A")] Character,
      [Token(Token = "0x4008F6B")] Vehicle,
    }
  }
}
