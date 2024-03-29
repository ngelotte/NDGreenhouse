using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Reactive.Threading.Tasks;
using NetDaemon.HassModel.Entities;
using System.Collections.Generic;
using NetDaemon.Extensions.Scheduler;
using System.Text.Json;
using System.Buffers;
using HomeAssistantGenerated;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace NdGreenhouse.Apps.Greenhouse
{

    public static class GreenhouseExtensions
    {
        public static IDisposable RunDaily(this INetDaemonScheduler scheduler, TimeSpan timeOfDay, Action action)
        {

            var startTime = scheduler.Now.Date.Add(timeOfDay);
            if (scheduler.Now > startTime)
            {
                startTime = startTime.AddDays(1);
            }

            return scheduler.RunEvery(TimeSpan.FromDays(1), startTime, action);
        }
        public static void TurnOn(this IList<SwitchEntity>? entities)
        {
            if (entities != null)
            {
                foreach (var entitiy in entities)
                {
                    entitiy.TurnOn();
                }
            }
        }

        public static void TurnOff(this IList<SwitchEntity>? entities)
        {
            if (entities != null)
            {
                foreach (var entitiy in entities)
                {
                    entitiy.TurnOff();
                }
            }
        }

        public static bool IsOn(this EntityState? es)
        {
            return (es?.State ?? "Unknown") == "on";
        }
        public static bool IsOff(this EntityState? bse)
        {
            return (bse?.State ?? "Unknown") == "off";
        }

        public static bool IsOn(this BinarySensorEntity bse)
        {
            return (bse?.State ?? "Unknown") == "on";
        }
        public static bool IsOff(this BinarySensorEntity bse)
        {
            return (bse?.State ?? "Unknown") == "off";
        }

        public static bool IsUnknown(this BinarySensorEntity bse)
        {
            return bse.State == null;
        }
        public static bool IsUnknown(this SensorEntity bse)
        {
            return bse.State == null;
        }

        //public static bool IsOn(this SwitchEntity se)
        //{
        //    return (se?.State ?? "Unknown") == "on";
        //}
        //public static bool IsOff(this SwitchEntity se)
        //{
        //    return (se?.State ?? "Unknown") == "off";
        //}
        public static bool IsUnknown(this SwitchEntity se)
        {
            return se.State == null;
        }



        public static async Task<T?> FirstOrTimeoutAsync<T>(this IObservable<T?> observable, TimeSpan refillTime)
        {
            try
            {
                return await observable.Timeout(refillTime).Take(1).ToTask();
            }
            catch (TimeoutException)
            {
                return default(T);

            }
        }
        //public static void RegisterServiceCallBack<T>(this IHaContext haContext, string serviceName, Action<T?> callBack)
        //     where T : class
        //{
        //    haContext.CallService("netdaemon", "register_service", data: new { @class = "gh", method = serviceName });

        //    haContext.Events.Filter<HassServiceEventData>("call_service")
        //        .Where(e => e.Data?.Domain == "netdaemon"
        //                    && string.Equals(e.Data?.Service, "gh_" + serviceName, StringComparison.OrdinalIgnoreCase))
        //        .Subscribe(e => callBack.Invoke(e.Data?.ServiceData?.ToObject<T>()));
        //}

        public static T ToObject<T>(this JsonElement element, JsonSerializerOptions? options = null)
        {
            var bufferWriter = new ArrayBufferWriter<byte>();
            using (var writer = new Utf8JsonWriter(bufferWriter))
            {
                element.WriteTo(writer);
            }

            return JsonSerializer.Deserialize<T>(bufferWriter.WrittenSpan, options) ?? default!;
        }

        public static IObservable<T?>? FirstOrTimeout<T>(this IObservable<T?> observable, TimeSpan refillTime)
        {
            try
            {
                return observable.Timeout(refillTime).Take(1);
            }
            catch (TimeoutException)
            {
                return null;
            }
        }



        // public static IObservable<(EntityState Old, EntityState New)> FirstOrTimeout(this IObservable<(EntityState Old, EntityState New)> observable, TimeSpan timeout)
        // {
        //       return observable.Timeout(timeout, Observable.Return((new NetDaemon.Common.EntityState() { State = "TimeOut" }, new NetDaemon.Common.EntityState() { State = "TimeOut" }))).Take(1);
        //}

        //public static async Task<bool> DelayFor(this NetDaemonRxApp app, TimeSpan timeSpan)
        //{
        //    var tcs = new TaskCompletionSource<bool>();
        //    app.RunIn(timeSpan, () =>
        //        {
        //            tcs.SetResult(true);
        //        });
        //    await tcs.Task;
        //    return true;
        //}


    }

}

// namespace NetDaemon.Common.Reactive.Services
// {

//         public partial class BinarySensorEntity : RxEntityBase
//     {
//         public BinarySensorEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds) : base(daemon, entityIds)
//         {
//         }
//         public bool IsOn => State == "on";
//         public bool IsOff => State == "off";
//         public bool IsUnknown => State == null;
//     }

//     public partial class SwitchEntity : RxEntityBase
//     {
//         public SwitchEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds) : base(daemon, entityIds)
//         {
//         }
//         public bool IsOn => State == "on";

//         public bool IsOff => State == "off";
//         public bool IsUnknown => State == null;
//     }
// }