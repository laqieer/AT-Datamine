// Decompiled with JetBrains decompiler
// Type: Story.ContentAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using Story.Adv;
using Story.APIResult;
using System;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000540")]
  public sealed class ContentAdv : Content, AdvPreLoadTask.IOwner
  {
    [Token(Token = "0x4001B93")]
    [FieldOffset(Offset = "0x20")]
    private AdvStage advStage;
    [Token(Token = "0x4001B94")]
    [FieldOffset(Offset = "0x28")]
    private IAdvDirection direction;

    [Token(Token = "0x17000423")]
    private IAdvDirection Story\u002EAdvPreLoadTask\u002EIOwner\u002EDirection
    {
      [Token(Token = "0x6001E72"), Address(RVA = "0x29FD420", Offset = "0x29FD420", VA = "0x29FD420", Slot = "9")] get
      {
        return (IAdvDirection) null;
      }
    }

    [Token(Token = "0x17000424")]
    private AdvStage Story\u002EAdvPreLoadTask\u002EIOwner\u002EAdvStage
    {
      [Token(Token = "0x6001E73"), Address(RVA = "0x29FD428", Offset = "0x29FD428", VA = "0x29FD428", Slot = "10")] get
      {
        return (AdvStage) null;
      }
      [Token(Token = "0x6001E74"), Address(RVA = "0x29FD430", Offset = "0x29FD430", VA = "0x29FD430", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x6001E75")]
    [Address(RVA = "0x29FD438", Offset = "0x29FD438", VA = "0x29FD438")]
    public ContentAdv(IAdvDirection direction)
    {
    }

    [Token(Token = "0x6001E76")]
    [Address(RVA = "0x29FD460", Offset = "0x29FD460", VA = "0x29FD460", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001E77")]
    [Address(RVA = "0x29FD650", Offset = "0x29FD650", VA = "0x29FD650")]
    private IEnumerator Execute() => (IEnumerator) null;

    [Token(Token = "0x6001E78")]
    [Address(RVA = "0x29FD6E0", Offset = "0x29FD6E0", VA = "0x29FD6E0")]
    private APIStoryMainquestAdvRequest CreateRequest() => (APIStoryMainquestAdvRequest) null;

    [Token(Token = "0x2000541")]
    public class EndAPI : IContentTask
    {
      [Token(Token = "0x4001B95")]
      [FieldOffset(Offset = "0x10")]
      private APIStoryMainquestAdv api;
      [Token(Token = "0x4001B96")]
      [FieldOffset(Offset = "0x18")]
      private MainQuestADVEnd result;
      [Token(Token = "0x4001B97")]
      [FieldOffset(Offset = "0x20")]
      private Func<APIStoryMainquestAdvRequest> getRequest;
      [Token(Token = "0x4001B98")]
      [FieldOffset(Offset = "0x28")]
      private bool isEnd;

      [Token(Token = "0x17000425")]
      public Action<APIStoryMainquestAdvResponse> SuccessCallback
      {
        [Token(Token = "0x6001E79"), Address(RVA = "0x29FD834", Offset = "0x29FD834", VA = "0x29FD834")] set
        {
        }
      }

      [Token(Token = "0x17000426")]
      public Action FailedCallback
      {
        [Token(Token = "0x6001E7A"), Address(RVA = "0x29FD880", Offset = "0x29FD880", VA = "0x29FD880")] set
        {
        }
      }

      [Token(Token = "0x6001E7B")]
      [Address(RVA = "0x29FD8CC", Offset = "0x29FD8CC", VA = "0x29FD8CC")]
      public EndAPI(Func<APIStoryMainquestAdvRequest> getRequest)
      {
      }

      [Token(Token = "0x6001E7C")]
      [Address(RVA = "0x29FD990", Offset = "0x29FD990", VA = "0x29FD990", Slot = "6")]
      public bool IsBusy() => new bool();

      [Token(Token = "0x6001E7D")]
      [Address(RVA = "0x29FD9A0", Offset = "0x29FD9A0", VA = "0x29FD9A0", Slot = "4")]
      public IEnumerator Start() => (IEnumerator) null;

      [Token(Token = "0x6001E7E")]
      [Address(RVA = "0x29FDA30", Offset = "0x29FDA30", VA = "0x29FDA30")]
      private void OnSuccess(
        APIStoryMainquestAdvRequest request,
        APIStoryMainquestAdvResponse response)
      {
      }

      [Token(Token = "0x6001E7F")]
      [Address(RVA = "0x29FDAA4", Offset = "0x29FDAA4", VA = "0x29FDAA4", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }
  }
}
