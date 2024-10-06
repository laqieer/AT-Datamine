// Decompiled with JetBrains decompiler
// Type: Story.ContentBookAdv
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
  [Token(Token = "0x200054F")]
  public sealed class ContentBookAdv : Content, AdvPreLoadTask.IOwner
  {
    [Token(Token = "0x4001BB5")]
    [FieldOffset(Offset = "0x20")]
    private AdvStage advStage;
    [Token(Token = "0x4001BB6")]
    [FieldOffset(Offset = "0x28")]
    private IAdvDirection direction;

    [Token(Token = "0x17000431")]
    private IAdvDirection Story\u002EAdvPreLoadTask\u002EIOwner\u002EDirection
    {
      [Token(Token = "0x6001EB7"), Address(RVA = "0x29FF4D8", Offset = "0x29FF4D8", VA = "0x29FF4D8", Slot = "9")] get
      {
        return (IAdvDirection) null;
      }
    }

    [Token(Token = "0x17000432")]
    private AdvStage Story\u002EAdvPreLoadTask\u002EIOwner\u002EAdvStage
    {
      [Token(Token = "0x6001EB8"), Address(RVA = "0x29FF4E0", Offset = "0x29FF4E0", VA = "0x29FF4E0", Slot = "10")] get
      {
        return (AdvStage) null;
      }
      [Token(Token = "0x6001EB9"), Address(RVA = "0x29FF4E8", Offset = "0x29FF4E8", VA = "0x29FF4E8", Slot = "11")] set
      {
      }
    }

    [Token(Token = "0x6001EBA")]
    [Address(RVA = "0x29FF4F0", Offset = "0x29FF4F0", VA = "0x29FF4F0")]
    public ContentBookAdv(IAdvDirection direction)
    {
    }

    [Token(Token = "0x6001EBB")]
    [Address(RVA = "0x29FF518", Offset = "0x29FF518", VA = "0x29FF518", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001EBC")]
    [Address(RVA = "0x29FF64C", Offset = "0x29FF64C", VA = "0x29FF64C")]
    private IEnumerator Execute() => (IEnumerator) null;

    [Token(Token = "0x6001EBD")]
    [Address(RVA = "0x29FF6DC", Offset = "0x29FF6DC", VA = "0x29FF6DC")]
    private APIStoryMainquestReadRequest CreateRequest() => (APIStoryMainquestReadRequest) null;

    [Token(Token = "0x2000550")]
    public class EndAPI : IContentTask
    {
      [Token(Token = "0x4001BB7")]
      [FieldOffset(Offset = "0x10")]
      private APIStoryMainquestRead api;
      [Token(Token = "0x4001BB8")]
      [FieldOffset(Offset = "0x18")]
      private MainQuestRead result;
      [Token(Token = "0x4001BB9")]
      [FieldOffset(Offset = "0x20")]
      private Func<APIStoryMainquestReadRequest> getRequest;
      [Token(Token = "0x4001BBA")]
      [FieldOffset(Offset = "0x28")]
      private bool isEnd;

      [Token(Token = "0x17000433")]
      public Action<APIStoryMainquestReadResponse> SuccessCallback
      {
        [Token(Token = "0x6001EBE"), Address(RVA = "0x29FF7CC", Offset = "0x29FF7CC", VA = "0x29FF7CC")] set
        {
        }
      }

      [Token(Token = "0x17000434")]
      public Action FailedCallback
      {
        [Token(Token = "0x6001EBF"), Address(RVA = "0x29FF818", Offset = "0x29FF818", VA = "0x29FF818")] set
        {
        }
      }

      [Token(Token = "0x6001EC0")]
      [Address(RVA = "0x29FF864", Offset = "0x29FF864", VA = "0x29FF864")]
      public EndAPI(Func<APIStoryMainquestReadRequest> getRequest)
      {
      }

      [Token(Token = "0x6001EC1")]
      [Address(RVA = "0x29FF928", Offset = "0x29FF928", VA = "0x29FF928", Slot = "6")]
      public bool IsBusy() => new bool();

      [Token(Token = "0x6001EC2")]
      [Address(RVA = "0x29FF938", Offset = "0x29FF938", VA = "0x29FF938", Slot = "4")]
      public IEnumerator Start() => (IEnumerator) null;

      [Token(Token = "0x6001EC3")]
      [Address(RVA = "0x29FF9C8", Offset = "0x29FF9C8", VA = "0x29FF9C8", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }
  }
}
