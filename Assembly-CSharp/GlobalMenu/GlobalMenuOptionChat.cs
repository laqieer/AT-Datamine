// Decompiled with JetBrains decompiler
// Type: GlobalMenu.GlobalMenuOptionChat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Chat;
using Scenes.OutGame;
using TMPro;
using UnityEngine;

#nullable disable
namespace GlobalMenu
{
  [Token(Token = "0x2000B9B")]
  public class GlobalMenuOptionChat : MonoBehaviour
  {
    [Token(Token = "0x40034E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BattleConfigItem simpleMessage;
    [Token(Token = "0x40034E6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleConfigItem newBadge;
    [Token(Token = "0x40034E7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI[] buttonTexts;
    [Token(Token = "0x40034E8")]
    [FieldOffset(Offset = "0x30")]
    private ChatFixedPhraseSettingPopup fixedPhraseEditPrefab;
    [Token(Token = "0x40034E9")]
    [FieldOffset(Offset = "0x38")]
    private ChatFixedPhraseSettingPopup fixedPhraseEditPopup;

    [Token(Token = "0x6004240")]
    [Address(RVA = "0x2A34EB8", Offset = "0x2A34EB8", VA = "0x2A34EB8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004241")]
    [Address(RVA = "0x2A35018", Offset = "0x2A35018", VA = "0x2A35018")]
    private void UpdateFixedPhraseText()
    {
    }

    [Token(Token = "0x6004242")]
    [Address(RVA = "0x2A350D8", Offset = "0x2A350D8", VA = "0x2A350D8")]
    public void OnValueChangedSimpleMessage(bool isOn)
    {
    }

    [Token(Token = "0x6004243")]
    [Address(RVA = "0x2A35168", Offset = "0x2A35168", VA = "0x2A35168")]
    public void OnValueChangedNewBadge(bool isOn)
    {
    }

    [Token(Token = "0x6004244")]
    [Address(RVA = "0x2A351F8", Offset = "0x2A351F8", VA = "0x2A351F8")]
    public void OnFixedPhraseEdit(int index)
    {
    }

    [Token(Token = "0x6004245")]
    [Address(RVA = "0x2A354A4", Offset = "0x2A354A4", VA = "0x2A354A4")]
    public GlobalMenuOptionChat()
    {
    }
  }
}
