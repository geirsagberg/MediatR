/*
The MIT License (MIT)

Copyright (c) 2016 Maksim Volkau

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

/*
========================================================================================================
NOTE: The code below is generated automatically at compile-time and not supposed to be changed by hand.
========================================================================================================
There are 4 generation issues (may be not an error dependent on context):

The issues with run-time registrations may be solved by `container.RegisterPlaceholder<T>()` 
in Registrations.ttinclude. Then you can replace placeholders using `DryIocZero.Container.Register`
at runtime.

--------------------------------------------------------------------------------------------------------
1. MediatR.Pipeline.IRequestPreProcessor<>
Error: Resolving open-generic service type is not possible for type: MediatR.Pipeline.IRequestPreProcessor<>.
2. MediatR.INotificationHandler<MediatR.Examples.Ponged> {RequiredServiceType=MediatR.INotificationHandler<>}
Error: Open-generic service does not match with registered open-generic implementation constraints MediatR.Examples.ConstrainedPingedHandler<> when resolving: MediatR.Examples.ConstrainedPingedHandler<>: MediatR.INotificationHandler<MediatR.Examples.Ponged> {RequiredServiceType=MediatR.INotificationHandler<>} #42
  from container.
3. MediatR.Pipeline.IRequestPostProcessor<,> {ServiceKey=DefaultKey(0)}
Error: Resolving open-generic service type is not possible for type: MediatR.Pipeline.IRequestPostProcessor<,>.
4. MediatR.Pipeline.IRequestPostProcessor<,> {ServiceKey=DefaultKey(1)}
Error: Resolving open-generic service type is not possible for type: MediatR.Pipeline.IRequestPostProcessor<,>.
*/

using System;
using System.Linq; // for Enumerable.Cast method required by LazyEnumerable<T>
using System.Collections.Generic;
using System.Threading;
using ImTools;
using static DryIocZero.ResolveManyResult;
    
namespace DryIocZero
{
    partial class Container
    {
        [ExcludeFromCodeCoverage]
        partial void GetLastGeneratedFactoryID(ref int lastFactoryID)
        {
            lastFactoryID = 60; // generated: equals to last used Factory.FactoryID 
        }

        [ExcludeFromCodeCoverage]
        partial void ResolveGenerated(ref object service, Type serviceType)
        {
            if (serviceType == typeof(MediatR.IRequestHandler<MediatR.Examples.Jing>))
                service = Get0_IRequestHandler(this);

            else
            if (serviceType == typeof(MediatR.IMediator))
                service = Get1_IMediator(this);

            else
            if (serviceType == typeof(MediatR.IRequestHandler<MediatR.Examples.Ping, MediatR.Examples.Pong>))
                service = Get4_IRequestHandler(this);

            else
            if (serviceType == typeof(MediatR.IRequest<MediatR.Examples.Pong>))
                service = Get5_IRequest(this);

            else
            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.Examples.Ponged>))
                service = Get6_INotificationHandler(this);

            else
            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.INotification>))
                service = Get7_INotificationHandler(this);

            else
            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>))
                service = Get16_INotificationHandler(this);

            else
            if (serviceType == typeof(MediatR.IRequest))
                service = Get17_IRequest(this);

            else
            if (serviceType == typeof(MediatR.IRequest<MediatR.Unit>))
                service = Get20_IRequest(this);
        }

        [ExcludeFromCodeCoverage]
        partial void ResolveGenerated(ref object service,
            Type serviceType, object serviceKey, Type requiredServiceType, Request preRequestParent, object[] args)
        {
            if (serviceType == typeof(MediatR.INotification)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    service = Get2_INotification(this);

                else
                if (DefaultKey.Of(1).Equals(serviceKey))
                    service = Get3_INotification(this);
            }

            else
            if (serviceType == typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    service = Get8_IPipelineBehavior(this);

                else
                if (DefaultKey.Of(1).Equals(serviceKey))
                    service = Get10_IPipelineBehavior(this);

                else
                if (DefaultKey.Of(2).Equals(serviceKey))
                    service = Get12_IPipelineBehavior(this);
            }

            else
            if (serviceType == typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    service = Get9_IPipelineBehavior(this);

                else
                if (DefaultKey.Of(1).Equals(serviceKey))
                    service = Get11_IPipelineBehavior(this);

                else
                if (DefaultKey.Of(2).Equals(serviceKey))
                    service = Get13_IPipelineBehavior(this);
            }

            else
            if (serviceType == typeof(MediatR.IBaseRequest)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    service = Get14_IBaseRequest(this);

                else
                if (DefaultKey.Of(1).Equals(serviceKey))
                    service = Get15_IBaseRequest(this);
            }

            else
            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>)) 
            {
                if (DefaultKey.Of(0).Equals(serviceKey))
                    service = Get18_INotificationHandler(this);

                else
                if (DefaultKey.Of(1).Equals(serviceKey))
                    service = Get19_INotificationHandler(this);
            }
        }

        [ExcludeFromCodeCoverage]
        partial void ResolveManyGenerated(ref IEnumerable<ResolveManyResult> services, Type serviceType) 
        {
            services = ResolveManyGenerated(serviceType);
        }

        [ExcludeFromCodeCoverage]
        private IEnumerable<ResolveManyResult> ResolveManyGenerated(Type serviceType)
        {
            if (serviceType == typeof(MediatR.IRequestHandler<MediatR.Examples.Jing>))
            {
                yield return Of(Get0_IRequestHandler);
            }

            if (serviceType == typeof(MediatR.IMediator))
            {
                yield return Of(Get1_IMediator);
            }

            if (serviceType == typeof(MediatR.INotification))
            {
                yield return Of(Get2_INotification, DefaultKey.Of(0));
                yield return Of(Get3_INotification, DefaultKey.Of(1));
            }

            if (serviceType == typeof(MediatR.IRequestHandler<MediatR.Examples.Ping, MediatR.Examples.Pong>))
            {
                yield return Of(Get4_IRequestHandler);
            }

            if (serviceType == typeof(MediatR.IRequest<MediatR.Examples.Pong>))
            {
                yield return Of(Get5_IRequest);
            }

            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.Examples.Ponged>))
            {
                yield return Of(Get6_INotificationHandler);
                yield return Of(Get7_INotificationHandler); // co-variant
            }

            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.INotification>))
            {
                yield return Of(Get7_INotificationHandler);
            }

            if (serviceType == typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>))
            {
                yield return Of(Get8_IPipelineBehavior, DefaultKey.Of(0), typeof(MediatR.IPipelineBehavior<,>));
                yield return Of(Get10_IPipelineBehavior, DefaultKey.Of(1), typeof(MediatR.IPipelineBehavior<,>));
                yield return Of(Get12_IPipelineBehavior, DefaultKey.Of(2), typeof(MediatR.IPipelineBehavior<,>));
            }

            if (serviceType == typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>))
            {
                yield return Of(Get9_IPipelineBehavior, DefaultKey.Of(0), typeof(MediatR.IPipelineBehavior<,>));
                yield return Of(Get11_IPipelineBehavior, DefaultKey.Of(1), typeof(MediatR.IPipelineBehavior<,>));
                yield return Of(Get13_IPipelineBehavior, DefaultKey.Of(2), typeof(MediatR.IPipelineBehavior<,>));
            }

            if (serviceType == typeof(MediatR.IBaseRequest))
            {
                yield return Of(Get14_IBaseRequest, DefaultKey.Of(0));
                yield return Of(Get15_IBaseRequest, DefaultKey.Of(1));
            }

            if (serviceType == typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>))
            {
                yield return Of(Get16_INotificationHandler, typeof(MediatR.INotificationHandler<>));
                yield return Of(Get18_INotificationHandler, DefaultKey.Of(0));
                yield return Of(Get19_INotificationHandler, DefaultKey.Of(1));
                yield return Of(Get7_INotificationHandler); // co-variant
            }

            if (serviceType == typeof(MediatR.IRequest))
            {
                yield return Of(Get17_IRequest);
            }

            if (serviceType == typeof(MediatR.IRequest<MediatR.Unit>))
            {
                yield return Of(Get20_IRequest);
            }

        }

        // typeof(MediatR.IRequestHandler<MediatR.Examples.Jing>)
        internal static object Get0_IRequestHandler(IResolverContext r)
        {
            return new MediatR.Examples.JingHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IRequestHandler<MediatR.Examples.Jing>), default(System.Type), (object)null, 37, FactoryType.Service, typeof(MediatR.Examples.JingHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IMediator)
        internal static object Get1_IMediator(IResolverContext r)
        {
            return new MediatR.Mediator((MediatR.SingleInstanceFactory)r.Resolve(typeof(MediatR.SingleInstanceFactory), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IMediator), default(System.Type), (object)null, 28, FactoryType.Service, typeof(MediatR.Mediator), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])), (MediatR.MultiInstanceFactory)r.Resolve(typeof(MediatR.MultiInstanceFactory), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IMediator), default(System.Type), (object)null, 28, FactoryType.Service, typeof(MediatR.Mediator), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.INotification)
        internal static object Get2_INotification(IResolverContext r)
        {
            return new MediatR.Examples.Pinged();
        }

        // typeof(MediatR.INotification)
        internal static object Get3_INotification(IResolverContext r)
        {
            return new MediatR.Examples.Ponged();
        }

        // typeof(MediatR.IRequestHandler<MediatR.Examples.Ping, MediatR.Examples.Pong>)
        internal static object Get4_IRequestHandler(IResolverContext r)
        {
            return new MediatR.Examples.PingHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IRequestHandler<MediatR.Examples.Ping, MediatR.Examples.Pong>), default(System.Type), (object)null, 44, FactoryType.Service, typeof(MediatR.Examples.PingHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IRequest<MediatR.Examples.Pong>)
        internal static object Get5_IRequest(IResolverContext r)
        {
            return new MediatR.Examples.Ping();
        }

        // typeof(MediatR.INotificationHandler<MediatR.Examples.Ponged>)
        internal static object Get6_INotificationHandler(IResolverContext r)
        {
            return new MediatR.Examples.PongedHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.INotificationHandler<MediatR.Examples.Ponged>), default(System.Type), (object)null, 41, FactoryType.Service, typeof(MediatR.Examples.PongedHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.INotificationHandler<MediatR.INotification>)
        internal static object Get7_INotificationHandler(IResolverContext r)
        {
            return new MediatR.Examples.GenericHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.INotificationHandler<MediatR.INotification>), default(System.Type), (object)null, 32, FactoryType.Service, typeof(MediatR.Examples.GenericHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>)
        internal static object Get8_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Pipeline.RequestPostProcessorBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>(new MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>[] { new MediatR.Examples.ConstrainedRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(0), 48, FactoryType.Service, typeof(MediatR.Pipeline.RequestPostProcessorBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, RequestFlags.IsResolutionCall).Push(typeof(System.Collections.Generic.IEnumerable<MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>>), default(System.Type), (object)null, 2, FactoryType.Wrapper, default(System.Type), Reuse.Transient, ((RequestFlags)0)).Push(typeof(MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>), default(System.Type), (object)DefaultKey.Of(0), IfUnresolved.ReturnDefaultIfNotRegistered, 49, FactoryType.Service, typeof(MediatR.Examples.ConstrainedRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, ((RequestFlags)0), 0), default(object[]))), new MediatR.Examples.GenericRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(0), 48, FactoryType.Service, typeof(MediatR.Pipeline.RequestPostProcessorBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, RequestFlags.IsResolutionCall).Push(typeof(System.Collections.Generic.IEnumerable<MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>>), default(System.Type), (object)null, 2, FactoryType.Wrapper, default(System.Type), Reuse.Transient, ((RequestFlags)0)).Push(typeof(MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>), default(System.Type), (object)DefaultKey.Of(1), IfUnresolved.ReturnDefaultIfNotRegistered, 50, FactoryType.Service, typeof(MediatR.Examples.GenericRequestPostProcessor<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, ((RequestFlags)0), 0), default(object[]))) });
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>)
        internal static object Get9_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Pipeline.RequestPostProcessorBehavior<MediatR.Examples.Jing, MediatR.Unit>(new MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Jing, MediatR.Unit>[] { new MediatR.Examples.GenericRequestPostProcessor<MediatR.Examples.Jing, MediatR.Unit>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(0), 51, FactoryType.Service, typeof(MediatR.Pipeline.RequestPostProcessorBehavior<MediatR.Examples.Jing, MediatR.Unit>), Reuse.Transient, RequestFlags.IsResolutionCall).Push(typeof(System.Collections.Generic.IEnumerable<MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Jing, MediatR.Unit>>), default(System.Type), (object)null, 2, FactoryType.Wrapper, default(System.Type), Reuse.Transient, ((RequestFlags)0)).Push(typeof(MediatR.Pipeline.IRequestPostProcessor<MediatR.Examples.Jing, MediatR.Unit>), default(System.Type), (object)DefaultKey.Of(1), IfUnresolved.ReturnDefaultIfNotRegistered, 52, FactoryType.Service, typeof(MediatR.Examples.GenericRequestPostProcessor<MediatR.Examples.Jing, MediatR.Unit>), Reuse.Transient, ((RequestFlags)0), 0), default(object[]))) });
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>)
        internal static object Get10_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Pipeline.RequestPreProcessorBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>(new MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Ping>[] { new MediatR.Examples.GenericRequestPreProcessor<MediatR.Examples.Ping>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(1), 53, FactoryType.Service, typeof(MediatR.Pipeline.RequestPreProcessorBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, RequestFlags.IsResolutionCall).Push(typeof(System.Collections.Generic.IEnumerable<MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Ping>>), default(System.Type), (object)null, 2, FactoryType.Wrapper, default(System.Type), Reuse.Transient, ((RequestFlags)0)).Push(typeof(MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Ping>), default(System.Type), (object)DefaultKey.Of(0), IfUnresolved.ReturnDefaultIfNotRegistered, 54, FactoryType.Service, typeof(MediatR.Examples.GenericRequestPreProcessor<MediatR.Examples.Ping>), Reuse.Transient, ((RequestFlags)0), 0), default(object[]))) });
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>)
        internal static object Get11_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Pipeline.RequestPreProcessorBehavior<MediatR.Examples.Jing, MediatR.Unit>(new MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Jing>[] { new MediatR.Examples.GenericRequestPreProcessor<MediatR.Examples.Jing>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(1), 55, FactoryType.Service, typeof(MediatR.Pipeline.RequestPreProcessorBehavior<MediatR.Examples.Jing, MediatR.Unit>), Reuse.Transient, RequestFlags.IsResolutionCall).Push(typeof(System.Collections.Generic.IEnumerable<MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Jing>>), default(System.Type), (object)null, 2, FactoryType.Wrapper, default(System.Type), Reuse.Transient, ((RequestFlags)0)).Push(typeof(MediatR.Pipeline.IRequestPreProcessor<MediatR.Examples.Jing>), default(System.Type), (object)DefaultKey.Of(0), IfUnresolved.ReturnDefaultIfNotRegistered, 56, FactoryType.Service, typeof(MediatR.Examples.GenericRequestPreProcessor<MediatR.Examples.Jing>), Reuse.Transient, ((RequestFlags)0), 0), default(object[]))) });
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>)
        internal static object Get12_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Examples.GenericPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(2), 57, FactoryType.Service, typeof(MediatR.Examples.GenericPipelineBehavior<MediatR.Examples.Ping, MediatR.Examples.Pong>), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>)
        internal static object Get13_IPipelineBehavior(IResolverContext r)
        {
            return new MediatR.Examples.GenericPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.IPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>), typeof(MediatR.IPipelineBehavior<,>), (object)DefaultKey.Of(2), 58, FactoryType.Service, typeof(MediatR.Examples.GenericPipelineBehavior<MediatR.Examples.Jing, MediatR.Unit>), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IBaseRequest)
        internal static object Get14_IBaseRequest(IResolverContext r)
        {
            return new MediatR.Examples.Jing();
        }

        // typeof(MediatR.IBaseRequest)
        internal static object Get15_IBaseRequest(IResolverContext r)
        {
            return new MediatR.Examples.Ping();
        }

        // typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>)
        internal static object Get16_INotificationHandler(IResolverContext r)
        {
            return new MediatR.Examples.ConstrainedPingedHandler<MediatR.Examples.Pinged>((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>), typeof(MediatR.INotificationHandler<>), (object)null, 59, FactoryType.Service, typeof(MediatR.Examples.ConstrainedPingedHandler<MediatR.Examples.Pinged>), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IRequest)
        internal static object Get17_IRequest(IResolverContext r)
        {
            return new MediatR.Examples.Jing();
        }

        // typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>)
        internal static object Get18_INotificationHandler(IResolverContext r)
        {
            return new MediatR.Examples.PingedHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>), default(System.Type), (object)DefaultKey.Of(0), 40, FactoryType.Service, typeof(MediatR.Examples.PingedHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>)
        internal static object Get19_INotificationHandler(IResolverContext r)
        {
            return new MediatR.Examples.PingedAlsoHandler((System.IO.TextWriter)r.Resolve(typeof(System.IO.TextWriter), null, IfUnresolved.Throw, default(System.Type), Request.Empty.Push(typeof(MediatR.INotificationHandler<MediatR.Examples.Pinged>), default(System.Type), (object)DefaultKey.Of(1), 43, FactoryType.Service, typeof(MediatR.Examples.PingedAlsoHandler), Reuse.Transient, RequestFlags.IsResolutionCall), default(object[])));
        }

        // typeof(MediatR.IRequest<MediatR.Unit>)
        internal static object Get20_IRequest(IResolverContext r)
        {
            return new MediatR.Examples.Jing();
        }

    }
}
