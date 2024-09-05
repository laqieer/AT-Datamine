// Decompiled with JetBrains decompiler
// Type: GameCore.Tween.UITweener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.Tween
{
  [Token(Token = "0x2000C2B")]
  public abstract class UITweener : MonoBehaviour
  {
    [Token(Token = "0x400372A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweener.PlayMethod method;
    [Token(Token = "0x400372B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private UITweener.PlayStyle style;
    [Token(Token = "0x400372C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private AnimationCurve animationCurve;
    [Token(Token = "0x400372D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool ignoreTimeScale;
    [Token(Token = "0x400372E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float delay;
    [Token(Token = "0x400372F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float duration;
    [Token(Token = "0x4003730")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string tweenGroup;
    [Token(Token = "0x4003732")]
    [FieldOffset(Offset = "0x48")]
    private bool started;
    [Token(Token = "0x4003733")]
    [FieldOffset(Offset = "0x4C")]
    private float startTime;
    [Token(Token = "0x4003734")]
    [FieldOffset(Offset = "0x50")]
    private float durationTime;
    [Token(Token = "0x4003735")]
    [FieldOffset(Offset = "0x54")]
    private float amountPerDelta;
    [Token(Token = "0x4003736")]
    [FieldOffset(Offset = "0x58")]
    private float factor;
    [Token(Token = "0x4003737")]
    [FieldOffset(Offset = "0x5C")]
    protected bool editMode;
    [Token(Token = "0x4003738")]
    [FieldOffset(Offset = "0x60")]
    private float playSpeedInEditor;
    [Token(Token = "0x4003739")]
    [FieldOffset(Offset = "0x64")]
    private float playTimeInEditor;

    [Token(Token = "0x17000A12")]
    public UITweener.PlayMethod Method
    {
      [Token(Token = "0x60045CA"), Address(RVA = "0x3513D5C", Offset = "0x3513D5C", VA = "0x3513D5C")] get
      {
        return new UITweener.PlayMethod();
      }
      [Token(Token = "0x60045CB"), Address(RVA = "0x3513D64", Offset = "0x3513D64", VA = "0x3513D64")] set
      {
      }
    }

    [Token(Token = "0x17000A13")]
    public UITweener.PlayStyle Style
    {
      [Token(Token = "0x60045CC"), Address(RVA = "0x3513D6C", Offset = "0x3513D6C", VA = "0x3513D6C")] get
      {
        return new UITweener.PlayStyle();
      }
      [Token(Token = "0x60045CD"), Address(RVA = "0x3513D74", Offset = "0x3513D74", VA = "0x3513D74")] set
      {
      }
    }

    [Token(Token = "0x17000A14")]
    public AnimationCurve AnimationCurve
    {
      [Token(Token = "0x60045CE"), Address(RVA = "0x3513D7C", Offset = "0x3513D7C", VA = "0x3513D7C")] get
      {
        return (AnimationCurve) null;
      }
      [Token(Token = "0x60045CF"), Address(RVA = "0x3513D84", Offset = "0x3513D84", VA = "0x3513D84")] set
      {
      }
    }

    [Token(Token = "0x17000A15")]
    public bool IgnoreTimeScale
    {
      [Token(Token = "0x60045D0"), Address(RVA = "0x3513D8C", Offset = "0x3513D8C", VA = "0x3513D8C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60045D1"), Address(RVA = "0x3513D94", Offset = "0x3513D94", VA = "0x3513D94")] set
      {
      }
    }

    [Token(Token = "0x17000A16")]
    public float Delay
    {
      [Token(Token = "0x60045D2"), Address(RVA = "0x3513DA0", Offset = "0x3513DA0", VA = "0x3513DA0")] get
      {
        return new float();
      }
      [Token(Token = "0x60045D3"), Address(RVA = "0x3513DA8", Offset = "0x3513DA8", VA = "0x3513DA8")] set
      {
      }
    }

    [Token(Token = "0x17000A17")]
    public float Duration
    {
      [Token(Token = "0x60045D4"), Address(RVA = "0x3513DB0", Offset = "0x3513DB0", VA = "0x3513DB0")] get
      {
        return new float();
      }
      [Token(Token = "0x60045D5"), Address(RVA = "0x3513DB8", Offset = "0x3513DB8", VA = "0x3513DB8")] set
      {
      }
    }

    [Token(Token = "0x17000A18")]
    public string TweenGroup
    {
      [Token(Token = "0x60045D6"), Address(RVA = "0x3513DC0", Offset = "0x3513DC0", VA = "0x3513DC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60045D7"), Address(RVA = "0x3513DC8", Offset = "0x3513DC8", VA = "0x3513DC8")] set
      {
      }
    }

    [Token(Token = "0x17000A19")]
    public Action OnFinished
    {
      [Token(Token = "0x60045D8"), Address(RVA = "0x3513DD0", Offset = "0x3513DD0", VA = "0x3513DD0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60045D9"), Address(RVA = "0x3513DD8", Offset = "0x3513DD8", VA = "0x3513DD8")] set
      {
      }
    }

    [Token(Token = "0x17000A1A")]
    public float AmountPerDelta
    {
      [Token(Token = "0x60045DA"), Address(RVA = "0x3513DE0", Offset = "0x3513DE0", VA = "0x3513DE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000A1B")]
    public bool EditMode
    {
      [Token(Token = "0x60045DB"), Address(RVA = "0x3513E3C", Offset = "0x3513E3C", VA = "0x3513E3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60045DC"), Address(RVA = "0x3513E44", Offset = "0x3513E44", VA = "0x3513E44")] set
      {
      }
    }

    [Token(Token = "0x17000A1C")]
    public float PlaySpeedInEditor
    {
      [Token(Token = "0x60045DD"), Address(RVA = "0x3513E50", Offset = "0x3513E50", VA = "0x3513E50")] get
      {
        return new float();
      }
      [Token(Token = "0x60045DE"), Address(RVA = "0x3513E58", Offset = "0x3513E58", VA = "0x3513E58")] set
      {
      }
    }

    [Token(Token = "0x60045DF")]
    [Address(RVA = "0x3513E60", Offset = "0x3513E60", VA = "0x3513E60")]
    public void ForceResetAmountPerDeltaCacheValue()
    {
    }

    [Token(Token = "0x17000A1D")]
    public float TweenFactor
    {
      [Token(Token = "0x60045E0"), Address(RVA = "0x3513E68", Offset = "0x3513E68", VA = "0x3513E68")] get
      {
        return new float();
      }
      [Token(Token = "0x60045E1"), Address(RVA = "0x3513E70", Offset = "0x3513E70", VA = "0x3513E70")] set
      {
      }
    }

    [Token(Token = "0x60045E2")]
    [Address(RVA = "0x3513E8C", Offset = "0x3513E8C", VA = "0x3513E8C")]
    private void Start()
    {
    }

    [Token(Token = "0x60045E3")]
    [Address(RVA = "0x3513E98", Offset = "0x3513E98", VA = "0x3513E98", Slot = "4")]
    protected virtual void OnStart()
    {
    }

    [Token(Token = "0x60045E4")]
    [Address(RVA = "0x3513E9C", Offset = "0x3513E9C", VA = "0x3513E9C", Slot = "5")]
    protected virtual void Startup()
    {
    }

    [Token(Token = "0x60045E5")]
    [Address(RVA = "0x35138A0", Offset = "0x35138A0", VA = "0x35138A0")]
    public void Update()
    {
    }

    [Token(Token = "0x60045E6")]
    [Address(RVA = "0x3513EA0", Offset = "0x3513EA0", VA = "0x3513EA0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60045E7")]
    [Address(RVA = "0x3513EB0", Offset = "0x3513EB0", VA = "0x3513EB0", Slot = "6")]
    protected virtual void OnDisableMonoBehaviour()
    {
    }

    [Token(Token = "0x60045E8")]
    [Address(RVA = "0x3513EB4", Offset = "0x3513EB4", VA = "0x3513EB4")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60045E9")]
    [Address(RVA = "0x3513EC0", Offset = "0x3513EC0", VA = "0x3513EC0", Slot = "7")]
    protected virtual void OnEnableMonoBehaviour()
    {
    }

    [Token(Token = "0x60045EA")]
    [Address(RVA = "0x3513758", Offset = "0x3513758", VA = "0x3513758")]
    public void Sample(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x60045EB")]
    [Address(RVA = "0x350DF38", Offset = "0x350DF38", VA = "0x350DF38")]
    public void PlayForward()
    {
    }

    [Token(Token = "0x60045EC")]
    [Address(RVA = "0x3513F58", Offset = "0x3513F58", VA = "0x3513F58")]
    public void PlayReverse()
    {
    }

    [Token(Token = "0x60045ED")]
    [Address(RVA = "0x3513EC4", Offset = "0x3513EC4", VA = "0x3513EC4")]
    public void Play(bool forward)
    {
    }

    [Token(Token = "0x60045EE")]
    [Address(RVA = "0x350DEC4", Offset = "0x350DEC4", VA = "0x350DEC4")]
    public void ResetToBeginning()
    {
    }

    [Token(Token = "0x60045EF")]
    protected abstract void OnUpdate(float factor, bool isFinished);

    [Token(Token = "0x60045F0")]
    [Address(RVA = "0x350E368", Offset = "0x350E368", VA = "0x350E368")]
    protected UITweener()
    {
    }

    [Token(Token = "0x2000C2C")]
    public enum PlayMethod
    {
      [Token(Token = "0x400373B")] Linear,
      [Token(Token = "0x400373C")] EaseIn,
      [Token(Token = "0x400373D")] EaseOut,
      [Token(Token = "0x400373E")] EaseInOut,
    }

    [Token(Token = "0x2000C2D")]
    public enum PlayStyle
    {
      [Token(Token = "0x4003740")] Once,
      [Token(Token = "0x4003741")] Loop,
      [Token(Token = "0x4003742")] PingPong,
    }
  }
}
