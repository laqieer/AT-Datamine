// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001634")]
  public class QuestButtonUI : MonoBehaviour
  {
    [Token(Token = "0x40064D5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("肯定的")]
    [Tooltip("開始、完了など")]
    private Button positive;
    [Token(Token = "0x40064D6")]
    [FieldOffset(Offset = "0x20")]
    [Header("否定的")]
    [SerializeField]
    [Tooltip("閉じるなど")]
    private Button negative;
    [Token(Token = "0x40064D7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("戻るなど")]
    [Header("中性的")]
    private Button neutral;
    [Token(Token = "0x40064D8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("機能的")]
    [Tooltip("マップなど")]
    private Button function;
    [Token(Token = "0x40064D9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Tooltip("破棄など")]
    [Header("破壊的")]
    private Button broken;

    [Token(Token = "0x17001375")]
    public Button Positive
    {
      [Token(Token = "0x6007DE2"), Address(RVA = "0x21AC280", Offset = "0x21AC280", VA = "0x21AC280")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17001376")]
    public Button Negative
    {
      [Token(Token = "0x6007DE3"), Address(RVA = "0x21AC288", Offset = "0x21AC288", VA = "0x21AC288")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17001377")]
    public Button Neutral
    {
      [Token(Token = "0x6007DE4"), Address(RVA = "0x21AC290", Offset = "0x21AC290", VA = "0x21AC290")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17001378")]
    public Button Function
    {
      [Token(Token = "0x6007DE5"), Address(RVA = "0x21AC298", Offset = "0x21AC298", VA = "0x21AC298")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x17001379")]
    public Button Broken
    {
      [Token(Token = "0x6007DE6"), Address(RVA = "0x21AC2A0", Offset = "0x21AC2A0", VA = "0x21AC2A0")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x6007DE7")]
    [Address(RVA = "0x21AB69C", Offset = "0x21AB69C", VA = "0x21AB69C")]
    public void ButtonsOff()
    {
    }

    [Token(Token = "0x6007DE8")]
    [Address(RVA = "0x21AC2A8", Offset = "0x21AC2A8", VA = "0x21AC2A8")]
    public static void SetText(Button button, string text)
    {
    }

    [Token(Token = "0x6007DE9")]
    [Address(RVA = "0x21AB8B4", Offset = "0x21AB8B4", VA = "0x21AB8B4")]
    public void AddListener(UnityAction callback)
    {
    }

    [Token(Token = "0x6007DEA")]
    [Address(RVA = "0x21AC314", Offset = "0x21AC314", VA = "0x21AC314")]
    private static void AddListener(Button button, UnityAction callback)
    {
    }

    [Token(Token = "0x6007DEB")]
    [Address(RVA = "0x21ABA6C", Offset = "0x21ABA6C", VA = "0x21ABA6C")]
    public void RemoveListener(UnityAction callback)
    {
    }

    [Token(Token = "0x6007DEC")]
    [Address(RVA = "0x21AC358", Offset = "0x21AC358", VA = "0x21AC358")]
    public QuestButtonUI()
    {
    }
  }
}
