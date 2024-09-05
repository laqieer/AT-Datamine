// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A25")]
  public class QuestNodeEffect : QuestNodeBase
  {
    [Token(Token = "0x400B351")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string seName;
    [Token(Token = "0x400B352")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float delaySoundPlayTime;

    [Token(Token = "0x6010806")]
    [Address(RVA = "0x4C22AC8", Offset = "0x4C22AC8", VA = "0x4C22AC8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6010807")]
    [Address(RVA = "0x4C22ACC", Offset = "0x4C22ACC", VA = "0x4C22ACC")]
    private void PlaySE()
    {
    }

    [Token(Token = "0x6010808")]
    [Address(RVA = "0x4C22C48", Offset = "0x4C22C48", VA = "0x4C22C48")]
    private IEnumerator DelayPlaySound() => (IEnumerator) null;

    [Token(Token = "0x6010809")]
    [Address(RVA = "0x4C22CD8", Offset = "0x4C22CD8", VA = "0x4C22CD8")]
    public QuestNodeEffect()
    {
    }
  }
}
