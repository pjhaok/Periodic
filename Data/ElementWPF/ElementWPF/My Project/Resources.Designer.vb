﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Elements.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html lang=en&gt;
        '''
        '''&lt;head&gt;
        '''	&lt;meta charset=utf-8&gt;
        '''	&lt;title&gt;Periodic Table of Elements&lt;/title&gt;
        '''	&lt;!--[if IE]&gt;
        '''        &lt;script src=&quot;http://html5shiv.googlecode.com/svn/trunk/html5.js&quot;&gt;&lt;/script&gt;
        '''        &lt;![endif]--&gt;
        '''	&lt;link rel=stylesheet href=&quot;assets/style.css&quot; type=&quot;text/css&quot;&gt;
        '''	&lt;script src=&quot;assets/script.js&quot; type=&quot;application/javascript&quot;&gt;&lt;/script&gt;
        '''
        '''&lt;/head&gt;
        '''
        '''&lt;body&gt;
        '''	&lt;footer id=&quot;foot&quot;&gt;
        '''		&lt;p&gt;Periodic Table of Elements&lt;/p&gt;
        '''		&lt;a&gt;Info&lt;/a&gt;
        '''		&lt;p&gt;Copyright © CF Studios 2014&lt;/p&gt;
        '''	&lt;/footer&gt;
        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property index() As String
            Get
                Return ResourceManager.GetString("index", resourceCulture)
            End Get
        End Property
    End Module
End Namespace