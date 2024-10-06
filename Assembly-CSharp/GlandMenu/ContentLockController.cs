// Decompiled with JetBrains decompiler
// Type: GlandMenu.ContentLockController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GlandMenu
{
  [Token(Token = "0x2000955")]
  public class ContentLockController : MonoBehaviour
  {
    [Token(Token = "0x4002B3F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject tapBlockArea;
    [Token(Token = "0x4002B40")]
    [FieldOffset(Offset = "0x20")]
    private ContentLockButton[] buttonList;
    [Token(Token = "0x4002B41")]
    [FieldOffset(Offset = "0x28")]
    private List<ContentLockButton> effectTargetList;

    [Token(Token = "0x60034AB")]
    [Address(RVA = "0x36347FC", Offset = "0x36347FC", VA = "0x36347FC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60034AC")]
    [Address(RVA = "0x3634850", Offset = "0x3634850", VA = "0x3634850")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60034AD")]
    [Address(RVA = "0x36348AC", Offset = "0x36348AC", VA = "0x36348AC")]
    public bool UnlockCheck() => new bool();

    [Token(Token = "0x60034AE")]
    [Address(RVA = "0x3634B48", Offset = "0x3634B48", VA = "0x3634B48")]
    public IEnumerator PlayToEffect() => (IEnumerator) null;

    [Token(Token = "0x60034AF")]
    [Address(RVA = "0x3634BD8", Offset = "0x3634BD8", VA = "0x3634BD8")]
    public IEnumerator PlayToaster() => (IEnumerator) null;

    [Token(Token = "0x60034B0")]
    [Address(RVA = "0x3634C68", Offset = "0x3634C68", VA = "0x3634C68")]
    public void SetTapBlock(bool isOn)
    {
    }

    [Token(Token = "0x60034B1")]
    [Address(RVA = "0x3634C88", Offset = "0x3634C88", VA = "0x3634C88")]
    public bool IsTapAllowed() => new bool();

    [Token(Token = "0x60034B2")]
    [Address(RVA = "0x3634CB0", Offset = "0x3634CB0", VA = "0x3634CB0")]
    public ContentLockController()
    {
    }

    [Token(Token = "0x2000956")]
    public enum LockIconType
    {
      [Token(Token = "0x4002B43")] Event,
      [Token(Token = "0x4002B44")] Guild,
      [Token(Token = "0x4002B45")] Arena,
      [Token(Token = "0x4002B46")] Chart,
      [Token(Token = "0x4002B47")] StoryShop,
      [Token(Token = "0x4002B48")] Main,
      [Token(Token = "0x4002B49")] Main2,
      [Token(Token = "0x4002B4A")] LimitedSenarioQuest,
    }
  }
}
