// Decompiled with JetBrains decompiler
// Type: Scenes.Story.SubQuest.SubQuestDetailPopupToaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Story.SubQuest
{
  [Token(Token = "0x2002D8F")]
  public class SubQuestDetailPopupToaster
  {
    [Token(Token = "0x400C3A9")]
    [FieldOffset(Offset = "0x10")]
    private ToasterUI instance;
    [Token(Token = "0x400C3AA")]
    [FieldOffset(Offset = "0x18")]
    private Transform parent;
    [Token(Token = "0x400C3AB")]
    [FieldOffset(Offset = "0x20")]
    private string text;

    [Token(Token = "0x6011D06")]
    [Address(RVA = "0x3F9F458", Offset = "0x3F9F458", VA = "0x3F9F458")]
    public SubQuestDetailPopupToaster(Transform parent)
    {
    }

    [Token(Token = "0x6011D07")]
    [Address(RVA = "0x3FA0190", Offset = "0x3FA0190", VA = "0x3FA0190")]
    public IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x6011D08")]
    [Address(RVA = "0x3FA0220", Offset = "0x3FA0220", VA = "0x3FA0220")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6011D09")]
    [Address(RVA = "0x3F9F4C4", Offset = "0x3F9F4C4", VA = "0x3F9F4C4")]
    public IEnumerator Play() => (IEnumerator) null;

    [Token(Token = "0x6011D0A")]
    [Address(RVA = "0x3FA0250", Offset = "0x3FA0250", VA = "0x3FA0250")]
    public void PlayTween()
    {
    }

    [Token(Token = "0x6011D0B")]
    [Address(RVA = "0x3F9F6B4", Offset = "0x3F9F6B4", VA = "0x3F9F6B4")]
    public void OnDestroy()
    {
    }
  }
}
