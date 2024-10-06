// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeSelectedMark
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A27")]
  public class QuestNodeSelectedMark : QuestNodeBase
  {
    [Token(Token = "0x400B356")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector inPlayableDirector;
    [Token(Token = "0x400B357")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector outPlayableDirector;

    [Token(Token = "0x6010810")]
    [Address(RVA = "0x4C226CC", Offset = "0x4C226CC", VA = "0x4C226CC")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x6010811")]
    [Address(RVA = "0x4C2269C", Offset = "0x4C2269C", VA = "0x4C2269C")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x6010812")]
    [Address(RVA = "0x4C22EA4", Offset = "0x4C22EA4", VA = "0x4C22EA4")]
    public QuestNodeSelectedMark()
    {
    }
  }
}
