// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.LocalizeText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C02")]
  public class LocalizeText : MonoBehaviour
  {
    [Token(Token = "0x4003681")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private LocalizeTextSetting.ComponentType componentType;
    [Token(Token = "0x4003682")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string localizeTextListName;
    [Token(Token = "0x4003683")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string localizeTextKey;
    [Token(Token = "0x4003684")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [HideInInspector]
    private int formatIndex;
    [Token(Token = "0x4003685")]
    [FieldOffset(Offset = "0x0")]
    private static string[] formatPresets;
    [Token(Token = "0x4003686")]
    [FieldOffset(Offset = "0x38")]
    private Text uiText;
    [Token(Token = "0x4003687")]
    [FieldOffset(Offset = "0x40")]
    private TextMeshPro textMeshPro;

    [Token(Token = "0x170009FD")]
    public LocalizeTextSetting.ComponentType ComponentType
    {
      [Token(Token = "0x60044E6"), Address(RVA = "0x364D0B4", Offset = "0x364D0B4", VA = "0x364D0B4")] get
      {
        return new LocalizeTextSetting.ComponentType();
      }
    }

    [Token(Token = "0x60044E7")]
    [Address(RVA = "0x364D0BC", Offset = "0x364D0BC", VA = "0x364D0BC")]
    private void Awake()
    {
    }

    [Token(Token = "0x60044E8")]
    [Address(RVA = "0x364D0C0", Offset = "0x364D0C0", VA = "0x364D0C0")]
    public void OverwriteLocalizeText()
    {
    }

    [Token(Token = "0x60044E9")]
    [Address(RVA = "0x364D2F4", Offset = "0x364D2F4", VA = "0x364D2F4")]
    public LocalizeText()
    {
    }

    [Token(Token = "0x60044EA")]
    [Address(RVA = "0x364D34C", Offset = "0x364D34C", VA = "0x364D34C")]
    static LocalizeText()
    {
    }
  }
}
