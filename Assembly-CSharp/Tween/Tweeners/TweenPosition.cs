// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x2000513")]
  [AddComponentMenu("Tween/Tweeners/Tween Position")]
  public class TweenPosition : UITweener
  {
    [Token(Token = "0x4001B12")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector3 from;
    [Token(Token = "0x4001B13")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Vector3 to;
    [Token(Token = "0x4001B14")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TweenPosition.PositionModeType positionMode;
    [Token(Token = "0x4001B15")]
    [FieldOffset(Offset = "0x88")]
    private Transform cachedTransform;
    [Token(Token = "0x4001B16")]
    [FieldOffset(Offset = "0x90")]
    protected Vector2[] points;

    [Token(Token = "0x170003C3")]
    public Vector3 From
    {
      [Token(Token = "0x6001D4F"), Address(RVA = "0x29F9620", Offset = "0x29F9620", VA = "0x29F9620")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D50"), Address(RVA = "0x29F962C", Offset = "0x29F962C", VA = "0x29F962C")] set
      {
      }
    }

    [Token(Token = "0x170003C4")]
    public Vector3 To
    {
      [Token(Token = "0x6001D51"), Address(RVA = "0x29F9638", Offset = "0x29F9638", VA = "0x29F9638")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D52"), Address(RVA = "0x29F9644", Offset = "0x29F9644", VA = "0x29F9644")] set
      {
      }
    }

    [Token(Token = "0x170003C5")]
    protected Vector3 diff
    {
      [Token(Token = "0x6001D53"), Address(RVA = "0x29F92F0", Offset = "0x29F92F0", VA = "0x29F92F0")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170003C6")]
    public TweenPosition.PositionModeType PositionMode
    {
      [Token(Token = "0x6001D54"), Address(RVA = "0x29F9650", Offset = "0x29F9650", VA = "0x29F9650")] get
      {
        return new TweenPosition.PositionModeType();
      }
      [Token(Token = "0x6001D55"), Address(RVA = "0x29F9658", Offset = "0x29F9658", VA = "0x29F9658")] set
      {
      }
    }

    [Token(Token = "0x170003C7")]
    public Transform CachedTransform
    {
      [Token(Token = "0x6001D56"), Address(RVA = "0x29F9660", Offset = "0x29F9660", VA = "0x29F9660")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x170003C8")]
    protected RectTransform rectTransform
    {
      [Token(Token = "0x6001D57"), Address(RVA = "0x29F96E0", Offset = "0x29F96E0", VA = "0x29F96E0")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170003C9")]
    public virtual Vector3 Value
    {
      [Token(Token = "0x6001D58"), Address(RVA = "0x29F9740", Offset = "0x29F9740", VA = "0x29F9740", Slot = "9")] get
      {
        return new Vector3();
      }
      [Token(Token = "0x6001D59"), Address(RVA = "0x29F97E8", Offset = "0x29F97E8", VA = "0x29F97E8", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x6001D5A")]
    [Address(RVA = "0x29F98FC", Offset = "0x29F98FC", VA = "0x29F98FC", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001D5B")]
    [Address(RVA = "0x29F9918", Offset = "0x29F9918", VA = "0x29F9918", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001D5C")]
    [Address(RVA = "0x29F9204", Offset = "0x29F9204", VA = "0x29F9204")]
    protected void CachedRectTransform()
    {
    }

    [Token(Token = "0x6001D5D")]
    [Address(RVA = "0x29F9310", Offset = "0x29F9310", VA = "0x29F9310")]
    protected void UpdateRectTransform(Vector2 value)
    {
    }

    [Token(Token = "0x6001D5E")]
    [Address(RVA = "0x29F94A0", Offset = "0x29F94A0", VA = "0x29F94A0")]
    public TweenPosition()
    {
    }

    [Token(Token = "0x2000514")]
    public enum PositionModeType
    {
      [Token(Token = "0x4001B18")] Local,
      [Token(Token = "0x4001B19")] Anchored,
      [Token(Token = "0x4001B1A")] World,
    }
  }
}
