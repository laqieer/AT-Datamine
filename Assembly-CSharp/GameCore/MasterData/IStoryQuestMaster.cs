﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IStoryQuestMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200142E")]
  public interface IStoryQuestMaster
  {
    [Token(Token = "0x6007194")]
    IStoryQuestData GetQuestData(int questID);
  }
}
