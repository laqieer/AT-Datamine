// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.DialogWindowBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CEA")]
  public class DialogWindowBase : MonoBehaviour
  {
    [Token(Token = "0x40039C7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected string OpenAnimationId;
    [Token(Token = "0x40039C8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected string CloseAnimationId;
    [Token(Token = "0x40039CC")]
    [FieldOffset(Offset = "0x38")]
    private UnityAction<int> onInquireFinishedCallback;
    [Token(Token = "0x40039CD")]
    [FieldOffset(Offset = "0x40")]
    private UnityAction<int> onResultReceivedCallback;

    [Token(Token = "0x17000AD9")]
    public DialogWindowBase.State CurrentState
    {
      [Token(Token = "0x6004A35"), Address(RVA = "0x313DEF4", Offset = "0x313DEF4", VA = "0x313DEF4")] get
      {
        return new DialogWindowBase.State();
      }
      [Token(Token = "0x6004A36"), Address(RVA = "0x313DEFC", Offset = "0x313DEFC", VA = "0x313DEFC")] protected set
      {
      }
    }

    [Token(Token = "0x17000ADA")]
    public int Result
    {
      [Token(Token = "0x6004A37"), Address(RVA = "0x313DF04", Offset = "0x313DF04", VA = "0x313DF04")] get
      {
        return new int();
      }
      [Token(Token = "0x6004A38"), Address(RVA = "0x313DF0C", Offset = "0x313DF0C", VA = "0x313DF0C")] protected set
      {
      }
    }

    [Token(Token = "0x17000ADB")]
    protected virtual Button[] DialogButtons
    {
      [Token(Token = "0x6004A39"), Address(RVA = "0x313DF14", Offset = "0x313DF14", VA = "0x313DF14", Slot = "4")] get
      {
        return (Button[]) null;
      }
    }

    [Token(Token = "0x17000ADC")]
    protected UIAnimationController AnimationController
    {
      [Token(Token = "0x6004A3A"), Address(RVA = "0x313DF58", Offset = "0x313DF58", VA = "0x313DF58")] get
      {
        return (UIAnimationController) null;
      }
      [Token(Token = "0x6004A3B"), Address(RVA = "0x313DF60", Offset = "0x313DF60", VA = "0x313DF60")] private set
      {
      }
    }

    [Token(Token = "0x17000ADD")]
    protected virtual float ButtonEnabledDelayTime
    {
      [Token(Token = "0x6004A3C"), Address(RVA = "0x313DF68", Offset = "0x313DF68", VA = "0x313DF68", Slot = "5")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6004A3D")]
    [Address(RVA = "0x313DF70", Offset = "0x313DF70", VA = "0x313DF70", Slot = "6")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x6004A3E")]
    [Address(RVA = "0x313DC0C", Offset = "0x313DC0C", VA = "0x313DC0C")]
    public void SetButtonMessage(int index, string message)
    {
    }

    [Token(Token = "0x6004A3F")]
    [Address(RVA = "0x313E134", Offset = "0x313E134", VA = "0x313E134")]
    protected void SetButtonEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6004A40")]
    [Address(RVA = "0x313E24C", Offset = "0x313E24C", VA = "0x313E24C")]
    protected void SetButtonEnabled(bool enabled, float delayTime)
    {
    }

    [Token(Token = "0x6004A41")]
    [Address(RVA = "0x313E270", Offset = "0x313E270", VA = "0x313E270")]
    private IEnumerator DelayedSetButtonEnabled(bool enabled, float delayTime)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004A42")]
    [Address(RVA = "0x313DE40", Offset = "0x313DE40", VA = "0x313DE40", Slot = "7")]
    protected virtual void OnButtonClicked(int index)
    {
    }

    [Token(Token = "0x6004A43")]
    [Address(RVA = "0x313E324", Offset = "0x313E324", VA = "0x313E324")]
    public void Open()
    {
    }

    [Token(Token = "0x6004A44")]
    [Address(RVA = "0x313E39C", Offset = "0x313E39C", VA = "0x313E39C", Slot = "8")]
    protected virtual IEnumerator PerformOpen() => (IEnumerator) null;

    [Token(Token = "0x6004A45")]
    [Address(RVA = "0x313E42C", Offset = "0x313E42C", VA = "0x313E42C", Slot = "9")]
    protected virtual void OnOpenAnimationFinished()
    {
    }

    [Token(Token = "0x6004A46")]
    [Address(RVA = "0x313E460", Offset = "0x313E460", VA = "0x313E460")]
    public void Close()
    {
    }

    [Token(Token = "0x6004A47")]
    [Address(RVA = "0x313E4A4", Offset = "0x313E4A4", VA = "0x313E4A4", Slot = "10")]
    protected virtual IEnumerator PerformClose() => (IEnumerator) null;

    [Token(Token = "0x6004A48")]
    [Address(RVA = "0x313E534", Offset = "0x313E534", VA = "0x313E534", Slot = "11")]
    protected virtual void OnCloseAnimationFinished()
    {
    }

    [Token(Token = "0x6004A49")]
    [Address(RVA = "0x313E558", Offset = "0x313E558", VA = "0x313E558", Slot = "12")]
    public virtual bool IsAnimationPlaying() => new bool();

    [Token(Token = "0x6004A4A")]
    [Address(RVA = "0x313E574", Offset = "0x313E574", VA = "0x313E574", Slot = "13")]
    public virtual IEnumerator Inquire() => (IEnumerator) null;

    [Token(Token = "0x6004A4B")]
    [Address(RVA = "0x313E604", Offset = "0x313E604", VA = "0x313E604")]
    public void Inquire(
      UnityAction<int> inquireFinishedCallback,
      UnityAction<int> resultReceivedCallback = null)
    {
    }

    [Token(Token = "0x6004A4C")]
    [Address(RVA = "0x313E654", Offset = "0x313E654", VA = "0x313E654")]
    private void Update()
    {
    }

    [Token(Token = "0x6004A4D")]
    [Address(RVA = "0x313DE4C", Offset = "0x313DE4C", VA = "0x313DE4C")]
    public DialogWindowBase()
    {
    }

    [Token(Token = "0x2000CEB")]
    public class ArrayElementAttribute : PropertyAttribute
    {
      [Token(Token = "0x17000ADE")]
      public string[] Names
      {
        [Token(Token = "0x6004A52"), Address(RVA = "0x313E6A4", Offset = "0x313E6A4", VA = "0x313E6A4")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x6004A53"), Address(RVA = "0x313E6AC", Offset = "0x313E6AC", VA = "0x313E6AC")] private set
        {
        }
      }

      [Token(Token = "0x6004A54")]
      [Address(RVA = "0x313E6B4", Offset = "0x313E6B4", VA = "0x313E6B4")]
      public ArrayElementAttribute(string[] names)
      {
      }
    }

    [Token(Token = "0x2000CEC")]
    public enum State
    {
      [Token(Token = "0x40039D0")] Open,
      [Token(Token = "0x40039D1")] Close,
    }
  }
}
