﻿// Decompiled with JetBrains decompiler
// Type: UnityEditorInternal.ProjectSettingsBaseEditor
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using UnityEditor;

namespace UnityEditorInternal
{
  [CustomEditor(typeof (ProjectSettingsBase), true)]
  internal class ProjectSettingsBaseEditor : Editor
  {
    protected override bool ShouldHideOpenButton()
    {
      return true;
    }
  }
}