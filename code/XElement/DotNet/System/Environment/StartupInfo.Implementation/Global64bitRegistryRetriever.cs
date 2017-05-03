﻿using Microsoft.Win32;

namespace XElement.DotNet.System.Environment.Startup
{
#region not unit-tested
    public class Global64bitRegistryRetriever : RegistryRetrieverBase, IStartupInfo
    {
        public Global64bitRegistryRetriever() { }


        protected override RegistryView /*RegistryRetrieverBase.*/Mode
        {
            get { return RegistryView.Registry64; }
        }


        protected override RegistryHive /*RegistryRetrieverBase.*/TopLevelNode
        {
            get { return RegistryHive.LocalMachine; }
        }
    }
#endregion
}