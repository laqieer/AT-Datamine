// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowPopupSubQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.ModeState;
using FreeMap.UI.Popup;
using Il2CppDummyDll;
using Scenes.Story.SubQuest;
using StaqData;
using System.Collections;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017EA")]
  public class ShowPopupSubQuest : FreeMapMethodProcess
  {
    [Token(Token = "0x40068ED")]
    [FieldOffset(Offset = "0x30")]
    private Loader<QuestPopup> loader;
    [Token(Token = "0x40068EE")]
    [FieldOffset(Offset = "0x38")]
    private int subquestID;

    [Token(Token = "0x1700156B")]
    public QuestPopupHandler PopupHandler
    {
      [Token(Token = "0x6008749"), Address(RVA = "0x43D605C", Offset = "0x43D605C", VA = "0x43D605C")] get
      {
        return (QuestPopupHandler) null;
      }
    }

    [Token(Token = "0x1700156C")]
    public SubQuestDetailPopupToaster Toaster
    {
      [Token(Token = "0x600874A"), Address(RVA = "0x43D6064", Offset = "0x43D6064", VA = "0x43D6064")] get
      {
        return (SubQuestDetailPopupToaster) null;
      }
      [Token(Token = "0x600874B"), Address(RVA = "0x43D606C", Offset = "0x43D606C", VA = "0x43D606C")] private set
      {
      }
    }

    [Token(Token = "0x600874C")]
    [Address(RVA = "0x43D6074", Offset = "0x43D6074", VA = "0x43D6074")]
    public ShowPopupSubQuest(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600874D")]
    [Address(RVA = "0x43D60E8", Offset = "0x43D60E8", VA = "0x43D60E8")]
    public ShowPopupSubQuest(FreeMapStateManager entity, Loader<QuestPopup> loader)
    {
    }

    [Token(Token = "0x600874E")]
    [Address(RVA = "0x43D6168", Offset = "0x43D6168", VA = "0x43D6168")]
    public void Initialize(
      int subquestID,
      SubQuestDataSetter dataSetter,
      QuestUIStateHandler stateHandler,
      IQuestUIEvent uiEvent)
    {
    }

    [Token(Token = "0x600874F")]
    [Address(RVA = "0x43D618C", Offset = "0x43D618C", VA = "0x43D618C", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x6008750")]
    [Address(RVA = "0x43D6288", Offset = "0x43D6288", VA = "0x43D6288")]
    public void Close()
    {
    }

    [Token(Token = "0x6008751")]
    [Address(RVA = "0x43D6220", Offset = "0x43D6220", VA = "0x43D6220")]
    private IEnumerator Setup() => (IEnumerator) null;

    [Token(Token = "0x6008752")]
    [Address(RVA = "0x43D62E8", Offset = "0x43D62E8", VA = "0x43D62E8")]
    public void GotoTarget(IPlayerAreaOperationEvent playerOperation, SubQuestData subquest)
    {
    }
  }
}
