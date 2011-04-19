﻿using System;
using System.Collections.Generic;
using FubuCore.Util;

namespace FubuMVC.Spark.Tokenization.Scanning
{
    public class ScanRequest
    {
        private readonly List<string> _roots;
        private readonly List<string> _filter;
        private CompositeAction<FileFound> _onFound;
        
        public ScanRequest()
        {
            _roots = new List<string>();
            _filter = new List<string>();
            _onFound = new CompositeAction<FileFound>();
        }

        public IEnumerable<string> Roots { get { return _roots; } }
        public string Filters { get { return _filter.Join(";"); } }

        public void AddRoot(string root)
        {
            _roots.Add(root);
        }

        public void Include(string filter)
        {
            _filter.Add(filter);
        }

        public void AddHandler(Action<FileFound> handler)
        {
            _onFound += handler;
        }

        public void OnFound(FileFound file)
        {
            _onFound.Do(file);
        }
    }
}