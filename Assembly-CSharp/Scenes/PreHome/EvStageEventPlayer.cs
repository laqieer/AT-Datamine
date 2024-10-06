// Decompiled with JetBrains decompiler
// Type: Scenes.PreHome.EvStageEventPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.PreHome
{
  [Token(Token = "0x2003172")]
  public class EvStageEventPlayer : MonoBehaviour
  {
    [Token(Token = "0x400D29A")]
    [FieldOffset(Offset = "0x18")]
    private Queue<EvStageEventPlayer.PlayContentObj> objs;
    [Token(Token = "0x400D29B")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine nowSequence;

    [Token(Token = "0x60134B7")]
    [Address(RVA = "0x4A2BE98", Offset = "0x4A2BE98", VA = "0x4A2BE98")]
    public EvStageEventPlayer()
    {
    }

    [Token(Token = "0x60134B8")]
    [Address(RVA = "0x4A2BF14", Offset = "0x4A2BF14", VA = "0x4A2BF14")]
    public void Setup(List<EvStageScheduleInfo> infos)
    {
    }

    [Token(Token = "0x60134B9")]
    [Address(RVA = "0x4A2C120", Offset = "0x4A2C120", VA = "0x4A2C120")]
    public void PlayToEnd()
    {
    }

    [Token(Token = "0x60134BA")]
    [Address(RVA = "0x4A2C150", Offset = "0x4A2C150", VA = "0x4A2C150")]
    private IEnumerator PlayToEndSequence() => (IEnumerator) null;

    [Token(Token = "0x60134BB")]
    [Address(RVA = "0x4A2C1E0", Offset = "0x4A2C1E0", VA = "0x4A2C1E0")]
    public bool IsEnded() => new bool();

    [Token(Token = "0x60134BC")]
    [Address(RVA = "0x4A2C234", Offset = "0x4A2C234", VA = "0x4A2C234")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x2003173")]
    public interface PreHomeAdv
    {
    }

    [Token(Token = "0x2003174")]
    private class PreHomeAdvStage : AdvStageBase, EvStageEventPlayer.PreHomeAdv
    {
      [Token(Token = "0x60134BD")]
      [Address(RVA = "0x4A2C3CC", Offset = "0x4A2C3CC", VA = "0x4A2C3CC")]
      public PreHomeAdvStage(AdvDemoInfoData demoInfo, string[] args)
      {
      }
    }

    [Token(Token = "0x2003175")]
    private class PlayContentObj
    {
      [Token(Token = "0x1700407E")]
      private int advdemoId
      {
        [Token(Token = "0x60134BE"), Address(RVA = "0x4A2C510", Offset = "0x4A2C510", VA = "0x4A2C510")] get
        {
          return new int();
        }
        [Token(Token = "0x60134BF"), Address(RVA = "0x4A2C518", Offset = "0x4A2C518", VA = "0x4A2C518")] set
        {
        }
      }

      [Token(Token = "0x1700407F")]
      private int recordId
      {
        [Token(Token = "0x60134C0"), Address(RVA = "0x4A2C520", Offset = "0x4A2C520", VA = "0x4A2C520")] get
        {
          return new int();
        }
        [Token(Token = "0x60134C1"), Address(RVA = "0x4A2C528", Offset = "0x4A2C528", VA = "0x4A2C528")] set
        {
        }
      }

      [Token(Token = "0x17004080")]
      private string[] args
      {
        [Token(Token = "0x60134C2"), Address(RVA = "0x4A2C530", Offset = "0x4A2C530", VA = "0x4A2C530")] get
        {
          return (string[]) null;
        }
        [Token(Token = "0x60134C3"), Address(RVA = "0x4A2C538", Offset = "0x4A2C538", VA = "0x4A2C538")] set
        {
        }
      }

      [Token(Token = "0x60134C4")]
      [Address(RVA = "0x4A2C0E4", Offset = "0x4A2C0E4", VA = "0x4A2C0E4")]
      public PlayContentObj(int advdemoId, int recordId, string[] args)
      {
      }

      [Token(Token = "0x60134C5")]
      [Address(RVA = "0x4A2C540", Offset = "0x4A2C540", VA = "0x4A2C540")]
      public IEnumerator StartToEnd() => (IEnumerator) null;

      [Token(Token = "0x60134C6")]
      [Address(RVA = "0x4A2C5D0", Offset = "0x4A2C5D0", VA = "0x4A2C5D0")]
      private List<EvStageEventPlayer.PreHomeAdvStage> StartAdvs()
      {
        return (List<EvStageEventPlayer.PreHomeAdvStage>) null;
      }

      [Token(Token = "0x60134C7")]
      [Address(RVA = "0x4A2C768", Offset = "0x4A2C768", VA = "0x4A2C768")]
      private void EndAdvs()
      {
      }

      [Token(Token = "0x60134C8")]
      [Address(RVA = "0x4A2C3C8", Offset = "0x4A2C3C8", VA = "0x4A2C3C8")]
      public void OnDestroy()
      {
      }
    }
  }
}
