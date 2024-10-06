// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestDetailSortieRestrict
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003232")]
  internal class QuestDetailSortieRestrict : MonoBehaviour
  {
    [Token(Token = "0x400D671")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SortieRestrictGroup sortieRestrictGroup;
    [Token(Token = "0x400D672")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GuestGroup guestGroup;
    [Token(Token = "0x400D673")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RestrictGroup restrictGroup;

    [Token(Token = "0x6013932")]
    [Address(RVA = "0x460BFE4", Offset = "0x460BFE4", VA = "0x460BFE4")]
    public bool SetData(QuestInfo questInfo) => new bool();

    [Token(Token = "0x6013933")]
    [Address(RVA = "0x460C8FC", Offset = "0x460C8FC", VA = "0x460C8FC")]
    public QuestDetailSortieRestrict()
    {
    }
  }
}
