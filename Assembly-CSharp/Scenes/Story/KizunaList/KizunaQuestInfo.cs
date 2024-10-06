// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using StaqData;
using Story.KizunaQuest;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E92")]
  public class KizunaQuestInfo
  {
    [Token(Token = "0x400C7A6")]
    [FieldOffset(Offset = "0x10")]
    public List<KizunaQuestInfo.KizunaQuestCharacterInfo> CharacterInfo;

    [Token(Token = "0x60122F5")]
    [Address(RVA = "0x45933CC", Offset = "0x45933CC", VA = "0x45933CC")]
    public int GetKizunaCharacterTotalNum() => new int();

    [Token(Token = "0x60122F6")]
    [Address(RVA = "0x45934B8", Offset = "0x45934B8", VA = "0x45934B8")]
    public int GetKizunaCharacterOpenedNum() => new int();

    [Token(Token = "0x60122F7")]
    [Address(RVA = "0x4593500", Offset = "0x4593500", VA = "0x4593500")]
    public KizunaQuestInfo()
    {
    }

    [Token(Token = "0x2002E93")]
    public class Factory
    {
      [Token(Token = "0x400C7A7")]
      [FieldOffset(Offset = "0x10")]
      private readonly int sequenceId;

      [Token(Token = "0x60122F8")]
      [Address(RVA = "0x4591AAC", Offset = "0x4591AAC", VA = "0x4591AAC")]
      public Factory(int sequenceId)
      {
      }

      [Token(Token = "0x60122F9")]
      [Address(RVA = "0x4591AD4", Offset = "0x4591AD4", VA = "0x4591AD4")]
      public KizunaQuestInfo Create() => (KizunaQuestInfo) null;
    }

    [Token(Token = "0x2002E96")]
    public class KizunaQuestCharacterInfo
    {
      [Token(Token = "0x400C7AD")]
      [FieldOffset(Offset = "0x10")]
      public readonly Communication Communication;
      [Token(Token = "0x400C7AE")]
      [FieldOffset(Offset = "0x18")]
      public readonly FreeMapCommunicationEventUIParam CommunicationEventUIParam;
      [Token(Token = "0x400C7AF")]
      [FieldOffset(Offset = "0x20")]
      private readonly int sequenceId;

      [Token(Token = "0x17003DC7")]
      public bool ExistsInSequence
      {
        [Token(Token = "0x6012302"), Address(RVA = "0x45936DC", Offset = "0x45936DC", VA = "0x45936DC")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6012303")]
      [Address(RVA = "0x459357C", Offset = "0x459357C", VA = "0x459357C")]
      public KizunaQuestCharacterInfo(
        Communication communication,
        int sequenceId,
        FreeMapCommunicationEventUIParam uiParam = null)
      {
      }

      [Token(Token = "0x6012304")]
      [Address(RVA = "0x45936F8", Offset = "0x45936F8", VA = "0x45936F8")]
      public IKizunaQuestPopupParam CreatePopupParameter() => (IKizunaQuestPopupParam) null;

      [Token(Token = "0x6012305")]
      [Address(RVA = "0x4593780", Offset = "0x4593780", VA = "0x4593780")]
      public int GetStyleId() => new int();
    }
  }
}
