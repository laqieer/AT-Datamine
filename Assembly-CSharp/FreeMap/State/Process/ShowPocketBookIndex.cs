// Decompiled with JetBrains decompiler
// Type: FreeMap.State.Process.ShowPocketBookIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.SubQuest;
using FreeMap.State.ModeState;
using Il2CppDummyDll;
using Scenes.Story.PocketBook;
using Scenes.Story.PocketBook.StoryIndex;

#nullable disable
namespace FreeMap.State.Process
{
  [Token(Token = "0x20017E9")]
  public class ShowPocketBookIndex : 
    FreeMapProcess,
    IPocketBookEventHandler,
    IPocketBookStoryIndexEventHandler
  {
    [Token(Token = "0x40068E8")]
    [FieldOffset(Offset = "0x34")]
    private PocketBookStoryIndex.Tab.Type tabType;
    [Token(Token = "0x40068E9")]
    [FieldOffset(Offset = "0x38")]
    private IPlayerAreaOperationEvent playerOperation;
    [Token(Token = "0x40068EA")]
    [FieldOffset(Offset = "0x40")]
    private readonly bool backSceneOperation;

    [Token(Token = "0x600873B")]
    [Address(RVA = "0x43D4CF8", Offset = "0x43D4CF8", VA = "0x43D4CF8")]
    public ShowPocketBookIndex(
      FreeMapStateManager entity,
      PocketBookStoryIndex.Tab.Type tabType,
      IPlayerAreaOperationEvent playerOperation,
      bool backSceneOperation = false)
    {
    }

    [Token(Token = "0x600873C")]
    [Address(RVA = "0x43D5664", Offset = "0x43D5664", VA = "0x43D5664", Slot = "4")]
    public override void Begin()
    {
    }

    [Token(Token = "0x1700156A")]
    private IPocketBookStoryIndexEventHandler Scenes\u002EStory\u002EPocketBook\u002EIPocketBookEventHandler\u002EStoryIndex
    {
      [Token(Token = "0x600873D"), Address(RVA = "0x43D580C", Offset = "0x43D580C", VA = "0x43D580C", Slot = "7")] get
      {
        return (IPocketBookStoryIndexEventHandler) null;
      }
    }

    [Token(Token = "0x600873E")]
    [Address(RVA = "0x43D5810", Offset = "0x43D5810", VA = "0x43D5810", Slot = "8")]
    private void Scenes\u002EStory\u002EPocketBook\u002EIPocketBookEventHandler\u002EOnClose()
    {
    }

    [Token(Token = "0x600873F")]
    [Address(RVA = "0x43D5874", Offset = "0x43D5874", VA = "0x43D5874", Slot = "9")]
    private void Scenes\u002EStory\u002EPocketBook\u002EIPocketBookEventHandler\u002EOnTimeSkip()
    {
    }

    [Token(Token = "0x6008740")]
    [Address(RVA = "0x43D5ACC", Offset = "0x43D5ACC", VA = "0x43D5ACC", Slot = "10")]
    private void Scenes\u002EStory\u002EPocketBook\u002EIPocketBookEventHandler\u002EOnOpenKizunaListFromSchedule()
    {
    }

    [Token(Token = "0x6008741")]
    [Address(RVA = "0x43D5C70", Offset = "0x43D5C70", VA = "0x43D5C70", Slot = "11")]
    private void Scenes\u002EStory\u002EPocketBook\u002EIPocketBookEventHandler\u002EOnOpenKizunaListFromMap()
    {
    }

    [Token(Token = "0x6008742")]
    [Address(RVA = "0x43D59C0", Offset = "0x43D59C0", VA = "0x43D59C0")]
    public static void Close()
    {
    }

    [Token(Token = "0x6008743")]
    [Address(RVA = "0x43D5E18", Offset = "0x43D5E18", VA = "0x43D5E18", Slot = "12")]
    private void Scenes\u002EStory\u002EPocketBook\u002EIPocketBookStoryIndexEventHandler\u002EGoto(
      FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6008744")]
    [Address(RVA = "0x43D5F80", Offset = "0x43D5F80", VA = "0x43D5F80")]
    private void OnSubQuest(FreeMapSubQuestEventUIParam param)
    {
    }

    [Token(Token = "0x6008745")]
    [Address(RVA = "0x43D5F84", Offset = "0x43D5F84", VA = "0x43D5F84")]
    private void OnCommunication(FreeMapCommunicationEventUIParam param)
    {
    }

    [Token(Token = "0x6008746")]
    [Address(RVA = "0x43D5F88", Offset = "0x43D5F88", VA = "0x43D5F88")]
    private void OnFacility(FreeMapFacilityEventUIParam param)
    {
    }

    [Token(Token = "0x6008747")]
    [Address(RVA = "0x43D5E1C", Offset = "0x43D5E1C", VA = "0x43D5E1C")]
    private void AutoMove(FreeMapUIParamBase param)
    {
    }
  }
}
