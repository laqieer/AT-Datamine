// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Other.LevelUp.ExpGaugeAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.Other.LevelUp
{
  [Token(Token = "0x2002C90")]
  public class ExpGaugeAnimator : MonoBehaviour
  {
    [Token(Token = "0x400BE1A")]
    private const float Speed = 0.01f;
    [Token(Token = "0x400BE1B")]
    private const string LevelFormat = "{0}";
    [Token(Token = "0x400BE1C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider slider;
    [Token(Token = "0x400BE1D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x400BE20")]
    [FieldOffset(Offset = "0x38")]
    private LevelUpUtility.ExpData from;
    [Token(Token = "0x400BE21")]
    [FieldOffset(Offset = "0x40")]
    private LevelUpUtility.ExpData to;

    [Token(Token = "0x17003C11")]
    public float SliderSpeed
    {
      [Token(Token = "0x6011701"), Address(RVA = "0x493696C", Offset = "0x493696C", VA = "0x493696C")] get
      {
        return new float();
      }
      [Token(Token = "0x6011702"), Address(RVA = "0x4936974", Offset = "0x4936974", VA = "0x4936974")] set
      {
      }
    }

    [Token(Token = "0x17003C12")]
    public string LevelFormatStr
    {
      [Token(Token = "0x6011703"), Address(RVA = "0x493697C", Offset = "0x493697C", VA = "0x493697C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6011704"), Address(RVA = "0x4936984", Offset = "0x4936984", VA = "0x4936984")] set
      {
      }
    }

    [Token(Token = "0x6011705")]
    [Address(RVA = "0x493698C", Offset = "0x493698C", VA = "0x493698C")]
    public void SetData(LevelUpUtility.ExpData from, LevelUpUtility.ExpData to)
    {
    }

    [Token(Token = "0x6011706")]
    [Address(RVA = "0x4936AA0", Offset = "0x4936AA0", VA = "0x4936AA0")]
    public void SetFromData(LevelUpUtility.ExpData from)
    {
    }

    [Token(Token = "0x6011707")]
    [Address(RVA = "0x4936BB0", Offset = "0x4936BB0", VA = "0x4936BB0")]
    public void SetToData(LevelUpUtility.ExpData to)
    {
    }

    [Token(Token = "0x6011708")]
    [Address(RVA = "0x4936BB8", Offset = "0x4936BB8", VA = "0x4936BB8")]
    public void PlayAnimation(Action<bool> callback = null)
    {
    }

    [Token(Token = "0x6011709")]
    [Address(RVA = "0x4936BD8", Offset = "0x4936BD8", VA = "0x4936BD8")]
    private IEnumerator PlayAnimationCoroutine(Action<bool> callback = null) => (IEnumerator) null;

    [Token(Token = "0x601170A")]
    [Address(RVA = "0x4936C74", Offset = "0x4936C74", VA = "0x4936C74")]
    public ExpGaugeAnimator()
    {
    }
  }
}
