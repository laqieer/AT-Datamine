// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI.BannerIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.Story.PocketBook.StoryIndex.ScheduleList.UI
{
  [Token(Token = "0x2002DFD")]
  [Serializable]
  public class BannerIcon
  {
    [Token(Token = "0x400C586")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("コミュランクアップ可能アイコン")]
    public GameObject commuRankUpIcon;
    [Token(Token = "0x400C587")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("サブクエスト受注不可アイコン")]
    public GameObject subquestUnplayableIcon;
    [Token(Token = "0x400C588")]
    [FieldOffset(Offset = "0x20")]
    [Header("サブクエストクリア済みアイコン")]
    [SerializeField]
    public GameObject subquestClearedIcon;

    [Token(Token = "0x6011F9B")]
    [Address(RVA = "0x43774DC", Offset = "0x43774DC", VA = "0x43774DC")]
    public BannerIcon()
    {
    }
  }
}
