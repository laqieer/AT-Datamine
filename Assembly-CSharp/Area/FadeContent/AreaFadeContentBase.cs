// Decompiled with JetBrains decompiler
// Type: Area.FadeContent.AreaFadeContentBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.FadeContent
{
  [Token(Token = "0x200284C")]
  public abstract class AreaFadeContentBase : MonoBehaviour
  {
    [Token(Token = "0x400ABC8")]
    [FieldOffset(Offset = "0x18")]
    protected float currentFadeAlpha;
    [Token(Token = "0x400ABC9")]
    protected const float TRANSPARENT_ALPHA = 0.0f;
    [Token(Token = "0x400ABCA")]
    protected const float UNTRANSPARENT_ALPHA = 1f;
    [Token(Token = "0x400ABCB")]
    [FieldOffset(Offset = "0x20")]
    protected List<IAreaFadeElement> fadeObjectElementList;
    [Token(Token = "0x400ABCC")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine fadeCoroutine;
    [Token(Token = "0x400ABCD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float changeDuration;

    [Token(Token = "0x170037E6")]
    public bool IsFadeOut
    {
      [Token(Token = "0x600FDCB"), Address(RVA = "0x4431790", Offset = "0x4431790", VA = "0x4431790")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FDCC"), Address(RVA = "0x4431798", Offset = "0x4431798", VA = "0x4431798")] private set
      {
      }
    }

    [Token(Token = "0x170037E7")]
    public bool IsFading
    {
      [Token(Token = "0x600FDCD"), Address(RVA = "0x44317A4", Offset = "0x44317A4", VA = "0x44317A4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FDCE")]
    [Address(RVA = "0x442D094", Offset = "0x442D094", VA = "0x442D094")]
    public void FadeOut()
    {
    }

    [Token(Token = "0x600FDCF")]
    [Address(RVA = "0x442D0D4", Offset = "0x442D0D4", VA = "0x442D0D4")]
    public void FadeIn()
    {
    }

    [Token(Token = "0x600FDD0")]
    [Address(RVA = "0x442BCCC", Offset = "0x442BCCC", VA = "0x442BCCC")]
    public void Hide()
    {
    }

    [Token(Token = "0x600FDD1")]
    [Address(RVA = "0x4431A3C", Offset = "0x4431A3C", VA = "0x4431A3C")]
    public void Show()
    {
    }

    [Token(Token = "0x600FDD2")]
    [Address(RVA = "0x4431884", Offset = "0x4431884", VA = "0x4431884")]
    private void DisableRenderer()
    {
    }

    [Token(Token = "0x600FDD3")]
    [Address(RVA = "0x4431C38", Offset = "0x4431C38", VA = "0x4431C38")]
    private void EnableRenderer()
    {
    }

    [Token(Token = "0x600FDD4")]
    [Address(RVA = "0x4431DF0", Offset = "0x4431DF0", VA = "0x4431DF0")]
    private void Validation(ref float changeDuration)
    {
    }

    [Token(Token = "0x600FDD5")]
    [Address(RVA = "0x44317B4", Offset = "0x44317B4", VA = "0x44317B4")]
    private IEnumerator FadeOutCoroutine() => (IEnumerator) null;

    [Token(Token = "0x600FDD6")]
    [Address(RVA = "0x443181C", Offset = "0x443181C", VA = "0x443181C")]
    private IEnumerator FadeInCoroutine() => (IEnumerator) null;

    [Token(Token = "0x600FDD7")]
    [Address(RVA = "0x4431E54", Offset = "0x4431E54", VA = "0x4431E54")]
    private bool ChechChangeFinished(float changeTime) => new bool();

    [Token(Token = "0x600FDD8")]
    [Address(RVA = "0x442D3EC", Offset = "0x442D3EC", VA = "0x442D3EC")]
    public void Destroy()
    {
    }

    [Token(Token = "0x600FDD9")]
    [Address(RVA = "0x44316F8", Offset = "0x44316F8", VA = "0x44316F8")]
    protected AreaFadeContentBase()
    {
    }
  }
}
