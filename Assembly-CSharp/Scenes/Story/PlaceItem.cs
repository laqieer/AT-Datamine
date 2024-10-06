// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PlaceItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D74")]
  public class PlaceItem : MonoBehaviour
  {
    [Token(Token = "0x400C316")]
    private const string TWEEN_KEY_PLACE_IN = "Place_In";
    [Token(Token = "0x400C317")]
    private const string TWEEN_KEY_PLACE_OUT = "Place_Out";
    [Token(Token = "0x400C318")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject root;
    [Token(Token = "0x400C319")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C31A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text areaNameText;
    [Token(Token = "0x400C31B")]
    [FieldOffset(Offset = "0x30")]
    private bool isActivated;
    [Token(Token = "0x400C31C")]
    [FieldOffset(Offset = "0x31")]
    private bool shown;

    [Token(Token = "0x6011C46")]
    [Address(RVA = "0x42BE3B4", Offset = "0x42BE3B4", VA = "0x42BE3B4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011C47")]
    [Address(RVA = "0x42BE3D4", Offset = "0x42BE3D4", VA = "0x42BE3D4")]
    public void SetActivate(bool isActive)
    {
    }

    [Token(Token = "0x6011C48")]
    [Address(RVA = "0x42BE3E0", Offset = "0x42BE3E0", VA = "0x42BE3E0")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x6011C49")]
    [Address(RVA = "0x42BE404", Offset = "0x42BE404", VA = "0x42BE404")]
    public void Show(bool stopCurrent = true)
    {
    }

    [Token(Token = "0x6011C4A")]
    [Address(RVA = "0x42BE498", Offset = "0x42BE498", VA = "0x42BE498")]
    public void Hide(bool stopCurrent = true)
    {
    }

    [Token(Token = "0x6011C4B")]
    [Address(RVA = "0x42BE574", Offset = "0x42BE574", VA = "0x42BE574")]
    private void HideCallback()
    {
    }

    [Token(Token = "0x6011C4C")]
    [Address(RVA = "0x42BE614", Offset = "0x42BE614", VA = "0x42BE614")]
    public PlaceItem()
    {
    }
  }
}
