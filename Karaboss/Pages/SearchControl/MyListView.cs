﻿using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Karaboss.Search
{
    class MyListView : ListView
    {
        public event EventHandler<int> GroupHeaderClick;
        protected virtual void OnGroupHeaderClick(int e)
        {
            var handler = GroupHeaderClick;
            if (handler != null) handler(this, e);
        }
        private const int LVM_HITTEST = 0x1000 + 18;
        private const int LVHT_EX_GROUP_HEADER = 0x10000000;
        [StructLayout(LayoutKind.Sequential)]
        private struct LVHITTESTINFO
        {
            public int pt_x;
            public int pt_y;
            public int flags;
            public int iItem;
            public int iSubItem;
            public int iGroup;
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref LVHITTESTINFO ht);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            var ht = new LVHITTESTINFO() { pt_x = e.X, pt_y = e.Y };
            var value = SendMessage(this.Handle, LVM_HITTEST, -1, ref ht);
            if (value != -1 && (ht.flags & LVHT_EX_GROUP_HEADER) != 0)
                OnGroupHeaderClick(value);
        }
    }

    public static class PropertyHelper
    {
        /// <summary>
        /// Returns a _private_ Property Value from a given Object. Uses Reflection.
        /// Throws a ArgumentOutOfRangeException if the Property is not found.
        /// </summary>
        /// <typeparam name="T">Type of the Property</typeparam>
        /// <param name="obj">Object from where the Property Value is returned</param>
        /// <param name="propName">Propertyname as string.</param>
        /// <returns>PropertyValue</returns>
        public static T GetPrivatePropertyValue<T>(this object obj, string propName)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            PropertyInfo pi = obj.GetType().GetProperty(propName,
                                                        BindingFlags.Public | BindingFlags.NonPublic |
                                                        BindingFlags.Instance);
            if (pi == null)
                throw new ArgumentOutOfRangeException("propName",
                                                      string.Format("Property {0} was not found in Type {1}", propName,
                                                                    obj.GetType().FullName));
            return (T)pi.GetValue(obj, null);
        }

        /// <summary>
        /// Returns a private Field Value from a given Object. Uses Reflection.
        /// Throws a ArgumentOutOfRangeException if the Property is not found.
        /// </summary>
        /// <typeparam name="T">Type of the Field</typeparam>
        /// <param name="obj">Object from where the Field Value is returned</param>
        /// <param name="propName">Field Name as string.</param>
        /// <returns>FieldValue</returns>
        public static T GetPrivateFieldValue<T>(this object obj, string propName)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            Type t = obj.GetType();
            FieldInfo fi = null;
            while (fi == null && t != null)
            {
                fi = t.GetField(propName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                t = t.BaseType;
            }
            if (fi == null)
                throw new ArgumentOutOfRangeException("propName",
                                                      string.Format("Field {0} was not found in Type {1}", propName,
                                                                    obj.GetType().FullName));
            return (T)fi.GetValue(obj);
        }

        /// <summary>
        /// Sets a _private_ Property Value from a given Object. Uses Reflection.
        /// Throws a ArgumentOutOfRangeException if the Property is not found.
        /// </summary>
        /// <typeparam name="T">Type of the Property</typeparam>
        /// <param name="obj">Object from where the Property Value is set</param>
        /// <param name="propName">Propertyname as string.</param>
        /// <param name="val">Value to set.</param>
        /// <returns>PropertyValue</returns>
        public static void SetPrivatePropertyValue<T>(this object obj, string propName, T val)
        {
            Type t = obj.GetType();
            if (t.GetProperty(propName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance) == null)
                throw new ArgumentOutOfRangeException("propName",
                                                      string.Format("Property {0} was not found in Type {1}", propName,
                                                                    obj.GetType().FullName));
            t.InvokeMember(propName,
                           BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty |
                           BindingFlags.Instance, null, obj, new object[] { val });
        }


        /// <summary>
        /// Set a private Field Value on a given Object. Uses Reflection.
        /// </summary>
        /// <typeparam name="T">Type of the Field</typeparam>
        /// <param name="obj">Object from where the Property Value is returned</param>
        /// <param name="propName">Field name as string.</param>
        /// <param name="val">the value to set</param>
        /// <exception cref="ArgumentOutOfRangeException">if the Property is not found</exception>
        public static void SetPrivateFieldValue<T>(this object obj, string propName, T val)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            Type t = obj.GetType();
            FieldInfo fi = null;
            while (fi == null && t != null)
            {
                fi = t.GetField(propName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                t = t.BaseType;
            }
            if (fi == null)
                throw new ArgumentOutOfRangeException("propName",
                                                      string.Format("Field {0} was not found in Type {1}", propName,
                                                                    obj.GetType().FullName));
            fi.SetValue(obj, val);
        }
    }

}
