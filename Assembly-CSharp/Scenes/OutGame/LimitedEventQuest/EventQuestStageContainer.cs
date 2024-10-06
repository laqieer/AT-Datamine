// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.LimitedEventQuest.EventQuestStageContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.LimitedEventQuest
{
  [Token(Token = "0x2003630")]
  public class EventQuestStageContainer : MonoBehaviour
  {
    [Token(Token = "0x400EBAE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<EventQuestStageThumbnail> thumbnails;

    [Token(Token = "0x170046F4")]
    public List<EventQuestStageThumbnail> Thumbnails
    {
      [Token(Token = "0x601556E"), Address(RVA = "0x4D9CD3C", Offset = "0x4D9CD3C", VA = "0x4D9CD3C")] get
      {
        return (List<EventQuestStageThumbnail>) null;
      }
    }

    [Token(Token = "0x601556F")]
    [Address(RVA = "0x4D9CD44", Offset = "0x4D9CD44", VA = "0x4D9CD44")]
    public void Show()
    {
    }

    [Token(Token = "0x6015570")]
    [Address(RVA = "0x4D9CD68", Offset = "0x4D9CD68", VA = "0x4D9CD68")]
    public void Hide()
    {
    }

    [Token(Token = "0x6015571")]
    [Address(RVA = "0x4D9CD8C", Offset = "0x4D9CD8C", VA = "0x4D9CD8C")]
    public EventQuestStageContainer()
    {
    }
  }
}
