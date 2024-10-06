// Decompiled with JetBrains decompiler
// Type: Gacha.GachaHeaderButtonView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001597")]
  internal class GachaHeaderButtonView : MonoBehaviour
  {
    [Token(Token = "0x4006308")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4006309")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text textNum;
    [Token(Token = "0x400630A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button buttonHeader;
    [Token(Token = "0x400630B")]
    [FieldOffset(Offset = "0x30")]
    public Action<Button> HeaderButtonClicked;

    [Token(Token = "0x6007A64")]
    [Address(RVA = "0x229C760", Offset = "0x229C760", VA = "0x229C760")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007A65")]
    [Address(RVA = "0x229C7F4", Offset = "0x229C7F4", VA = "0x229C7F4")]
    private void OnHeaderButtonClicked()
    {
    }

    [Token(Token = "0x6007A66")]
    [Address(RVA = "0x229C814", Offset = "0x229C814", VA = "0x229C814")]
    public void SetHeaderIcon(Sprite sprite)
    {
    }

    [Token(Token = "0x6007A67")]
    [Address(RVA = "0x229C830", Offset = "0x229C830", VA = "0x229C830")]
    public void SetHeaderNumText(string text)
    {
    }

    [Token(Token = "0x6007A68")]
    [Address(RVA = "0x229C854", Offset = "0x229C854", VA = "0x229C854")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x6007A69")]
    [Address(RVA = "0x229C87C", Offset = "0x229C87C", VA = "0x229C87C")]
    public GachaHeaderButtonView()
    {
    }
  }
}
