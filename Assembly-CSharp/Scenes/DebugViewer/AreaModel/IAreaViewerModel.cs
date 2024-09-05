// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.IAreaViewerModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F81")]
  internal interface IAreaViewerModel : IDebugViewerModel
  {
    [Token(Token = "0x6012932")]
    IEnumerator InitializeAsync();

    [Token(Token = "0x6012933")]
    void Update();

    [Token(Token = "0x6012934")]
    void Destroy();
  }
}
