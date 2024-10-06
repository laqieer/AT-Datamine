// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.IKizunaQuestPopupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x200067B")]
  public interface IKizunaQuestPopupParam
  {
    [Token(Token = "0x1700056E")]
    Communication CommunicationData { [Token(Token = "0x6002511")] get; }

    [Token(Token = "0x6002512")]
    bool CanProceedKizunaQuest();
  }
}
