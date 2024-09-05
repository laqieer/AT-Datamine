// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HotDeal.HotDealSideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Home.HotDeal
{
  [Token(Token = "0x2002B31")]
  internal class HotDealSideMenu : MonoBehaviour
  {
    [Token(Token = "0x400B7D9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400B7DA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button button;
    [Token(Token = "0x400B7DB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text hotDealName;
    [Token(Token = "0x400B7DC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text timeLimit;
    [Token(Token = "0x400B7DD")]
    [FieldOffset(Offset = "0x38")]
    private DateTime endDate;
    [Token(Token = "0x400B7DE")]
    [FieldOffset(Offset = "0x40")]
    private TimeSpan limit;
    [Token(Token = "0x400B7DF")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> selectAction;
    [Token(Token = "0x400B7E0")]
    [FieldOffset(Offset = "0x50")]
    private int myIndex;

    [Token(Token = "0x6010E08")]
    [Address(RVA = "0x1C3B4D4", Offset = "0x1C3B4D4", VA = "0x1C3B4D4")]
    public IEnumerator Initialized(int index, HotDealInfoType data, Action<int> selectAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010E09")]
    [Address(RVA = "0x1C3C328", Offset = "0x1C3C328", VA = "0x1C3C328")]
    private IEnumerator OnClick() => (IEnumerator) null;

    [Token(Token = "0x6010E0A")]
    [Address(RVA = "0x1C3AC74", Offset = "0x1C3AC74", VA = "0x1C3AC74")]
    public bool TimeOver() => new bool();

    [Token(Token = "0x6010E0B")]
    [Address(RVA = "0x1C3ACD0", Offset = "0x1C3ACD0", VA = "0x1C3ACD0")]
    public void SelectIn(bool stopCurrent)
    {
    }

    [Token(Token = "0x6010E0C")]
    [Address(RVA = "0x1C3AD2C", Offset = "0x1C3AD2C", VA = "0x1C3AD2C")]
    public void SelectOut(bool stopCurrent)
    {
    }

    [Token(Token = "0x6010E0D")]
    [Address(RVA = "0x1C3C3B8", Offset = "0x1C3C3B8", VA = "0x1C3C3B8")]
    private IEnumerator BadgeIn() => (IEnumerator) null;

    [Token(Token = "0x6010E0E")]
    [Address(RVA = "0x1C3C448", Offset = "0x1C3C448", VA = "0x1C3C448")]
    private IEnumerator BadgeOut() => (IEnumerator) null;

    [Token(Token = "0x6010E0F")]
    [Address(RVA = "0x1C3C4D8", Offset = "0x1C3C4D8", VA = "0x1C3C4D8")]
    private void Update()
    {
    }

    [Token(Token = "0x6010E10")]
    [Address(RVA = "0x1C3C618", Offset = "0x1C3C618", VA = "0x1C3C618")]
    public HotDealSideMenu()
    {
    }
  }
}
