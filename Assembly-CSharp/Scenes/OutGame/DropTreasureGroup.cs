// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.DropTreasureGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200321A")]
  internal class DropTreasureGroup : MonoBehaviour
  {
    [Token(Token = "0x400D5FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject copper;
    [Token(Token = "0x400D600")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject silver;
    [Token(Token = "0x400D601")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject gold;

    [Token(Token = "0x60138B7")]
    [Address(RVA = "0x49C3DF4", Offset = "0x49C3DF4", VA = "0x49C3DF4")]
    public void SetDropTreasure(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x60138B8")]
    [Address(RVA = "0x49C4AC0", Offset = "0x49C4AC0", VA = "0x49C4AC0")]
    public DropTreasureGroup()
    {
    }
  }
}
