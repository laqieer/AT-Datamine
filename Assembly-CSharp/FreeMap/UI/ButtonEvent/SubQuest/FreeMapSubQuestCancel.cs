// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.SubQuest.FreeMapSubQuestCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Story.APIResult;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent.SubQuest
{
  [Token(Token = "0x200172D")]
  public class FreeMapSubQuestCancel
  {
    [Token(Token = "0x4006717")]
    [FieldOffset(Offset = "0x10")]
    private APIStorySubquestCancellation api;
    [Token(Token = "0x4006718")]
    [FieldOffset(Offset = "0x18")]
    private SubQuestCancellation result;

    [Token(Token = "0x17001489")]
    public APIStorySubquestCancellationResponse Response
    {
      [Token(Token = "0x6008318"), Address(RVA = "0x42036B0", Offset = "0x42036B0", VA = "0x42036B0")] get
      {
        return (APIStorySubquestCancellationResponse) null;
      }
      [Token(Token = "0x6008319"), Address(RVA = "0x42036B8", Offset = "0x42036B8", VA = "0x42036B8")] private set
      {
      }
    }

    [Token(Token = "0x1700148A")]
    public bool IsProcessing
    {
      [Token(Token = "0x600831A"), Address(RVA = "0x42036C0", Offset = "0x42036C0", VA = "0x42036C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600831B"), Address(RVA = "0x42036C8", Offset = "0x42036C8", VA = "0x42036C8")] private set
      {
      }
    }

    [Token(Token = "0x600831C")]
    [Address(RVA = "0x42036D4", Offset = "0x42036D4", VA = "0x42036D4")]
    public void Execute(int subquestID, IFreeMapLocationControll locationControllMethod)
    {
    }

    [Token(Token = "0x600831D")]
    [Address(RVA = "0x42038D4", Offset = "0x42038D4", VA = "0x42038D4")]
    private IEnumerator APICoroutine(APIStorySubquestCancellationRequest request)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600831E")]
    [Address(RVA = "0x4203970", Offset = "0x4203970", VA = "0x4203970")]
    public FreeMapSubQuestCancel()
    {
    }
  }
}
