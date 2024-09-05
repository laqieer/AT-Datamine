// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CharacterList.ContentCharacterList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.CharacterList
{
  [Token(Token = "0x200371C")]
  public class ContentCharacterList : MonoBehaviour
  {
    [Token(Token = "0x400F0A2")]
    public const int ContentSubMenuMargin = 3;
    [Token(Token = "0x400F0A3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentCharacterPresenter _contentBase;
    [Token(Token = "0x400F0A4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private HorizontalInfiniteScrollView _scroll;
    [Token(Token = "0x400F0A5")]
    [FieldOffset(Offset = "0x28")]
    private List<InfiniteCellData> cellDatas;

    [Token(Token = "0x6015B41")]
    [Address(RVA = "0x1D88B8C", Offset = "0x1D88B8C", VA = "0x1D88B8C")]
    public void CreateList(
      IReadOnlyList<ContentCharacterModel> characters,
      Action<int> onClickCharacter,
      Action<int> onClickLostRecovery,
      Action<int, int> onHeal,
      Func<IEnumerator> onRecoveryTimeOver)
    {
    }

    [Token(Token = "0x6015B42")]
    [Address(RVA = "0x1D893C0", Offset = "0x1D893C0", VA = "0x1D893C0")]
    public ContentCharacterModel GetData(int index) => (ContentCharacterModel) null;

    [Token(Token = "0x6015B43")]
    [Address(RVA = "0x1D89F54", Offset = "0x1D89F54", VA = "0x1D89F54")]
    public float ContentWidth() => new float();

    [Token(Token = "0x6015B44")]
    [Address(RVA = "0x1D89F60", Offset = "0x1D89F60", VA = "0x1D89F60")]
    public void OperationPossible(bool flg)
    {
    }

    [Token(Token = "0x6015B45")]
    [Address(RVA = "0x1D8A180", Offset = "0x1D8A180", VA = "0x1D8A180")]
    public ContentCharacterList()
    {
    }
  }
}
