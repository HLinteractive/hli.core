// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Core.IModelBase.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2016
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

#if NET40
using System;
using System.Runtime.Serialization;
#elif PORTABLE
using System;
using System.Runtime.Serialization;
#endif
using System.ComponentModel;

namespace HLI.Core.Interfaces.Models
{
    /// <summary>
    ///     Base class for HLI Models, declaring change tracking, notification, validation etc.
    /// </summary>
    public interface IModelBase : IFilterableObject, IChangeTracking, INotifyPropertyChanged, IEditableObject, IValidationActive, IObjectWithAudit
    {
    }
}