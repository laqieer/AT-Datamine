// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryChapterType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE6")]
  [Serializable]
  public class PlayerStoryChapterType
  {
    [Token(Token = "0x4007359")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int chapter_id;
    [Token(Token = "0x400735A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int loop_count;
    [Token(Token = "0x400735B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int main_quest_sequence_id;

    [Token(Token = "0x17001BBB")]
    public int ChapterId
    {
      [Token(Token = "0x6009CC7"), Address(RVA = "0x48F26DC", Offset = "0x48F26DC", VA = "0x48F26DC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CC8"), Address(RVA = "0x48F26E4", Offset = "0x48F26E4", VA = "0x48F26E4")] set
      {
      }
    }

    [Token(Token = "0x17001BBC")]
    public int LoopCount
    {
      [Token(Token = "0x6009CC9"), Address(RVA = "0x48F26EC", Offset = "0x48F26EC", VA = "0x48F26EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CCA"), Address(RVA = "0x48F26F4", Offset = "0x48F26F4", VA = "0x48F26F4")] set
      {
      }
    }

    [Token(Token = "0x17001BBD")]
    public int MainQuestSequenceId
    {
      [Token(Token = "0x6009CCB"), Address(RVA = "0x48F26FC", Offset = "0x48F26FC", VA = "0x48F26FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CCC"), Address(RVA = "0x48F2704", Offset = "0x48F2704", VA = "0x48F2704")] set
      {
      }
    }

    [Token(Token = "0x6009CCD")]
    [Address(RVA = "0x48F270C", Offset = "0x48F270C", VA = "0x48F270C")]
    public PlayerStoryChapterType()
    {
    }
  }
}
