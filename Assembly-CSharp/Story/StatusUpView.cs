// Decompiled with JetBrains decompiler
// Type: Story.StatusUpView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000538")]
  public class StatusUpView : MonoBehaviour
  {
    [Token(Token = "0x4001B71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject containerHeader;
    [Token(Token = "0x4001B72")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Image imageCharacter;
    [Token(Token = "0x4001B73")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public GameObject itemIconPos;
    [Token(Token = "0x4001B74")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public Image imageRankNum1;
    [Token(Token = "0x4001B75")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public Image imageRankNum2;
    [Token(Token = "0x4001B76")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public TextMeshProUGUI txtName;
    [Token(Token = "0x4001B77")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public TextMeshProUGUI txtItem;
    [Token(Token = "0x4001B78")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public Button buttonTouchArea;
    [Token(Token = "0x4001B79")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public Sprite[] spriteRankNum;
    [Token(Token = "0x4001B7A")]
    [FieldOffset(Offset = "0x60")]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001B7B")]
    [FieldOffset(Offset = "0x68")]
    private UIAnimationController animationController;
    [Token(Token = "0x4001B7C")]
    [FieldOffset(Offset = "0x70")]
    private Action callback;
    [Token(Token = "0x4001B7D")]
    [FieldOffset(Offset = "0x78")]
    private bool buttonReady;

    [Token(Token = "0x6001E38")]
    [Address(RVA = "0x29FC3F4", Offset = "0x29FC3F4", VA = "0x29FC3F4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001E39")]
    [Address(RVA = "0x29FC524", Offset = "0x29FC524", VA = "0x29FC524")]
    private void Update()
    {
    }

    [Token(Token = "0x6001E3A")]
    [Address(RVA = "0x29FC538", Offset = "0x29FC538", VA = "0x29FC538")]
    public void StartStatusUp(int rank, string name, string itemuName, Action callback = null)
    {
    }

    [Token(Token = "0x6001E3B")]
    [Address(RVA = "0x29FC720", Offset = "0x29FC720", VA = "0x29FC720")]
    private void ButtonTouch()
    {
    }

    [Token(Token = "0x6001E3C")]
    [Address(RVA = "0x29FC6A8", Offset = "0x29FC6A8", VA = "0x29FC6A8")]
    private IEnumerator StartFlow(int rank) => (IEnumerator) null;

    [Token(Token = "0x6001E3D")]
    [Address(RVA = "0x29FC750", Offset = "0x29FC750", VA = "0x29FC750")]
    private IEnumerator EndFlow() => (IEnumerator) null;

    [Token(Token = "0x6001E3E")]
    [Address(RVA = "0x29FC808", Offset = "0x29FC808", VA = "0x29FC808")]
    private IEnumerator WaitAnim(string anim) => (IEnumerator) null;

    [Token(Token = "0x6001E3F")]
    [Address(RVA = "0x29FC574", Offset = "0x29FC574", VA = "0x29FC574")]
    private void SetStatusUpDraw(int rank, string name, string itemuName)
    {
    }

    [Token(Token = "0x6001E40")]
    [Address(RVA = "0x29FC8A4", Offset = "0x29FC8A4", VA = "0x29FC8A4")]
    public StatusUpView()
    {
    }
  }
}
