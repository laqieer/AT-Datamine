// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ContentItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E56")]
  public class ContentItem : MonoBehaviour
  {
    [Token(Token = "0x400C6C7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400C6C8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text content;
    [Token(Token = "0x400C6C9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject button;
    [Token(Token = "0x400C6CA")]
    [FieldOffset(Offset = "0x30")]
    private int targetCommuidentfierId;
    [Token(Token = "0x400C6CB")]
    [FieldOffset(Offset = "0x38")]
    private Action<int> onClickReleaseCommuAction;

    [Token(Token = "0x60121B0")]
    [Address(RVA = "0x4586C34", Offset = "0x4586C34", VA = "0x4586C34")]
    public void Set(string title, string content)
    {
    }

    [Token(Token = "0x60121B1")]
    [Address(RVA = "0x4586D08", Offset = "0x4586D08", VA = "0x4586D08")]
    public void Set(
      string characterName,
      int rank,
      int commuId,
      Action<int> onClickReleaseCommuAction)
    {
    }

    [Token(Token = "0x60121B2")]
    [Address(RVA = "0x4586EB8", Offset = "0x4586EB8", VA = "0x4586EB8")]
    public void OnClickReleaseCommuButton()
    {
    }

    [Token(Token = "0x60121B3")]
    [Address(RVA = "0x4586ED8", Offset = "0x4586ED8", VA = "0x4586ED8")]
    public ContentItem()
    {
    }
  }
}
