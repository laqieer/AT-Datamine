// Decompiled with JetBrains decompiler
// Type: Scenes.Story.AreaEvent.AreaEventQuestPopupController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using StaqData.AreaEvent;
using System;

#nullable disable
namespace Scenes.Story.AreaEvent
{
  [Token(Token = "0x2002F13")]
  public class AreaEventQuestPopupController
  {
    [Token(Token = "0x400CA0D")]
    [FieldOffset(Offset = "0x10")]
    private SubQuestDetailPopup popup;

    [Token(Token = "0x17003E61")]
    public bool IsInitialized
    {
      [Token(Token = "0x6012658"), Address(RVA = "0x2303DF0", Offset = "0x2303DF0", VA = "0x2303DF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6012659")]
    [Address(RVA = "0x2303E50", Offset = "0x2303E50", VA = "0x2303E50")]
    public void Initialize(SubQuestDetailPopup popup)
    {
    }

    [Token(Token = "0x601265A")]
    [Address(RVA = "0x2303E94", Offset = "0x2303E94", VA = "0x2303E94")]
    public void Set(AreaEventQuestData quest, Action positiveAction, Action closeAction)
    {
    }

    [Token(Token = "0x601265B")]
    [Address(RVA = "0x2304394", Offset = "0x2304394", VA = "0x2304394")]
    public void Open()
    {
    }

    [Token(Token = "0x601265C")]
    [Address(RVA = "0x23043E8", Offset = "0x23043E8", VA = "0x23043E8")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601265D")]
    [Address(RVA = "0x2304408", Offset = "0x2304408", VA = "0x2304408")]
    public AreaEventQuestPopupController()
    {
    }
  }
}
