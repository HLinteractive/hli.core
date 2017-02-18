// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.EditableObject.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

using HLI.Core.Extensions;

namespace HLI.Core.Models
{
    /// <summary>
    ///     <see cref="IEditableObject" /> implementation. Inherits <see cref="NotificationObject" />
    /// </summary>
    public class EditableObject : NotificationObject, IEditableObject
    {
        #region Fields

        private Dictionary<string, object> props;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     <seealso cref="IEditableObject.BeginEdit" />
        /// </summary>
        public void BeginEdit()
        {
            if (null != this.props)
            {
                return;
            }

            // Enumerate properties
            var properties = this.GetType().GetRuntimeProperties().ToList();
            this.props = new Dictionary<string, object>(properties.Count - 1);

            foreach (var t in properties)
            {
                // check if there is set accessor
                if (t == null || t.GetMethod == null)
                {
                    continue;
                }

                var value = t.GetValue(this, null).DeepClone();
                this.props.Add(t.Name, value);
            }
        }

        /// <summary>
        ///     <seealso cref="IEditableObject.CancelEdit" />
        /// </summary>
        public void CancelEdit()
        {
            // Check for inappropriate call sequence
            if (null == this.props)
            {
                return;
            }

            // restore old values
            var properties = this.GetType().GetRuntimeProperties().ToList();
            for (var i = 0; i < properties.Count(); i++)
            {
                // check if there is set accessor
                if (properties[i].SetMethod == null)
                {
                    continue;
                }

                var value = this.props[properties[i].Name];
                properties[i].SetValue(this, value, null);
            }

            // Delete current values
            this.props = null;
        }

        /// <summary>
        ///     <seealso cref="IEditableObject.EndEdit" />
        /// </summary>
        public void EndEdit()
        {
            // delete current values
            this.props = null;
        }

        #endregion
    }
}