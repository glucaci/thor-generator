﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Thor.Generator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Thor.Generator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace EventSources
        ///{
        ///    [EventSourceDefinition(Name = Constants.MessageEventSourceName)]
        ///    public interface IMessageEventSource
        ///    {
        ///        [Event(1,
        ///           Level = EventLevel.Verbose,
        ///           Message = &quot;Sent message {correlationId}/{messageId} to {to}.&quot;,
        ///           Version = 1)]
        ///        void MessageSent(Guid messageId, Guid correlationId, string messageType, string from, string to);
        ///    }
        ///}.
        /// </summary>
        internal static string EventSourceWithConstant {
            get {
                return ResourceManager.GetString("EventSourceWithConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace EventSources
        ///{
        ///    [EventSourceDefinition(Name = &quot;Foo&quot;)]
        ///    public interface IMessageEventSource
        ///    {
        ///        [Event(1,
        ///           Level = EventLevel.Verbose,
        ///           Message = &quot;Sent message {correlationId}/{messageId} to {to}.&quot;,
        ///           Version = 1)]
        ///        void MessageSent(Guid messageId, Guid correlationId, string messageType, string from, string to);
        ///    }
        ///}.
        /// </summary>
        internal static string EventSourceWithLiteral {
            get {
                return ResourceManager.GetString("EventSourceWithLiteral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace EventSources
        ///{
        ///    [EventSourceDefinition(Name = &quot;FooEventSource&quot;)]
        ///    public interface IFooEventSource
        ///    {
        ///        [Event(1,
        ///           Level = EventLevel.Verbose,
        ///           Message = &quot;Sent message {correlationId}/{messageId} to {to}.&quot;,
        ///           Version = 1)]
        ///        void One(Guid messageId, Guid correlationId, string messageType, string from, string to);
        ///
        ///	[Event(2,
        ///           Level = EventLevel.Verbose,
        ///           Message = &quot;Sent message {correlationId}/{messageId} to {to}.&quot;, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EventSourceWithTwoMethods {
            get {
                return ResourceManager.GetString("EventSourceWithTwoMethods", resourceCulture);
            }
        }
    }
}
