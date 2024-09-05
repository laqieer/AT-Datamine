// Decompiled with JetBrains decompiler
// Type: BasicIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200020D")]
public class BasicIcon : MonoBehaviour
{
  [Token(Token = "0x4000C39")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Image m_iconImage;
  [Token(Token = "0x4000C3A")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private Image m_backgroundImage;
  [Token(Token = "0x4000C3B")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private Image m_foregroundImage;
  [Token(Token = "0x4000C3C")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Text m_titleText;
  [Token(Token = "0x4000C3D")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Text m_numberText;
  [Token(Token = "0x4000C3E")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private LongPressButton m_longPressButton;

  [Token(Token = "0x17000104")]
  public Image iconImage
  {
    [Token(Token = "0x6000CEB"), Address(RVA = "0x4C7F1DC", Offset = "0x4C7F1DC", VA = "0x4C7F1DC")] get
    {
      return (Image) null;
    }
  }

  [Token(Token = "0x17000105")]
  public Image backgroundImage
  {
    [Token(Token = "0x6000CEC"), Address(RVA = "0x4C7F1E0", Offset = "0x4C7F1E0", VA = "0x4C7F1E0")] get
    {
      return (Image) null;
    }
  }

  [Token(Token = "0x17000106")]
  public Image foregroundImage
  {
    [Token(Token = "0x6000CED"), Address(RVA = "0x4C7F1E8", Offset = "0x4C7F1E8", VA = "0x4C7F1E8")] get
    {
      return (Image) null;
    }
  }

  [Token(Token = "0x17000107")]
  public Text titleText
  {
    [Token(Token = "0x6000CEE"), Address(RVA = "0x4C7F1F0", Offset = "0x4C7F1F0", VA = "0x4C7F1F0")] get
    {
      return (Text) null;
    }
  }

  [Token(Token = "0x17000108")]
  public Text numberText
  {
    [Token(Token = "0x6000CEF"), Address(RVA = "0x4C7F1F8", Offset = "0x4C7F1F8", VA = "0x4C7F1F8")] get
    {
      return (Text) null;
    }
  }

  [Token(Token = "0x17000109")]
  public LongPressButton longPressButton
  {
    [Token(Token = "0x6000CF0"), Address(RVA = "0x4C7F200", Offset = "0x4C7F200", VA = "0x4C7F200")] get
    {
      return (LongPressButton) null;
    }
  }

  [Token(Token = "0x6000CF1")]
  [Address(RVA = "0x4C7F208", Offset = "0x4C7F208", VA = "0x4C7F208")]
  private void Start()
  {
  }

  [Token(Token = "0x6000CF2")]
  [Address(RVA = "0x4C7F20C", Offset = "0x4C7F20C", VA = "0x4C7F20C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CF3")]
  [Address(RVA = "0x4C7F210", Offset = "0x4C7F210", VA = "0x4C7F210")]
  public void SetIconImageSprite(Sprite sprite)
  {
  }

  [Token(Token = "0x6000CF4")]
  [Address(RVA = "0x4C7F22C", Offset = "0x4C7F22C", VA = "0x4C7F22C")]
  public void SetBackgroundImageSprite(Sprite sprite)
  {
  }

  [Token(Token = "0x6000CF5")]
  [Address(RVA = "0x4C7F248", Offset = "0x4C7F248", VA = "0x4C7F248")]
  public void SetForegroundImageSprite(Sprite sprite)
  {
  }

  [Token(Token = "0x6000CF6")]
  [Address(RVA = "0x4C7F264", Offset = "0x4C7F264", VA = "0x4C7F264")]
  public void SetNumberText(int number)
  {
  }

  [Token(Token = "0x6000CF7")]
  [Address(RVA = "0x4C7F2AC", Offset = "0x4C7F2AC", VA = "0x4C7F2AC")]
  public void SetTitleText(string text)
  {
  }

  [Token(Token = "0x6000CF8")]
  [Address(RVA = "0x4C7F2D0", Offset = "0x4C7F2D0", VA = "0x4C7F2D0")]
  public BasicIcon()
  {
  }
}
