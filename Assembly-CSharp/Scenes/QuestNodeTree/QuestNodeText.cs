// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A2B")]
  public class QuestNodeText : QuestNodeBase
  {
    [Token(Token = "0x400B36C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshPro textMeshPro;

    [Token(Token = "0x6010834")]
    [Address(RVA = "0x4C22F5C", Offset = "0x4C22F5C", VA = "0x4C22F5C")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6010835")]
    [Address(RVA = "0x4C23780", Offset = "0x4C23780", VA = "0x4C23780")]
    public QuestNodeText()
    {
    }
  }
}
