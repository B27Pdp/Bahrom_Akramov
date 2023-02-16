using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_11_February_15_2023.HomeTasks
{
    internal class Root
    {
        public string? client { get; set; }
        public string? collectionName { get; set; }
        public DateTime dateExported { get; set; }
        public string? version { get; set; }
        public List<Folder>? folders { get; set; }
        public List<Request>? requests { get; set; }
        
        public Root()
        {
            folders = new List<Folder>();
            requests = new List<Request>();
        }
    }

    internal class Folder
    {
        public string? containerId { get; set; }
        public int sortNum { get; set; }
        public string? name { get; set; }
        public string? _id { get; set; }
        public DateTime created { get; set; }
    }

    internal class Request
    {
        public string? containerId { get; set; }
        public int sortNum { get; set; }
        public List<Header>? headers { get; set; }
        public string? colId { get; set; }
        public string? name { get; set; }
        public string? url { get; set; }
        public string? method { get; set; }
        public DateTime modified { get; set; }
        public DateTime created { get; set; }
        public string? _id { get; set; }

        [JsonProperty("params")]
        public List<object>? parametrs { get; set; }
        public List<object>? tests { get; set; }

        public Request()
        {
            this.headers = new List<Header>();
            this.parametrs = new List<object>();
            this.tests = new List<object>();
        }
        public void AddHeader(Header header)
        {
            this.headers?.Add(header);
        }
    }

    internal class Header
    {
        public string? name { get; set; }
        public string? value { get; set; }
    }
}
