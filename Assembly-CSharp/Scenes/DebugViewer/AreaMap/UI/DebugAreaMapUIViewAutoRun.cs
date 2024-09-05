// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIViewAutoRun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F59")]
  internal class DebugAreaMapUIViewAutoRun : DebugAreaMapUIViewBase
  {
    [Token(Token = "0x400CAE9")]
    [FieldOffset(Offset = "0x28")]
    private readonly Color[] GizmosColorTable;
    [Token(Token = "0x400CAEA")]
    [FieldOffset(Offset = "0x30")]
    private Vector2 scrollViewPosition;
    [Token(Token = "0x400CAEB")]
    [FieldOffset(Offset = "0x38")]
    private GUIDropdown anchor;
    [Token(Token = "0x400CAEC")]
    [FieldOffset(Offset = "0x40")]
    private NavMeshPath path;
    [Token(Token = "0x400CAED")]
    [FieldOffset(Offset = "0x48")]
    private MeshFilter[] meshes;
    [Token(Token = "0x400CAEE")]
    [FieldOffset(Offset = "0x50")]
    private Texture2D colorTexture;

    [Token(Token = "0x14000197")]
    public event EventHandler<string> OnStartRun
    {
      [Token(Token = "0x6012816"), Address(RVA = "0x211AB5C", Offset = "0x211AB5C", VA = "0x211AB5C")] add
      {
      }
      [Token(Token = "0x6012817"), Address(RVA = "0x21219A4", Offset = "0x21219A4", VA = "0x21219A4")] remove
      {
      }
    }

    [Token(Token = "0x14000198")]
    public event EventHandler OnStopRun
    {
      [Token(Token = "0x6012818"), Address(RVA = "0x211AC0C", Offset = "0x211AC0C", VA = "0x211AC0C")] add
      {
      }
      [Token(Token = "0x6012819"), Address(RVA = "0x2121A54", Offset = "0x2121A54", VA = "0x2121A54")] remove
      {
      }
    }

    [Token(Token = "0x14000199")]
    public event EventHandler OnShowGizmos
    {
      [Token(Token = "0x601281A"), Address(RVA = "0x211ACA8", Offset = "0x211ACA8", VA = "0x211ACA8")] add
      {
      }
      [Token(Token = "0x601281B"), Address(RVA = "0x2121AF0", Offset = "0x2121AF0", VA = "0x2121AF0")] remove
      {
      }
    }

    [Token(Token = "0x1400019A")]
    public event DebugAreaMapUIViewAutoRun.GetNavMeshPath OnGetNavMeshPath
    {
      [Token(Token = "0x601281C"), Address(RVA = "0x211AE18", Offset = "0x211AE18", VA = "0x211AE18")] add
      {
      }
      [Token(Token = "0x601281D"), Address(RVA = "0x2121B8C", Offset = "0x2121B8C", VA = "0x2121B8C")] remove
      {
      }
    }

    [Token(Token = "0x601281E")]
    [Address(RVA = "0x211AA48", Offset = "0x211AA48", VA = "0x211AA48")]
    public DebugAreaMapUIViewAutoRun()
    {
    }

    [Token(Token = "0x601281F")]
    [Address(RVA = "0x2121C70", Offset = "0x2121C70", VA = "0x2121C70", Slot = "11")]
    public override void OnGUI()
    {
    }

    [Token(Token = "0x6012820")]
    [Address(RVA = "0x2121D78", Offset = "0x2121D78", VA = "0x2121D78", Slot = "13")]
    protected override void DoMainWindow(int windowId)
    {
    }

    [Token(Token = "0x6012821")]
    [Address(RVA = "0x212254C", Offset = "0x212254C", VA = "0x212254C", Slot = "12")]
    public override void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6012822")]
    [Address(RVA = "0x21221D8", Offset = "0x21221D8", VA = "0x21221D8")]
    private void UpdateNavMeshPath()
    {
    }

    [Token(Token = "0x6012823")]
    [Address(RVA = "0x2122660", Offset = "0x2122660", VA = "0x2122660")]
    private void DrawNavMeshPath(NavMeshPath path)
    {
    }

    [Token(Token = "0x6012824")]
    [Address(RVA = "0x21226C8", Offset = "0x21226C8", VA = "0x21226C8")]
    private void DrawMesh(Color color, MeshFilter mesh)
    {
    }

    [Token(Token = "0x6012825")]
    [Address(RVA = "0x212225C", Offset = "0x212225C", VA = "0x212225C")]
    private void DrawMeshInfo(Color color, MeshFilter mesh)
    {
    }

    [Token(Token = "0x6012826")]
    [Address(RVA = "0x211D7E4", Offset = "0x211D7E4", VA = "0x211D7E4")]
    public void SetAnchorList(List<string> list)
    {
    }

    [Token(Token = "0x6012827")]
    [Address(RVA = "0x2122868", Offset = "0x2122868", VA = "0x2122868")]
    public void SetMeshes(MeshFilter[] meshes)
    {
    }

    [Token(Token = "0x2002F5A")]
    public delegate NavMeshPath GetNavMeshPath(string anchorName);
  }
}
