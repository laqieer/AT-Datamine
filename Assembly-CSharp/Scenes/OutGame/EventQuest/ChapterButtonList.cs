// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.EventQuest.ChapterButtonList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.EventQuest
{
  [Token(Token = "0x2003654")]
  public class ChapterButtonList : MonoBehaviour
  {
    [Token(Token = "0x400EC6A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform buttonParent;
    [Token(Token = "0x400EC6B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton baseButton;
    [Token(Token = "0x400EC6C")]
    [FieldOffset(Offset = "0x28")]
    private List<CommonButton> buttonList;

    [Token(Token = "0x601563D")]
    [Address(RVA = "0x18DA280", Offset = "0x18DA280", VA = "0x18DA280")]
    public void CreateChapterButton(Action<StoryChapterData> action)
    {
    }

    [Token(Token = "0x601563E")]
    [Address(RVA = "0x18DA944", Offset = "0x18DA944", VA = "0x18DA944")]
    private void ResetObject()
    {
    }

    [Token(Token = "0x601563F")]
    [Address(RVA = "0x18DAB1C", Offset = "0x18DAB1C", VA = "0x18DAB1C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6015640")]
    [Address(RVA = "0x18DAB20", Offset = "0x18DAB20", VA = "0x18DAB20")]
    public ChapterButtonList()
    {
    }
  }
}
