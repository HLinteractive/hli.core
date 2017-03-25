![HL Interactive](https://www.dropbox.com/s/fdyzvkso9zs9ndf/HLi.Signature.DVDs.jpg?dl=1)
> HL Interactive (HLi) Source Code Readme
> Copyright © HL Interactive 2015, Thomas Hagström,
> Horisontvägen 85, Stockholm, Sweden

# <a name="hlicore"></a>HLI.Core #
HL Interactive core project where global .Net (Portable) code is kept to provide base classes, extensions etc.

## Purpose and Scope ##
This project contains a **[ModelBase](#modelbase)** class and other common C# code.

## Solution File Structure ##
* **HLI.Core** - solution root directory
	* **HLI.Core (Portable)** - main project
		* **Extensions** - common extensions to .Net classes
		* **Interfaces** - interfaces used by project
			* **Models** - model interfaces
			* **Repositories** - repository pattern interfaces
		* **Models** - base models to simplify validation, serialization, change tracking etc.
	* **HLI.Core.Tests** - unit tests (MS Test)
		* **Mocks**

## <a name="usage"></a>Usage ##
### Installation ###
Download the nuget package through Package Manager Console:

> install-package HLI.Core

You can also clone the package on GitHub:

* [https://github.com/HLinteractive/hli.core](https://github.com/HLinteractive/hli.core "HLI.Core on GitHub")

### Model Base ###
For business objects / models; inherit one of the base classes:

* <a name="modelbase"></a>**ModelBase** - inherits *AuditedObject* and implements change tracking, notification, filtering. This gives a complete model with little effort. Inherits all of the below.
* **AuditedObject** - `IObjectWithAudit` implementation that inherits *EditableObject*. Provides base properties
	* `Created:DateTime`
	* `Updated:DateTime`
	* `Version:int`
	* `Id:Guid` 
* **NotificationObject**: `INotifyPropertyChanged` implementation with *SetProperty* methods
* **EditableObject** - `IEditableObject` implementation allowing change tracking by calling *BeginEdit, CancelEdit* and *EndEdit*

### Extensions ###
Common portable extensions to avoid code copy (i.e re-inventing the wheel).

* **EnumerableExtensions** - *IndexOf* method accepting an object
* **ExpressionExtensions** - *ToPropertyName* method acccepting an `Expression`
* **ObjectExtensions** - provides the following methods:
	* *StreamToByte* accepting an `Stream`
	* *DeepClone* accepting an `object`
	* *GetValueForProperty* accepting a property name by `string` or `Expression`

### Other ###
Other nifty code to keep you going:

* **DateTimeSpan** - because it's missing from .Net

# Deployment #
Package for NuGet by running `dotnet cli`. A post build task generates the package using `project.json`.

    nuget build HLI.Core

Publish the generated .nupkg to NuGet official feed.