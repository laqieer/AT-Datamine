// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.GenerateUIParamFromDataTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam.AreaEvent;
using FreeMap.Parameter.UIParam.SubQuest;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using StaqData.Story;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x2001879")]
  public static class GenerateUIParamFromDataTable
  {
    [Token(Token = "0x6008ADD")]
    [Address(RVA = "0x45234B4", Offset = "0x45234B4", VA = "0x45234B4")]
    public static FreeMapPassiveMessageParam CreatePassiveMsgParam(
      StoryFreeActionTalkBalloonEventData data)
    {
      return (FreeMapPassiveMessageParam) null;
    }

    [Token(Token = "0x6008ADE")]
    [Address(RVA = "0x4523548", Offset = "0x4523548", VA = "0x4523548")]
    public static FreeMapADVEventUIParam CreateADVEventParam(StoryFreeActionTalkADVEventData data)
    {
      return (FreeMapADVEventUIParam) null;
    }

    [Token(Token = "0x6008ADF")]
    [Address(RVA = "0x4523608", Offset = "0x4523608", VA = "0x4523608")]
    public static FreeMapSystemMenuEventUIParam CreateSystemMenuEventParam(
      StoryFreeActionSystemMenuEventData data)
    {
      return (FreeMapSystemMenuEventUIParam) null;
    }

    [Token(Token = "0x6008AE0")]
    [Address(RVA = "0x45236C4", Offset = "0x45236C4", VA = "0x45236C4")]
    public static FreeMapCommunicationEventUIParam CreateCommunicationEventParam(
      StoryCommunicationAttachData data)
    {
      return (FreeMapCommunicationEventUIParam) null;
    }

    [Token(Token = "0x6008AE1")]
    [Address(RVA = "0x4523778", Offset = "0x4523778", VA = "0x4523778")]
    public static FreeMapStoryShopEventUIParam CreateNpccommunicationStoryShopEventUIParam(
      StoryShop storyShop)
    {
      return (FreeMapStoryShopEventUIParam) null;
    }

    [Token(Token = "0x6008AE2")]
    [Address(RVA = "0x45237D8", Offset = "0x45237D8", VA = "0x45237D8")]
    public static FreeMapFacilityEventUIParam CreateFacilityEventUIParam(Facility data)
    {
      return (FreeMapFacilityEventUIParam) null;
    }

    [Token(Token = "0x6008AE3")]
    [Address(RVA = "0x45238EC", Offset = "0x45238EC", VA = "0x45238EC")]
    public static FreeMapSubQuestReceiptEventUIParam CreateSubQuestReceiptUIParam(
      SubQuestReceiptInfo receiptInfo)
    {
      return (FreeMapSubQuestReceiptEventUIParam) null;
    }

    [Token(Token = "0x6008AE4")]
    [Address(RVA = "0x45239C8", Offset = "0x45239C8", VA = "0x45239C8")]
    public static FreeMapSubQuestReceiptedEventUIParam CreateSubQuestReceiptedUIParam(
      SubQuestReceiptInfo receiptInfo)
    {
      return (FreeMapSubQuestReceiptedEventUIParam) null;
    }

    [Token(Token = "0x6008AE5")]
    [Address(RVA = "0x4523AA4", Offset = "0x4523AA4", VA = "0x4523AA4")]
    public static FreeMapAreaEventQuestEventUIParam CreateAreaEventQuestTaskParam(
      StoryAreaEventQuestTaskData taskData)
    {
      return (FreeMapAreaEventQuestEventUIParam) null;
    }

    [Token(Token = "0x6008AE6")]
    [Address(RVA = "0x4523B60", Offset = "0x4523B60", VA = "0x4523B60")]
    public static FreeMapFlavorUIParam CreateFlavorUIParam(StoryFreeActionFlavorObjectData data)
    {
      return (FreeMapFlavorUIParam) null;
    }
  }
}
