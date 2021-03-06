﻿using CommandLine;

namespace Yuniql.CLI
{
    public class BaseOption
    {
        //yuniql <command> -p c:\temp\demo | --path c:\temp\demo
        [Option('p', "path", Required = false, HelpText = "Path to initialize.")]
        public string Workspace { get; set; }

        //yuniql <command> -d | --debug
        [Option('d', "debug", Required = false, HelpText = "Print debug information including all raw scripts.")]
        public bool IsDebug { get; set; }
    }

}
