// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.QuestNodeConnectingLine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A24")]
  public class QuestNodeConnectingLine : QuestNodeBase
  {
    [Token(Token = "0x400B34C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SpriteRenderer[] lineSpriteRenderers;
    [Token(Token = "0x400B34D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SpriteRenderer clearLine;
    [Token(Token = "0x400B350")]
    [FieldOffset(Offset = "0x38")]
    private float lineWidth;

    [Token(Token = "0x17003959")]
    public QuestNodeSpace RootNode
    {
      [Token(Token = "0x60107FC"), Address(RVA = "0x4C227FC", Offset = "0x4C227FC", VA = "0x4C227FC")] get
      {
        return (QuestNodeSpace) null;
      }
      [Token(Token = "0x60107FD"), Address(RVA = "0x4C22804", Offset = "0x4C22804", VA = "0x4C22804")] private set
      {
      }
    }

    [Token(Token = "0x1700395A")]
    public QuestNodeSpace NextNode
    {
      [Token(Token = "0x60107FE"), Address(RVA = "0x4C2280C", Offset = "0x4C2280C", VA = "0x4C2280C")] get
      {
        return (QuestNodeSpace) null;
      }
      [Token(Token = "0x60107FF"), Address(RVA = "0x4C22814", Offset = "0x4C22814", VA = "0x4C22814")] private set
      {
      }
    }

    [Token(Token = "0x6010800")]
    [Address(RVA = "0x4C2281C", Offset = "0x4C2281C", VA = "0x4C2281C")]
    public void SetConnectNode(QuestNodeSpace root, QuestNodeSpace next)
    {
    }

    [Token(Token = "0x6010801")]
    [Address(RVA = "0x4C22824", Offset = "0x4C22824", VA = "0x4C22824")]
    public void UpdateLine()
    {
    }

    [Token(Token = "0x6010802")]
    [Address(RVA = "0x4C20FC8", Offset = "0x4C20FC8", VA = "0x4C20FC8")]
    public float SetUnleashLine(float per) => new float();

    [Token(Token = "0x6010803")]
    [Address(RVA = "0x4C22A68", Offset = "0x4C22A68", VA = "0x4C22A68")]
    public void SetActiveUnleashLine(bool isUnleashLine)
    {
    }

    [Token(Token = "0x6010804")]
    [Address(RVA = "0x4C228B0", Offset = "0x4C228B0", VA = "0x4C228B0")]
    private void SetNextPosition(Vector3 startPosition, Vector3 endPostion)
    {
    }

    [Token(Token = "0x6010805")]
    [Address(RVA = "0x4C22AC0", Offset = "0x4C22AC0", VA = "0x4C22AC0")]
    public QuestNodeConnectingLine()
    {
    }
  }
}
