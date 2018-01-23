﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.UIElements.IUxmlAttributes
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

namespace UnityEngine.Experimental.UIElements
{
  public interface IUxmlAttributes
  {
    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <returns>
    ///   <para>The raw value or null if not found.</para>
    /// </returns>
    string GetPropertyString(string propertyName);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <param name="defaultValue">Default value if the property is not found.</param>
    /// <returns>
    ///   <para>The attribute value or the default value if not found.</para>
    /// </returns>
    long GetPropertyLong(string propertyName, long defaultValue);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <param name="def">Default value if the property is not found.</param>
    /// <returns>
    ///   <para>The attribute value or the default value if not found.</para>
    /// </returns>
    float GetPropertyFloat(string propertyName, float def);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <param name="def">Default value if the property is not found.</param>
    /// <returns>
    ///   <para>The attribute value or the default value if not found.</para>
    /// </returns>
    int GetPropertyInt(string propertyName, int def);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <param name="def">Default value if the property is not found.</param>
    /// <returns>
    ///   <para>The attribute value or the default value if not found.</para>
    /// </returns>
    bool GetPropertyBool(string propertyName, bool def);

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="propertyName">Attribute name.</param>
    /// <param name="def">Default value if the property is not found.</param>
    /// <returns>
    ///   <para>The attribute value or the default value if not found.</para>
    /// </returns>
    Color GetPropertyColor(string propertyName, Color def);

    T GetPropertyEnum<T>(string propertyName, T def);
  }
}