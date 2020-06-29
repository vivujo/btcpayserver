using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BTCPayServer.Data;
using BTCPayServer.Events;
using BTCPayServer.Services.Notifications.Blobs;
using Newtonsoft.Json;

namespace BTCPayServer.Models.NotificationViewModels
{
    public class IndexViewModel
    {
        public int Skip { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
        public List<NotificationViewModel> Items { get; set; }
    }

    public class NotificationViewModel
    {
        public string Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Body { get; set; }
        public string ActionLink { get; set; }
        public bool Seen { get; set; }
    }
}
