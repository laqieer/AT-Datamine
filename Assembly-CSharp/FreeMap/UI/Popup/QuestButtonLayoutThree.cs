// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.QuestButtonLayoutThree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x2001632")]
  public class QuestButtonLayoutThree : MonoBehaviour
  {
    [Token(Token = "0x40064CB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestButtonUI left;
    [Token(Token = "0x40064CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private QuestButtonUI center;
    [Token(Token = "0x40064CD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private QuestButtonUI right;
    [Token(Token = "0x40064CE")]
    [FieldOffset(Offset = "0x30")]
    public Action ClickLeft;
    [Token(Token = "0x40064CF")]
    [FieldOffset(Offset = "0x38")]
    public Action ClickCenter;
    [Token(Token = "0x40064D0")]
    [FieldOffset(Offset = "0x40")]
    public Action ClickRight;

    [Token(Token = "0x17001370")]
    public QuestButtonUI Left
    {
      [Token(Token = "0x6007DCE"), Address(RVA = "0x21ABD10", Offset = "0x21ABD10", VA = "0x21ABD10")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x17001371")]
    public QuestButtonUI Center
    {
      [Token(Token = "0x6007DCF"), Address(RVA = "0x21ABD18", Offset = "0x21ABD18", VA = "0x21ABD18")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x17001372")]
    public QuestButtonUI Right
    {
      [Token(Token = "0x6007DD0"), Address(RVA = "0x21ABD20", Offset = "0x21ABD20", VA = "0x21ABD20")] get
      {
        return (QuestButtonUI) null;
      }
    }

    [Token(Token = "0x6007DD1")]
    [Address(RVA = "0x21AB4EC", Offset = "0x21AB4EC", VA = "0x21AB4EC")]
    public void SetActiveChild(bool active)
    {
    }

    [Token(Token = "0x6007DD2")]
    [Address(RVA = "0x21ABD28", Offset = "0x21ABD28", VA = "0x21ABD28")]
    public QuestButtonLayoutThree Use() => (QuestButtonLayoutThree) null;

    [Token(Token = "0x6007DD3")]
    [Address(RVA = "0x21ABD8C", Offset = "0x21ABD8C", VA = "0x21ABD8C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6007DD4")]
    [Address(RVA = "0x21ABEAC", Offset = "0x21ABEAC", VA = "0x21ABEAC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6007DD5")]
    [Address(RVA = "0x21ABFCC", Offset = "0x21ABFCC", VA = "0x21ABFCC")]
    private void OnClickLeft()
    {
    }

    [Token(Token = "0x6007DD6")]
    [Address(RVA = "0x21ABFE8", Offset = "0x21ABFE8", VA = "0x21ABFE8")]
    private void OnClickCenter()
    {
    }

    [Token(Token = "0x6007DD7")]
    [Address(RVA = "0x21AC004", Offset = "0x21AC004", VA = "0x21AC004")]
    private void OnClickRight()
    {
    }

    [Token(Token = "0x6007DD8")]
    [Address(RVA = "0x21AC020", Offset = "0x21AC020", VA = "0x21AC020")]
    public QuestButtonLayoutThree()
    {
    }
  }
}
